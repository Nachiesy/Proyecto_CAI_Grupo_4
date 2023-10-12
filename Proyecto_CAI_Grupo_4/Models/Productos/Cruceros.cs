using System.ComponentModel;

namespace Proyecto_CAI_Grupo_4.Models.Productos
{
    public class Cruceros : Productos
    {
        public CrucerosOrigenEnum CiudadDePartida { get; set; }

        public CrucerosDestinoEnum CiudadDeLlegada { get; set; }

        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }
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
}
