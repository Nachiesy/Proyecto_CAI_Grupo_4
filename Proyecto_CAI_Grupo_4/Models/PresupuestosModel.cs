using Proyecto_CAI_Grupo_4.Entities;

namespace Proyecto_CAI_Grupo_4.Models
{
    public static class PresupuestosModel
    {
        private static List<Itinerario> Presupuestos { get; set; } = new List<Itinerario>();

        public static void AddPresupuesto(Itinerario itinerario)
        {
            Presupuestos.Add(itinerario);
        }

        public static void UpdatePresupuesto(Itinerario itinerarioActualizado)
        {
            var index = Presupuestos.FindIndex(x => x.IdItinerario == itinerarioActualizado.IdItinerario);

            if (index != -1)
            {
                Presupuestos[index] = itinerarioActualizado;
            }
        }

        public static Itinerario? GetPresupuesto(int id)
        {
            return Presupuestos.FirstOrDefault(x => x.IdItinerario == id);
        }

        public static int GenerarId()
        {
            return Presupuestos.Count + 1;
        }
    }
}
