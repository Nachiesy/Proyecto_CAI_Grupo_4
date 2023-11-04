using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Models;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4
{
    public partial class ConsultarReservas : VistaBase
    {
        ConsultarReservasModel Model = new ConsultarReservasModel();

        public ConsultarReservas() : base(tituloModulo: "Consulta de Reservas")
        {
            InitializeComponent();
        }

        private void ConsultarReservas_Load(object sender, EventArgs e)
        {
            AddReservasToListView(Model.GetReservas());
            
            var estados = new List<string>()
            {
                "Todas"
            };

            estados.AddRange(
                Enum.GetValues(typeof(ReservaEstadoEnum))
                .Cast<ReservaEstadoEnum>()
                .Select(v => v.GetDescription())
                .Skip(1));

            filtroEstado.DataSource = estados;
        }

        private void buscarReserva_Click(object sender, EventArgs e)
        {
            var reservas = Model.GetReservas()
                .AsQueryable();

            var codigoInput = filtroCodigo.Text.Trim();

            var estado = filtroEstado.SelectedIndex;

            var dni = filtroNroDeDoc.Text.Trim();

            if (!string.IsNullOrEmpty(codigoInput))
            {
                if (!int.TryParse(codigoInput, out int reservaId))
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

            if (filtroEstado.SelectedIndex != 0)
            {
                reservas = reservas.Where(x => x.Estado == (ReservaEstadoEnum)estado);
            }

            if (reservas.Any())
            {
                AddReservasToListView(reservas);
            }
            else
            {
                MessageBox.Show("No hay reservas disponibles para los parámetros ingresados.", "Error",
                    MessageBoxButtons.OK);

            }
        }

        private void AddReservasToListView(IEnumerable<Reserva> list)
        {
            reservasListView.Items.Clear();

            reservasListView.Items.AddRange(list.Select(item => new ListViewItem(item.Codigo.ToString())
            {
                SubItems =
                {
                    item.Estado.GetDescription(),
                    item.Cliente.DNI,
                    Model.GetPresupuestoById(item.IdItinerario).PrecioTotal.ToString("C2") ?? "-",
                    item.FechaEstado.ToFormDate()
                }
            }).ToArray());
        }

        private void limpiarConsulta_Click(object sender, EventArgs e)
        {
            reservasListView.Items.Clear();

            filtroCodigo.Clear();
            filtroEstado.SelectedIndex = 0;
            filtroNroDeDoc.Clear();

            AddReservasToListView(Model.GetReservas());
        }
    }
}
