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
    public partial class IngresarPasajero : Form
    {
        public Pasajeros pasajero = new Pasajeros();
        public IngresarPasajero()
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
            this.Close();

            Thread thread = new Thread(ReturnGenerarReserva);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
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
            string nombre = nombrepasajerotxt.Text;
            string apellido = apellidopasajerotxt.Text;
            DateTime fechanachimiento = dtnacmiento.Value;
            string nacionalidad = nacpasajerocbx.Text;
            int tipodoc = cbxTipodoc.TabIndex;
            string documento = dnipasajerotxt.Text;
            DateTime fechaexpo = exppasajerodgv.Value;
            string paisemisor = paiscbx.Text;
            string email = emailpasajerotxt.Text;
            string telefono = telpasajerotxt.Text;



            
        }
        private void IngresarPasajero_Load_1(object sender, EventArgs e)
        {

        }
    }
}
