using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Managers;
using Proyecto_CAI_Grupo_4.Models.Productos;
using Proyecto_CAI_Grupo_4.Utils;
using System.Data;
using Proyecto_CAI_Grupo_4.Common.Views;

namespace Proyecto_CAI_Grupo_4
{
    public partial class ConsultarAereos : VistaBase
    {
        public ConsultarAereos() : base(tituloModulo: "Consultar Productos > Aereos")
        {
            InitializeComponent();
        }

        private void GenerarPresupuestoAereos_Load(object sender, EventArgs e)
        {
            datePickerFechaSalida.Value = DateTime.Now.Date;
            datePickerFechaLlegada.Value = DateTime.Now.AddDays(1).Date;

            foreach (AereosOrigenEnum value in Enum.GetValues(typeof(AereosOrigenEnum)))
            {
                comboBoxOrigen.Items.Add(value.GetDescription());
            }

            foreach (AereosDestinoEnum value in Enum.GetValues(typeof(AereosDestinoEnum)))
            {
                comboBoxDestino.Items.Add(value.GetDescription());
            }

            foreach (TipoDePasajeroEnum value in Enum.GetValues(typeof(TipoDePasajeroEnum)))
            {
                comboBoxTipoDePasajero.Items.Add(value.GetDescription());
            }

            foreach (AereosItinerarioEnum value in Enum.GetValues(typeof(AereosItinerarioEnum)))
            {
                comboBoxItinerario.Items.Add(value.GetDescription());
            }

            foreach (TipoDeClaseAereaEnum value in Enum.GetValues(typeof(TipoDeClaseAereaEnum)))
            {
                comboBoxClase.Items.Add(value.GetDescription());
            }

            AddProductosToListView(GenerarPresupuestosManager.aereos);
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            var filterDto = new AereosFilterDto()
            {
                PrecioDesde = txtBoxPrecioDesde.Text,
                PrecioHasta = txtBoxPrecioHasta.Text,
                FechaDesde = datePickerFechaSalida.Enabled ? datePickerFechaSalida.Value : null,
                FechaHasta = datePickerFechaLlegada.Enabled ? datePickerFechaLlegada.Value : null,
                Origen = comboBoxOrigen.SelectedIndex != -1 ? comboBoxOrigen.SelectedIndex : null,
                Destino = comboBoxDestino.SelectedIndex != -1 ? comboBoxDestino.SelectedIndex : null,
                TipoDePasajero = comboBoxTipoDePasajero.SelectedIndex != -1 ? comboBoxTipoDePasajero.SelectedIndex : null,
                Itinerario = comboBoxItinerario.SelectedIndex != -1 ? comboBoxItinerario.SelectedIndex : null,
                Clase = comboBoxClase.SelectedIndex != -1 ? comboBoxClase.SelectedIndex : null,
            };

            var validacion = ValidacionDeFiltros(filterDto);

            if (!string.IsNullOrEmpty(validacion))
            {
                MessageBox.Show(validacion, "Error", MessageBoxButtons.OK);
            }
            else
            {
                var filter = new AereosFilter(filterDto);

                var productos = GenerarPresupuestosManager.aereos
                    .Where(x => (!filter.PrecioDesde.HasValue || x.Precio >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Precio <= filter.PrecioHasta)
                                && (!filter.FechaDesde.HasValue || x.FechaDeSalida == filter.FechaDesde)
                                && (!filter.FechaHasta.HasValue || x.FechaDeLlegada == filter.FechaHasta)
                                && (!filter.Origen.HasValue || (int)x.Origen == filter.Origen)
                                && (!filter.Destino.HasValue || (int)x.Destino == filter.Destino)
                                && (!filter.TipoDePasajero.HasValue || (int)x.TipoDePasajero == filter.TipoDePasajero)
                                && (!filter.Itinerario.HasValue || (int)x.Itinerario == filter.Itinerario)
                                && (!filter.Clase.HasValue || (int)x.Clase == filter.Clase));

                listViewProductos.Items.Clear();

                AddProductosToListView(productos);

                if (!productos.Any())
                {
                    MessageBox.Show("No hay Vuelos disponibles para los parámetros ingresados.", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private string ValidacionDeFiltros(AereosFilterDto presupuesto)
        {
            var messages = string.Empty;

            messages += FiltrosManager.ValidarPrecios(presupuesto);

            messages += FiltrosManager.ValidarFechas(presupuesto);

            return messages;
        }

        private void AddProductosToListView(IEnumerable<Aereos> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Codigo);
                row.SubItems.Add(item.Origen.GetDescription());
                row.SubItems.Add(item.Destino.GetDescription());
                row.SubItems.Add(item.Clase.GetDescription());
                row.SubItems.Add(item.Itinerario.GetDescription());
                row.SubItems.Add(item.Cantidad.ToString());
                row.SubItems.Add(item.TipoDePasajero.GetDescription());
                row.SubItems.Add(item.Precio.ToFormDecimal());
                row.SubItems.Add(item.Aerolinea.GetDescription());
                row.SubItems.Add(item.Paradas.Count().ToString());
                row.SubItems.Add(item.FechaDeSalida.ToFormVueloDate());
                row.SubItems.Add(item.FechaDeLlegada.ToFormVueloDate());

                listViewProductos.Items.Add(row);
            }
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            txtBoxPrecioDesde.Clear();
            txtBoxPrecioHasta.Clear();
            datePickerFechaSalida.Value = DateTime.Now.Date;
            datePickerFechaLlegada.Value = DateTime.Now.AddDays(1).Date;
            comboBoxOrigen.SelectedIndex = -1;
            comboBoxDestino.SelectedIndex = -1;
            comboBoxTipoDePasajero.SelectedIndex = -1;
            comboBoxItinerario.SelectedIndex = -1;
            comboBoxClase.SelectedIndex = -1;

            listViewProductos.Items.Clear();

            AddProductosToListView(GenerarPresupuestosManager.aereos);
        }

        private void btnVolverMenuGenerarPresupuestos_Click(object sender, EventArgs e)
        {
            Close();

            Thread thread = new Thread(OpenMenuConsultarProductos);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenMenuConsultarProductos()
        {
            Application.Run(new ConsultarProductosMenu());
        }

        private void btnDisableDatePickerFilterFechaDesde_Click(object sender, EventArgs e)
        {
            if (datePickerFechaSalida.Enabled)
            {
                datePickerFechaSalida.Enabled = false;
                btnDisableDatePickerFilterFechaDesde.Text = "Habilitar";
            }
            else
            {
                datePickerFechaSalida.Enabled = true;
                btnDisableDatePickerFilterFechaDesde.Text = "Deshabilitar";
            }
        }

        private void btnDisableDatePickerFilterFechaHasta_Click(object sender, EventArgs e)
        {
            if (datePickerFechaLlegada.Enabled)
            {
                datePickerFechaLlegada.Enabled = false;
                btnDisableDatePickerFilterFechaHasta.Text = "Habilitar";
            }
            else
            {
                datePickerFechaLlegada.Enabled = true;
                btnDisableDatePickerFilterFechaHasta.Text = "Deshabilitar";
            }
        }

        private void listViewProductos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Cancel = true;
                e.NewWidth = 0;
            }
        }
    }
}
