using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Managers;
using Proyecto_CAI_Grupo_4.Models.Productos;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarPresupuestoHoteles : Form
    {
        public GenerarPresupuestoHoteles()
        {
            InitializeComponent();
        }

        private void GenerarPresupuestoHoteles_Load(object sender, EventArgs e)
        {
            datePickerFechaSalida.Checked = false;
            datePickerFechaSalida.Value = DateTime.Now.Date;
            datePickerFechaLlegada.Checked = false;
            datePickerFechaLlegada.Value = DateTime.Now.AddDays(1).Date;

            AddProductosHotelesToListView(GenerarPresupuestosManager.productosHoteles, lstViewProductos);

            AddProductosHotelesToListView(GenerarPresupuestosManager.productosHotelesElegidos, lstViewProductosElegidos);
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            var filterDto = new ProductosAereosFilterDto()
            {
                PrecioDesde = txtBoxPrecioDesde.Text,
                PrecioHasta = txtBoxPrecioHasta.Text,
                FechaDeSalida = datePickerFechaSalida.Checked ? datePickerFechaSalida.Value : null,
                FechaDeLlegada = datePickerFechaLlegada.Checked ? datePickerFechaLlegada.Value : null,
            };

            var validacion = ValidacionDeFiltros(filterDto);

            if (!string.IsNullOrEmpty(validacion))
            {
                MessageBox.Show(validacion, "Error", MessageBoxButtons.OK);
            }
            else
            {
                var filter = new ProductosAereosFilter(filterDto);

                var productos = GenerarPresupuestosManager.productosHoteles
                    .Where(x => (!filter.PrecioDesde.HasValue || x.Precio >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Precio <= filter.PrecioHasta)
                                && (!filter.FechaDeSalida.HasValue || x.FechaDesde == filter.FechaDeSalida)
                                && (!filter.FechaDeLlegada.HasValue || x.FechaHasta == filter.FechaDeLlegada));

                lstViewProductos.Items.Clear();

                AddProductosHotelesToListView(productos, lstViewProductos);

                if (!productos.Any())
                {
                    MessageBox.Show("No hay Vuelos disponibles para los parámetros ingresados.", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private string ValidacionDeFiltros(ProductosAereosFilterDto presupuesto)
        {
            var messages = string.Empty;

            messages += ValidarPrecios(presupuesto);

            if (presupuesto.FechaDeSalida.HasValue && presupuesto.FechaDeLlegada.HasValue)
            {
                messages += ValidarFechas(presupuesto);
            }

            return messages;
        }

        private string ValidarPrecios(ProductosAereosFilterDto presupuesto)
        {
            var messages = string.Empty;

            var precioDesdeEmpty = string.IsNullOrEmpty(presupuesto.PrecioDesde);
            var precioHastaEmpty = string.IsNullOrEmpty(presupuesto.PrecioHasta);

            var isPrecioDesdeDecimal = decimal.TryParse(presupuesto.PrecioDesde, out decimal precioDesde);
            var isPrecioHastaDecimal = decimal.TryParse(presupuesto.PrecioHasta, out decimal precioHasta);

            if (!precioDesdeEmpty && !isPrecioDesdeDecimal)
            {
                messages += $"Precio Desde debe ser un numero decimal" + Environment.NewLine;
            }

            if (!precioHastaEmpty && !isPrecioHastaDecimal)
            {
                messages += $"Precio Hasta debe ser un numero decimal" + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(messages) && !precioDesdeEmpty && !precioHastaEmpty)
            {
                if (precioDesde >= precioHasta)
                {
                    messages += "El Precio Desde debe ser menor al Precio Hasta" + Environment.NewLine;
                }
            }

            return messages;
        }

        private string ValidarFechas(ProductosAereosFilterDto presupuesto)
        {
            var messages = string.Empty;

            if (presupuesto.FechaDeSalida.Value.Date < DateTime.Now.Date)
            {
                messages += "La Fecha Desde debe ser mayor a hoy" + Environment.NewLine;
            }
            else if (presupuesto.FechaDeSalida.Value.Date >= presupuesto.FechaDeLlegada.Value.Date)
            {
                messages += "La Fecha Desde debe ser menor a la Fecha Hasta" + Environment.NewLine;
            }

            return messages;
        }

        private void AddProductosHotelesToListView(IEnumerable<ProductosHoteles> listToAdd, ListView listView)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Ciudad);
                row.SubItems.Add(item.Habitacion);
                row.SubItems.Add(item.Precio.ToString());
                row.SubItems.Add(item.FechaDesde.ToFormDate());
                row.SubItems.Add(item.FechaHasta.ToFormDate());

                listView.Items.Add(row);
            }
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            if (lstViewProductos.SelectedItems.Count > 0)
            {
                var productosToAdd = new List<ProductosHoteles>();

                foreach (ListViewItem selectedItem in lstViewProductos.SelectedItems)
                {
                    var id = Guid.Parse(selectedItem.Text);

                    var producto = GenerarPresupuestosManager.productosHoteles.Where(x => x.Id == id).SingleOrDefault();

                    if (!GenerarPresupuestosManager.productosHotelesElegidos.Any(x => x.Id == producto.Id))
                    {
                        productosToAdd.Add(producto);
                    }
                }

                AddProductosHotelesToListView(productosToAdd, lstViewProductosElegidos);
            }
            else
            {
                MessageBox.Show("Ningun vuelo seleccionado para agregar al presupuesto.");
            }
        }

        private void btnRemoverProductos_Click(object sender, EventArgs e)
        {
            if (lstViewProductosElegidos.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in lstViewProductosElegidos.SelectedItems)
                {
                    lstViewProductosElegidos.Items.Remove(selectedItem);
                }
            }
            else
            {
                MessageBox.Show("Ningun vuelo seleccionado para remover del presupuesto.");
            }
        }

        private void btnFinalizarPresupuesto_Click(object sender, EventArgs e)
        {
            GenerarPresupuestosManager.productosHotelesElegidos.Clear();

            foreach (ListViewItem selectedItem in lstViewProductosElegidos.Items)
            {
                var id = Guid.Parse(selectedItem.Text);

                var producto = GenerarPresupuestosManager.productosHoteles.Where(x => x.Id == id).SingleOrDefault();

                GenerarPresupuestosManager.productosHotelesElegidos.Add(producto);
            }

            this.Close();

            Thread thread = new Thread(OpenMenuGenerarPresupuesto);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnVolverMenuGenerarPresupuestos_Click(object sender, EventArgs e)
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
            txtBoxPrecioDesde.Clear();
            txtBoxPrecioHasta.Clear();
            datePickerFechaSalida.Checked = false;
            datePickerFechaSalida.Value = DateTime.Now.Date;
            datePickerFechaLlegada.Checked = false;
            datePickerFechaLlegada.Value = DateTime.Now.AddDays(1).Date;

            btnBuscarProducto_Click(sender, e);
        }
    }
}
