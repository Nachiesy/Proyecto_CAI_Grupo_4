namespace Proyecto_CAI_Grupo_4.Filters
{
    public class HotelesFilter : ProductosFilter
    {
        public string Nombre { get; set; }

        public int? Ciudad { get; set; }

        public int? TipoDeHabitacion { get; set; }

        public int? Calificacion { get; set; }
    }
}
