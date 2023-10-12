using System.ComponentModel;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class Reserva
    {
        public int Codigo { get; set; }

        public ReservaEstadoEnum Estado { get; set; }

        public string DNI { get; set; }

        public int TipoDoc {  get; set; }

        public decimal Precio { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }

        public int CantPasajeros { get; set; }

        public int CantMayores { get; set; }
        public int CantMenores { get; set; }


        private string DateTimeToString(DateTime dateTime)
        {
            return dateTime.ToString("dd/MM/yyyy");
        }
    }

    public enum ReservaEstadoEnum
    {
        [Description("Pendiente de Pago")]
        pendienteDePago,

        [Description("Abonada")]
        pagada,

        [Description("Confirmada")]
        confirmada,
    }
}
