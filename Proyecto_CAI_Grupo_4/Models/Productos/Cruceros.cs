namespace Proyecto_CAI_Grupo_4.Models.Productos
{
    public class Cruceros : Productos
    {
        public string CiudadDePartida { get; set; }

        public string CiudadDeLlegada { get; set; }

        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }
    }
}
