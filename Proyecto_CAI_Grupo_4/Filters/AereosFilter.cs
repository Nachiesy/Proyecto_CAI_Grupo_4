namespace Proyecto_CAI_Grupo_4.Filters
{
    public class AereosFilterDto : ProductosFilterDto
    {
        public int? Origen { get; set; }

        public int? Destino { get; set; }

        public int? TipoDePasajero { get; set; }

        public int? Itinerario { get; set; }

        public int? Clase { get; set; }
    }

    public class AereosFilter : ProductosFilter
    {
        public AereosFilter(AereosFilterDto dto) : base(dto)
        {
            Origen = dto.Origen;

            Destino = dto.Destino;

            TipoDePasajero = dto.TipoDePasajero;

            Itinerario = dto.Itinerario;

            Clase = dto.Clase;
        }

        public int? Origen { get; set; }

        public int? Destino { get; set; }

        public int? TipoDePasajero { get; set; }

        public int? Itinerario { get; set; }

        public int? Clase { get; set; }
    }
}
