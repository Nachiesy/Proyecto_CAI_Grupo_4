using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modules;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class AgregarPasajerosModel
    {
        public List<Pasajeros> Pasajeros = new List<Pasajeros>();

        public static AgregarPasajerosParams GetAgregarPasajerosParamsStatic()
        {
            return PasajerosModule.GetAgregarPasajerosParams();
        }

        public AgregarPasajerosParams GetAgregarPasajerosParams()
        {
            return PasajerosModule.GetAgregarPasajerosParams();
        }

        public void SetAgregarPasajerosParams(AgregarPasajerosParams agregarPasajerosParams)
        {
            PasajerosModule.SetAgregarPasajerosParams(agregarPasajerosParams);
        }

        public AereoEnt GetAereoById(int id)
        {
            return AereosModule.GetAereoByID(id);
        }

        public HotelEnt GetHotelById(int id)
        {
            return HotelesModule.GetHotelByID(id);
        }

        public IEnumerable<Pasajeros> GetPasajerosByIdPresupuesto(int idPresupuesto)
        {
            var listaPasajeros = new List<Pasajeros>();
            //Pasajeros persistidos en almacen
            listaPasajeros.AddRange(PasajerosModule.GetPasajerosByIdPresupuesto(idPresupuesto));

            //Pasajeros ingresados por confirmar
            listaPasajeros.AddRange(PasajerosModule.GetPasajerosPorConfirmar());

            return listaPasajeros;
        }

        public IEnumerable<Itinerario> GetPresupuestosByDNI(string dni) 
        {
            return PresupuestosModule.GetPresupuestosByDNI(dni);
        }

        public Itinerario GetPresupuestoById(int id)
        {
            return PresupuestosModule.GetPresupuestoById(id);
        }

        public IEnumerable<Itinerario> GetPresupuestos()
        {
            return PresupuestosModule.GetPresupuestos();
        }

        public bool ValidarPasajeros(int idItinerario)
        {
            //cantidad Agrupada PorTipo De Pasajero Y IdHotel y COUNT por cada grupo
            var agrupacionCantidadesHotelesSeleccionados = Pasajeros
                .SelectMany(x => x.HotelesAsignados
                    .Select(y =>
                        new { TipoPasajero = x.GetTipoDePasajero(), IdHotel = y.IdHotel }))
                .GroupBy(x => new { x.IdHotel, x.TipoPasajero })
                .Select(x => new { x.Key.IdHotel, x.Key.TipoPasajero, Cantidad = x.Count() })
                .ToList();

            var agrupacionVuelosAsignados = Pasajeros
                .SelectMany(x =>
                    x.AereosAsignados.Select(y =>
                        new { y.Id }))
                .GroupBy(x => new { x.Id })
                .Select(x => new { x.Key, Cantidad = x.Count() })
                .ToList();

            var agrupacionHotelesAsignados = Pasajeros
                .SelectMany(x =>
                    x.HotelesAsignados.Select(y =>
                        new { y.Id }))
                .GroupBy(x => new { x.Id })
                .Select(x => new { x.Key, Cantidad = x.Count() })
                .ToList();

            foreach (var pasajero in Pasajeros)
            {
                foreach (var aereoSeleccionado in pasajero.AereosAsignados)
                {
                    var aereo = AereosModule.GetAereoByID(aereoSeleccionado.IdAereo);

                    if (aereo.Tarifa.TipoDePasajero != pasajero.GetTipoDePasajero())
                    {
                        MessageBox.Show($"Debe ingresar bien los datos del pasajero {pasajero.Nombre} {pasajero.Apellido} para el vuelo con Id del producto {aereoSeleccionado.IdAereo}, " +
                                        $"dado que es una tarifa de {aereo.Tarifa.TipoDePasajero} y el pasajero es aplicable a tarifa de {pasajero.GetTipoDePasajero()}");
                        return false;
                    }

                    var aereoRepetido = agrupacionVuelosAsignados.FirstOrDefault(x => x.Key.Id == aereoSeleccionado.Id);

                    if (aereoRepetido is not null && aereoRepetido.Cantidad > 1)
                    {
                        MessageBox.Show($"Debe ingresar bien los datos del pasajero {pasajero.Nombre} {pasajero.Apellido} para el vuelo con Id del producto {aereoSeleccionado.IdAereo}, " +
                                        $"dado que el asiento no puede ser asignado más de una vez.");

                        return false;
                    }
                    
                }

                foreach (var hotelSeleccionado in pasajero.HotelesAsignados)
                {
                    var hotel = HotelesModule.GetHotelByID(hotelSeleccionado.IdHotel);
                    var tipoPasajero = pasajero.GetTipoDePasajero();

                    if (hotel.Disponibilidad.CantidadMaximaAdultos == 0 && tipoPasajero == "Adulto")
                    {
                        MessageBox.Show($"El pasajero {pasajero.Nombre} {pasajero.Apellido} no puede hospedarse en el hotel {hotel.Nombre} porque no permite adultos (Id del producto: {hotelSeleccionado.Id}).");
                        return false;
                    }

                    if (hotel.Disponibilidad.CantidadMaximaMenores == 0 && tipoPasajero == "Menor")
                    {
                        MessageBox.Show($"El pasajero {pasajero.Nombre} {pasajero.Apellido} no puede hospedarse en el hotel {hotel.Nombre} porque no permite menores (Id del producto: {hotelSeleccionado.Id}).");
                        return false;
                    }

                    if (hotel.Disponibilidad.CantidadMaximaInfantes == 0 && tipoPasajero == "Infante")
                    {
                        MessageBox.Show($"El pasajero {pasajero.Nombre} {pasajero.Apellido} no puede hospedarse en el hotel {hotel.Nombre} porque no permite infantes (Id del producto: {hotelSeleccionado.Id}).");
                        return false;
                    }

                    var cantidadActualDelMismoHotelParaTipoPasajeroConcreto = agrupacionCantidadesHotelesSeleccionados
                        .SingleOrDefault(x => x.IdHotel == hotelSeleccionado.IdHotel && x.TipoPasajero == tipoPasajero)
                        .Cantidad;

                    if (tipoPasajero == "Adulto" &&
                        cantidadActualDelMismoHotelParaTipoPasajeroConcreto > hotel.Disponibilidad.CantidadMaximaAdultos)
                    {
                        MessageBox.Show($"Se excedió la capacidad máxima de adultos para la habitación del hotel {hotel.Nombre} (Id del producto: {hotelSeleccionado.Id}).", "Error de Validacion", MessageBoxButtons.OK);
                        return false;
                    }

                    if (tipoPasajero == "Menor" &&
                        cantidadActualDelMismoHotelParaTipoPasajeroConcreto > hotel.Disponibilidad.CantidadMaximaMenores)
                    {
                        MessageBox.Show($"Se excedió la capacidad máxima de menores para la habitación del hotel {hotel.Nombre} (Id del producto: {hotelSeleccionado.Id}).", "Error de Validacion", MessageBoxButtons.OK);
                        return false;
                    }

                    if (tipoPasajero == "Infante" &&
                        cantidadActualDelMismoHotelParaTipoPasajeroConcreto > hotel.Disponibilidad.CantidadMaximaInfantes)
                    {
                        MessageBox.Show($"Se excedió la capacidad máxima de infantes para la habitación del hotel {hotel.Nombre} (Id del producto: {hotelSeleccionado.Id}).", "Error de Validacion", MessageBoxButtons.OK);
                        return false;
                    }

                }
            }

            //DEBE CARGAR TODOS LOS PASAJEROS para cada uno de los productos
            var itinerario = PresupuestosModule.GetPresupuestoById(idItinerario);

            foreach (var aereoSeleccionado in itinerario.IdAereosSeleccionados)
            {
                var fueAsignado = agrupacionVuelosAsignados.Count(x => x.Key.Id == aereoSeleccionado.Id) > 0;

                if (!fueAsignado)
                {
                    var detalleAereo = AereosModule.GetAereoByID(aereoSeleccionado.IdAereo);

                    MessageBox.Show($"Debe cargar todos los pasajeros a cada uno de los productos. Falta asignar un pasajero al vuelo {detalleAereo.Nombre} con tarifa {detalleAereo.Tarifa.TipoDePasajero}. (Id del producto: {aereoSeleccionado.Id})");
                    return false;
                }
            }

            foreach (var hotelSeleccionado in itinerario.IdHotelesSeleccionados)
            {
                var detalleHotel = HotelesModule.GetHotelByID(hotelSeleccionado.IdHotel);
                var fueAsignado = agrupacionHotelesAsignados.Count(x => x.Key.Id == hotelSeleccionado.Id) > 0;

                if (!fueAsignado && agrupacionCantidadesHotelesSeleccionados.Count(x => x.IdHotel == hotelSeleccionado.IdHotel) == 0)
                {
                    MessageBox.Show($"Debe cargar todos los pasajeros a cada uno de los productos. Falta asignar al menos un pasajero al hotel {detalleHotel.Nombre}. (Id del producto: {hotelSeleccionado.Id})");
                    return false;
                }

                if (fueAsignado && agrupacionCantidadesHotelesSeleccionados.Count(x =>
                        x.IdHotel == hotelSeleccionado.IdHotel && x.TipoPasajero == "Adulto") <= 0)
                {
                    MessageBox.Show($"Los hoteles deben hospedar al menos un adulto. Falta asignar al menos un pasajero adulto al hotel {detalleHotel.Nombre}. (Id del producto: {hotelSeleccionado.Id})");
                    return false;
                }
            }

            return true;
        }

        public void AgregarPasajero(Pasajeros pasajero)
        {
            Pasajeros.Add(pasajero);
        }

        public void AgregarPasajeroPorConfirmar(Pasajeros pasajero)
        {
            PasajerosModule.AgregarPasajeroPorConfirmar(pasajero);
        }

        public void LimpiarPasajerosPorConfirmar()
        {
            PasajerosModule.LimpiarPasajerosPorConfirmar();
        }

        public void EliminarPasajero(string idProducto)
        {
            for (int i = Pasajeros.Count - 1; i >= 0; i--)
            {
                var pasajero = Pasajeros[i];

                if (pasajero.AereosAsignados.Any(x => x.Id == idProducto))
                {
                    pasajero.AereosAsignados.RemoveAll(x => x.Id == idProducto);
                }

                if (pasajero.HotelesAsignados.Any(x => x.Id == idProducto))
                {
                    pasajero.HotelesAsignados.RemoveAll(x => x.Id == idProducto);
                }

                if (pasajero.AereosAsignados.Count == 0 && pasajero.HotelesAsignados.Count == 0)
                {
                    Pasajeros.RemoveAt(i);
                }
            }
        }

        public void GuardarPasajeros(int idPresupuesto)
        {
            PasajerosModule.LimpiarPasajerosPorIdPresupuesto(idPresupuesto);
            PasajerosModule.LimpiarPasajerosPorConfirmar();
            PasajerosModule.AgregarPasajeros(Pasajeros);
        }
    }
}
