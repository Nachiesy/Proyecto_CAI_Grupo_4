﻿using Proyecto_CAI_Grupo_4.Utils;
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
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modelos;
using Proyecto_CAI_Grupo_4.Models;

namespace Proyecto_CAI_Grupo_4
{
    public partial class ConfirmarReserva : VistaBase
    {
        public ConfirmarReserva()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void OpenMenuPrincipal()
        {
            Application.Run(new MenuPrincipal());

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var codigo = nroPresupuestotxt.Text.Trim();
            var dni = txbDocumento.Text.Trim();

            var reservas = ReservaModel
                .GetReservasPendientesDeConfirmacion()
                .AsQueryable();

            if (!string.IsNullOrEmpty(codigo))
            {
                if (!int.TryParse(codigo, out int reservaId))
                {
                    MessageBox.Show("El codigo de reserva debe ser numérico.");
                    return;
                }

                reservas = reservas.Where(x => x.Codigo == reservaId);
            }

            if (!string.IsNullOrEmpty(dni) && dni.EsDNI())
            {
                if (!dni.EsDNI())
                {
                    MessageBox.Show("Ingrese un DNI valido por favor.");
                    return;
                }

                reservas = reservas.Where(x => x.Cliente.DNI == dni);
            }

            AddReservasToListView(reservas.ToList());
        }
        private void AddReservasToListView(IEnumerable<Reserva> list)
        {
            lv_Reservas.Items.Clear();

            lv_Reservas.Items.AddRange(list.Select(item => new ListViewItem(item.Codigo.ToString())
            {
                SubItems =
                {
                    item.Estado.GetDescription(),
                    item.Cliente.DNI,
                    PresupuestosModel.GetPresupuestoById(item.IdItinerario).PrecioTotal.ToString("C2") ?? "-",
                    item.FechaEstado.ToFormDate()
                }
            }).ToArray());
        }

        private void btn_LimpiarFiltros_Click(object sender, EventArgs e)
        {
            nroPresupuestotxt.Text = string.Empty;
            txbDocumento.Text = string.Empty;
            lv_Reservas.Items.Clear();
        }

        private void btn_ConfirmarReserva_Click(object sender, EventArgs e)
        {
            if (lv_Reservas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva para confirmarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem item = lv_Reservas.SelectedItems[0];
            DialogResult resultado = MessageBox.Show("¿Desea confirmar la reserva?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Reserva Confirmada");

                ReservaModel.ConfirmarReserva(int.Parse(item.Text));

                lv_Reservas.Items.Remove(item);
            }
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(OpenMenuPrincipal);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmarReserva_Load(object sender, EventArgs e)
        {

        }
    }
}