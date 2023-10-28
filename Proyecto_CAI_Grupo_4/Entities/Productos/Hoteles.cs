using System.ComponentModel;

namespace Proyecto_CAI_Grupo_4.Entities
{
    public class Hoteles : Productos
    {
        public HotelesCiudadEnum Ciudad { get; set; }

        public string Direccion { get; set; }

        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }

        public TipoDeHabitacionEnum TipoDeHabitacion { get; set; }

        public HotelesCalificacionEnum Calificacion { get; set; }

        public int CantidadDePersonas
        {
            get
            {
                return CantidadMaximaDeAdultos + CantidadMaximaDeMenores + CantidadMaximaDeInfantes;
            }
        }

        public int CantidadMaximaDeAdultos { get; set; }

        public int CantidadMaximaDeMenores { get; set; }

        public int CantidadMaximaDeInfantes { get; set; }
    }

    public enum HotelesCiudadEnum
    {
        [Description("Buenos Aires")]
        buenosAires,

        [Description("Montevideo")]
        montevideo,

        [Description("Madrid")]
        madrid,
    }

    public enum TipoDeHabitacionEnum
    {
        [Description("Simple")]
        simple,

        [Description("Doble")]
        doble,

        [Description("Triple")]
        triple,


        [Description("Cuádruple")]
        cuadruple,
    }

    public enum HotelesCalificacionEnum
    {
        [Description("1 Estrella")]
        una,

        [Description("2 Estrellas")]
        dos,

        [Description("3 Estrellas")]
        tres,

        [Description("4 Estrellas")]
        cuatro,

        [Description("5 Estrellas")]
        cinco,
    }
}
