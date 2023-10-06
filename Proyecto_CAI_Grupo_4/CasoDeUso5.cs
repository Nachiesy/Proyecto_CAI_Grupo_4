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
            foreach (var reserva in reservas)
            {
                var row = new ListViewItem(reserva.Codigo);

                row.SubItems.Add(reserva.Estado.GetDescription());
                row.SubItems.Add(reserva.NumeroDeDocumento);
                row.SubItems.Add(reserva.Precio.ToString());
                row.SubItems.Add(reserva.Fecha.ToFormDate());
                row.SubItems.Add(reserva.FechaDesde.ToFormDate());
                row.SubItems.Add(reserva.FechaHasta.ToFormDate());

                reservasListView.Items.Add(row);
            }
        }
    }
}
