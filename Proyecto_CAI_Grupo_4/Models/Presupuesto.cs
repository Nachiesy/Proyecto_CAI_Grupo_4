namespace Proyecto_CAI_Grupo_4.Models
{
    public class Presupuesto
    {
        public TipoDeServicioEnum TipoDeServicio { get; set; }

        public string NombreDelServicio { get; set; }

        public int CantidadDePasajerosAdultos { get; set; }

        public int CantidadDePasajerosMenores { get; set; }

        public decimal PrecioDesde { get; set; }

        public decimal PrecioHasta { get; set; }

        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }
    }

    public enum TipoDeServicioEnum
    {
        aereo,
        hotel,
        crucero,
    }

    public class PresupuestoDto
    {
        public int TipoDeServicio { get; set; }

        public string NombreDelServicio { get; set; }

        public string CantidadDePasajerosAdultos { get; set; }

        public string CantidadDePasajerosMenores { get; set; }

        public string PrecioDesde { get; set; }

        public string PrecioHasta { get; set; }

        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }
    }
}
