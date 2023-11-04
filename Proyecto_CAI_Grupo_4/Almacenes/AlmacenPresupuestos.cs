using Newtonsoft.Json;
using Proyecto_CAI_Grupo_4.Entities;

namespace Proyecto_CAI_Grupo_4.Almacenes
{
    public static class AlmacenPresupuestos
    {
        private static string AlmacenPath = @"..\..\..\Datos\Presupuestos.json";

        private static List<Itinerario> Itinerarios;

        static AlmacenPresupuestos()
        {
            if (File.Exists(AlmacenPath))
            {
                var itinerariosInDb = File.ReadAllText(AlmacenPath);

                Itinerarios = JsonConvert.DeserializeObject<List<Itinerario>>(itinerariosInDb);
            }
            else
            {
                Itinerarios = new List<Itinerario>();
            }
        }

        public static List<Itinerario> GetPresupuestos()
        {
            return Itinerarios;
        }

        public static void UpdatePresupuestos(List<Itinerario> updatedItinerarios)
        {
            Itinerarios.Clear();

            Itinerarios = updatedItinerarios;
        }

        public static void Guardar()
        {
            File.WriteAllText(AlmacenPath, JsonConvert.SerializeObject(Itinerarios, Formatting.Indented));
        }
    }
}
