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

namespace Proyecto_CAI_Grupo_4
{
    public partial class ConfirmarReserva : VistaBase
    {
        Reserva reservaselct = new Reserva();
        public ConfirmarReserva()
        {
            InitializeComponent();
        }
        private List<Reserva> reservas = new List<Reserva>()
        {
            new Reserva()
            {
                Codigo = 110,
                Estado = ReservaEstadoEnum.pendconfirmacion,
                TipoDoc = 1,
                DNI = "39117825",
                CantPasajeros = 2,
                Precio = (decimal)100000.50,
                Fecha = DateTime.Now.AddDays(-7),
            },
            new Reserva()
            {
                Codigo = 111,
                Estado = ReservaEstadoEnum.pendconfirmacion,
                TipoDoc = 1,
                DNI = "27098332",
                CantPasajeros = 5,
                Precio = (decimal)50000,
                Fecha = DateTime.Now.AddDays(-14),
            },
            new Reserva()
            {
                Codigo = 112,
                Estado = ReservaEstadoEnum.pendconfirmacion,
                TipoDoc = 1,
                DNI = "30945665",
                CantPasajeros = 2,
                Precio = (decimal)500000.95,
                Fecha = DateTime.Now.AddDays(-21),
            },
                        new Reserva()
            {
                Codigo = 113,
                Estado = ReservaEstadoEnum.pendconfirmacion,
                TipoDoc = 1,
                DNI = "20945665",
                CantPasajeros = 2,
                Precio = (decimal)500000.95,
                Fecha = DateTime.Now.AddDays(-21),
            },
        };
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

            if (dni == "")
            {

                var filteredReservas = reservas
                .Where(x => (string.IsNullOrEmpty(codigo) || (int)x.Codigo == int.Parse(codigo))
                 && (string.IsNullOrEmpty(dni) || x.DNI == dni));
                if (filteredReservas.Any())
                {
                    listPresupuestos.Items.Clear();

                    AddReservasToListView(filteredReservas);
                }
                else
                {
                    listPresupuestos.Items.Clear();
                }
            }
            else if (!dni.EsDNI())
            {
                MessageBox.Show("Ingrese un DNI valido por favor.");
            }
            else
            {
                var filteredReservas = reservas
                .Where(x => (string.IsNullOrEmpty(codigo) || (int)x.Codigo == int.Parse(codigo))
                 && (string.IsNullOrEmpty(dni) || x.DNI == dni));
                if (filteredReservas.Any())
                {
                    listPresupuestos.Items.Clear();

                    AddReservasToListView(filteredReservas);
                }
                else
                {
                    listPresupuestos.Items.Clear();
                }
            };
        }
        private void AddReservasToListView(IEnumerable<Reserva> list)
        {
            foreach (var item in list)
            {
                var row = new ListViewItem(item.Codigo.ToString());
                row.SubItems.Add(item.DNI);
                row.SubItems.Add(item.CantPasajeros.ToString());
                row.SubItems.Add(item.Precio.ToString());
                row.SubItems.Add(item.Estado.GetDescription());
                row.SubItems.Add(item.Fecha.ToFormDate());

                listPresupuestos.Items.Add(row);
            }
        }

        private void btn_LimpiarFiltros_Click(object sender, EventArgs e)
        {
            nroPresupuestotxt.Text = string.Empty;
            txbDocumento.Text = string.Empty;
            listPresupuestos.Items.Clear();
        }

        private void btn_ConfirmarReserva_Click(object sender, EventArgs e)
        {


            if (listPresupuestos.SelectedItems.Count > 0)
            {
                ListViewItem item = listPresupuestos.SelectedItems[0];
                DialogResult resultado = MessageBox.Show("¿Desea confirmar la reserva?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    MessageBox.Show("Reserva Confirmada");
                    listPresupuestos.Items.Remove(item);

                }
            }
            else
            {
                MessageBox.Show("Seleccione una reserva");
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
