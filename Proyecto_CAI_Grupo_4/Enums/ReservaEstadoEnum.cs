using System.ComponentModel;

namespace Proyecto_CAI_Grupo_4.Enums;

public enum ReservaEstadoEnum
{
    [Description("Estado Invalido")]
    Invalida = 0,
    [Description("Pendiente de Confirmación")]
    PendienteDeConfirmacion = 1,
    [Description("Confirmada")]
    Confirmada = 2
}
