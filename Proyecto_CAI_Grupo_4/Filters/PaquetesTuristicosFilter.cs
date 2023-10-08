namespace Proyecto_CAI_Grupo_4.Filters
{
    public class PaquetesTuristicosFilterDto : ProductosFilterDto
    {
        public string Origen { get; set; }

        public string Destino { get; set; }
    }

    public class PaquetesTuristicosFilter : ProductosFilter
    {
        public PaquetesTuristicosFilter(PaquetesTuristicosFilterDto dto) : base(dto)
        {
            Origen = dto.Origen;

            Destino = dto.Destino;
        }

        public string Origen { get; set; }

        public string Destino { get; set; }
    }
}
