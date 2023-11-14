using Proyecto_CAI_Grupo_4.Almacenes;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Models;

namespace Proyecto_CAI_Grupo_4.Modelos
{
    public static class ReservaModule
    {
        private static List<ReservaEnt> Reservas = new List<ReservaEnt>();

        static ReservaModule()
        {
            Reservas = AlmacenReservas.GetReservas();
        }

        public static List<ReservaEnt> GetReservas()
        {
            return Reservas
                .Where(x => x.Estado == ReservaEstadoEnum.PendienteDeConfirmacion
                            || x.Estado == ReservaEstadoEnum.Confirmada)
                .ToList();
        }

        public static List<PresupuestoEnt> GetPreservas()
        {
            return PresupuestosModule.GetPresupuestosPrereservados()
                .ToList();
        }

        public static List<PresupuestoEnt> GetPrereservaByItinerario(int idItinerario)
        {
            return GetPreservas()
                .FindAll(x => idItinerario == x.IdPresupuesto)
                .ToList();
        }

        public static List<PresupuestoEnt> GetPrereservaAbonadaByItinerario(int idItinerario)
        {
            return GetPreReservasAbonadas()
                .FindAll(x => idItinerario == x.IdPresupuesto)
                .ToList();
        }

        public static PresupuestoEnt GetPreReservasAbonadasById(int id)
        {
            return GetPreReservasAbonadas()
                .Find(x => x.IdPresupuesto == id);
        }

        public static List<ReservaEnt> GetReservasPendientesDeConfirmacion()
        {
            return Reservas.FindAll(x => x.Estado == ReservaEstadoEnum.PendienteDeConfirmacion);
        }

        public static List<PresupuestoEnt> GetPreReservasAbonadas()
        {
            return PresupuestosModule
                .GetPresupuestosPrereservadosAbonados()
                .ToList();
        }

        private static int GenerarCodigoDeReserva()
        {
            return 10000 + Reservas.Count + 1;
        }

        public static ReservaEnt GenerarNuevaReserva(int idItinerario, Cliente cliente)
        {
            var codigo = GenerarCodigoDeReserva();

            var reserva = new ReservaEnt(codigo, idItinerario, cliente);
            
            Reservas.Add(reserva);

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
