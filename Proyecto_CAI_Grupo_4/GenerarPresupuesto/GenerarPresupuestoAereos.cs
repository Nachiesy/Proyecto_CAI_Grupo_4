using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Managers;
using Proyecto_CAI_Grupo_4.Models.Productos;
using Proyecto_CAI_Grupo_4.Utils;
using System.Data;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarPresupuestoAereos : Form
    {
        public GenerarPresupuestoAereos()
        {
            InitializeComponent();
        }

        private void GenerarPresupuesto_Load(object sender, EventArgs e)
        {
            datePickerFechaSalida.Checked = false;
            datePickerFechaSalida.Value = DateTime.Now.Date;
            datePickerFechaLlegada.Checked = false;
            datePickerFechaLlegada.Value = DateTime.Now.AddDays(1).Date;

            AddPresupuestosToListView(GenerarPresupuestosManager.productosAereos, lstViewProductosAereos);

            AddPresupuestosToListView(GenerarPresupuestosManager.productosAereosElegidos, lstViewProductosAereosElegidos);
        }

        private void buscarPresupuesto_Click(object sender, EventArgs e)
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

                var productos = GenerarPresupuestosManager.productosAereos
                    .Where(x => (!filter.PrecioDesde.HasValue || x.Precio >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Precio <= filter.PrecioHasta)
                                && (!filter.FechaDeSalida.HasValue || x.FechaDeSalida == filter.FechaDeSalida)
                                && (!filter.FechaDeLlegada.HasValue || x.FechaDeLlegada == filter.FechaDeLlegada));

                lstViewProductosAereos.Items.Clear();

                AddPresupuestosToListView(productos, lstViewProductosAereos);

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

        private void AddPresupuestosToListView(IEnumerable<ProductosAereos> listToAdd, ListView listView)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Origen);
                row.SubItems.Add(item.Destino);
                row.SubItems.Add(item.TipoDeClaseAerea.GetDescription());
                row.SubItems.Add(item.Precio.ToString());
                row.SubItems.Add(item.FechaDeSalida.ToFormDate());
                row.SubItems.Add(item.FechaDeLlegada.ToFormDate());

                listView.Items.Add(row);
            }
        }

        private void agregarPresupuesto_Click(object sender, EventArgs e)
        {
            if (lstViewProductosAereos.SelectedItems.Count > 0)
            {
                var productosToAdd = new List<ProductosAereos>();

                foreach (ListViewItem selectedItem in lstViewProductosAereos.SelectedItems)
                {
                    var id = Guid.Parse(selectedItem.Text);

                    var producto = GenerarPresupuestosManager.productosAereos.Where(x => x.Id == id).SingleOrDefault();

                    if (!GenerarPresupuestosManager.productosAereosElegidos.Any(x => x.Id == producto.Id))
                    {
                        productosToAdd.Add(producto);
                    }
                }

                AddPresupuestosToListView(productosToAdd, lstViewProductosAereosElegidos);
            }
            else
            {
                MessageBox.Show("Ningun vuelo seleccionado para agregar al presupuesto.");
            }
        }

        private void removerPresupuesto_Click(object sender, EventArgs e)
        {
            if (lstViewProductosAereosElegidos.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in lstViewProductosAereosElegidos.SelectedItems)
                {
                    lstViewProductosAereosElegidos.Items.Remove(selectedItem);
                }
            }
            else
            {
                MessageBox.Show("Ningun vuelo seleccionado para remover del presupuesto.");
            }
        }

        private void finalizarPresupuesto_Click(object sender, EventArgs e)
        {
            GenerarPresupuestosManager.productosAereosElegidos.Clear();

            foreach (ListViewItem selectedItem in lstViewProductosAereosElegidos.Items)
            {
                var id = Guid.Parse(selectedItem.Text);

                var producto = GenerarPresupuestosManager.productosAereos.Where(x => x.Id == id).SingleOrDefault();

                GenerarPresupuestosManager.productosAereosElegidos.Add(producto);
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

            buscarPresupuesto_Click(sender, e);
        }
    }
}
