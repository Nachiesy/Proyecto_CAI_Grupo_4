namespace Proyecto_CAI_Grupo_4.Filters
{
    public class PaquetesTuristicosFilterDto : ProductosFilterDto
    {
        public int? Origen { get; set; }

        public int? Destino { get; set; }
    }

    public class PaquetesTuristicosFilter : ProductosFilter
    {
        public PaquetesTuristicosFilter() : base() { }

        public PaquetesTuristicosFilter(PaquetesTuristicosFilterDto dto) : base(dto)
        {
            Origen = dto.Origen;

            Destino = dto.Destino;
        }

        public int? Origen { get; set; }

        public int? Destino { get; set; }
    }
}
