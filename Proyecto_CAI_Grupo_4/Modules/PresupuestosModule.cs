using Proyecto_CAI_Grupo_4.Almacenes;
using Proyecto_CAI_Grupo_4.Entities;

namespace Proyecto_CAI_Grupo_4.Models
{
    public static class PresupuestosModule
    {
        private static List<Itinerario> Presupuestos = new List<Itinerario>();

        static PresupuestosModule()
        {
            Presupuestos = AlmacenPresupuestos.GetPresupuestos();
        }

        public static List<Itinerario> GetPresupuestos() => Presupuestos;

        public static List<Itinerario> GetPresupuestosByDNI(string dni) => Presupuestos.FindAll(x => x.Cliente.DNI == dni);

        public static Itinerario? GetPresupuestoById(int id) => Presupuestos.FirstOrDefault(x => x.IdItinerario == id);

        public static List<Itinerario> GetPresupuestosPrereservables() => Presupuestos.FindAll(x => x.EsPrereservable());

        public static List<Itinerario> GetPresupuestosPrereservadosAbonados() => Presupuestos.FindAll(x => x.EsPrereservaAbonada());

        public static List<Itinerario> GetPresupuestosPrereservadosNoAbonados() => Presupuestos.FindAll(x => x.EsPrereservaNoAbonada());

        public static List<Itinerario> GetPresupuestosPrereservados() => Presupuestos.FindAll(x => x.EsPrereserva());

        public static bool EsPresupuestoModificable(int itinerarioId) => 
            Presupuestos.Any(x => x.IdItinerario == itinerarioId && x.EsModificable());

        public static void AddPresupuesto(Itinerario itinerario) => Presupuestos.Add(itinerario);

        public static void UpdatePresupuesto(Itinerario itinerarioActualizado)
        {
            var index = Presupuestos.FindIndex(x => x.IdItinerario == itinerarioActualizado.IdItinerario);

            if (index != -1)
            {
                Presupuestos[index] = itinerarioActualizado;
            }
        }

        public static int GenerarId() => Presupuestos.Count + 1;
    }
}
