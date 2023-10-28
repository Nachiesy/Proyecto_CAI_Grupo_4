using Proyecto_CAI_Grupo_4.Models;

namespace Proyecto_CAI_Grupo_4.Modelos
{
    public static class ReservaModel
    {
        private static List<Reserva> reservas = new List<Reserva>();

        public static Reserva GetLastReserva()
        {
            return reservas.Last();
        }

        public static void AddReserva(Reserva reserva)
        {
            reservas.Add(reserva);
        }
    }
}
