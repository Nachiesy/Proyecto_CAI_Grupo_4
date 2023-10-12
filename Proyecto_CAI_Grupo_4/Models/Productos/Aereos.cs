using System.ComponentModel;

namespace Proyecto_CAI_Grupo_4.Models.Productos
{
    public class Aereos : Productos
    {
        public decimal PrecioAdultos { get; set; }

        public decimal PrecioMenores { get; set; }

        public int CantidadSeleccionadaAdultos { get; set; }

        public int CantidadSeleccionadaMenores { get; set; }

        public AereosOrigenEnum Origen { get; set; }

        public AereosDestinoEnum Destino { get; set; }

        public DateTime FechaDeSalida { get; set; }

        public DateTime FechaDeLlegada { get; set; }

        public TipoDeClaseAereaEnum TipoDeClaseAerea { get; set; }
    }

    public enum TipoDeClaseAereaEnum
    {
        [Description("Turista")]
        turista,

        [Description("Ejecutivo")]
        ejecutivo,

        [Description("Primera Clase")]
        primeraClase,
    }

    public enum AereosOrigenEnum
    {
        [Description("Buenos Aires")]
        buenosAires,

        [Description("Madrid")]
        madrid,

        [Description("Londres")]
        londres,
    }

    public enum AereosDestinoEnum
    {
        [Description("Montevideo")]
        montevideo,

        [Description("Paris")]
        paris,

        [Description("San Francisco")]
        sanFrancisco,
    }
}
