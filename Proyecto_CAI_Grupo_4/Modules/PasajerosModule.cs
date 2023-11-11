using Proyecto_CAI_Grupo_4.Almacenes;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public static class PasajerosModule
    {
        private static AgregarPasajerosParams AgregarPasajerosParams;

        public static List<Pasajeros> Pasajeros { get; set; } = new List<Pasajeros>();

        public static List<Pasajeros> PasajerosPorConfirmar { get; set; } = new List<Pasajeros>();

        static PasajerosModule()
        {
            Pasajeros = AlmacenPasajeros.GetPasajeros();
        }

        public static List<Pasajeros> GetPasajerosPorConfirmar()
        {
            return PasajerosPorConfirmar;
        }

        public static void LimpiarPasajerosPorConfirmar()
        {
            PasajerosPorConfirmar = new List<Pasajeros>();
        }

        public static void AgregarPasajeroPorConfirmar(Pasajeros pasajero)
        {
            PasajerosPorConfirmar.Add(pasajero);
        }

        public static void AgregarPasajero(Pasajeros pasajero)
        {
            Pasajeros.Add(pasajero);
        }

        public static void AgregarPasajeros(List<Pasajeros> pasajeros)
        {
            AlmacenPasajeros.ReemplazarPasajerosPorIdItinerario(pasajeros, AgregarPasajerosParams.PresupuestoId);
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

        public static void LimpiarPasajerosPorIdPresupuesto(int idPresupuesto)
        {
            Pasajeros = Pasajeros
                .Where(x => x.IdPresupuesto != idPresupuesto)
                .ToList();
        }
    }
}
