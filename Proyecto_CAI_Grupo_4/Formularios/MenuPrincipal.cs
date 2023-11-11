using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.GenerarPresupuesto;
using Proyecto_CAI_Grupo_4.Models;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4
{
    public partial class MenuPrincipal : VistaBase
    {
        private MenuPrincipalModel Model;

        public MenuPrincipal() : base(tituloModulo: "Menu Principal")
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            Model = new MenuPrincipalModel();

            Model.SetGenerarPresupuestoParamsPorDefecto();

            Model.SetAgregarPasajerosParamsPorDefecto();
        }

        private void btn_BuscarPresupuesto_Click(object sender, EventArgs e)
        {
            Close();

            var thread = new Thread(OpenBuscarPresupuesto);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnMenuGenerarPresupuesto_Click(object sender, EventArgs e)
        {
            Close();

            var thread = new Thread(OpenGenerarPresupuestoMenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btn_AgregarPasajeros_Click(object sender, EventArgs e)
        {
            Close();

            Thread thread = new Thread(OpenAgregarPasajeros);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btn_GenerarPrereserva_Click(object sender, EventArgs e)
        {
            Close();

            var thread = new Thread(OpenGenerarPrereserva);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btn_GenerarReserva_Click(object sender, EventArgs e)
        {
            Close();

            var thread = new Thread(OpenGenerarReserva);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btn_ConfirmarReserva_Click(object sender, EventArgs e)
        {
            Close();

            Thread thread = new Thread(OpenConfirmarReserva);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnConsultarReservas_Click(object sender, EventArgs e)
        {
            Close();

            Thread thread = new Thread(OpenConsultarReservas);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenBuscarPresupuesto()
        {
            Application.Run(new BuscarPresupuesto());
        }
        
        private void OpenGenerarPresupuestoMenu()
        {
            Application.Run(new GenerarPresupuestoMenu());
        }

        private void OpenAgregarPasajeros()
        {
            Application.Run(new AgregarPasajeros());
        }

        private void OpenGenerarPrereserva()
        {
            Application.Run(new GenerarPrereserva());
        }

        private void OpenGenerarReserva()
        {
            Application.Run(new GenerarReserva());
        }

        private void OpenConfirmarReserva()
        {
            Application.Run(new ConfirmarReserva());
        }

        private void OpenConsultarReservas()
        {
            Application.Run(new ConsultarReservas());
        }
    }
}
