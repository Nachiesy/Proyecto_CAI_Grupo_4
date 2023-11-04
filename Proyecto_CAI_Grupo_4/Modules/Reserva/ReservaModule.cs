using Proyecto_CAI_Grupo_4.Almacenes;
using Proyecto_CAI_Grupo_4.Entities;

namespace Proyecto_CAI_Grupo_4.Modelos
{
    public static class ReservaModule
    {
        private static List<Reserva> Reservas = new List<Reserva>();

        static ReservaModule()
        {
            Reservas = AlmacenReservas.GetReservas();
        }

        public static List<Reserva> GetReservas()
        {
            return Reservas;
        }

        public static List<Reserva> GetReservasPendientesDeConfirmacion()
        {
            return Reservas.FindAll(x => x.Estado == ReservaEstadoEnum.PendienteDeConfirmacion);
        }

        public static List<Reserva> GetReservasByItinerario(int id)
        {
            return Reservas.FindAll(x => x.IdItinerario == id);
        }

        public static Reserva GetLastReserva()
        {
            return Reservas.Last();
        }

        private static int GenerarCodigoDeReserva()
        {
            return GetLastReserva().Codigo + 1;
        }

        public static Reserva GenerarNuevaReserva(int idItinerario, ReservaEstadoEnum estado, Cliente cliente)
        {
            var codigo = GenerarCodigoDeReserva();

            var nuevaReserva = new Reserva(codigo, idItinerario, estado, cliente);

            Reservas.Add(nuevaReserva);

            return nuevaReserva;
        }

        public static void AddReserva(Reserva reserva)
        {
            Reservas.Add(reserva);
        }

        public static void ConfirmarReserva(int idReserva)
        {
            Reservas
                .Find(x => x.Codigo == idReserva)
                .ConfirmarReserva();
        }
    }
}
