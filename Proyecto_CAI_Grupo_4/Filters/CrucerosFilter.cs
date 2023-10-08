namespace Proyecto_CAI_Grupo_4.Filters
{
    public class CrucerosFilterDto : ProductosFilterDto
    {
        public string CiudadDePartida { get; set; }

        public string CiudadDeLlegada { get; set; }
    }

    public class CrucerosFilter : ProductosFilter
    {
        public CrucerosFilter(CrucerosFilterDto dto) : base(dto)
        {
            CiudadDePartida = dto.CiudadDePartida;

            CiudadDeLlegada = dto.CiudadDeLlegada;
        }

        public string CiudadDePartida { get; set; }

        public string CiudadDeLlegada { get; set; }
    }
}
