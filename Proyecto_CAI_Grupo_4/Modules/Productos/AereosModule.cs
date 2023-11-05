using Proyecto_CAI_Grupo_4.Almacenes;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Filters;

namespace Proyecto_CAI_Grupo_4.Modules
{
    public static class AereosModule
    {
        private static List<AereosEnt> aereos = new List<AereosEnt>();

        private static List<AereosEnt> aereosElegidos = new List<AereosEnt>();

        static AereosModule()
        {
            aereos = AlmacenAereos.GetAereos();
        }

        public static IEnumerable<AereosEnt> GetAereos()
        {
            return aereos;
        }

        public static IEnumerable<AereosEnt> GetAereosByIds(IEnumerable<int> ids)
        {
            return aereos.Where(x => ids.Contains(x.Id));
        }

        public static IEnumerable<AereosEnt> GetAereos(AereosFilter filter)
        {
            return aereos
                    .Where(x => (!filter.CantidadMin.HasValue || x.Tarifa.Disponibilidad >= filter.CantidadMin)
                                && (!filter.PrecioDesde.HasValue || x.Tarifa.Precio >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Tarifa.Precio <= filter.PrecioHasta)
                                && (!filter.FechaDesde.HasValue || x.FechaDeSalida.Date == filter.FechaDesde)
                                && (!filter.FechaHasta.HasValue || x.FechaDeLlegada.Date == filter.FechaHasta)
                                && (string.IsNullOrEmpty(filter.Origen) || x.Origen == filter.Origen)
                                && (string.IsNullOrEmpty(filter.Destino) || x.Destino == filter.Destino)
                                && (string.IsNullOrEmpty(filter.TipoDePasajero) || x.Tarifa.TipoDePasajero == filter.TipoDePasajero)
                                && (string.IsNullOrEmpty(filter.Clase) || x.Tarifa.Clase == filter.Clase));
        }

        public static AereosEnt? GetAereoByID(int id)
        {
            return aereos.SingleOrDefault(x => x.Id == id);
        }

        public static IEnumerable<AereosEnt> GetAereosElegidos()
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
            var aereosToUpdate = new List<AereosEnt>(aereos.Intersect(aereosElegidos));

            foreach (var aereo in aereosToUpdate)
            {
                var indexAereo = aereos.FindIndex(x => x.Id == aereo.Id);

                var cantidadSeleccionada = aereosElegidos.Where(x => x.Id == aereo.Id).Count();

                aereo.Tarifa.Disponibilidad = aereo.Tarifa.Disponibilidad - cantidadSeleccionada;

                if (indexAereo != -1)
                {
                    aereos[indexAereo] = aereo;
                }
            }

            aereosElegidos.Clear();
        }
    }
}
