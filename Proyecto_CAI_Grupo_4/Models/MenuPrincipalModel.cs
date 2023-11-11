using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class MenuPrincipalModel
    {
        public void SetGenerarPresupuestoParamsPorDefecto()
        {
            PresupuestosModule.SetGenerarPresupuestoParams(new GenerarPresupuestoParams()
            {
                EsNuevo = true,
                InitBuscarPresupuesto = false,
            });
        }

        public void SetAgregarPasajerosParamsPorDefecto()
        {
            PasajerosModule.SetAgregarPasajerosParams(new AgregarPasajerosParams());
        }
    }
}
