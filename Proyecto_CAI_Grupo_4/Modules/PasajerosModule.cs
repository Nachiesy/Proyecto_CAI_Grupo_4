using Proyecto_CAI_Grupo_4.Almacenes;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public static class PasajerosModule
    {
        private static AgregarPasajerosParams AgregarPasajerosParams;

        public static List<Pasajeros> Pasajeros { get; set; } = new List<Pasajeros>();

        static PasajerosModule()
        {
            Pasajeros = AlmacenPasajeros.GetPasajeros();
        }

        public static void AgregarPasajero(Pasajeros pasajero)
        {
            AlmacenPasajeros.AgregarPasajero(pasajero);
        }

        public static void AgregarPasajeros(List<Pasajeros> pasajeros)
        {
            AlmacenPasajeros.AgregarPasajeros(pasajeros);
        }

        public static void EliminarPasajero(Pasajeros pasajero)
        {
            AlmacenPasajeros.EliminarPasajero(pasajero);
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
    }
}
