using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_CAI_Grupo_4.Enums;

public enum PresupuestoEstadoEnum
{
    [Description("Estado Inválido")]
    EstadoInvalido = 0,
    [Description("Presupuesto Pendiente de Pago")]
    Presupuesto_Pendiente_De_Pago = 1,
    [Description("Presupuesto Abonado")]
    Presupuesto_Abonado = 2,
}