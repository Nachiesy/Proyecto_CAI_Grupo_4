﻿using Proyecto_CAI_Grupo_4.Utils;
using System.Data;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Models;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarReserva : VistaBase
    {
        GenerarReservaModel Model;

        public GenerarReserva()
        {
            InitializeComponent();
        }

        private void ConfirmarReserva_Load(object sender, EventArgs e)
        {
            Model = new GenerarReservaModel();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var codigo = nroPresupuestotxt.Text.Trim();
            var dni = txbDocumento.Text.Trim();

            var msgError = Model.ValidarFiltros(codigo, dni);

            if (!string.IsNullOrEmpty(msgError))
            {
                MessageBox.Show(msgError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddPrereservasToListView(Model.GetPreReservasAbonadasFiltradas(codigo, dni));
        }

        private void AddPrereservasToListView(IEnumerable<PresupuestoEnt> list)
        {
            lv_Prereservas.Items.Clear();

            lv_Prereservas.Items.AddRange(list.Select(item => new ListViewItem(item.IdPresupuesto.ToString())
            {
                SubItems =
                {
                    item.Estado,
                    Model.GetTotalDePasajeros(item.IdPresupuesto).ToString(),
                    item.Cliente.DNI,
                    (Model.GetPresupuestoById(item.IdPresupuesto)?.PrecioTotal ?? 0).ToString("C2"),
                    item.FechaEstado.ToFormDate()
                }
            }).ToArray());
        }

        private void btn_LimpiarFiltros_Click(object sender, EventArgs e)
        {
            nroPresupuestotxt.Text = string.Empty;
            txbDocumento.Text = string.Empty;
            lv_Prereservas.Items.Clear();
        }

        private void btn_GenerarReserva_Click(object sender, EventArgs e)
        {
            if (lv_Prereservas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Deber seleccionar una Pre-reserva para poder generar la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem item = lv_Prereservas.SelectedItems[0];
            DialogResult resultado = MessageBox.Show("¿Desea generar la reserva?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                var prereserva = Model.GetPreReservaAbonadaById(int.Parse(item.SubItems[0].Text));

                var reserva = Model.GenerarReserva(prereserva);

                MessageBox.Show("La reserva ha sigo generada exitosamente. El código de la misma es: " + reserva.Codigo);

                lv_Prereservas.Items.Remove(item);
            }
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Close();

            var thread = new Thread(OpenMenuPrincipal);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
