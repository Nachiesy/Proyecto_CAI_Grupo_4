using System.ComponentModel;

namespace Proyecto_CAI_Grupo_4.Models.Productos
{
    public class Cruceros : Productos
    {
        public CrucerosOrigenEnum CiudadDePartida { get; set; }

        public CrucerosDestinoEnum CiudadDeLlegada { get; set; }

        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }

        public TipoDeCamaroteEnum TipoDeCamarote { get; set; }

        public IEnumerable<CrucerosParadas> Paradas { get; set; }

        public string GetParadas()
        {
            var paradas = string.Empty;

            var delimitter = ";";

            foreach (var parada in Paradas)
            {
                if (paradas == string.Empty)
                {
                    paradas += $"{parada.Nombre}";
                }
                else
                {
                    paradas += $"{delimitter}{parada.Nombre}";
                }
            }

            paradas = paradas.Replace(delimitter, ", ");

            return paradas;
        }
    }

    public enum CrucerosOrigenEnum
    {
        [Description("Buenos Aires")]
        buenosAires,

        [Description("Montevideo")]
        montevideo,

        [Description("Miami")]
        miami,

        [Description("Atenas")]
        atenas,
    }

    public enum CrucerosDestinoEnum
    {
        [Description("Mar del Plata")]
        marDelPlata,

        [Description("Rio de Janeiro")]
        rioDeJaneiro,

        [Description("Cancun")]
        cancun,

        [Description("Marruecos")]
        marruecos,
    }

    public enum TipoDeCamaroteEnum
    {
        [Description("Interior")]
        interior,

        [Description("Exterior")]
        exterior,

        [Description("Con Balcon")]
        conBalcon,

        [Description("Suite")]
        suite,
    }

    public class CrucerosParadas
    {
        public string Nombre { get; set; }
    }
}
