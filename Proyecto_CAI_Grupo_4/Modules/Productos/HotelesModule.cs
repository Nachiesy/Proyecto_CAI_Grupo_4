﻿using Proyecto_CAI_Grupo_4.Almacenes;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Filters;

namespace Proyecto_CAI_Grupo_4.Modules
{
    public static class HotelesModule
    {
        private static List<Hoteles> hoteles = new List<Hoteles>();

        private static List<Hoteles> hotelesElegidos = new List<Hoteles>();

        static HotelesModule()
        {
            hoteles = AlmacenHoteles.GetHoteles();
        }

        public static IEnumerable<Hoteles> GetHoteles()
        {
            return hoteles;
        }

        public static IEnumerable<Hoteles> GetHotelesByIds(IEnumerable<int> ids)
        {
            return hoteles.Where(x => ids.Contains(x.Id));
        }

        public static IEnumerable<Hoteles> GetHoteles(HotelesFilter filter)
        {
            return hoteles
                    .Where(x => (!filter.CantidadMin.HasValue || x.Cantidad >= filter.CantidadMin)
                                && (!filter.PrecioDesde.HasValue || x.Precio >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Precio <= filter.PrecioHasta)
                                && (!filter.FechaDesde.HasValue || x.FechaDesde == filter.FechaDesde)
                                && (!filter.FechaHasta.HasValue || x.FechaHasta == filter.FechaHasta)
                                && (string.IsNullOrEmpty(filter.Nombre) || x.Nombre == filter.Nombre)
                                && (!filter.Ciudad.HasValue || (int)x.Ciudad == filter.Ciudad)
                                && (!filter.TipoDeHabitacion.HasValue || (int)x.TipoDeHabitacion == filter.TipoDeHabitacion)
                                && (!filter.Calificacion.HasValue || (int)x.Calificacion == filter.Calificacion));
        }

        public static Hoteles? GetHotelByID(int id)
        {
            return hoteles.Where(x => x.Id == id).SingleOrDefault();
        }

        public static IEnumerable<Hoteles> GetHotelesElegidos()
        {
            return hotelesElegidos;
        }

        public static IEnumerable<int> GetIdsHotelesElegidos()
        {
            return hotelesElegidos.Select(x => x.Id);
        }

        public static void ClearHotelesElegidos()
        {
            hotelesElegidos.Clear();
        }

        public static void AddHotelElegido(int id)
        {
            var producto = hoteles.Where(x => x.Id == id).SingleOrDefault();

            hotelesElegidos.Add(producto);
        }

        public static void RemoveHotelElegido(int id)
        {
            var index = hotelesElegidos.FindIndex(x => x.Id == id);

            if (index != -1)
            {
                hotelesElegidos.RemoveAt(index);
            }
        }

        public static void ActualizarCantidadesDeHoteles()
        {
            var hotelesToUpdate = new List<Hoteles>(hoteles.Intersect(hotelesElegidos));

            foreach (var hotel in hotelesToUpdate)
            {
                var indexHotel = hoteles.FindIndex(x => x.Id == hotel.Id);

                var cantidadSeleccionada = hotelesElegidos.Where(x => x.Id == hotel.Id).Count();

                hotel.Cantidad = hotel.Cantidad - cantidadSeleccionada;

                if (indexHotel != -1)
                {
                    hoteles[indexHotel] = hotel;
                }
            }

            hotelesElegidos.Clear();
        }
    }
}