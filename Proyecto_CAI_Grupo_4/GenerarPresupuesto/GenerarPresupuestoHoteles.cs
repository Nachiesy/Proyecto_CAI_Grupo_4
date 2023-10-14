using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Managers;
using Proyecto_CAI_Grupo_4.Models.Productos;
using Proyecto_CAI_Grupo_4.Utils;
using System.Data;
using Proyecto_CAI_Grupo_4.Common.Views;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarPresupuestoHoteles : VistaBase
    {
        private readonly int codigoSubItemIndex = 1;

        public GenerarPresupuestoHoteles() : base(tituloModulo: "Generar Presupuesto > Hoteles")
        {
            InitializeComponent();
        }

        private void GenerarPresupuestoHoteles_Load(object sender, EventArgs e)
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

            AddProductosToListView(GenerarPresupuestosManager.hoteles.Where(x => x.Cantidad > 0));

            AddProductosSeleccionadosToListView(GenerarPresupuestosManager.hotelesElegidos);
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            var filterDto = new HotelesFilterDto()
            {
                PrecioDesde = txtBoxFiltroPrecioDesde.Text,
                PrecioHasta = txtBoxFiltroPrecioHasta.Text,
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

                var productos = GenerarPresupuestosManager.hoteles
                    .Where(x => x.Cantidad > 0
                                && (!filter.PrecioDesde.HasValue || x.Precio >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Precio <= filter.PrecioHasta)
                                && (!filter.FechaDesde.HasValue || x.FechaDesde == filter.FechaDesde)
                                && (!filter.FechaHasta.HasValue || x.FechaHasta == filter.FechaHasta)
                                && (string.IsNullOrEmpty(filter.Nombre) || x.Nombre == filter.Nombre)
                                && (!filter.Ciudad.HasValue || (int)x.Ciudad == filter.Ciudad)
                                && (!filter.TipoDeHabitacion.HasValue || (int)x.TipoDeHabitacion == filter.TipoDeHabitacion)
                                && (!filter.Calificacion.HasValue || (int)x.Calificacion == filter.Calificacion));

                listViewProductos.Items.Clear();

                AddProductosToListView(productos);

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

        private void AddProductosToListView(IEnumerable<Hoteles> listToAdd)
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

        private void AddProductosSeleccionadosToListView(IEnumerable<Hoteles> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Codigo);
                row.SubItems.Add(item.Nombre);
                row.SubItems.Add(item.Ciudad.GetDescription());
                row.SubItems.Add(item.Direccion);
                row.SubItems.Add(item.Calificacion.GetDescription());
                // row.SubItems.Add(item.Cantidad.ToString()); NO MOSTRAR LA CANTIDAD
                row.SubItems.Add(item.TipoDeHabitacion.GetDescription());
                row.SubItems.Add(item.Precio.ToFormDecimal());
                row.SubItems.Add(item.CantidadDePersonas.ToString());
                row.SubItems.Add(item.CantidadMaximaDeAdultos.ToString());
                row.SubItems.Add(item.CantidadMaximaDeMenores.ToString());
                row.SubItems.Add(item.CantidadMaximaDeInfantes.ToString());
                row.SubItems.Add(item.FechaDesde.ToFormDate());
                row.SubItems.Add(item.FechaHasta.ToFormDate());

                listViewProductosSeleccionados.Items.Add(row);
            }
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            if (listViewProductos.SelectedItems.Count > 0)
            {
                var productosToAdd = new List<Hoteles>();

                foreach (ListViewItem item in listViewProductos.SelectedItems)
                {
                    var id = Guid.Parse(item.Text);

                    var producto = GenerarPresupuestosManager.hoteles.Where(x => x.Id == id).SingleOrDefault();

                    var cantidad = IsProductInProductosSeleccionados(producto.Id);

                    if (producto.Cantidad > cantidad)
                    {
                        productosToAdd.Add(producto);
                    }
                }

                AddProductosSeleccionadosToListView(productosToAdd);
            }
            else
            {
                MessageBox.Show("Ningun hotel seleccionado para agregar al presupuesto.");
            }
        }

        private void btnRemoverProductos_Click(object sender, EventArgs e)
        {
            if (listViewProductosSeleccionados.SelectedItems.Count > 0)
            {
                foreach (ListViewItem row in listViewProductosSeleccionados.SelectedItems)
                {
                    listViewProductosSeleccionados.Items.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Ningun hotel seleccionado para remover del presupuesto.");
            }
        }

        private void btnConfirmarProductosSeleccionados_Click(object sender, EventArgs e)
        {
            GenerarPresupuestosManager.hotelesElegidos.Clear();

            foreach (ListViewItem item in listViewProductosSeleccionados.Items)
            {
                var id = Guid.Parse(item.Text);

                var producto = GenerarPresupuestosManager.hoteles.Where(x => x.Id == id).SingleOrDefault();

                GenerarPresupuestosManager.hotelesElegidos.Add(producto);
            }

            this.Close();

            Thread thread = new Thread(OpenMenuGenerarPresupuesto);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnVolverAlMenuGenerarPresupuestos_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(OpenMenuGenerarPresupuesto);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenMenuGenerarPresupuesto()
        {
            Application.Run(new GenerarPresupuestoMenu());
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            txtBoxFiltroPrecioDesde.Clear();
            txtBoxFiltroPrecioHasta.Clear();
            datePickerFilterFechaDesde.Value = DateTime.Now.Date;
            datePickerFilterFechaHasta.Value = DateTime.Now.AddDays(1).Date;
            textBoxNombre.Clear();
            comboBoxCiudad.SelectedIndex = -1;
            comboBoxTipoDeHabitacion.SelectedIndex = -1;
            comboBoxCalificacion.SelectedIndex = -1;

            listViewProductos.Items.Clear();

            AddProductosToListView(GenerarPresupuestosManager.hoteles);
        }

        private int IsProductInProductosSeleccionados(Guid id)
        {
            var selectedIDs = new List<Guid>();

            foreach (ListViewItem item in listViewProductosSeleccionados.Items)
            {
                var selectedID = Guid.Parse(item.Text);

                if (selectedID == id)
                {
                    selectedIDs.Add(selectedID);
                }
            }

            return selectedIDs.Count();
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

        private void listViewProductosSeleccionados_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Cancel = true;
                e.NewWidth = 0;
            }
        }
    }
}
