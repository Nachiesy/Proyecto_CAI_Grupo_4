using Proyecto_CAI_Grupo_4.Almacenes;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Models;

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

        public static List<Itinerario> GetPreservas()
        {
            return PresupuestosModule.GetPresupuestosPrereservados()
                .ToList();
        }

        public static List<Itinerario> GetPrereservaByItinerario(int idItinerario)
        {
            return GetPreservas()
                .FindAll(x => idItinerario == x.IdItinerario)
                .ToList();
        }

        public static List<Itinerario> GetPrereservaAbonadaByItinerario(int idItinerario)
        {
            return GetPreReservasAbonadas()
                .FindAll(x => idItinerario == x.IdItinerario)
                .ToList();
        }

        public static Itinerario GetPreReservasAbonadasById(int id)
        {
            return GetPreReservasAbonadas()
                .Find(x => x.IdItinerario == id);
        }

        public static List<Reserva> GetReservasPendientesDeConfirmacion()
        {
            return Reservas.FindAll(x => x.Estado == ReservaEstadoEnum.PendienteDeConfirmacion);
        }

        public static List<Itinerario> GetPreReservasAbonadas()
        {
            return PresupuestosModule
                .GetPresupuestosPrereservadosAbonados()
                .ToList();
        }

        private static int GenerarCodigoDeReserva()
        {
            return Reservas.Last().Codigo + 1;
        }

        public static Reserva GenerarNuevaReserva(int idItinerario, Cliente cliente)
        {
            var codigo = GenerarCodigoDeReserva();

            var reserva = new Reserva(codigo, idItinerario, cliente);
            
            Reservas.Add(reserva);

            return reserva;
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
