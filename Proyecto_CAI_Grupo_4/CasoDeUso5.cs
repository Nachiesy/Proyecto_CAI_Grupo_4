namespace Proyecto_CAI_Grupo_4
{
    public partial class CasoDeUso5 : Form
    {
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

        public CasoDeUso5()
        {
            InitializeComponent();
        }

        private void CasoDeUso5_Load(object sender, EventArgs e)
        {
            AddReservasToListView(reservas);
        }

        private void buscarReserva_Click(object sender, EventArgs e)
        {
            var codigo = filtroCodigo.Text.Trim();

            var estado = filtroEstado.SelectedIndex;

            var nroDeDoc = filtroNroDeDoc.Text.Trim();

            var filterReservas = reservas
                .Where(x => (string.IsNullOrEmpty(codigo) || x.Codigo == codigo)
                            && (estado == -1 || (int)x.Estado == estado)
                            && (string.IsNullOrEmpty(nroDeDoc) || x.NumeroDeDocumento == nroDeDoc));

            reservasListView.Items.Clear();

            AddReservasToListView(filterReservas);
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

                reservasListView.Items.Add(row);
            }
        }
    }
}
