using Proyecto_CAI_Grupo_4.Utils;
using System.Data;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Models;

namespace Proyecto_CAI_Grupo_4
{
    public partial class ConfirmarReserva : VistaBase
    {
        private ConfirmarReservaModel Model;

        public ConfirmarReserva()
        {
            InitializeComponent();
        }

        private void ConfirmarReserva_Load(object sender, EventArgs e)
        {
            Model = new ConfirmarReservaModel();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var codigo = nroPresupuestotxt.Text.Trim();
            var dni = txbDocumento.Text.Trim();

            var msg = Model.ValidarCamposBusqueda(codigo, dni);

            if (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lv_Reservas.Items.Clear();

            AddReservasToListView(Model.GetReservasPendientesDeConfirmacionFiltradas(codigo, dni));
        }

        private void AddReservasToListView(IEnumerable<ReservaEnt> list)
        {
            lv_Reservas.Items.Clear();

            lv_Reservas.Items.AddRange(list.Select(item => new ListViewItem(item.Codigo.ToString())
            {
                SubItems =
                {
                    item.Estado.GetDescription(),
                    item.Cliente.DNI,
                    Model.GetPresupuestoById(item.IdPresupuesto).PrecioTotal.ToString("C2") ?? "-",
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
                MessageBox.Show("La reserva ha sido confirmada");

                Model.ConfirmarReserva(int.Parse(item.Text));

                lv_Reservas.Items.Remove(item);
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
