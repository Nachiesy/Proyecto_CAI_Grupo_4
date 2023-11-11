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

        internal static void BajarDisponibilidad(int idHotel)
        {
            var index = hoteles.FindIndex(x => x.Id == idHotel);

            if (index != -1)
            {
                hoteles[index].Disponibilidad.Disponibilidad--;
            }
        }
    }
}
