using Newtonsoft.Json;
using Proyecto_CAI_Grupo_4.Entities;

namespace Proyecto_CAI_Grupo_4.Almacenes
{
    public static class AlmacenAereos
    {
        private static string AlmacenPath = @"..\..\..\Datos\Productos\Aereos.json";

        private static List<AereoEnt> Aereos;

        static AlmacenAereos()
        {
            if (File.Exists(AlmacenPath))
            {
                var aereosInDb = File.ReadAllText(AlmacenPath);

                Aereos = JsonConvert.DeserializeObject<List<AereoEnt>>(aereosInDb);
            }
            else
            {
                Aereos = new List<AereoEnt>();
            }
        }

        public static List<AereoEnt> GetAereos()
        {
            return Aereos;
        }

        public static void UpdateAereos(List<AereoEnt> updatedAereos)
        {
            Aereos.Clear();

            Aereos = updatedAereos;
        }

        public static void Guardar()
        {
            File.WriteAllText(AlmacenPath, JsonConvert.SerializeObject(Aereos, Formatting.Indented));
        }
    }
}
