namespace Proyecto_CAI_Grupo_4.Filters
{
    public class CrucerosFilterDto : ProductosFilterDto
    {
        public int? CiudadDePartida { get; set; }

        public int? CiudadDeLlegada { get; set; }

        public int? TipoDeCamarote { get; set; }
    }

    public class CrucerosFilter : ProductosFilter
    {
        public CrucerosFilter(CrucerosFilterDto dto) : base(dto)
        {
            CiudadDePartida = dto.CiudadDePartida;

            CiudadDeLlegada = dto.CiudadDeLlegada;

            TipoDeCamarote = dto.TipoDeCamarote;
        }

        public int? CiudadDePartida { get; set; }

        public int? CiudadDeLlegada { get; set; }

        public int? TipoDeCamarote { get; set; }
    }
}
