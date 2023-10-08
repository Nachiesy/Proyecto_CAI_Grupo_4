namespace Proyecto_CAI_Grupo_4.Filters
{
    public class AereosFilterDto : ProductosFilterDto
    {
        public string Origen { get; set; }

        public string Destino { get; set; }

        public int TipoDeClaseAerea { get; set; }
    }

    public class AereosFilter : ProductosFilter
    {
        public AereosFilter(AereosFilterDto dto) : base(dto)
        {
            Origen = dto.Origen;

            Destino = dto.Destino;

            TipoDeClaseAerea = dto.TipoDeClaseAerea;
        }

        public string Origen { get; set; }

        public string Destino { get; set; }

        public int TipoDeClaseAerea { get; set; }
    }
}
