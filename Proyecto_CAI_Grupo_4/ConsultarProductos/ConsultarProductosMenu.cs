using Proyecto_CAI_Grupo_4.Common.Views;

namespace Proyecto_CAI_Grupo_4
{
    public partial class ConsultarProductosMenu : VistaBase
    {
        public ConsultarProductosMenu() : base(tituloModulo: "Consultar Productos")
        {
            InitializeComponent();
        }

        private void btnMenuAereos_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(OpenConsultarAereos);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenConsultarAereos()
        {
            Application.Run(new ConsultarAereos());
        }

        private void btnMenuHoteles_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(OpenConsultarHoteles);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenConsultarHoteles()
        {
            Application.Run(new ConsultarHoteles());
        }

        private void btnMenuCruceros_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(OpenConsultarCruceros);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenConsultarCruceros()
        {
            Application.Run(new ConsultarCruceros());
        }

        private void btnMenuPaquetes_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(OpenConsultarPaquetes);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenConsultarPaquetes()
        {
            Application.Run(new ConsultarPaquetesTuristicos());
        }
    }
}
