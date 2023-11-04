using Newtonsoft.Json;
using Proyecto_CAI_Grupo_4.Entities;

namespace Proyecto_CAI_Grupo_4.Almacenes
{
    public class AlmacenHoteles
    {
        private static string AlmacenPath = @"..\..\..\Datos\Hoteles.json";

        private static List<Hoteles> Hoteles;

        static AlmacenHoteles()
        {
            if (File.Exists(AlmacenPath))
            {
                var hotelesInDb = File.ReadAllText(AlmacenPath);

                Hoteles = JsonConvert.DeserializeObject<List<Hoteles>>(hotelesInDb);
            }
            else
            {
                Hoteles = new List<Hoteles>();
            }
        }

        public static List<Hoteles> GetHoteles()
        {
            return Hoteles;
        }

        public static void UpdateHoteles(List<Hoteles> updatedHoteles)
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
