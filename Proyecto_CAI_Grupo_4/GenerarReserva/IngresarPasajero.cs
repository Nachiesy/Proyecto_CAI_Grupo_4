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
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities;

namespace Proyecto_CAI_Grupo_4
{
    public partial class IngresarPasajero : VistaBase
    {
        public Pasajeros pasajero { get; private set; }
        public IngresarPasajero() : base(tituloModulo: "Ingresar Pasajero", deshabilitarBotones: true)
        {
            InitializeComponent();
        }

        private void cancelpasajbtn_Click(object sender, EventArgs e)
        {
            pasajero = null;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void confirmpasajerobtn_Click(object sender, EventArgs e)
        {

        }
        private void IngresarPasajero_Load(object sender, EventArgs e)
        {

        }
    }
}
