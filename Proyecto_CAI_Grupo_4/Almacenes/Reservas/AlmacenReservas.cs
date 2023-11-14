using Newtonsoft.Json;
using Proyecto_CAI_Grupo_4.Entities;

namespace Proyecto_CAI_Grupo_4.Almacenes
{
    public static class AlmacenReservas
    {
        private static string AlmacenPath = @"..\..\..\Datos\Reservas\Reservas.json";

        private static List<ReservaEnt> Reservas;

        static AlmacenReservas()
        {
            if (File.Exists(AlmacenPath))
            {
                var reservasInDb = File.ReadAllText(AlmacenPath);

                Reservas = JsonConvert.DeserializeObject<List<ReservaEnt>>(reservasInDb);
            }
            else
            {
                Reservas = new List<ReservaEnt>();
            }
        }

        public static List<ReservaEnt> GetReservas()
        {
            return Reservas;
        }

        public static void UpdateReservas(List<ReservaEnt> updatedReservas)
        {
            Reservas.Clear();

            Reservas = updatedReservas;
        }

        public static void Guardar()
        {
            File.WriteAllText(AlmacenPath, JsonConvert.SerializeObject(Reservas, Formatting.Indented));
        }
    }
}
