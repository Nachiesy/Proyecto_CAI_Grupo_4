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

namespace Proyecto_CAI_Grupo_4
{
    public partial class IngresarPasajero : VistaBase
    {
        public Pasajeros pasajero { get; private set; }
        public IngresarPasajero() : base(tituloModulo: "Ingresar Pasajero", deshabilitarBotones: true)
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void IngresarPasajero_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cancelpasajbtn_Click(object sender, EventArgs e)
        {
            pasajero = null;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ReturnGenerarReserva()
        {
            Application.Run(new GenerarReserva());
        }

        private void cbxTipodoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void confirmpasajerobtn_Click(object sender, EventArgs e)
        {

            pasajero = new Pasajeros();

            pasajero.Nombre = nombrepasajerotxt.Text;
            pasajero.Apellido = apellidopasajerotxt.Text;
            pasajero.Fecha_Nac = dtnacmiento.Value;
            pasajero.Nacionalidad = nacpasajerocbx.Text;
            pasajero.Tipo_Doc = cbxTipodoc.TabIndex;
            pasajero.Doc = dnipasajerotxt.Text;
            pasajero.Fecha_Exp = exppasajerodgv.Value;
            pasajero.Pais_emisor = paiscbx.Text;
            pasajero.Email = emailpasajerotxt.Text;
            pasajero.Tel_contacto = telpasajerotxt.Text;




            if (pasajero.CamposPasajeros().Count > 0)
            {
                string mensajeError = "Los siguientes campos no se han completado:\n" + string.Join(", ", pasajero.CamposPasajeros());
                MessageBox.Show(mensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pasajero.Edad = pasajero.Fecha_Nac.Calculoedad();
                pasajero.Tipo = pasajero.Edad.TipoPasajero();
                DialogResult = DialogResult.OK;
                Close();
            }




        }
        private void IngresarPasajero_Load_1(object sender, EventArgs e)
        {

        }
    }
}
