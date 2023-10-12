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

            AddProductosToDataGridView(GenerarPresupuestosManager.aereos);
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
                                && (!filter.Destino.HasValue || (int)x.Destino == filter.Destino));

                dataGridViewProductos.Rows.Clear();

                AddProductosToDataGridView(productos);

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

        private void AddProductosToDataGridView(IEnumerable<Aereos> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Id.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Codigo });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Nombre });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.PrecioAdultos.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.PrecioMenores.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Cantidad.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.FechaDeSalida.ToFormDate() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.FechaDeLlegada.ToFormDate() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Aerolinea.GetDescription() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Origen.GetDescription() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Destino.GetDescription() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.TipoDeClaseAerea.GetDescription() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.GetParadas() });

                dataGridViewProductos.Rows.Add(row);
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

            dataGridViewProductos.Rows.Clear();

            AddProductosToDataGridView(GenerarPresupuestosManager.aereos);
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
