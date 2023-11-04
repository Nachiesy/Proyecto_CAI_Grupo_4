using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Models;

namespace Proyecto_CAI_Grupo_4
{
    public partial class MenuPrincipal : VistaBase
    {
        private MenuPrincipalModel Model = new MenuPrincipalModel();

        public MenuPrincipal() : base(tituloModulo: "Menu Principal")
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btn_BuscarPresupuesto_Click(object sender, EventArgs e)
        {
            Close();

            Model.GoToBuscarPresupuesto();
        }

        private void btnMenuGenerarPresupuesto_Click(object sender, EventArgs e)
        {
            Close();

            Model.GoToGenerarPresupuestoMenu();
        }

        private void btn_AgregarPasajeros_Click(object sender, EventArgs e)
        {
            Close();

            Model.GoToAgregarPasajeros();
        }

        private void btn_GenerarPrereserva_Click(object sender, EventArgs e)
        {
            Close();

            Model.GoToGenerarPrereserva();
        }

        private void btn_GenerarReserva_Click(object sender, EventArgs e)
        {
            Close();

            Model.GoToGenerarReserva();
        }

        private void btn_ConfirmarReserva_Click(object sender, EventArgs e)
        {
            Close();

            Model.GoToConfirmarReserva();
        }

        private void btnConsultarReservas_Click(object sender, EventArgs e)
        {
            Close();

            Model.GoToConsultarReservas();
        }
    }
}
