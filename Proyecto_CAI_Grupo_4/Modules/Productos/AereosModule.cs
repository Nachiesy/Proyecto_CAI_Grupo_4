using Proyecto_CAI_Grupo_4.Almacenes;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Filters;

namespace Proyecto_CAI_Grupo_4.Modules
{
    public static class AereosModule
    {
        private static List<Aereos> aereos = new List<Aereos>();

        private static List<Aereos> aereosElegidos = new List<Aereos>();

        static AereosModule()
        {
            aereos = AlmacenAereos.GetAereos();
        }

        public static IEnumerable<Aereos> GetAereos()
        {
            return aereos;
        }

        public static IEnumerable<Aereos> GetAereosByIds(IEnumerable<int> ids)
        {
            return aereos.Where(x => ids.Contains(x.Id));
        }

        public static IEnumerable<Aereos> GetAereos(AereosFilter filter)
        {
            return aereos
                    .Where(x => (!filter.CantidadMin.HasValue || x.Cantidad >= filter.CantidadMin)
                                && (!filter.PrecioDesde.HasValue || x.Precio >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Precio <= filter.PrecioHasta)
                                && (!filter.FechaDesde.HasValue || x.FechaDeSalida.Date == filter.FechaDesde)
                                && (!filter.FechaHasta.HasValue || x.FechaDeLlegada.Date == filter.FechaHasta)
                                && (!filter.Origen.HasValue || (int)x.Origen == filter.Origen)
                                && (!filter.Destino.HasValue || (int)x.Destino == filter.Destino)
                                && (!filter.TipoDePasajero.HasValue || (int)x.TipoDePasajero == filter.TipoDePasajero)
                                && (!filter.Itinerario.HasValue || (int)x.Itinerario == filter.Itinerario)
                                && (!filter.Clase.HasValue || (int)x.Clase == filter.Clase));
        }

        public static Aereos? GetAereoByID(int id)
        {
            return aereos.SingleOrDefault(x => x.Id == id);
        }

        public static IEnumerable<Aereos> GetAereosElegidos()
        {
            return aereosElegidos;
        }

        public static IEnumerable<int> GetIdsAereosElegidos()
        {
            return aereosElegidos.Select(x => x.Id);
        }

        public static void ClearAereosElegidos()
        {
            aereosElegidos.Clear();
        }

        public static void AddAereoElegido(int id)
        {
            var producto = aereos.Where(x => x.Id == id).SingleOrDefault();

            aereosElegidos.Add(producto);
        }

        public static void RemoveAereoElegido(int id)
        {
            var index = aereosElegidos.FindIndex(x => x.Id == id);

            if (index != -1)
            {
                aereosElegidos.RemoveAt(index);
            }
        }

        public static void ActualizarCantidadesDeAereos()
        {
            var aereosToUpdate = new List<Aereos>(aereos.Intersect(aereosElegidos));

            foreach (var aereo in aereosToUpdate)
            {
                var indexAereo = aereos.FindIndex(x => x.Id == aereo.Id);

                var cantidadSeleccionada = aereosElegidos.Where(x => x.Id == aereo.Id).Count();

                aereo.Cantidad = aereo.Cantidad - cantidadSeleccionada;

                if (indexAereo != -1)
                {
                    aereos[indexAereo] = aereo;
                }
            }

            aereosElegidos.Clear();
        }
    }
}
