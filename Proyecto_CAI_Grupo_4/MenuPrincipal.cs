﻿using System;
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

        /* <<<<<<< HEAD*/
        private void label1_Click(object sender, EventArgs e)
        {

            /*=======*/
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(OpenReservasForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenReservasForm()
        {
            Application.Run(new Reservas());
            /*>>>>>>> 0cf15ab1261db55f98947b8966023a59eed0f5c3*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(OpenPresupuestoForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenPresupuestoForm()
        {
            Application.Run(new BuscarPresupuestos());
        }
    }
}
