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
        public IngresarPasajero() : base(tituloModulo: "Ingresar Pasajero")
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

            List<string> camposVacios = new List<string>();



            if (string.IsNullOrWhiteSpace(nombrepasajerotxt.Text))
            {
                camposVacios.Add("Nombre");
            }
            else { pasajero.Nombre = nombrepasajerotxt.Text; }

            if (string.IsNullOrWhiteSpace(apellidopasajerotxt.Text))
            {
                camposVacios.Add("Apellido");
            }
            else { pasajero.Apellido = apellidopasajerotxt.Text; }

            if (dtnacmiento.Value<DateTime.Today)
            {
                camposVacios.Add("Fecha de Nacimiento debe ser inferio al día de hoy");
            }
            else { pasajero.Fecha_Nac = dtnacmiento.Value; }


            pasajero.Nacionalidad = nacpasajerocbx.Text;
            pasajero.Tipo_Doc = cbxTipodoc.TabIndex;
            pasajero.Doc = dnipasajerotxt.Text;
            pasajero.Fecha_Exp = exppasajerodgv.Value;
            pasajero.Pais_emisor = paiscbx.Text;
            pasajero.Email = emailpasajerotxt.Text;
            pasajero.Tel_contacto = telpasajerotxt.Text;




            if (camposVacios.Count > 0)
            {
                string mensajeError = "Los siguientes campos no se han completado:\n" + string.Join(", ", camposVacios);
                MessageBox.Show(mensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }




        }
        private void IngresarPasajero_Load_1(object sender, EventArgs e)
        {

        }
    }
}
