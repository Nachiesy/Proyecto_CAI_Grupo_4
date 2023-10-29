using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Enums;
using Proyecto_CAI_Grupo_4.Modelos;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4
{
    public partial class ConsultarReservas : VistaBase
    {
        private List<Reserva> reservas = ReservaModel.GetReservas();

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
            var codigoInput = filtroCodigo.Text.Trim();

            int.TryParse(codigoInput, out int codigo);

            var estado = filtroEstado.SelectedIndex;

            var dni = filtroNroDeDoc.Text.Trim();

            var filteredReservas = reservas
                .Where(x => (string.IsNullOrEmpty(codigoInput) || x.Codigo == codigo)
                            && (estado == -1 || (int)x.Estado == estado)
                            && (string.IsNullOrEmpty(dni) /*|| x.DNI == dni*/));

            //Todo: esta rota la busqueda x DNI...

            reservasListView.Items.Clear();

            if (filteredReservas.Any())
            {
                AddReservasToListView(filteredReservas);
            }
            else
            {
                MessageBox.Show("No hay reservas disponibles para los parámetros ingresados.", "Error",
                    MessageBoxButtons.OK);

            }
        }

    private void AddReservasToListView(IEnumerable<Reserva> list)
        {
            foreach (var item in list)
            {
                var row = new ListViewItem(item.Codigo.ToString());

                row.SubItems.Add(item.Estado.GetDescription());
                //row.SubItems.Add(item.DNI);
                //row.SubItems.Add(item.Precio.ToFormDecimal());
                //row.SubItems.Add(item.CantPasajeros.ToString());

                //Todo: Faltan esas 3 definiciones que no estan en la entidad reserva como tal...
                row.SubItems.Add("item.DNI");
                row.SubItems.Add("item.Precio.ToFormDecimal()");
                row.SubItems.Add("item.CantPasajeros.ToString()");
                row.SubItems.Add(item.FechaReserva.ToFormDate());

                reservasListView.Items.Add(row);
            }
        }

        private void limpiarConsulta_Click(object sender, EventArgs e)
        {
            reservasListView.Items.Clear();

            filtroCodigo.Clear();
            filtroEstado.SelectedIndex = -1;
            filtroNroDeDoc.Clear();

            AddReservasToListView(reservas);
        }
    }
}
