namespace Proyecto_CAI_Grupo_4.Models.Productos
{
    public class ProductosHoteles : Productos
    {
        public string Ciudad { get; set; }

        public string Habitacion { get; set; }

        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }
    }
}
