namespace Proyecto_CAI_Grupo_4
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnMenuGenerarPresupuesto_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(OpenMenuGenerarPresupuesto);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenMenuGenerarPresupuesto()
        {
            Application.Run(new GenerarPresupuestoMenu());
        }

        private void btnEstadoDeReservas_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(OpenEstadoDeReservas);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenEstadoDeReservas()
        {
            Application.Run(new Reservas());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
