using Proyecto_CAI_Grupo_4.Almacenes;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public static class PresupuestosModule
    {
        private static GenerarPresupuestoParams GenerarPresupuestoParams;

        private static List<PresupuestoEnt> Presupuestos = new List<PresupuestoEnt>();

        static PresupuestosModule()
        {
            Presupuestos = AlmacenPresupuestos.GetPresupuestos();
        }

        public static List<PresupuestoEnt> GetPresupuestoParaId()
        {
            return Presupuestos;
        }

        public static List<PresupuestoEnt> GetPresupuestos() => Presupuestos.Where(x => x.EsModificable()).ToList();

        public static List<PresupuestoEnt> GetPresupuestosByDNI(string dni) => Presupuestos.FindAll(x => x.Cliente.DNI == dni);

        public static PresupuestoEnt? GetPresupuestoById(int id) => Presupuestos.FirstOrDefault(x => x.IdPresupuesto == id);

        public static List<PresupuestoEnt> GetPresupuestosPrereservables() => Presupuestos.FindAll(x => x.EsPrereservable());

        public static List<PresupuestoEnt> GetPresupuestosPrereservadosAbonados() => Presupuestos.FindAll(x => x.EsPrereservaAbonada());

        public static List<PresupuestoEnt> GetPresupuestosPrereservadosNoAbonados() => Presupuestos.FindAll(x => x.EsPrereservaNoAbonada());

        public static List<PresupuestoEnt> GetPresupuestosPrereservados() => Presupuestos.FindAll(x => x.EsPrereserva());

        public static bool EsPresupuestoModificable(int itinerarioId) => 
            Presupuestos.Any(x => x.IdPresupuesto == itinerarioId && x.EsModificable());

        public static void ActualizarEstadoAReservado(int idItinerario)
        {
            var presupuesto = Presupuestos.Find(x => x.IdPresupuesto == idItinerario);

            if (presupuesto != null)
            {
                presupuesto.ActualizarEstadoAReservado();
            }
        }

        public static void AddPresupuesto(PresupuestoEnt itinerario) => Presupuestos.Add(itinerario);

        public static void UpdatePresupuesto(PresupuestoEnt itinerarioActualizado)
        {
            var index = Presupuestos.FindIndex(x => x.IdPresupuesto == itinerarioActualizado.IdPresupuesto);

            if (index != -1)
            {
                Presupuestos[index] = itinerarioActualizado;
            }
        }

        public static GenerarPresupuestoParams GetGenerarPresupuestoParams()
        {
            return GenerarPresupuestoParams;
        }
        public static void SetGenerarPresupuestoParams(GenerarPresupuestoParams generarPresupuestoParams)
        {
            GenerarPresupuestoParams = generarPresupuestoParams;
        }
    }
}
