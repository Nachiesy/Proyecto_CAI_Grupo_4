namespace Proyecto_CAI_Grupo_4.Filters
{
    public class ProductosFilterDto
    {
        public string PrecioDesde { get; set; }

        public string PrecioHasta { get; set; }

        public DateTime? FechaDesde { get; set; }

        public DateTime? FechaHasta { get; set; }
    }

    public class ProductosFilter
    {
        public ProductosFilter(ProductosFilterDto dto)
        {
            if (decimal.TryParse(dto.PrecioDesde, out decimal precioDesde))
            {
                PrecioDesde = precioDesde;
            }

            if (decimal.TryParse(dto.PrecioHasta, out decimal precioHasta))
            {
                PrecioHasta = precioHasta;
            }

            FechaDesde = dto.FechaDesde.HasValue ? dto.FechaDesde.Value.Date : null;

            FechaHasta = dto.FechaHasta.HasValue ? dto.FechaHasta.Value.Date : null;
        }

        public decimal? PrecioDesde { get; set; }

        public decimal? PrecioHasta { get; set; }

        public DateTime? FechaDesde { get; set; }

        public DateTime? FechaHasta { get; set; }
    }
}
