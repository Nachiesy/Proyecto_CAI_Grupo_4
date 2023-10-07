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
        private static string tituloModulo = "Menu Principal";
        public MenuPrincipal() : base(tituloModulo)
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
            Close();

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
