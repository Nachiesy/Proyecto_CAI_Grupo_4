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

        private void btnEstadoDeReservas_Click(object sender, EventArgs e)
        {
            Close();

            Thread thread = new Thread(OpenEstadoDeReservas);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenEstadoDeReservas()
        {
            Application.Run(new ConsultarReservas());
        }

        private void btnGenerarReserva_Click(object sender, EventArgs e)
        {
            Close();

            Thread thread = new Thread(OpenEstadoDeReservas);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
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
    }
}
