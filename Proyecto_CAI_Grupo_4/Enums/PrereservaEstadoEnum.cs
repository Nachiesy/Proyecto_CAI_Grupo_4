using System.ComponentModel;

namespace Proyecto_CAI_Grupo_4.Enums;

public enum PrereservaEstadoEnum
{
    [Description("Estado Invalido")]
    Invalida = 0,
    [Description("Pendiente de Pago")]
    PendienteDePago = 1,
    [Description("Abonada")]
    Pagada = 2
}
