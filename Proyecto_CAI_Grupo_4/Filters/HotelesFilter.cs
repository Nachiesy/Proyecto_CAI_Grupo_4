namespace Proyecto_CAI_Grupo_4.Filters
{
    public class HotelesFilterDto : ProductosFilterDto
    {
        public string Ciudad { get; set; }
    }

    public class HotelesFilter : ProductosFilter
    {
        public HotelesFilter(HotelesFilterDto dto) : base(dto)
        {
            Ciudad = dto.Ciudad;
        }

        public string Ciudad { get; set; }
    }
}
