using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Models;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4
{
    public partial class ConsultarReservas : VistaBase
    {
        ConsultarReservasModel Model;

        public ConsultarReservas() : base(tituloModulo: "Consulta de Reservas")
        {
            InitializeComponent();
        }

        private void ConsultarReservas_Load(object sender, EventArgs e)
        {
            Model = new ConsultarReservasModel();

            AddReservasToListView(Model.GetReservas());

            filtroEstado.DataSource = Model.GetListadoEstadosReservas();
        }

        private void buscarReserva_Click(object sender, EventArgs e)
        {

            var codigo = filtroCodigo.Text.Trim();
            var dni = filtroNroDeDoc.Text.Trim();
            var estado = filtroEstado.Text.Trim();

            var msg = Model.ValidarCamposBusqueda(codigo, dni);

            if (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            reservasListView.Items.Clear();

            AddReservasToListView(Model.GetReservasFiltradas(codigo, dni, estado));
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
