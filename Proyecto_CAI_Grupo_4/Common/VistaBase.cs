using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_CAI_Grupo_4.Common
{
    public partial class VistaBase : Form
    {
        public VistaBase(string tituloModulo)
        {
            InitializeComponent();
            lbl_TituloModulo.Text = tituloModulo;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void pnl_BarraFijaSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
