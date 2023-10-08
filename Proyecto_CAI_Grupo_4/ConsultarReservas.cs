using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Models;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4
{
    public partial class ConsultarReservas : VistaBase
    {
        private List<Reserva> reservas = new List<Reserva>()
        {
            new Reserva()
            {
                Codigo = Guid.NewGuid(),
                Estado = ReservaEstadoEnum.pendienteDePago,
                DNI = "41753082",
                Precio = (decimal)100000.50,
                Fecha = DateTime.Now.AddDays(-7),
                FechaDesde = DateTime.Now.AddDays(21),
                FechaHasta = DateTime.Now.AddDays(14),
            },
            new Reserva()
            {
                Codigo = Guid.NewGuid(),
                Estado = ReservaEstadoEnum.pagada,
                DNI = "14975308",
                Precio = (decimal)50000.20,
                Fecha = DateTime.Now.AddDays(-14),
                FechaDesde = DateTime.Now.AddDays(14),
                FechaHasta = DateTime.Now.AddDays(7),
            },
            new Reserva()
            {
                Codigo = Guid.NewGuid(),
                Estado = ReservaEstadoEnum.confirmada,
                DNI = "29327456",
                Precio = (decimal)500000.95,
                Fecha = DateTime.Now.AddDays(-21),
                FechaDesde = DateTime.Now.AddDays(7),
                FechaHasta = DateTime.Now.AddDays(21),
            },
        };

        public ConsultarReservas() : base(tituloModulo: "Consulta de Reservas")
        {
            InitializeComponent();
        }

        private void ConsultarReservas_Load(object sender, EventArgs e)
        {
            AddReservasToListView(reservas);
        }

        private void buscarReserva_Click(object sender, EventArgs e)
        {
            var codigo = filtroCodigo.Text.Trim();

            var estado = filtroEstado.SelectedIndex;

            var dni = filtroNroDeDoc.Text.Trim();

            var filteredReservas = reservas
                .Where(x => (string.IsNullOrEmpty(codigo) || x.Codigo == Guid.Parse(codigo))
                            && (estado == -1 || (int)x.Estado == estado)
                            && (string.IsNullOrEmpty(dni) || x.DNI == dni));

            if (filteredReservas.Any())
            {
                reservasListView.Items.Clear();

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
                var row = new ListViewItem(item.Codigo.ToString());

                row.SubItems.Add(item.Estado.GetDescription());
                row.SubItems.Add(item.DNI);
                row.SubItems.Add(item.Precio.ToString());
                row.SubItems.Add(item.Fecha.ToFormDate());
                row.SubItems.Add(item.FechaDesde.ToFormDate());
                row.SubItems.Add(item.FechaHasta.ToFormDate());

                reservasListView.Items.Add(row);
            }
        }

        private void limpiarConsulta_Click(object sender, EventArgs e)
        {
            reservasListView.Items.Clear();

            filtroCodigo.Text = string.Empty;
            filtroEstado.SelectedIndex = -1;
            filtroNroDeDoc.Text = string.Empty;
        }
    }
}
