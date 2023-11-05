using Newtonsoft.Json;
using Proyecto_CAI_Grupo_4.Entities;

namespace Proyecto_CAI_Grupo_4.Almacenes
{
    public class AlmacenHoteles
    {
        private static string AlmacenPath = @"..\..\..\Datos\Productos\Hoteles.json";

        private static List<HotelesEnt> Hoteles;

        static AlmacenHoteles()
        {
            if (File.Exists(AlmacenPath))
            {
                var hotelesInDb = File.ReadAllText(AlmacenPath);

                Hoteles = JsonConvert.DeserializeObject<List<HotelesEnt>>(hotelesInDb);
            }
            else
            {
                Hoteles = new List<HotelesEnt>();
            }
        }

        public static List<HotelesEnt> GetHoteles()
        {
            return Hoteles;
        }

        public static void UpdateHoteles(List<HotelesEnt> updatedHoteles)
        {
            Hoteles.Clear();

            Hoteles = updatedHoteles;
        }

        public static void Guardar()
        {
            File.WriteAllText(AlmacenPath, JsonConvert.SerializeObject(Hoteles, Formatting.Indented));
        }
    }
}
