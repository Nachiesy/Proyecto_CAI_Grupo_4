using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Managers;
using Proyecto_CAI_Grupo_4.Utils;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities.Productos;
using Proyecto_CAI_Grupo_4.Models.Productos;

namespace Proyecto_CAI_Grupo_4
{
    public partial class ConsultarHoteles : VistaBase
    {
        public ConsultarHoteles() : base(tituloModulo: "Consultar Productos > Hoteles")
        {
            InitializeComponent();
        }

        private void GenerarPresupuestoAereos_Load(object sender, EventArgs e)
        {
            datePickerFilterFechaDesde.Value = DateTime.Now.Date;
            datePickerFilterFechaHasta.Value = DateTime.Now.AddDays(1).Date;

            foreach (HotelesCiudadEnum value in Enum.GetValues(typeof(HotelesCiudadEnum)))
            {
                comboBoxCiudad.Items.Add(value.GetDescription());
            }

            foreach (TipoDeHabitacionEnum value in Enum.GetValues(typeof(TipoDeHabitacionEnum)))
            {
                comboBoxTipoDeHabitacion.Items.Add(value.GetDescription());
            }

            foreach (HotelesCalificacionEnum value in Enum.GetValues(typeof(HotelesCalificacionEnum)))
            {
                comboBoxCalificacion.Items.Add(value.GetDescription());
            }

            AddProductosToDataGridView(HotelesModel.GetHoteles());
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            var filterDto = new HotelesFilterDto()
            {
                PrecioDesde = txtBoxPrecioDesde.Text,
                PrecioHasta = txtBoxPrecioHasta.Text,
                FechaDesde = datePickerFilterFechaDesde.Enabled ? datePickerFilterFechaDesde.Value : null,
                FechaHasta = datePickerFilterFechaHasta.Enabled ? datePickerFilterFechaHasta.Value : null,
                Nombre = textBoxNombre.Text,
                Ciudad = comboBoxCiudad.SelectedIndex != -1 ? comboBoxCiudad.SelectedIndex : null,
                TipoDeHabitacion = comboBoxTipoDeHabitacion.SelectedIndex != -1 ? comboBoxTipoDeHabitacion.SelectedIndex : null,
                Calificacion = comboBoxCalificacion.SelectedIndex != -1 ? comboBoxCalificacion.SelectedIndex : null,
            };

            var validacion = ValidacionDeFiltros(filterDto);

            if (!string.IsNullOrEmpty(validacion))
            {
                MessageBox.Show(validacion, "Error", MessageBoxButtons.OK);
            }
            else
            {
                var filter = new HotelesFilter(filterDto);

                var productos = HotelesModel.GetHoteles(filter);

                listViewProductos.Items.Clear();

                AddProductosToDataGridView(productos);

                if (!productos.Any())
                {
                    MessageBox.Show("No hay Hoteles disponibles para los parámetros ingresados.", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private string ValidacionDeFiltros(HotelesFilterDto presupuesto)
        {
            var messages = string.Empty;

            messages += FiltrosManager.ValidarPrecios(presupuesto);

            messages += FiltrosManager.ValidarFechas(presupuesto);

            return messages;
        }

        private void AddProductosToDataGridView(IEnumerable<Hoteles> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Codigo);
                row.SubItems.Add(item.Nombre);
                row.SubItems.Add(item.Ciudad.GetDescription());
                row.SubItems.Add(item.Direccion);
                row.SubItems.Add(item.Calificacion.GetDescription());
                row.SubItems.Add(item.Cantidad.ToString());
                row.SubItems.Add(item.TipoDeHabitacion.GetDescription());
                row.SubItems.Add(item.Precio.ToFormDecimal());
                row.SubItems.Add(item.CantidadDePersonas.ToString());
                row.SubItems.Add(item.CantidadMaximaDeAdultos.ToString());
                row.SubItems.Add(item.CantidadMaximaDeMenores.ToString());
                row.SubItems.Add(item.CantidadMaximaDeInfantes.ToString());
                row.SubItems.Add(item.FechaDesde.ToFormDate());
                row.SubItems.Add(item.FechaHasta.ToFormDate());

                listViewProductos.Items.Add(row);
            }
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            txtBoxPrecioDesde.Clear();
            txtBoxPrecioHasta.Clear();
            datePickerFilterFechaDesde.Value = DateTime.Now.Date;
            datePickerFilterFechaHasta.Value = DateTime.Now.AddDays(1).Date;
            textBoxNombre.Clear();
            comboBoxCiudad.SelectedIndex = -1;
            comboBoxTipoDeHabitacion.SelectedIndex = -1;
            comboBoxCalificacion.SelectedIndex = -1;

            listViewProductos.Items.Clear();

            AddProductosToDataGridView(HotelesModel.GetHoteles());
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
            if (datePickerFilterFechaDesde.Enabled)
            {
                datePickerFilterFechaDesde.Enabled = false;
                btnDisableDatePickerFilterFechaDesde.Text = "Habilitar";
            }
            else
            {
                datePickerFilterFechaDesde.Enabled = true;
                btnDisableDatePickerFilterFechaDesde.Text = "Deshabilitar";
            }
        }

        private void btnDisableDatePickerFilterFechaHasta_Click(object sender, EventArgs e)
        {
            if (datePickerFilterFechaHasta.Enabled)
            {
                datePickerFilterFechaHasta.Enabled = false;
                btnDisableDatePickerFilterFechaHasta.Text = "Habilitar";
            }
            else
            {
                datePickerFilterFechaHasta.Enabled = true;
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
