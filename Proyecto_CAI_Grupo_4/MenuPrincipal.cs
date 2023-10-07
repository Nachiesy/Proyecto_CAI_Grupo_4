using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_CAI_Grupo_4
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(OpenCasoDeUso5Form);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenCasoDeUso5Form()
        {
            Application.Run(new CasoDeUso5());
        }
    }
}
