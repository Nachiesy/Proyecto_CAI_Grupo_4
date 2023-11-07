using Newtonsoft.Json;
using Proyecto_CAI_Grupo_4.Entities;

namespace Proyecto_CAI_Grupo_4.Almacenes
{
    public class AlmacenHoteles
    {
        private static string AlmacenPath = @"..\..\..\Datos\Productos\Hoteles.json";

        private static List<HotelEnt> Hoteles;

        static AlmacenHoteles()
        {
            if (File.Exists(AlmacenPath))
            {
                var hotelesInDb = File.ReadAllText(AlmacenPath);

                Hoteles = JsonConvert.DeserializeObject<List<HotelEnt>>(hotelesInDb);
            }
            else
            {
                Hoteles = new List<HotelEnt>();
            }
        }

        public static List<HotelEnt> GetHoteles()
        {
            return Hoteles;
        }

        public static void UpdateHoteles(List<HotelEnt> updatedHoteles)
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
