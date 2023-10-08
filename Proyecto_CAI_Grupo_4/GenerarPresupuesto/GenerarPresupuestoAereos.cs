using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Managers;
using Proyecto_CAI_Grupo_4.Models.Productos;
using Proyecto_CAI_Grupo_4.Utils;
using System.Data;
using Proyecto_CAI_Grupo_4.Common.Views;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarPresupuestoAereos : VistaBase
    {
        public GenerarPresupuestoAereos() : base(tituloModulo: "Generar Presupuesto > Aereos")
        {
            InitializeComponent();
        }

        private void GenerarPresupuestoAereos_Load(object sender, EventArgs e)
        {
            datePickerFechaSalida.Checked = false;
            datePickerFechaSalida.Value = DateTime.Now.Date;
            datePickerFechaLlegada.Checked = false;
            datePickerFechaLlegada.Value = DateTime.Now.AddDays(1).Date;

            AddProductosAereosToListView(GenerarPresupuestosManager.aereos, lstViewProductos);

            AddProductosAereosToListView(GenerarPresupuestosManager.aereosElegidos, lstViewProductosElegidos);
        }

        private void buscarProductosAereos_Click(object sender, EventArgs e)
        {
            var filterDto = new AereosFilterDto()
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
                var filter = new AereosFilter(filterDto);

                var productos = GenerarPresupuestosManager.aereos
                    .Where(x => (!filter.PrecioDesde.HasValue || x.Precio >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Precio <= filter.PrecioHasta)
                                && (!filter.FechaDesde.HasValue || x.FechaDeSalida == filter.FechaDesde)
                                && (!filter.FechaHasta.HasValue || x.FechaDeLlegada == filter.FechaHasta));

                lstViewProductos.Items.Clear();

                AddProductosAereosToListView(productos, lstViewProductos);

                if (!productos.Any())
                {
                    MessageBox.Show("No hay Vuelos disponibles para los parámetros ingresados.", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private string ValidacionDeFiltros(AereosFilterDto presupuesto)
        {
            var messages = string.Empty;

            messages += ValidarPrecios(presupuesto);

            if (presupuesto.FechaDesde.HasValue && presupuesto.FechaHasta.HasValue)
            {
                messages += ValidarFechas(presupuesto);
            }

            return messages;
        }

        private string ValidarPrecios(AereosFilterDto presupuesto)
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

        private string ValidarFechas(AereosFilterDto presupuesto)
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

        private void AddProductosAereosToListView(IEnumerable<Aereos> listToAdd, ListView listView)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Nombre);
                row.SubItems.Add(item.Origen);
                row.SubItems.Add(item.Destino);
                row.SubItems.Add(item.TipoDeClaseAerea.GetDescription());
                row.SubItems.Add(item.Precio.ToString());
                row.SubItems.Add(item.FechaDeSalida.ToFormDate());
                row.SubItems.Add(item.FechaDeLlegada.ToFormDate());

                listView.Items.Add(row);
            }
        }

        private void agregarProductosAereosElegidos_Click(object sender, EventArgs e)
        {
            if (lstViewProductos.SelectedItems.Count > 0)
            {
                var productosToAdd = new List<Aereos>();

                foreach (ListViewItem selectedItem in lstViewProductos.SelectedItems)
                {
                    var id = Guid.Parse(selectedItem.Text);

                    var producto = GenerarPresupuestosManager.aereos.Where(x => x.Id == id).SingleOrDefault();

                    if (!IsProductInSelectedListView(id))
                    {
                        productosToAdd.Add(producto);
                    }
                }

                AddProductosAereosToListView(productosToAdd, lstViewProductosElegidos);
            }
            else
            {
                MessageBox.Show("Ningun vuelo seleccionado para agregar al presupuesto.");
            }
        }

        private void removerProductosAereosDeLosElegidos_Click(object sender, EventArgs e)
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

        private void finalizarPresupuestoAereo_Click(object sender, EventArgs e)
        {
            GenerarPresupuestosManager.aereosElegidos.Clear();

            foreach (ListViewItem selectedItem in lstViewProductosElegidos.Items)
            {
                var id = Guid.Parse(selectedItem.Text);

                var producto = GenerarPresupuestosManager.aereos.Where(x => x.Id == id).SingleOrDefault();

                GenerarPresupuestosManager.aereosElegidos.Add(producto);
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

            buscarProductosAereos_Click(sender, e);
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
