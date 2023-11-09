using Proyecto_CAI_Grupo_4.Modules;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class VistaBaseModel
    {
        public void ClearProducts()
        {
            AereosModule.ClearAereosElegidos();
            HotelesModule.ClearHotelesElegidos();
        }
    }
}
