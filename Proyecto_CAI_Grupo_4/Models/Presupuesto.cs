using System.ComponentModel;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class Presupuesto
    {
        public Presupuesto()
        {

        }

        public Presupuesto(PresupuestoDto dto)
        {
            SetTipoDeServicio(dto.TipoDeServicio);

            NombreDelServicio = dto.NombreDelServicio;

            CantidadDePasajerosAdultos = int.Parse(dto.CantidadDePasajerosAdultos);

            CantidadDePasajerosMenores = int.Parse(dto.CantidadDePasajerosMenores);

            if (decimal.TryParse(dto.PrecioDesde, out decimal resultDesde))
            {
                PrecioDesde = resultDesde;
            }


            if (decimal.TryParse(dto.PrecioHasta, out decimal resultHasta))
            {
                PrecioHasta = resultHasta;
            }

            FechaDesde = dto.FechaDesde.Date;

            FechaHasta = dto.FechaHasta.Date;
        }

        public int? Id { get; set; }

        public TipoDeServicioEnum TipoDeServicio { get; set; }

        public string NombreDelServicio { get; set; }

        public int CantidadDePasajerosAdultos { get; set; }

        public int CantidadDePasajerosMenores { get; set; }

        public decimal? PrecioDesde { get; set; }

        public decimal? PrecioHasta { get; set; }

        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }

        private void SetTipoDeServicio(int tipoDeServicio)
        {
            switch (tipoDeServicio)
            {
                case (int)TipoDeServicioEnum.aereo:
                    TipoDeServicio = TipoDeServicioEnum.aereo;
                    break;
                case (int)TipoDeServicioEnum.hotel:
                    TipoDeServicio = TipoDeServicioEnum.hotel;
                    break;
                case (int)TipoDeServicioEnum.crucero:
                    TipoDeServicio = TipoDeServicioEnum.crucero;
                    break;
            }
        }
    }

    public enum TipoDeServicioEnum
    {
        [Description("Aéreo")]
        aereo,

        [Description("Hotel")]
        hotel,

        [Description("Crucero")]
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
