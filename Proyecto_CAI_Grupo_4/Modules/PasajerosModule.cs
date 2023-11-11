﻿using Proyecto_CAI_Grupo_4.Almacenes;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public static class PasajerosModule
    {
        private static AgregarPasajerosParams AgregarPasajerosParams;

        public static List<Pasajeros> Pasajeros { get; set; } = new List<Pasajeros>();

        static PasajerosModule()
        {
            Pasajeros = AlmacenPasajeros.GetPasajeros();
        }

        public static void AgregarPasajero(Pasajeros pasajero)
        {
            AlmacenPasajeros.AgregarPasajero(pasajero);
        }

        public static void AgregarPasajeros(List<Pasajeros> pasajeros)
        {
            AlmacenPasajeros.AgregarPasajeros(pasajeros);
        }

        public static void EliminarPasajero(Pasajeros pasajero)
        {
            AlmacenPasajeros.EliminarPasajero(pasajero);
        }

        public static List<Pasajeros> GetPasajeros()
        {
            return Pasajeros;
        }

        public static List<Pasajeros> GetPasajerosByIdPresupuesto(int idPresupuesto)
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

        public static List<AgrupacionCantidadesHotelesSeleccionados> GetAgrupacionCantidadesHotelesSeleccionadosPorIdItinerario(int idItinerario)
        {
            var agrupacionCantidadesHotelesSeleccionados = Pasajeros
                .Where(x => x.IdPresupuesto == idItinerario)
                .SelectMany(x => x.HotelesAsignados
                    .Select(y =>
                        new { TipoPasajero = x.GetTipoDePasajero(), IdHotel = y.IdHotel }))
                .GroupBy(x => new { x.IdHotel, x.TipoPasajero })
                .Select(x => new AgrupacionCantidadesHotelesSeleccionados { IdHotel = x.Key.IdHotel, TipoPasajero = x.Key.TipoPasajero, Cantidad = x.Count() })
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
            Pasajeros.RemoveAll(x => x.IdPresupuesto ==  presupuestoId);
        }
    }
}
