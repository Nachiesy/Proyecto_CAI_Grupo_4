using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class BuscarPresupuestoModel
    {
        public int PresupuestoId;

        public void GoToGenerarPresupuestoMenu()
        {
            Thread thread = new Thread(OpenGenerarPresupuestoMenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenGenerarPresupuestoMenu()
        {
            Application.Run(new GenerarPresupuestoMenu(new GenerarPresupuestoMenuParams()
            {
                PresupuestoId = PresupuestoId,
                EsNuevo = false,
                InitBuscarPresupuesto = true,
            }));
        }

        public void GoToMenuPrincipal()
        {
            Thread thread = new Thread(OpenMenuPrincipal);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenMenuPrincipal()
        {
            Application.Run(new MenuPrincipal());
        }
    }
}
