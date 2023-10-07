using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_CAI_Grupo_4.Common;

namespace Proyecto_CAI_Grupo_4
{
    public partial class MenuPrincipal : VistaBase
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(OpenReservasForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenReservasForm()
        {
            Application.Run(new Reservas());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

            var thread = new Thread(OpenPresupuestoForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenPresupuestoForm()
        {
            Application.Run(new GenerarPresupuesto());
        }

        private void btn_CerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnl_BarraFijaSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
