using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modelos;
using Proyecto_CAI_Grupo_4.Modules;
using Proyecto_CAI_Grupo_4.Utils;
using System.Linq;
using System.Reflection;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class GenerarPrereservaModel
    {
        public IEnumerable<PresupuestoEnt> GetPreReservables()
        {
            return PresupuestosModule
                .GetPresupuestosPrereservables()
                .AsQueryable();
        }

        public int GetTotalPasajerosByIdPresupuesto(int idItinerario)
        {
            return PasajerosModule.GetTotalPasajerosByIdPresupuesto(idItinerario);
        }

        public PresupuestoEnt GetPresupuestoById(int id)
        {
            return PresupuestosModule.GetPresupuestoById(id);
        }

        public PresupuestoEnt GenerarPreReserva(PresupuestoEnt itinerario)
        {
            itinerario.ActualizarEstadoAPrereservado();

            PresupuestosModule.UpdatePresupuesto(itinerario);
            
            //Baja los stocks de los productos
            foreach (var aereoSeleccionado in itinerario.IdAereosSeleccionados)
            {
                AereosModule.BajarDisponibilidad(aereoSeleccionado.IdAereo);
            }

            foreach (var hotelSeleccionado in itinerario.IdHotelesSeleccionados)
            {
                HotelesModule.BajarDisponibilidad(hotelSeleccionado.IdHotel);
            }

            return itinerario;
        }

        public string? ValidarRequisitosPreReserva(int idItinerario)
        {
            var msg = ValidarStock(idItinerario);

            if (!string.IsNullOrEmpty(msg)) return msg;

            msg = ValidarPasajeros(idItinerario);

            if (!string.IsNullOrEmpty(msg)) return msg;

            return null;
        }

        public string? ValidarStock(int idItinerario)
        {
            var pasajerosAereosAsignados =
                PasajerosModule.GetAgrupacionVuelosAsignados(idItinerario)
                .GroupBy(x => x.IdProducto).Select(x => new { Id = x.Key, Cantidad = x.Count() });

            var pasajerosHotelesAsignados = PasajerosModule.GetAgrupacionHotelesAsignados(idItinerario);

            foreach (var aereoSeleccionado in pasajerosAereosAsignados)
            {
                var aereo = AereosModule.GetAereoByID(aereoSeleccionado.Id);

                if (aereo.Tarifa.Disponibilidad < aereoSeleccionado.Cantidad)
                {
                    return $"No hay suficiente disponibilidad para la tarifa con id {aereo.Id} perteneciente al {aereo.Nombre}. Por favor, modifique el presupuesto.";
                }
            }

            var huespedesAgrupadosPorHotel = pasajerosHotelesAsignados
                .GroupBy(x => x.IdProducto)
                .Select(group => new
                {
                    IdHotel = group.Key,
                    CantidadHuespedes = group.Count(),
                    Pasajeros = group.ToList()
                });

            foreach (var hotelSeleccionado in huespedesAgrupadosPorHotel)
            {
                var hotel = HotelesModule.GetHotelByID(hotelSeleccionado.IdHotel);

                if (hotelSeleccionado.CantidadHuespedes > hotel.Disponibilidad.Disponibilidad)
                {
                    var firstPasajero = hotelSeleccionado.Pasajeros.FirstOrDefault();
                    var mensaje = $"No hay suficiente disponibilidad para la tarifa con id {hotelSeleccionado.IdHotel} perteneciente al hotel {hotel.Nombre}. Por favor, modifique el presupuesto.";
                    return mensaje;
                }
            }

            return null;
        }

        public string? ValidarPasajeros(int idItinerario)
        {
            if (GetTotalPasajerosByIdPresupuesto(idItinerario) == 0)
            {
                return $"No se puede generar una Pre-reserva sobre un presupuesto sin pasajeros asignados.\r\n" +
                    $"Por favor agregue pasajeros al presupuesto desde la pantalla correspondiente. (Id Presupuesto: {idItinerario})";
            }

            //Cantidad Agrupada PorTipo De Pasajero Y IdHotel y COUNT por cada grupo
            var agrupacionCantidadesHotelesSeleccionados =
                PasajerosModule.GetAgrupacionCantidadesHotelesSeleccionadosPorIdItinerario(idItinerario);

            var agrupacionVuelosAsignados = PasajerosModule.GetAgrupacionVuelosAsignados(idItinerario);

            var agrupacionVuelosAsignadosPorTarifa = PasajerosModule.GetAgrupacionVuelosAsignadosPorTarifa(idItinerario);

            var agrupacionHotelesAsignados = PasajerosModule.GetAgrupacionHotelesAsignados(idItinerario);

            var pasajerosAsignados = PasajerosModule.GetPasajerosByIdPresupuesto(idItinerario);

            foreach (var pasajero in pasajerosAsignados)
            {
                foreach (var aereoSeleccionado in pasajero.AereosAsignados)
                {
                    var aereo = AereosModule.GetAereoByID(aereoSeleccionado.IdAereo);
                    var tipoPasajero = pasajero.GetTipoDePasajero();

                    if (aereo.Tarifa.TipoDePasajero != tipoPasajero)
                    {
                        return $"Debe ingresar bien los datos del pasajero {pasajero.Nombre} {pasajero.Apellido} para Id del producto {aereoSeleccionado.Id}, " + $"dado que es una tarifa de aéreos de {aereo.Tarifa.TipoDePasajero} y el pasajero es aplicable a tarifas de {pasajero.GetTipoDePasajero()}";
                    }

                    var aereoRepetido = agrupacionVuelosAsignados.FirstOrDefault(x => x.Id == aereoSeleccionado.Id);

                    if (aereoRepetido is not null && aereoRepetido.Cantidad > 1)
                    {
                        return $"El producto con id {aereoSeleccionado.Id} que corresponde a un asiento de un aéreo, fue asignado a más de un pasajero.\r\n" +
                            $"Por favor, modifique los pasajeros asignados en la pantalla correspondiente."; ;
                    }

                }

                foreach (var hotelSeleccionado in pasajero.HotelesAsignados)
                {
                    var hotel = HotelesModule.GetHotelByID(hotelSeleccionado.IdHotel);
                    var tipoPasajero = pasajero.GetTipoDePasajero();

                    if (hotel.Disponibilidad.CantidadMaximaAdultos == 0 && tipoPasajero == "Adulto")
                    {
                        return $"El pasajero {pasajero.Nombre} {pasajero.Apellido} no puede hospedarse en el hotel {hotel.Nombre} porque no permite adultos (Id del producto: {hotelSeleccionado.Id}).";
                    }

                    if (hotel.Disponibilidad.CantidadMaximaMenores == 0 && tipoPasajero == "Menor")
                    {
                        return $"El pasajero {pasajero.Nombre} {pasajero.Apellido} no puede hospedarse en el hotel {hotel.Nombre} porque no permite menores (Id del producto: {hotelSeleccionado.Id}).";
                    }

                    if (hotel.Disponibilidad.CantidadMaximaInfantes == 0 && tipoPasajero == "Infante")
                    {
                        return $"El pasajero {pasajero.Nombre} {pasajero.Apellido} no puede hospedarse en el hotel {hotel.Nombre} porque no permite infantes (Id del producto: {hotelSeleccionado.Id}).";
                    }

                    var cantidadActualDelMismoHotelParaTipoPasajeroConcreto = agrupacionCantidadesHotelesSeleccionados
                        .Where(x => x.IdHotel == hotelSeleccionado.IdHotel)
                        .Select(x => x.Cantidad)
                        .DefaultIfEmpty(0)
                        .Sum();

                    if (tipoPasajero == "Adulto" &&
                        cantidadActualDelMismoHotelParaTipoPasajeroConcreto > hotel.Disponibilidad.CantidadMaximaAdultos)
                    {
                        return $"Se excedió la capacidad máxima de adultos para la habitación del hotel {hotel.Nombre} (Id del producto: {hotelSeleccionado.Id}).";
                    }

                    if (tipoPasajero == "Menor" &&
                        cantidadActualDelMismoHotelParaTipoPasajeroConcreto > hotel.Disponibilidad.CantidadMaximaMenores)
                    {
                        return $"Se excedió la capacidad máxima de menores para la habitación del hotel {hotel.Nombre} (Id del producto: {hotelSeleccionado.Id}).";
                    }

                    if (tipoPasajero == "Infante" &&
                        cantidadActualDelMismoHotelParaTipoPasajeroConcreto > hotel.Disponibilidad.CantidadMaximaInfantes)
                    {
                        return $"Se excedió la capacidad máxima de infantes para la habitación del hotel {hotel.Nombre} (Id del producto: {hotelSeleccionado.Id}).";
                    }

                }
            }

            //DEBE CARGAR TODOS LOS PASAJEROS para cada uno de los productos
            var itinerario = PresupuestosModule.GetPresupuestoById(idItinerario);

            foreach (var aereoSeleccionado in itinerario.IdAereosSeleccionados)
            {
                var fueAsignado = agrupacionVuelosAsignados.Count(x => x.Id == aereoSeleccionado.Id) > 0;

                if (!fueAsignado)
                {
                    var detalleAereo = AereosModule.GetAereoByID(aereoSeleccionado.IdAereo);

                    return $"Debe cargar todos los pasajeros a cada uno de los productos. Falta asignar un pasajero al {detalleAereo.Nombre} con tarifa {detalleAereo.Tarifa.TipoDePasajero}. (Id del producto: {aereoSeleccionado.Id})";
                }

                
            }

            foreach (var aereoSeleccionado in agrupacionVuelosAsignadosPorTarifa)
            {
                //La cantidad de menores no puede ser mayor a la de adultos
                var cantidadMenoresEInfantes = agrupacionVuelosAsignadosPorTarifa
                    .Where(x => x.TipoPasajero != "Adulto" && x.CodigoProducto == aereoSeleccionado.CodigoProducto)
                    .Select(x => x.Cantidad)
                    .DefaultIfEmpty(0)
                    .Sum();

                var cantidadAdultos = agrupacionVuelosAsignadosPorTarifa
                    .Where(x => x.TipoPasajero == "Adulto" && x.CodigoProducto == aereoSeleccionado.CodigoProducto)
                    .Select(x => x.Cantidad)
                    .DefaultIfEmpty(0)
                    .Sum();

                //var cantidadAdultos = agrupacionVuelosAsignadosPorTarifa.Count(x => aereoSeleccionado.IdProducto == x.IdProducto && GetTipoPasajeroAereo(x.IdProducto) == "Adulto");

                if (cantidadMenoresEInfantes > cantidadAdultos)
                {
                    return $"La cantidad de menores e infantes del vuelo {aereoSeleccionado.CodigoProducto} no puede ser mayor a la de adultos. Por favor modifique su presupuesto.";
                }
            }

            foreach (var hotelSeleccionado in itinerario.IdHotelesSeleccionados)
            {
                //Reviso que exista al menos algun adulto
                var agrupacionPorTipoPasajeroYProductoId = !agrupacionCantidadesHotelesSeleccionados.Any(x => x.IdHotel == hotelSeleccionado.IdHotel && x.Id == hotelSeleccionado.Id && x.TipoPasajero == "Adulto");
                if (agrupacionPorTipoPasajeroYProductoId)
                {
                    var detalleHotel = HotelesModule.GetHotelByID(hotelSeleccionado.IdHotel);

                    return $"Los hoteles deben hospedar al menos un adulto. Falta asignar al menos un pasajero adulto al hotel {detalleHotel.Nombre}. (Id del producto: {hotelSeleccionado.Id})";
                }
            }

            //Si alguno de los productos dentro de itinerario.IdHotelesSeleccionados no fue asignado en agrupacionHotelesAsignados
            //entonces no se cargaron todos los pasajeros a cada uno de los productos
            var hotelesSinAsignar = itinerario.IdHotelesSeleccionados.Where(x => !agrupacionHotelesAsignados.Any(y => y.Id == x.Id));

            foreach(var hotelSinAsignar in hotelesSinAsignar)
            {
                var detalleHotel = HotelesModule.GetHotelByID(hotelSinAsignar.IdHotel);

                return $"Debe cargar todos los pasajeros a cada uno de los productos. Falta asignar al menos un pasajero al hotel {detalleHotel.Nombre}. (Id del producto: {hotelSinAsignar.Id})";
            }

            return null;
        }

        public string? ValidarFiltros(string codigo, string dni)
        {
            if (!string.IsNullOrEmpty(codigo) && !int.TryParse(codigo, out int presupuestoId))
            {
                return "Debes ingresar un Id de presupuesto correcto. El mismo tiene que ser un número entero.";
            }

            if (!string.IsNullOrEmpty(dni) && !dni.EsDNI())
            {
                return "Debes ingresar un DNI correcto. El mismo debe ser numérico y tener entre 7 y 8 cifras.";
            }

            return null;
        }

        public IEnumerable<PresupuestoEnt> GetPreReservablesByDNI(string dni)
        {
            return GetPreReservables().Where(x => x.Cliente.DNI == dni);
        }

        public IEnumerable<PresupuestoEnt> GetPreReservablesById(object presupuestoId)
        {
            return GetPreReservables().Where(x => x.IdPresupuesto == (int)presupuestoId);
        }

        public IEnumerable<PresupuestoEnt> GetPreReservablesFiltrados(string inputCodigo, string inputDni)
        {
            var presupuestos = GetPreReservables();

            if (!string.IsNullOrEmpty(inputCodigo))
            {
                var codigo = int.Parse(inputCodigo);

                presupuestos = presupuestos.Where(x => x.IdPresupuesto == codigo);
            }

            if (!string.IsNullOrEmpty(inputDni))
            {
                presupuestos = presupuestos.Where(x => x.Cliente.DNI == inputDni);
            }

            return presupuestos;
        }
    }
}
