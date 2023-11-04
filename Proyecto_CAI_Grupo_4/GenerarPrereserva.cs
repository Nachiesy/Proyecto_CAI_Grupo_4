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
using Proyecto_CAI_Grupo_4.Enums;
using Proyecto_CAI_Grupo_4.Modelos;
using Proyecto_CAI_Grupo_4.Models;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarPrereserva : VistaBase
    {
        public GenerarPrereserva()
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

            var presupuestos = PresupuestosModel
                .GetPresupuestos()
                .Where(x => PrereservaModel.GetPrereservaByItinerario(x.IdItinerario).Count == 0)
                .AsQueryable();

            if (!string.IsNullOrEmpty(codigo))
            {
                if (!int.TryParse(codigo, out int presupuestoId))
                {
                    MessageBox.Show("El codigo de presupuesto debe ser numérico.");
                    return;
                }

                presupuestos = presupuestos.Where(x => x.IdItinerario == presupuestoId);
            }

            if (!string.IsNullOrEmpty(dni) && dni.EsDNI())
            {
                if (!dni.EsDNI())
                {
                    MessageBox.Show("Ingrese un DNI valido por favor.");
                    return;
                }

                presupuestos = presupuestos.Where(x => x.Cliente.DNI == dni);
            }

            AddReservasToListView(presupuestos.ToList());
        }
        private void AddReservasToListView(IEnumerable<Itinerario> list)
        {
            lv_Prereservas.Items.Clear();

            lv_Prereservas.Items.AddRange(list.Select(item => new ListViewItem(item.IdItinerario.ToString())
            {
                SubItems =
                {
                    PasajerosModel.GetTotalPasajerosByIdPresupuesto(item.IdItinerario).ToString(),
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
            DialogResult resultado = MessageBox.Show("¿Desea crear la prereserva?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                var itinerario = PresupuestosModel.GetPresupuestoById(int.Parse(item.SubItems[0].Text));

                var prereserva = PrereservaModel.GenerarNuevaPrereserva(
                    idItinerario: int.Parse(item.SubItems[0].Text),
                    /*ESTADO HARDCODEADO PORQUE MAGICAMENTE DE UNA U OTRA FORMA TIENEN QUE SER PAGADAS PARA PODER GENERAR RESERVA. EL LISTADO FILTRA PAGADAS.*/
                    estado: PrereservaEstadoEnum.Pagada, /* PrereservaEstadoEnum.PendienteDePago */
                    cliente: itinerario.Cliente);

                MessageBox.Show("Prereserva generada con Id: " + prereserva.Codigo);

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
