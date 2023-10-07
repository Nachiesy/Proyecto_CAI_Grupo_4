namespace Proyecto_CAI_Grupo_4.Filters
{
    public class ProductosHotelesFilterDto : ProductosFilterDto
    {
        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }
    }

    public class ProductosHotelesFilter : ProductosFilter
    {
        public ProductosHotelesFilter(ProductosHotelesFilterDto dto) : base(dto)
        {
            FechaDesde = dto.FechaDesde.Date;

            FechaHasta = dto.FechaHasta.Date;
        }

        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }
    }
}
