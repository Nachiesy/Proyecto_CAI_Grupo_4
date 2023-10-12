namespace Proyecto_CAI_Grupo_4.Filters
{
    public class HotelesFilterDto : ProductosFilterDto
    {
        public int? Ciudad { get; set; }

        public int? TipoDeHabitacion { get; set; }

        public int? Calificacion { get; set; }
    }

    public class HotelesFilter : ProductosFilter
    {
        public HotelesFilter(HotelesFilterDto dto) : base(dto)
        {
            Ciudad = dto.Ciudad;
            TipoDeHabitacion = dto.TipoDeHabitacion;
            Calificacion = dto.Calificacion;
        }

        public int? Ciudad { get; set; }

        public int? TipoDeHabitacion { get; set; }

        public int? Calificacion { get; set; }
    }
}
