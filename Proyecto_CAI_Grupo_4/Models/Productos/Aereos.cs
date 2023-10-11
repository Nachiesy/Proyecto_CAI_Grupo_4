using System.ComponentModel;

namespace Proyecto_CAI_Grupo_4.Models.Productos
{
    public class Aereos : Productos
    {
        public decimal PrecioAdultos { get; set; }

        public decimal PrecioMenores { get; set; }

        public string Origen { get; set; }

        public string Destino { get; set; }

        public DateTime FechaDeSalida { get; set; }

        public DateTime FechaDeLlegada { get; set; }

        public TipoDeClaseAereaEnum TipoDeClaseAerea { get; set; }
    }
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
