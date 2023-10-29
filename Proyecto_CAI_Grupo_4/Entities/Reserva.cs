using Proyecto_CAI_Grupo_4.Enums;

namespace Proyecto_CAI_Grupo_4.Entities
{
    public class Reserva
    {
        public int Codigo { get; set; }
        public int IdItinerario { get; set; }

        public ReservaEstadoEnum Estado { get; set; }
        public DateTime FechaReserva { get; set; }

        public Reserva(int codigo, int idItinerario)
        {
            Codigo = codigo;
            IdItinerario = idItinerario;
            Estado = ReservaEstadoEnum.pendconfirmacion;
            FechaReserva = DateTime.Now;
        }

        public Reserva() { }
    }
}
