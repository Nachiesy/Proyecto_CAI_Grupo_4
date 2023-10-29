using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Enums;

namespace Proyecto_CAI_Grupo_4.Modelos
{
    public static class ReservaModel
    {
        private static List<Reserva> reservas = new List<Reserva>()
        {
            new Reserva()
            {
                Codigo = 5000,
                Estado = ReservaEstadoEnum.pagada,
                IdItinerario = 1,

            },
        };

        public static Reserva NuevaReserva(int idItinerario)
        {
            var codigo = reservas.Last().Codigo + 1;

            return new Reserva(codigo, idItinerario);
        }

        public static List<Reserva> GetReservas()
        {
            return reservas;
        }

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
