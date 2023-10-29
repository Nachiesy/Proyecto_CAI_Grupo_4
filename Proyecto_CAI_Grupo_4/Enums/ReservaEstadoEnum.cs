﻿using System.ComponentModel;

namespace Proyecto_CAI_Grupo_4.Enums;

public enum ReservaEstadoEnum
{
    [Description("Pendiente de confirmación")]
    pendconfirmacion,

    [Description("Confirmada")]
    confirmada,

    [Description("Pendiente de Pago")]
    pendienteDePago,

    [Description("Abonada")]
    pagada,
}