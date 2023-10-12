using Proyecto_CAI_Grupo_4.Utils;
using System.ComponentModel;

namespace Proyecto_CAI_Grupo_4.Models.Productos
{
    public class Productos
    {
        public Guid Id { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        public int Cantidad { get; set; }

        public int? CantidadSeleccionada { get; set; }

        public decimal? SubTotal { get; set; }

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

    [Description("Paquete")]
    paquete,
}

public static class TipoDeServicioEnumHelper
{
    public static TipoDeServicioEnum? GetTipoDeServicioEnum(string tipoDeServicio)
    {
        if (tipoDeServicio == TipoDeServicioEnum.aereo.GetDescription())
        {
            return TipoDeServicioEnum.aereo;
        }

        if (tipoDeServicio == TipoDeServicioEnum.hotel.GetDescription())
        {
            return TipoDeServicioEnum.hotel;
        }

        if (tipoDeServicio == TipoDeServicioEnum.crucero.GetDescription())
        {
            return TipoDeServicioEnum.crucero;
        }

        if (tipoDeServicio == TipoDeServicioEnum.paquete.GetDescription())
        {
            return TipoDeServicioEnum.paquete;
        }

        return null;
    }
}
