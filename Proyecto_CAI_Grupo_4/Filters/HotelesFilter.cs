namespace Proyecto_CAI_Grupo_4.Filters
{
    public class HotelesFilterDto : ProductosFilterDto
    {
        public string Nombre { get; set; }

        public int? Ciudad { get; set; }

        public int? TipoDeHabitacion { get; set; }

        public int? Calificacion { get; set; }
    }

    public class HotelesFilter : ProductosFilter
    {
        public HotelesFilter() : base() { }

        public HotelesFilter(HotelesFilterDto dto) : base(dto)
        {
            Nombre = dto.Nombre;
            Ciudad = dto.Ciudad;
            TipoDeHabitacion = dto.TipoDeHabitacion;
            Calificacion = dto.Calificacion;
        }

        public string Nombre { get; set; }

        public int? Ciudad { get; set; }

        public int? TipoDeHabitacion { get; set; }

        public int? Calificacion { get; set; }
    }
}
