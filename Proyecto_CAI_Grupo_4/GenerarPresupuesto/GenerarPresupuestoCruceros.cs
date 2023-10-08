using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Managers;
using Proyecto_CAI_Grupo_4.Models.Productos;
using Proyecto_CAI_Grupo_4.Utils;
using System.Data;
using Proyecto_CAI_Grupo_4.Common.Views;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarPresupuestoCruceros : VistaBase
    {
        public GenerarPresupuestoCruceros() : base(tituloModulo: "Generar Presupuesto > Cruceros")
        {
            InitializeComponent();
        }

        private void GenerarPresupuestoCruceros_Load(object sender, EventArgs e)
        {
            datePickerFechaSalida.Checked = false;
            datePickerFechaSalida.Value = DateTime.Now.Date;
            datePickerFechaLlegada.Checked = false;
            datePickerFechaLlegada.Value = DateTime.Now.AddDays(1).Date;

            AddProductosToListView(GenerarPresupuestosManager.cruceros, lstViewProductos);

            AddProductosToListView(GenerarPresupuestosManager.crucerosElegidos, lstViewProductosElegidos);
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            var filterDto = new CrucerosFilterDto()
            {
                PrecioDesde = txtBoxPrecioDesde.Text,
                PrecioHasta = txtBoxPrecioHasta.Text,
                FechaDesde = datePickerFechaSalida.Checked ? datePickerFechaSalida.Value : null,
                FechaHasta = datePickerFechaLlegada.Checked ? datePickerFechaLlegada.Value : null,
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
                                && (!filter.FechaHasta.HasValue || x.FechaHasta == filter.FechaHasta));

                lstViewProductos.Items.Clear();

                AddProductosToListView(productos, lstViewProductos);

                if (!productos.Any())
                {
                    MessageBox.Show("No hay Cruceros disponibles para los parámetros ingresados.", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private string ValidacionDeFiltros(CrucerosFilterDto presupuesto)
        {
            var messages = string.Empty;

            messages += ValidarPrecios(presupuesto);

            if (presupuesto.FechaDesde.HasValue && presupuesto.FechaHasta.HasValue)
            {
                messages += ValidarFechas(presupuesto);
            }

            return messages;
        }

        private string ValidarPrecios(CrucerosFilterDto presupuesto)
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

        private string ValidarFechas(CrucerosFilterDto presupuesto)
        {
            var messages = string.Empty;

            if (presupuesto.FechaDesde.Value.Date < DateTime.Now.Date)
            {
                messages += "La Fecha Desde debe ser mayor a hoy" + Environment.NewLine;
            }
            else if (presupuesto.FechaDesde.Value.Date >= presupuesto.FechaHasta.Value.Date)
            {
                messages += "La Fecha Desde debe ser menor a la Fecha Hasta" + Environment.NewLine;
            }

            return messages;
        }

        private void AddProductosToListView(IEnumerable<Cruceros> listToAdd, ListView listView)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Nombre);
                row.SubItems.Add(item.CiudadDePartida);
                row.SubItems.Add(item.CiudadDeLlegada);
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
                var productosToAdd = new List<Cruceros>();

                foreach (ListViewItem selectedItem in lstViewProductos.SelectedItems)
                {
                    var id = Guid.Parse(selectedItem.Text);

                    var producto = GenerarPresupuestosManager.cruceros.Where(x => x.Id == id).SingleOrDefault();

                    if (!IsProductInSelectedListView(id))
                    {
                        productosToAdd.Add(producto);
                    }
                }

                AddProductosToListView(productosToAdd, lstViewProductosElegidos);
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
            GenerarPresupuestosManager.crucerosElegidos.Clear();

            foreach (ListViewItem selectedItem in lstViewProductosElegidos.Items)
            {
                var id = Guid.Parse(selectedItem.Text);

                var producto = GenerarPresupuestosManager.cruceros.Where(x => x.Id == id).SingleOrDefault();

                GenerarPresupuestosManager.crucerosElegidos.Add(producto);
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

        private bool IsProductInSelectedListView(Guid id)
        {
            var ids = new List<Guid>();

            foreach (ListViewItem selectedItem in lstViewProductosElegidos.Items)
            {
                var selectedId = Guid.Parse(selectedItem.Text);

                ids.Add(selectedId);
            }

            return ids.Any(x => x == id);
        }
    }
}
