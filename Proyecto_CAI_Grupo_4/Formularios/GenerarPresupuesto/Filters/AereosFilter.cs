namespace Proyecto_CAI_Grupo_4.Filters
{
    public class AereosFilter : ProductosFilter
    {
        public string Origen { get; set; }

        public string Destino { get; set; }

        public string TipoDePasajero { get; set; }

        public string Itinerario { get; set; }

        public string Clase { get; set; }
    }
}
