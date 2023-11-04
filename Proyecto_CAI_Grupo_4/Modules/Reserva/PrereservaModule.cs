using Proyecto_CAI_Grupo_4.Almacenes;
using Proyecto_CAI_Grupo_4.Entities;

namespace Proyecto_CAI_Grupo_4.Modelos
{
    public static class PrereservaModule
    {
        private static List<Prereserva> PreReservas = new List<Prereserva>();

        static PrereservaModule()
        {
            PreReservas = AlmacenPreReservas.GetPreReservas();
        }

        public static List<Prereserva> GetPrereservas()
        {
            return PreReservas;
        }

        public static Prereserva? GetPrereservaById(int id)
        {
            return PreReservas.Find(x => x.Codigo == id);
        }

        public static List<Prereserva> GetPrereservaAbonadas()
        {
            return PreReservas.FindAll(x => x.Estado == PrereservaEstadoEnum.Pagada);
        }

        public static List<Prereserva> GetPrereservaPendientesDePago()
        {
            return PreReservas.FindAll(x => x.Estado == PrereservaEstadoEnum.PendienteDePago);
        }

        public static List<Prereserva> GetPrereservaByItinerario(int idItinerario)
        {
            return PreReservas.FindAll(x => x.IdItinerario == idItinerario);
        }

        public static Prereserva GetLastPrereserva()
        {
            return PreReservas.Last();
        }

        private static int GenerarCodigoDePrereserva()
        {
            return GetLastPrereserva().Codigo + 1;
        }

        public static Prereserva GenerarNuevaPrereserva(int idItinerario, PrereservaEstadoEnum estado, Cliente cliente)
        {
            var codigo = GenerarCodigoDePrereserva();

            var nuevaPreReserva = new Prereserva(codigo, idItinerario, estado, cliente);

            PreReservas.Add(nuevaPreReserva);

            return nuevaPreReserva;
        }

        public static void ConfirmarPrereserva(int idPrereserva)
        {
            PreReservas
                .Find(x => x.Codigo == idPrereserva)
                .AbonarReserva();
        }
    }
}
