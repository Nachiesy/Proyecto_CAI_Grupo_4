using System.ComponentModel;

namespace Proyecto_CAI_Grupo_4.Entities.Productos
{
    public class Aereos : Productos
    {
        public Aereos()
        {
            Paradas = new List<AereosParadas>();
        }

        public AereosItinerarioEnum Itinerario { get; set; }

        public TipoDePasajeroEnum TipoDePasajero { get; set; }

        public AereosOrigenEnum Origen { get; set; }

        public AereosDestinoEnum Destino { get; set; }

        public DateTime FechaDeSalida { get; set; }

        public DateTime FechaDeLlegada { get; set; }

        public AerolineaEnum Aerolinea { get; set; }

        public TipoDeClaseAereaEnum Clase { get; set; }

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
        [Description("Economy")]
        economy,

        [Description("Premium")]
        premium,

        [Description("Business")]
        business,

        [Description("First")]
        first,
    }

    public enum TipoDePasajeroEnum
    {
        [Description("Adulto")]
        adulto,

        [Description("Menor")]
        menor,

        [Description("Infante")]
        infante,
    }

    public enum AereosItinerarioEnum
    {
        [Description("OW")]
        oneWay,

        [Description("RT")]
        roundTrip,
    }

    public enum AereosOrigenEnum
    {
        [Description("Buenos Aires")]
        buenosAires,

        [Description("Madrid")]
        madrid,

        [Description("Londres")]
        londres,

        [Description("Montevideo")]
        montevideo,

        [Description("Paris")]
        paris,

        [Description("San Francisco")]
        sanFrancisco,
    }

    public enum AereosDestinoEnum
    {
        [Description("Buenos Aires")]
        buenosAires,

        [Description("Madrid")]
        madrid,

        [Description("Londres")]
        londres,

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
