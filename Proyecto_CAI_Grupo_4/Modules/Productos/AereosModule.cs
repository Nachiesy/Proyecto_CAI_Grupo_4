using Proyecto_CAI_Grupo_4.Almacenes;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Filters;

namespace Proyecto_CAI_Grupo_4.Modules
{
    public static class AereosModule
    {
        private static List<AereoEnt> aereos = new List<AereoEnt>();

        private static List<AereoEnt> aereosElegidos = new List<AereoEnt>();

        static AereosModule()
        {
            aereos = AlmacenAereos.GetAereos();
        }

        public static IEnumerable<AereoEnt> GetAereos()
        {
            return aereos;
        }

        public static IEnumerable<AereoEnt> GetAereosByIds(IEnumerable<int> ids)
        {
            return aereos.Where(x => ids.Contains(x.Id));
        }

        public static AereoEnt? GetAereoByID(int id)
        {
            return aereos.SingleOrDefault(x => x.Id == id);
        }

        public static IEnumerable<AereoEnt> GetAereosElegidos()
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
            var aereosToUpdate = new List<AereoEnt>(aereos.Intersect(aereosElegidos));

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
