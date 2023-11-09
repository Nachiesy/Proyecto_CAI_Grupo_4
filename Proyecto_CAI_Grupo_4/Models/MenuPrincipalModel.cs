using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class MenuPrincipalModel
    {
        public void SetGenerarPresupuestoParams(GenerarPresupuestoParams generarPresupuestoParams)
        {
            PresupuestosModule.SetGenerarPresupuestoParams(generarPresupuestoParams);
        }
    }
}
