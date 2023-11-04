using Newtonsoft.Json;
using Proyecto_CAI_Grupo_4.Entities;

namespace Proyecto_CAI_Grupo_4.Almacenes
{
    public static class AlmacenPreReservas
    {
        private static string AlmacenPath = @"..\..\..\Datos\Reservas\PreReservas.json";

        private static List<Prereserva> PreReservas;

        static AlmacenPreReservas()
        {
            if (File.Exists(AlmacenPath))
            {
                var preReservasInDb = File.ReadAllText(AlmacenPath);

                PreReservas = JsonConvert.DeserializeObject<List<Prereserva>>(preReservasInDb);
            }
            else
            {
                PreReservas = new List<Prereserva>();
            }
        }

        public static List<Prereserva> GetPreReservas()
        {
            return PreReservas;
        }

        public static void UpdatePreReservas(List<Prereserva> updatedPreReservas)
        {
            PreReservas.Clear();

            PreReservas = updatedPreReservas;
        }

        public static void Guardar()
        {
            File.WriteAllText(AlmacenPath, JsonConvert.SerializeObject(PreReservas, Formatting.Indented));
        }
    }
}
