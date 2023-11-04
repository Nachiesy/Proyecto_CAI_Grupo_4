namespace Proyecto_CAI_Grupo_4.Models
{
    public class BuscarPresupuestoModel
    {
        public int PresupuestoId;

        public void GoToGenerarPresupuestoMenu()
        {
            GenerarPresupuestoMenuModel.PresupuestoId = PresupuestoId;
            GenerarPresupuestoMenuModel.EsNuevo = false;
            GenerarPresupuestoMenuModel.InitBuscarPresupuesto = true;

            Thread thread = new Thread(GenerarPresupuestoMenuModel.OpenGenerarPresupuestoMenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
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
