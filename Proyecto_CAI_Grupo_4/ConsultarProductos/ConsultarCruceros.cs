using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Managers;
using Proyecto_CAI_Grupo_4.Models.Productos;
using Proyecto_CAI_Grupo_4.Utils;
using System.Data;
using Proyecto_CAI_Grupo_4.Common.Views;

namespace Proyecto_CAI_Grupo_4
{
    public partial class ConsultarCruceros : VistaBase
    {
        public ConsultarCruceros() : base(tituloModulo: "Consultar Productos > Cruceros")
        {
            InitializeComponent();
        }

        private void GenerarPresupuestoAereos_Load(object sender, EventArgs e)
        {
            datePickerFechaSalida.Value = DateTime.Now.Date;
            datePickerFechaLlegada.Value = DateTime.Now.AddDays(1).Date;

            foreach (CrucerosOrigenEnum value in Enum.GetValues(typeof(CrucerosOrigenEnum)))
            {
                comboBoxOrigen.Items.Add(value.GetDescription());
            }

            foreach (CrucerosDestinoEnum value in Enum.GetValues(typeof(CrucerosDestinoEnum)))
            {
                comboBoxDestino.Items.Add(value.GetDescription());
            }


            foreach (TipoDeCamaroteEnum value in Enum.GetValues(typeof(TipoDeCamaroteEnum)))
            {
                comboBoxTipoDeCamarote.Items.Add(value.GetDescription());
            }

            AddProductosToDataGridView(GenerarPresupuestosManager.cruceros);
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            var filterDto = new CrucerosFilterDto()
            {
                PrecioDesde = txtBoxPrecioDesde.Text,
                PrecioHasta = txtBoxPrecioHasta.Text,
                FechaDesde = datePickerFechaSalida.Enabled ? datePickerFechaSalida.Value : null,
                FechaHasta = datePickerFechaLlegada.Enabled ? datePickerFechaLlegada.Value : null,
                CiudadDePartida = comboBoxOrigen.SelectedIndex != -1 ? comboBoxOrigen.SelectedIndex : null,
                CiudadDeLlegada = comboBoxDestino.SelectedIndex != -1 ? comboBoxDestino.SelectedIndex : null,
                TipoDeCamarote = comboBoxTipoDeCamarote.SelectedIndex != -1 ? comboBoxTipoDeCamarote.SelectedIndex : null,
            };

            var validacion = ValidacionDeFiltros(filterDto);

            if (!string.IsNullOrEmpty(validacion))
            {
                MessageBox.Show(validacion, "Error", MessageBoxButtons.OK);
            }
            else
            {
                var filter = new CrucerosFilter(filterDto);

                var productos = GenerarPresupuestosManager.cruceros
                    .Where(x => (!filter.PrecioDesde.HasValue || x.Precio >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Precio <= filter.PrecioHasta)
                                && (!filter.FechaDesde.HasValue || x.FechaDesde == filter.FechaDesde)
                                && (!filter.FechaHasta.HasValue || x.FechaHasta == filter.FechaHasta)
                                && (!filter.CiudadDePartida.HasValue || (int)x.CiudadDePartida == filter.CiudadDePartida)
                                && (!filter.CiudadDeLlegada.HasValue || (int)x.CiudadDeLlegada == filter.CiudadDeLlegada)
                                && (!filter.TipoDeCamarote.HasValue || (int)x.TipoDeCamarote == filter.TipoDeCamarote));

                listViewProductos.Items.Clear();

                AddProductosToDataGridView(productos);

                if (!productos.Any())
                {
                    MessageBox.Show("No hay Cruceros disponibles para los parámetros ingresados.", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private string ValidacionDeFiltros(CrucerosFilterDto presupuesto)
        {
            var messages = string.Empty;

            messages += FiltrosManager.ValidarPrecios(presupuesto);

            messages += FiltrosManager.ValidarFechas(presupuesto);

            return messages;
        }

        private void AddProductosToDataGridView(IEnumerable<Cruceros> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Codigo);
                row.SubItems.Add(item.Nombre);
                row.SubItems.Add(item.CiudadDePartida.GetDescription());
                row.SubItems.Add(item.CiudadDeLlegada.GetDescription());
                row.SubItems.Add(item.Cantidad.ToString());
                row.SubItems.Add(item.TipoDeCamarote.GetDescription());
                row.SubItems.Add(item.Precio.ToFormDecimal());
                row.SubItems.Add(item.FechaDesde.ToFormDate());
                row.SubItems.Add(item.FechaHasta.ToFormDate());

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
            comboBoxTipoDeCamarote.SelectedIndex = -1;

            listViewProductos.Items.Clear();

            AddProductosToDataGridView(GenerarPresupuestosManager.cruceros);
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
    }
}
