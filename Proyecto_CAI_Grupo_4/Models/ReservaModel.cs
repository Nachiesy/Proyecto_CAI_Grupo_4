using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Enums;

namespace Proyecto_CAI_Grupo_4.Modelos
{
    public static class ReservaModel
    {
        private static List<Reserva> reservas = new List<Reserva>()
        {
            new Reserva(
                codigo: 1,
                estado: ReservaEstadoEnum.PendienteDeConfirmacion,
                cliente: new Cliente("43422654", "Juan", "Perez"),
                idItinerario: 1),
        };

        public static List<Reserva> GetReservas()
        {
            return reservas;
        }

        public static List<Reserva> GetReservasPendientesDeConfirmacion()
        {
            return reservas.FindAll(x => x.Estado == ReservaEstadoEnum.PendienteDeConfirmacion);
        }

        public static List<Reserva> GetReservasByItinerario(string dni)
        {
            return reservas.FindAll(x => x.Cliente.DNI == dni);
        }

        public static Reserva GetLastReserva()
        {
            return reservas.Last();
        }

        private static int GenerarCodigoDeReserva()
        {
            return GetLastReserva().Codigo + 1;
        }

        public static Reserva GenerarNuevaReserva(int idItinerario, ReservaEstadoEnum estado, Cliente cliente)
        {
            var codigo = GenerarCodigoDeReserva();

            return new Reserva(codigo, idItinerario, estado, cliente);
        }

        public static void AddReserva(Reserva reserva)
        {
            reservas.Add(reserva);
        }

        public static void ConfirmarReserva(int idReserva)
        {
            reservas
                .Find(x => x.Codigo == idReserva)
                .ConfirmarReserva();
        }
    }
}
