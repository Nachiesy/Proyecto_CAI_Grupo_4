namespace Proyecto_CAI_Grupo_4.Filters
{
    public class AereosFilter : ProductosFilter
    {
        public int? Origen { get; set; }

        public int? Destino { get; set; }

        public int? TipoDePasajero { get; set; }

        public int? Itinerario { get; set; }

        public int? Clase { get; set; }
    }
}
