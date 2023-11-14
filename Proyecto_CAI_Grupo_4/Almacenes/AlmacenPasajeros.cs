using Newtonsoft.Json;
using Proyecto_CAI_Grupo_4.Entities;

namespace Proyecto_CAI_Grupo_4.Almacenes
{
    public static class AlmacenPasajeros
    {
        private static string AlmacenPath = @"..\..\..\Datos\Pasajeros.json";

        private static List<PasajerosEnt> Pasajeros = new List<PasajerosEnt>();

        static AlmacenPasajeros()
        {
            if (File.Exists(AlmacenPath))
            {
                var pasajerosInDb = File.ReadAllText(AlmacenPath);

                var pasajeros = JsonConvert.DeserializeObject<List<PasajerosEnt>>(pasajerosInDb);

                if (pasajeros != null)
                {
                    Pasajeros = pasajeros;
                }
            }
        }

        public static List<PasajerosEnt> GetPasajeros()
        {
            return Pasajeros;
        }

        public static void UpdatePasajeros(List<PasajerosEnt> updatedPasajeros)
        {
            Pasajeros.Clear();

            Pasajeros = updatedPasajeros;
        }

        public static void AgregarPasajero(PasajerosEnt pasajero)
        {
            Pasajeros.Add(pasajero);
        }

        public static void AgregarPasajeros(List<PasajerosEnt> pasajeros)
        {
            Pasajeros.AddRange(pasajeros);
        }

        public static void EliminarPasajero(PasajerosEnt pasajero)
        {
            Pasajeros.Remove(pasajero);
        }

        public static void Guardar()
        {
            if (Pasajeros.Count > 0)
            {
                File.WriteAllText(AlmacenPath, JsonConvert.SerializeObject(Pasajeros, Formatting.Indented));
            }
        }

        public static void EliminarPasajerosPorIdPresupuesto(int presupuestoId)
        {
            Pasajeros.RemoveAll(x => x.IdPresupuesto == presupuestoId);
        }
    }
}
