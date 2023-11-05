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
            return Reservas
                .Where(x => x.Estado == ReservaEstadoEnum.PendienteDeConfirmacion
                            || x.Estado == ReservaEstadoEnum.Confirmada)
                .ToList();
        }

        public static List<Reserva> GetPreservas()
        {
            return Reservas
                .Where(x => x.Estado == ReservaEstadoEnum.PendienteDePago
                            || x.Estado == ReservaEstadoEnum.Pagada)
                .ToList();
        }

        public static List<Reserva> GetPrereservaByItinerario(int idItinerario)
        {
            return GetPreservas()
                .FindAll(x => idItinerario == x.IdItinerario)
                .ToList();
        }

        public static List<Reserva> GetPrereservaAbonadaByItinerario(int idItinerario)
        {
            return GetPreReservasAbonadas()
                .FindAll(x => idItinerario == x.IdItinerario)
                .ToList();
        }

        public static Reserva GetPreReservasAbonadasById(int id)
        {
            return GetPreReservasAbonadas().Find(x => x.Codigo == id);
        }

        public static List<Reserva> GetReservasPendientesDeConfirmacion()
        {
            return Reservas.FindAll(x => x.Estado == ReservaEstadoEnum.PendienteDeConfirmacion);
        }

        public static List<Reserva> GetPreReservasAbonadas()
        {
            return Reservas.FindAll(x => x.Estado == ReservaEstadoEnum.Pagada);
        }

        private static int GenerarCodigoDeReserva()
        {
            return Reservas.Last().Codigo + 1;
        }

        public static Reserva GenerarNuevaPreReserva(int idItinerario, Cliente cliente)
        {
            var codigo = GenerarCodigoDeReserva();

            //var preReserva = new Reserva(codigo, idItinerario, ReservaEstadoEnum.PendienteDePago, cliente);
            var preReserva = new Reserva(codigo, idItinerario, ReservaEstadoEnum.Pagada, cliente);
            //Queda hardcodeado que todas las pre-reservas automaticamente se "abonan" al generarlas

            Reservas.Add(preReserva);

            return preReserva;
        }

        public static Reserva ConvertirPreReservaEnReserva(int idReserva)
        {
            var reserva = Reservas
                .Find(x => x.Codigo == idReserva);

            reserva.ConfirmarPreReserva();

            return reserva;
        }

        public static void ConfirmarReserva(int idReserva)
        {
            Reservas
                .Find(x => x.Codigo == idReserva)
                .ConfirmarReserva();
        }
    }
}
