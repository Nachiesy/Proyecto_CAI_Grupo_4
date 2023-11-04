using Proyecto_CAI_Grupo_4.Enums;

namespace Proyecto_CAI_Grupo_4.Entities
{
    public class Prereserva
    {
        public int Codigo { get; set; }
        public int IdItinerario { get; set; }
        public Cliente Cliente { get; set; }
        public PrereservaEstadoEnum Estado { get; set; }
        public DateTime FechaEstado { get; set; }

        public Prereserva(int codigo, int idItinerario, PrereservaEstadoEnum estado, Cliente cliente)
        {
            Codigo = codigo;
            IdItinerario = idItinerario;
            Cliente = cliente;
            Estado = estado;
            FechaEstado = DateTime.Now;
        }

        public void AbonarReserva()
        {
            Estado = PrereservaEstadoEnum.Pagada;
            FechaEstado = DateTime.Now;
        }
    }
}
