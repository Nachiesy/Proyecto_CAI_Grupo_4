using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Managers;
using Proyecto_CAI_Grupo_4.Models.Productos;
using Proyecto_CAI_Grupo_4.Utils;
using System.Data;
using Proyecto_CAI_Grupo_4.Common.Views;

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

            AddProductosToListView(GenerarPresupuestosManager.hoteles, lstViewProductos);
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            var filterDto = new HotelesFilterDto()
            {
                PrecioDesde = txtBoxPrecioDesde.Text,
                PrecioHasta = txtBoxPrecioHasta.Text,
                FechaDesde = datePickerFilterFechaDesde.Enabled ? datePickerFilterFechaDesde.Value : null,
                FechaHasta = datePickerFilterFechaHasta.Enabled ? datePickerFilterFechaHasta.Value : null,
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

                var productos = GenerarPresupuestosManager.hoteles
                    .Where(x => (!filter.PrecioDesde.HasValue || x.Precio >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Precio <= filter.PrecioHasta)
                                && (!filter.FechaDesde.HasValue || x.FechaDesde == filter.FechaDesde)
                                && (!filter.FechaHasta.HasValue || x.FechaHasta == filter.FechaHasta)
                                && (!filter.Ciudad.HasValue || (int)x.Ciudad == filter.Ciudad)
                                && (!filter.TipoDeHabitacion.HasValue || (int)x.TipoDeHabitacion == filter.TipoDeHabitacion)
                                && (!filter.Calificacion.HasValue || (int)x.Calificacion == filter.Calificacion));

                lstViewProductos.Items.Clear();

                AddProductosToListView(productos, lstViewProductos);

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

        private void AddProductosToListView(IEnumerable<Hoteles> listToAdd, ListView listView)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Nombre);
                row.SubItems.Add(item.Ciudad.GetDescription());
                row.SubItems.Add(item.Precio.ToString());
                row.SubItems.Add(item.Cantidad.ToString());
                row.SubItems.Add(item.FechaDesde.ToFormDate());
                row.SubItems.Add(item.FechaHasta.ToFormDate());
                row.SubItems.Add(item.TipoDeHabitacion.GetDescription());
                row.SubItems.Add(item.Calificacion.GetDescription());

                listView.Items.Add(row);
            }
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            txtBoxPrecioDesde.Clear();
            txtBoxPrecioHasta.Clear();
            datePickerFilterFechaDesde.Value = DateTime.Now.Date;
            datePickerFilterFechaHasta.Value = DateTime.Now.AddDays(1).Date;
            comboBoxCiudad.SelectedIndex = -1;
            comboBoxTipoDeHabitacion.SelectedIndex = -1;
            comboBoxCalificacion.SelectedIndex = -1;

            lstViewProductos.Items.Clear();

            AddProductosToListView(GenerarPresupuestosManager.hoteles, lstViewProductos);
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
    }
}
