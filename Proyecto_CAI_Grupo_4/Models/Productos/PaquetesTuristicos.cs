namespace Proyecto_CAI_Grupo_4.Models.Productos
{
    public class PaquetesTuristicos : Productos
    {
        public string Origen { get; set; }

        public string Destino { get; set; }

        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }
    }
}
