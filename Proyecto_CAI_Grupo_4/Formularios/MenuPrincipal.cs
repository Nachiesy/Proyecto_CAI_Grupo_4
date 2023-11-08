using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.GenerarPresupuesto;
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

            GoToBuscarPresupuesto();
        }

        private void btnMenuGenerarPresupuesto_Click(object sender, EventArgs e)
        {
            Close();

            GoToGenerarPresupuestoMenu();
        }

        private void btn_AgregarPasajeros_Click(object sender, EventArgs e)
        {
            Close();

            GoToAgregarPasajeros();
        }

        private void btn_GenerarPrereserva_Click(object sender, EventArgs e)
        {
            Close();

            GoToGenerarPrereserva();
        }

        private void btn_GenerarReserva_Click(object sender, EventArgs e)
        {
            Close();

            GoToGenerarReserva();
        }

        private void btn_ConfirmarReserva_Click(object sender, EventArgs e)
        {
            Close();

            GoToConfirmarReserva();
        }

        private void btnConsultarReservas_Click(object sender, EventArgs e)
        {
            Close();

            GoToConsultarReservas();
        }

        private void GoToBuscarPresupuesto()
        {
            var thread = new Thread(OpenBuscarPresupuesto);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenBuscarPresupuesto()
        {
            Application.Run(new BuscarPresupuesto());
        }

        private void GoToGenerarPresupuestoMenu()
        {
            var thread = new Thread(GenerarPresupuestoMenuModel.OpenGenerarPresupuestoMenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void GoToAgregarPasajeros()
        {
            Thread thread = new Thread(OpenAgregarPasajeros);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenAgregarPasajeros()
        {
            Application.Run(new AgregarPasajeros());
        }

        private void GoToGenerarPrereserva()
        {
            var thread = new Thread(OpenGenerarPrereserva);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenGenerarPrereserva()
        {
            Application.Run(new GenerarPrereserva());
        }

        private void GoToGenerarReserva()
        {
            var thread = new Thread(OpenGenerarReserva);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenGenerarReserva()
        {
            Application.Run(new GenerarReserva());
        }

        private void GoToConfirmarReserva()
        {
            Thread thread = new Thread(OpenConfirmarReserva);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenConfirmarReserva()
        {
            Application.Run(new ConfirmarReserva());
        }

        private void GoToConsultarReservas()
        {
            Thread thread = new Thread(OpenConsultarReservas);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenConsultarReservas()
        {
            Application.Run(new ConsultarReservas());
        }
    }
}
