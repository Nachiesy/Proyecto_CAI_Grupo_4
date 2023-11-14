using System.ComponentModel;

namespace Proyecto_CAI_Grupo_4.Entities
{
    public class ReservaEnt
    {
        public int Codigo { get; set; }
        public int IdPresupuesto { get; set; }
        public Cliente Cliente { get; set; }
        public ReservaEstadoEnum Estado { get; set; }
        public DateTime FechaEstado { get; set; }

        public ReservaEnt(int codigo, int idItinerario, Cliente cliente)
        {
            Codigo = codigo;
            IdPresupuesto = idItinerario;
            Cliente = cliente;
            Estado = ReservaEstadoEnum.PendienteDeConfirmacion;
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
        [Description("Reserva pendiente de confirmación")]
        PendienteDeConfirmacion = 1,
        [Description("Reserva confirmada")]
        Confirmada = 2,
    }
}
