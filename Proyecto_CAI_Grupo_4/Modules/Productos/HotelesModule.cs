using Proyecto_CAI_Grupo_4.Almacenes;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Filters;

namespace Proyecto_CAI_Grupo_4.Modules
{
    public static class HotelesModule
    {
        private static List<HotelEnt> hoteles = new List<HotelEnt>();

        private static List<HotelEnt> hotelesElegidos = new List<HotelEnt>();

        static HotelesModule()
        {
            hoteles = AlmacenHoteles.GetHoteles();
        }

        public static IEnumerable<HotelEnt> GetHoteles()
        {
            return hoteles;
        }

        public static IEnumerable<HotelEnt> GetHotelesByIds(IEnumerable<int> ids)
        {
            return hoteles.Where(x => ids.Contains(x.Id));
        }

        public static IEnumerable<HotelEnt> GetHoteles(HotelesFilter filter)
        {
            return hoteles
                    .Where(x => (!filter.CantidadMin.HasValue || x.Disponibilidad.Disponibilidad >= filter.CantidadMin)
                                && (!filter.PrecioDesde.HasValue || x.Disponibilidad.TarifaPorDia >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Disponibilidad.TarifaPorDia <= filter.PrecioHasta)
                                && (!filter.FechaDesde.HasValue || x.Disponibilidad.FechaDesde == filter.FechaDesde)
                                && (!filter.FechaHasta.HasValue || x.Disponibilidad.FechaHasta == filter.FechaHasta)
                                && (string.IsNullOrEmpty(filter.Nombre) || x.Nombre == filter.Nombre)
                                && (string.IsNullOrEmpty(filter.Ciudad) || x.Ciudad == filter.Ciudad)
                                && (string.IsNullOrEmpty(filter.TipoDeHabitacion) || x.Disponibilidad.NombreHabitacion == filter.TipoDeHabitacion)
                                && (string.IsNullOrEmpty(filter.Calificacion) || x.Calificacion == filter.Calificacion));
        }

        public static HotelEnt? GetHotelByID(int id)
        {
            return hoteles.Where(x => x.Id == id).SingleOrDefault();
        }

        public static IEnumerable<HotelEnt> GetHotelesElegidos()
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
            var hotelesToUpdate = new List<HotelEnt>(hoteles.Intersect(hotelesElegidos));

            foreach (var hotel in hotelesToUpdate)
            {
                var indexHotel = hoteles.FindIndex(x => x.Id == hotel.Id);

                var cantidadSeleccionada = hotelesElegidos.Where(x => x.Id == hotel.Id).Count();

                hotel.Disponibilidad.Disponibilidad = hotel.Disponibilidad.Disponibilidad - cantidadSeleccionada;

                if (indexHotel != -1)
                {
                    hoteles[indexHotel] = hotel;
                }
            }

            hotelesElegidos.Clear();
        }
    }
}
