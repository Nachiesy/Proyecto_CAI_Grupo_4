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

    public partial class GenerarReserva : Form
    {

        public GenerarReserva()
        {
            InitializeComponent();
        }
        private void GenerarReservao_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)

        {
            this.Close();

            Thread thread = new Thread(OpenMenuPrincipal);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenMenuPrincipal()
        {
            Application.Run(new MenuPrincipal());
        }

        private void btnAddpasajero_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(AgregarPasajero);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void AgregarPasajero()
        {
            Application.Run(new IngresarPasajero());
        }

        private void listPresupuestos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private List<Reserva> reservas = new List<Reserva>()
        {
            new Reserva()
            {
                Codigo = "Cod-1",
                Estado = ReservaEstadoEnum.pendienteDePago,
                NumeroDeDocumento = "Nro.1",
                Precio = (decimal)100000.50,
                Fecha = DateTime.Now.AddDays(-7),
                FechaDesde = DateTime.Now.AddDays(21),
                FechaHasta = DateTime.Now.AddDays(14),
            },
            new Reserva()
            {
                Codigo = "Cod-2",
                Estado = ReservaEstadoEnum.pagada,
                NumeroDeDocumento = "Nro.2",
                Precio = (decimal)50000,
                Fecha = DateTime.Now.AddDays(-14),
                FechaDesde = DateTime.Now.AddDays(14),
                FechaHasta = DateTime.Now.AddDays(7),
            },
            new Reserva()
            {
                Codigo = "Cod-3",
                Estado = ReservaEstadoEnum.confirmada,
                NumeroDeDocumento = "Nro.3",
                Precio = (decimal)500000.95,
                Fecha = DateTime.Now.AddDays(-21),
                FechaDesde = DateTime.Now.AddDays(7),
                FechaHasta = DateTime.Now.AddDays(21),
            },
        };
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var nropresup = nroPresupuesto.Text.Trim();

            var tipodoc = cbxTipodoc.SelectedIndex;

            var nroDeDoc = txbDocumento.Text.Trim();

            var filteredReservas = reservas
                .Where(x => (string.IsNullOrEmpty(nropresup) || x.Codigo == nropresup)
                            && (tipodoc == -1 || (int)x.Estado == tipodoc)
                            && (string.IsNullOrEmpty(nroDeDoc) || x.NumeroDeDocumento == nroDeDoc));

            if (filteredReservas.Any())
            {
                listPresupuestos.Items.Clear();

                AddReservasToListView(filteredReservas);
            }
            else
            {
                MessageBox.Show("No hay reservas disponibles para los parámetros ingresados.", "Error", MessageBoxButtons.OK);
            }
        }
        private void AddReservasToListView(IEnumerable<Reserva> list)
        {
            foreach (var item in list)
            {
                var row = new ListViewItem(item.Codigo);

                row.SubItems.Add(item.Estado.GetDescription());
                row.SubItems.Add(item.NumeroDeDocumento);
                row.SubItems.Add(item.Precio.ToString());
                row.SubItems.Add(item.Fecha.ToFormDate());
                row.SubItems.Add(item.FechaDesde.ToFormDate());
                row.SubItems.Add(item.FechaHasta.ToFormDate());

                listPresupuestos.Items.Add(row);
            }
        }

    }
}
