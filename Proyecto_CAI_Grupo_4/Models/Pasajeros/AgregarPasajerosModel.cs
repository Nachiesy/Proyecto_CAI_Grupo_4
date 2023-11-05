using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modules;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class AgregarPasajerosModel
    {
        public List<Pasajeros> Pasajeros = new List<Pasajeros>();

        public Aereos GetAereoById(int id)
        {
            return AereosModule.GetAereoByID(id);
        }

        public Hoteles GetHotelById(int id)
        {
            return HotelesModule.GetHotelByID(id);
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

        public bool ValidarPasajeros()
        {
            //cantidad Agrupada PorTipo De Pasajero Y IdHotel y COUNT por cada grupo
            var agrupacionCantidadesHotelesSeleccionados = Pasajeros
                .SelectMany(x => x.HotelesAsignados
                    .Select(y =>
                        new { TipoPasajero = x.GetTipoDePasajero(), IdHotel = y.IdHotel }))
                .GroupBy(x => new { x.IdHotel, x.TipoPasajero })
                .Select(x => new { x.Key.IdHotel, x.Key.TipoPasajero, Cantidad = x.Count() })
                .ToList();

            var agrupacionVuelosSeleccionados = Pasajeros
                .SelectMany(x =>
                    x.AereosAsignados.Select(y =>
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
                                        $"dado que es una tarifa de {aereo.TipoDePasajero.GetDescription()} y el pasajero es aplicable a tarifa de {pasajero.GetTipoDePasajero().GetDescription()}");
                        return false;
                    }

                    var aereoRepetido = agrupacionVuelosSeleccionados.FirstOrDefault(x => x.Key.Id == aereoSeleccionado.Id);

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
                        MessageBox.Show($"El pasajero {pasajero.Nombre} {pasajero.Apellido} no puede hospedarse en el hotel {hotel.Nombre} porque no permite adultos");
                        return false;
                    }

                    if (hotel.Disponibilidad.CantidadMaximaMenores == 0 && tipoPasajero == "Menor")
                    {
                        MessageBox.Show($"El pasajero {pasajero.Nombre} {pasajero.Apellido} no puede hospedarse en el hotel {hotel.Nombre} porque no permite menores");
                        return false;
                    }

                    if (hotel.Disponibilidad.CantidadMaximaInfantes == 0 && tipoPasajero == "Infante")
                    {
                        MessageBox.Show($"El pasajero {pasajero.Nombre} {pasajero.Apellido} no puede hospedarse en el hotel {hotel.Nombre} porque no permite infantes");
                        return false;
                    }

                    var cantidadActualDelMismoHotelParaTipoPasajeroConcreto = agrupacionCantidadesHotelesSeleccionados
                        .SingleOrDefault(x => x.IdHotel == hotelSeleccionado.IdHotel && x.TipoPasajero == tipoPasajero)
                        .Cantidad;

                    if (tipoPasajero == "Adulto" &&
                        cantidadActualDelMismoHotelParaTipoPasajeroConcreto > hotel.Disponibilidad.CantidadMaximaAdultos)
                    {
                        MessageBox.Show($"El pasajero {pasajero.Nombre} {pasajero.Apellido} no puede hospedarse en el hotel {hotel.Nombre} porque ya hay {cantidadActualDelMismoHotelParaTipoPasajeroConcreto} adultos hospedados y el maximo es {hotel.Disponibilidad.CantidadMaximaAdultos}.", "Error de Validacion", MessageBoxButtons.OK);
                        return false;
                    }

                    if (tipoPasajero == "Menor" &&
                        cantidadActualDelMismoHotelParaTipoPasajeroConcreto > hotel.Disponibilidad.CantidadMaximaMenores)
                    {
                        MessageBox.Show($"El pasajero {pasajero.Nombre} {pasajero.Apellido} no puede hospedarse en el hotel {hotel.Nombre} porque ya hay {cantidadActualDelMismoHotelParaTipoPasajeroConcreto} menores hospedados y el maximo es {hotel.Disponibilidad.CantidadMaximaMenores}.", "Error de Validacion", MessageBoxButtons.OK);
                        return false;
                    }

                    if (tipoPasajero == "Infante" &&
                        cantidadActualDelMismoHotelParaTipoPasajeroConcreto > hotel.Disponibilidad.CantidadMaximaInfantes)
                    {
                        MessageBox.Show($"El pasajero {pasajero.Nombre} {pasajero.Apellido} no puede hospedarse en el hotel {hotel.Nombre} porque ya hay {cantidadActualDelMismoHotelParaTipoPasajeroConcreto} infantes hospedados y el maximo es {hotel.Disponibilidad.CantidadMaximaInfantes}.", "Error de Validacion", MessageBoxButtons.OK);
                        return false;
                    }

                }
            }

            //Para el caso de los hoteles esta bien a priori, ver el ejemplo de una habitacion cuadruple que permite 2 adultos y 2 menores...
            //if (Pasajeros.Any(x => x.HotelesAsignados.Any(y =>
            //        Pasajeros.Any(z => z.HotelesAsignados.Any(w => w.Id == y.Id && z != x)))))
            //{
            //    MessageBox.Show("Algun pasajero tiene asignado un mismo producto de hotel mas de una vez");
            //    return false;
            //}

            //var agrupacionClientes = Pasajeros
            //    .GroupBy(x => x.DNI)
            //    .Select(x => new { x.Key, Cantidad = x.Count() })
            //    .ToList();

            //if (agrupacionClientes.Count > 1)
            //{
            //    MessageBox.Show("Algun pasajero se repite");
            //    return false;
            //}


            return true;
        }

        public void AgregarPasajeros()
        {
            PasajerosModule.AgregarPasajeros(Pasajeros);
        }

        public void GoToMenuPrinicipal()
        {
            Thread thread = new Thread(MenuPrincipalModel.OpenMenuPrincipal);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public static void OpenAgregarPasajeros()
        {
            Application.Run(new AgregarPasajeros());
        }
    }
}
