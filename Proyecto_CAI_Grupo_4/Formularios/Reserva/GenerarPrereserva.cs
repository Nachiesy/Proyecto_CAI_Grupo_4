using Proyecto_CAI_Grupo_4.Utils;
using System.Data;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Models;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarPrereserva : VistaBase
    {
        GenerarPrereservaModel Model;

        public GenerarPrereserva()
        {
            InitializeComponent();
        }

        private void ConfirmarReserva_Load(object sender, EventArgs e)
        {
            Model = new GenerarPrereservaModel();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var codigo = nroPresupuestotxt.Text.Trim();
            var dni = txbDocumento.Text.Trim();

            var msgError = Model.ValidarFiltros(codigo, dni);

            if(!string.IsNullOrEmpty(msgError))
            {
                MessageBox.Show(msgError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(dni))
            {
                AddReservasToListView(Model.GetPreReservablesByDNI(dni));
                return;
            }

            if (!string.IsNullOrEmpty(codigo))
            {
                AddReservasToListView(Model.GetPreReservablesById(codigo));
                return;
            }

            AddReservasToListView(Model.GetPreReservables());
        }

        private void AddReservasToListView(IEnumerable<Itinerario> list)
        {
            lv_Prereservas.Items.Clear();

            lv_Prereservas.Items.AddRange(list.Select(item => new ListViewItem(item.IdItinerario.ToString())
            {
                SubItems =
                {
                    Model.GetTotalPasajerosByIdPresupuesto(item.IdItinerario).ToString(),
                    item.Cliente.DNI,
                    item.PrecioTotal.ToString("C2"),
                }
            }).ToArray());
        }

        private void btn_LimpiarFiltros_Click(object sender, EventArgs e)
        {
            nroPresupuestotxt.Text = string.Empty;
            txbDocumento.Text = string.Empty;
            lv_Prereservas.Items.Clear();
        }

        private void btn_GenerarPreReserva_Click(object sender, EventArgs e)
        {
            if (lv_Prereservas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un presupuesto para pre reservar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem item = lv_Prereservas.SelectedItems[0];

            var idItinerario = int.Parse(item.SubItems[0].Text);

            var itinerario = Model.GetPresupuestoById(idItinerario);

            var msgError = Model.ValidarRequisitosPreReserva(idItinerario);

            if(!string.IsNullOrEmpty(msgError))
            {
                MessageBox.Show(msgError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Desea crear la prereserva?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                var prereserva = Model.GenerarPreReserva(itinerario);

                MessageBox.Show($"El itinerario #{prereserva.IdItinerario} ha sido pre-reservado.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lv_Prereservas.Items.Remove(item);
            }
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();

            var thread = new Thread(OpenMenuPrincipal);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
