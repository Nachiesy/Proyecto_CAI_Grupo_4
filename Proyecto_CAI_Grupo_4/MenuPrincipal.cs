using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_CAI_Grupo_4.Common.Views;

namespace Proyecto_CAI_Grupo_4
{
    public partial class MenuPrincipal : VistaBase
    {
        public MenuPrincipal() : base(tituloModulo: "Menu Principal")
        {
            InitializeComponent();
        }

        private void btnMenuGenerarPresupuesto_Click(object sender, EventArgs e)
        {
            Close();

            var thread = new Thread(OpenMenuGenerarPresupuesto);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenMenuGenerarPresupuesto()
        {
            Application.Run(new GenerarPresupuestoMenu());
        }

        private void btnConsultarReservas_Click(object sender, EventArgs e)
        {
            Close();

            Thread thread = new Thread(OpenConsultarDeReservas);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenConsultarDeReservas()
        {
            Application.Run(new ConsultarReservas());
        }

        private void btn_GenerarReserva_Click(object sender, EventArgs e)
        {
            Close();

            Thread thread = new Thread(OpenGenerarReserva);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenGenerarReserva()
        {
            Application.Run(new GenerarReserva());
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btn_ConfirmarReserva_Click(object sender, EventArgs e)
        {
            Close();

            Thread thread = new Thread(OpenConfirmarReserva);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void OpenConfirmarReserva()
        {
            Application.Run(new ConfirmarReserva());
        }

    }
}
