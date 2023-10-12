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

            FechaDesde = dto.FechaDesde;

            FechaHasta = dto.FechaHasta;
        }

        public decimal? PrecioDesde { get; set; }

        public decimal? PrecioHasta { get; set; }

        public DateTime? FechaDesde { get; set; }

        public DateTime? FechaHasta { get; set; }
    }
}
