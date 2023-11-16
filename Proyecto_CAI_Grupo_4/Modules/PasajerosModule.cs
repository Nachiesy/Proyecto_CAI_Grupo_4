using Proyecto_CAI_Grupo_4.Almacenes;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modules;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public static class PasajerosModule
    {
        private static AgregarPasajerosParams AgregarPasajerosParams;

        public static List<PasajerosEnt> Pasajeros { get; set; } = new List<PasajerosEnt>();

        static PasajerosModule()
        {
            Pasajeros = AlmacenPasajeros.GetPasajeros();
        }

        public static void AgregarPasajero(PasajerosEnt pasajero)
        {
            AlmacenPasajeros.AgregarPasajero(pasajero);
        }

        public static void AgregarPasajeros(List<PasajerosEnt> pasajeros)
        {
            AlmacenPasajeros.AgregarPasajeros(pasajeros);
        }

        public static void EliminarPasajero(PasajerosEnt pasajero)
        {
            AlmacenPasajeros.EliminarPasajero(pasajero);
        }

        public static List<PasajerosEnt> GetPasajeros()
        {
            return Pasajeros;
        }

        public static List<PasajerosEnt> GetPasajerosByIdPresupuesto(int idPresupuesto)
        {
            return Pasajeros
                .Where(x => x.IdPresupuesto == idPresupuesto)
                .ToList();
        }

        public static int GetTotalPasajerosByIdPresupuesto(int idPresupuesto)
        {
            return Pasajeros
                .Where(x => x.IdPresupuesto == idPresupuesto)
                .Select(x => x.AereosAsignados.Count + x.HotelesAsignados.Count)
                .DefaultIfEmpty(0)
                .Sum();
        }

        public static AgregarPasajerosParams GetAgregarPasajerosParams()
        {
            return AgregarPasajerosParams;
        }

        public static void SetAgregarPasajerosParams(AgregarPasajerosParams agregarPasajerosParams)
        {
            AgregarPasajerosParams = agregarPasajerosParams;
        }

        private static int GetCantidadMaximaDePasajerosPorTipoDePasajero(int idHotel, string tipoDePasajero)
        {
            if(tipoDePasajero == "Adulto")
            {
                return HotelesModule.GetHotelByID(idHotel).Disponibilidad.CantidadMaximaAdultos;
            }
            else if(tipoDePasajero == "Menor")
            {
                return HotelesModule.GetHotelByID(idHotel).Disponibilidad.CantidadMaximaMenores;
            }
            else if(tipoDePasajero == "Infante")
            {
                return HotelesModule.GetHotelByID(idHotel).Disponibilidad.CantidadMaximaInfantes;
            }
            else
            {
                return 0;
            }
        }

        public static List<AgrupacionCantidadesHotelesSeleccionados> GetAgrupacionCantidadesHotelesSeleccionadosPorIdItinerario(int idItinerario)
        {
            var agrupacionCantidadesHotelesSeleccionados = Pasajeros
                .Where(x => x.IdPresupuesto == idItinerario)
                .SelectMany(x => x.HotelesAsignados
                    .Select(y =>
                        new { TipoPasajero = x.GetTipoDePasajero(), IdHotel = y.IdHotel, Id = y.Id }))
                .GroupBy(x => new { x.IdHotel, x.Id, x.TipoPasajero })
                .Select(x => new AgrupacionCantidadesHotelesSeleccionados {
                    Id = x.Key.Id,
                    IdHotel = x.Key.IdHotel,
                    TipoPasajero = x.Key.TipoPasajero,
                    CantidadMaximaPorTipoPasajero = GetCantidadMaximaDePasajerosPorTipoDePasajero(x.Key.IdHotel, x.Key.TipoPasajero),
                    Cantidad = x.Count() })
                .ToList();

            return agrupacionCantidadesHotelesSeleccionados;
        }

        public static List<AgrupacionCantidadesProductosAsignados> GetAgrupacionVuelosAsignados(int idItinerario)
        {
            var agrupacionVuelosAsignados = Pasajeros
                .Where(x => x.IdPresupuesto == idItinerario)
                .SelectMany(x =>
                    x.AereosAsignados.Select(y =>
                        new { y.Id, y.IdAereo }))
                .GroupBy(x => new { x.Id })
                .Select(x => new AgrupacionCantidadesProductosAsignados { Id = x.Key.Id, IdProducto = x.First().IdAereo, Cantidad = x.Count() })
                .ToList();

            return agrupacionVuelosAsignados;
        }

        public static List<AgrupacionCantidadesProductosAsignados> GetAgrupacionHotelesAsignados(int idItinerario)
        {
            var agrupacionHotelesAsignados = Pasajeros
                .Where(x => x.IdPresupuesto == idItinerario)
                .SelectMany(x =>
                    x.HotelesAsignados.Select(y =>
                        new { y.Id, y.IdHotel }))
                .GroupBy(x => new { x.Id })
                .Select(x => new AgrupacionCantidadesProductosAsignados { Id = x.Key.Id, IdProducto = x.First().IdHotel, Cantidad = x.Count() })
                .ToList();

            return agrupacionHotelesAsignados;
        }

        public static void LimpiarAsignacionesPasajerosPorIdPresupuesto(int presupuestoId)
        {
            AlmacenPasajeros.EliminarPasajerosPorIdPresupuesto(presupuestoId);
        }

        public static List<AgrupacionCantidadesProductosAsignados> GetAgrupacionVuelosAsignadosPorTarifa(int idItinerario)
        {
            var agrupacionVuelosAsignados = Pasajeros
                .Where(x => x.IdPresupuesto == idItinerario)
                .SelectMany(x =>
                    x.AereosAsignados.Select(y => new {
                        Id = y.Id,
                        IdAereo = y.IdAereo,
                        CodigoAereo = AereosModule.GetAereoByID(y.IdAereo)!.Codigo,
                        TipoPasajero = AereosModule.GetAereoByID(y.IdAereo)!.Tarifa.TipoDePasajero
                    }))
                .GroupBy(x => new { x.TipoPasajero, x.CodigoAereo })
                .Select(x => new AgrupacionCantidadesProductosAsignados { CodigoProducto = x.Key.CodigoAereo, TipoPasajero = x.Key.TipoPasajero, Cantidad = x.Count() })
                .ToList();

            return agrupacionVuelosAsignados;
        }
    }
}
