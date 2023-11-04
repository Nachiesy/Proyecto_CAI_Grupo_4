using Proyecto_CAI_Grupo_4.Utils;
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
    public partial class GenerarReserva : VistaBase
    {
        public GenerarReserva()
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

            var prereservas = PrereservaModel
                .GetPrereservaAbonadas()
                .Where(x => ReservaModel.GetReservasByItinerario(x.IdItinerario).Count == 0)
                .AsQueryable();

            if (!string.IsNullOrEmpty(codigo))
            {
                if (!int.TryParse(codigo, out int prereservaId))
                {
                    MessageBox.Show("El codigo de prereserva debe ser numérico.");
                    return;
                }

                prereservas = prereservas.Where(x => x.IdItinerario == prereservaId);
            }

            if (!string.IsNullOrEmpty(dni) && dni.EsDNI())
            {
                if (!dni.EsDNI())
                {
                    MessageBox.Show("Ingrese un DNI valido por favor.");
                    return;
                }

                prereservas = prereservas.Where(x => x.Cliente.DNI == dni);
            }

            AddPrereservasToListView(prereservas.ToList());
        }
        private void AddPrereservasToListView(IEnumerable<Prereserva> list)
        {
            lv_Prereservas.Items.Clear();

            lv_Prereservas.Items.AddRange(list.Select(item => new ListViewItem(item.IdItinerario.ToString())
            {
                SubItems =
                {
                    PasajerosModel.GetTotalPasajerosByIdPresupuesto(item.IdItinerario).ToString(),
                    item.Cliente.DNI,
                    (PresupuestosModel.GetPresupuestoById(item.IdItinerario)?.PrecioTotal ?? 0).ToString("C2"),
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
                var prereserva = PrereservaModel.GetPrereservaById(int.Parse(item.SubItems[0].Text));

                var reserva = ReservaModel.GenerarNuevaReserva(
                    idItinerario: int.Parse(item.SubItems[0].Text),
                    estado: ReservaEstadoEnum.PendienteDeConfirmacion,
                    cliente: prereserva.Cliente);

                MessageBox.Show("Reserva generada con Id: " + reserva.Codigo);

                lv_Prereservas.Items.Remove(item);
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
