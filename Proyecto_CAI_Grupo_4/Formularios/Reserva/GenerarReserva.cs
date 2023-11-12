using Proyecto_CAI_Grupo_4.Utils;
using System.Data;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Models;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarReserva : VistaBase
    {
        GenerarReservaModel Model = new GenerarReservaModel();

        public GenerarReserva()
        {
            InitializeComponent();
        }

        private void ConfirmarReserva_Load(object sender, EventArgs e)
        {

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

            if (!string.IsNullOrEmpty(dni))
            {
                AddPrereservasToListView(Model.GetPreReservasAbonadasByDNI(dni));
                return;
            }

            if (!string.IsNullOrEmpty(codigo))
            {
                AddPrereservasToListView(Model.GetPreReservasAbonadasById(codigo));
                return;
            }

            AddPrereservasToListView(Model.GetPreReservasAbonadas());
        }

        private void AddPrereservasToListView(IEnumerable<Itinerario> list)
        {
            lv_Prereservas.Items.Clear();

            lv_Prereservas.Items.AddRange(list.Select(item => new ListViewItem(item.IdItinerario.ToString())
            {
                SubItems =
                {
                    item.Estado,
                    Model.GetTotalDePasajeros(item.IdItinerario).ToString(),
                    item.Cliente.DNI,
                    (Model.GetPresupuestoById(item.IdItinerario)?.PrecioTotal ?? 0).ToString("C2"),
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
                MessageBox.Show("Seleccione una prereserva para reservar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem item = lv_Prereservas.SelectedItems[0];
            DialogResult resultado = MessageBox.Show("¿Desea crear la reserva?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                var prereserva = Model.GetPreReservaAbonadaById(int.Parse(item.SubItems[0].Text));

                var reserva = Model.GenerarReserva(prereserva);

                MessageBox.Show("Reservacion exitosa con Id: " + reserva.Codigo);

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
