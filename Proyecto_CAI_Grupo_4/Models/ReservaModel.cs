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
                Codigo = 1,
                Estado = ReservaEstadoEnum.pagada,
                IdItinerario = 1,
                FechaReserva = DateTime.Now,
            },
        };

        public static List<Reserva> GetReservas()
        {
            return reservas;
        }

        public static Reserva GetLastReserva()
        {
            return reservas.Last();
        }

        private static int GenerarCodigoDeReserva()
        {
            return GetLastReserva().Codigo + 1;
        }

        public static Reserva GenerarNuevaReserva(int idItinerario, ReservaEstadoEnum estado)
        {
            var codigo = GenerarCodigoDeReserva();

            return new Reserva(codigo, idItinerario, estado);
        }

        public static void AddReserva(Reserva reserva)
        {
            reservas.Add(reserva);
        }
    }
}
