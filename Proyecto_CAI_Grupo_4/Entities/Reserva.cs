using System.ComponentModel;

namespace Proyecto_CAI_Grupo_4.Entities
{
    public class Reserva
    {
        public int Codigo { get; set; }
        public int IdItinerario { get; set; }
        public Cliente Cliente { get; set; }
        public ReservaEstadoEnum Estado { get; set; }
        public DateTime FechaEstado { get; set; }

        public Reserva(int codigo, int idItinerario, ReservaEstadoEnum estado, Cliente cliente)
        {
            Codigo = codigo;
            IdItinerario = idItinerario;
            Cliente = cliente;
            Estado = estado;
            FechaEstado = DateTime.Now;
        }

        public void ConfirmarReserva()
        {
            Estado = ReservaEstadoEnum.Confirmada;
            FechaEstado = DateTime.Now;
        }
    }

    public enum ReservaEstadoEnum
    {
        [Description("Estado Invalido")]
        Invalida = 0,
        [Description("Pendiente de Confirmación")]
        PendienteDeConfirmacion = 1,
        [Description("Confirmada")]
        Confirmada = 2
    }
}
