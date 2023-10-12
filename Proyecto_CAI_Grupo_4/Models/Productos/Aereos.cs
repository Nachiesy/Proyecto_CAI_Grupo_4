using System.ComponentModel;

namespace Proyecto_CAI_Grupo_4.Models.Productos
{
    public class Aereos : Productos
    {
        public Aereos()
        {
            Paradas = new List<AereosParadas>();
        }

        public decimal PrecioAdultos { get; set; }

        public decimal PrecioMenores { get; set; }

        public int CantidadSeleccionadaAdultos { get; set; }

        public int CantidadSeleccionadaMenores { get; set; }

        public AereosOrigenEnum Origen { get; set; }

        public AereosDestinoEnum Destino { get; set; }

        public DateTime FechaDeSalida { get; set; }

        public DateTime FechaDeLlegada { get; set; }

        public AerolineaEnum Aerolinea { get; set; }

        public TipoDeClaseAereaEnum TipoDeClaseAerea { get; set; }

        public IEnumerable<AereosParadas> Paradas { get; set; }

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

    public enum AerolineaEnum
    {
        [Description("Aerolíneas Argentinas")]
        argentinas,

        [Description("LATAM")]
        latam,
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

    public class AereosParadas
    {
        public string Nombre { get; set; }
    }
}
