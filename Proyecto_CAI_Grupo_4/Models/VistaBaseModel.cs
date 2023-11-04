using Proyecto_CAI_Grupo_4.Modules;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class VistaBaseModel
    {
        public void GoToMenuPrincipal()
        {
            AereosModule.ClearAereosElegidos();
            HotelesModule.ClearHotelesElegidos();

            var thread = new Thread(MenuPrincipalModel.OpenMenuPrincipal);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
