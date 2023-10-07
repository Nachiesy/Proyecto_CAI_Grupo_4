using System.ComponentModel;

namespace Proyecto_CAI_Grupo_4.Models.Productos
{
    public class Productos
    {
        public Guid Id { get; set; }

        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        public TipoDeServicioEnum TipoDeServicio { get; set; }
    }
}

public enum TipoDeServicioEnum
{
    [Description("Aéreo")]
    aereo,

    [Description("Hotel")]
    hotel,

    [Description("Crucero")]
    crucero,
}
