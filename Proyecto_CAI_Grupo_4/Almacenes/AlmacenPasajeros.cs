using Newtonsoft.Json;
using Proyecto_CAI_Grupo_4.Entities;

namespace Proyecto_CAI_Grupo_4.Almacenes
{
    public static class AlmacenPasajeros
    {
        private static string AlmacenPath = @"..\..\..\Datos\Pasajeros.json";

        private static List<Pasajeros> Pasajeros = new List<Pasajeros>();

        static AlmacenPasajeros()
        {
            if (File.Exists(AlmacenPath))
            {
                var pasajerosInDb = File.ReadAllText(AlmacenPath);

                var pasajeros = JsonConvert.DeserializeObject<List<Pasajeros>>(pasajerosInDb);

                if (pasajeros != null)
                {
                    Pasajeros = pasajeros;
                }
            }
        }

        public static List<Pasajeros> GetPasajeros()
        {
            return Pasajeros;
        }

        public static void UpdatePasajeros(List<Pasajeros> updatedPasajeros)
        {
            Pasajeros.Clear();

            Pasajeros = updatedPasajeros;
        }

        public static void Guardar()
        {
            if (Pasajeros.Count > 0)
            {
                File.WriteAllText(AlmacenPath, JsonConvert.SerializeObject(Pasajeros, Formatting.Indented));
            }
        }
    }
}
