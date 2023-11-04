using Proyecto_CAI_Grupo_4.Entities;

namespace Proyecto_CAI_Grupo_4.Modelos
{
    public static class PrereservaModule
    {
        private static List<Prereserva> prereserva = new List<Prereserva>()
        {
            new Prereserva(
                codigo: 1,
                estado: PrereservaEstadoEnum.PendienteDePago,
                cliente: new Cliente("43422654", "Juan", "Perez"),
                idItinerario: 1),
        };

        public static List<Prereserva> GetPrereservas()
        {
            return prereserva;
        }

        public static Prereserva? GetPrereservaById(int id)
        {
            return prereserva.Find(x => x.Codigo == id);
        }

        public static List<Prereserva> GetPrereservaAbonadas()
        {
            return prereserva.FindAll(x => x.Estado == PrereservaEstadoEnum.Pagada);
        }

        public static List<Prereserva> GetPrereservaPendientesDePago()
        {
            return prereserva.FindAll(x => x.Estado == PrereservaEstadoEnum.PendienteDePago);
        }

        public static List<Prereserva> GetPrereservaByItinerario(int idItinerario)
        {
            return prereserva.FindAll(x => x.IdItinerario == idItinerario);
        }

        public static Prereserva GetLastPrereserva()
        {
            return prereserva.Last();
        }

        private static int GenerarCodigoDePrereserva()
        {
            return GetLastPrereserva().Codigo + 1;
        }

        public static Prereserva GenerarNuevaPrereserva(int idItinerario, PrereservaEstadoEnum estado, Cliente cliente)
        {
            var codigo = GenerarCodigoDePrereserva();

            var nuevaPreReserva = new Prereserva(codigo, idItinerario, estado, cliente);

            prereserva.Add(nuevaPreReserva);

            return nuevaPreReserva;
        }

        public static void ConfirmarPrereserva(int idPrereserva)
        {
            prereserva
                .Find(x => x.Codigo == idPrereserva)
                .AbonarReserva();
        }
    }
}
