using Proyecto_CAI_Grupo_4.Models;
using Proyecto_CAI_Grupo_4.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_CAI_Grupo_4
{

    public partial class GenerarReserva : Form
    {

        public GenerarReserva()
        {
            InitializeComponent();
        }
        private void GenerarReservao_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)

        {
            this.Close();

            Thread thread = new Thread(OpenMenuPrincipal);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenMenuPrincipal()
        {
            Application.Run(new MenuPrincipal());
        }

        private void btnAddpasajero_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(AgregarPasajero);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void AgregarPasajero()
        {
            Application.Run(new IngresarPasajero());
        }
    }
}
