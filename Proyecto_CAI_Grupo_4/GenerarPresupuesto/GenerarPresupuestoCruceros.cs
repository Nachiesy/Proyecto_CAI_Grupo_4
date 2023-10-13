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
        private readonly int codigoSubItemIndex = 1;

        public GenerarPresupuestoCruceros() : base(tituloModulo: "Generar Presupuesto > Cruceros")
        {
            InitializeComponent();
        }

        private void GenerarPresupuestoCruceros_Load(object sender, EventArgs e)
        {
            datePickerFilterFechaDesde.Value = DateTime.Now.Date;
            datePickerFilterFechaHasta.Value = DateTime.Now.AddDays(1).Date;

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

            AddProductosToListView(GenerarPresupuestosManager.cruceros.Where(x => x.Cantidad > 0));

            AddProductosSeleccionadosToListView(GenerarPresupuestosManager.crucerosElegidos);
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            var filterDto = new CrucerosFilterDto()
            {
                PrecioDesde = txtBoxFiltroPrecioDesde.Text,
                PrecioHasta = txtBoxFiltroPrecioHasta.Text,
                FechaDesde = datePickerFilterFechaDesde.Enabled ? datePickerFilterFechaDesde.Value : null,
                FechaHasta = datePickerFilterFechaHasta.Enabled ? datePickerFilterFechaHasta.Value : null,
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
                    .Where(x => x.Cantidad > 0
                                && (!filter.PrecioDesde.HasValue || x.Precio >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Precio <= filter.PrecioHasta)
                                && (!filter.FechaDesde.HasValue || x.FechaDesde == filter.FechaDesde)
                                && (!filter.FechaHasta.HasValue || x.FechaHasta == filter.FechaHasta)
                                && (!filter.CiudadDePartida.HasValue || (int)x.CiudadDePartida == filter.CiudadDePartida)
                                && (!filter.CiudadDeLlegada.HasValue || (int)x.CiudadDeLlegada == filter.CiudadDeLlegada)
                                && (!filter.TipoDeCamarote.HasValue || (int)x.TipoDeCamarote == filter.TipoDeCamarote));

                listViewProductos.Items.Clear();

                AddProductosToListView(productos);

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

        private void AddProductosToListView(IEnumerable<Cruceros> listToAdd)
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

        private void AddProductosSeleccionadosToListView(IEnumerable<Cruceros> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Codigo);
                row.SubItems.Add(item.Nombre);
                row.SubItems.Add(item.CiudadDePartida.GetDescription());
                row.SubItems.Add(item.CiudadDeLlegada.GetDescription());
                // row.SubItems.Add(item.Cantidad.ToString());
                row.SubItems.Add(item.TipoDeCamarote.GetDescription());
                row.SubItems.Add(item.Precio.ToFormDecimal());
                row.SubItems.Add(item.FechaDesde.ToFormDate());
                row.SubItems.Add(item.FechaHasta.ToFormDate());

                listViewProductosSeleccionados.Items.Add(row);
            }
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            if (listViewProductos.SelectedItems.Count > 0)
            {
                var productosToAdd = new List<Cruceros>();

                foreach (ListViewItem item in listViewProductos.SelectedItems)
                {
                    var id = Guid.Parse(item.Text);

                    var producto = GenerarPresupuestosManager.cruceros.Where(x => x.Id == id).SingleOrDefault();

                    var cantidad = IsProductInProductosSeleccionados(producto.Codigo);

                    if (producto.Cantidad > cantidad)
                    {
                        productosToAdd.Add(producto);
                    }
                }

                AddProductosSeleccionadosToListView(productosToAdd);
            }
            else
            {
                MessageBox.Show("Ningun crucero seleccionado para agregar al presupuesto.");
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
                MessageBox.Show("Ningun crucero seleccionado para remover del presupuesto.");
            }
        }

        private void btnConfirmarProductosSeleccionados_Click(object sender, EventArgs e)
        {
            if (listViewProductosSeleccionados.Items.Count > 0)
            {
                GenerarPresupuestosManager.crucerosElegidos.Clear();

                foreach (ListViewItem item in listViewProductosSeleccionados.Items)
                {
                    var id = Guid.Parse(item.Text);

                    var producto = GenerarPresupuestosManager.cruceros.Where(x => x.Id == id).SingleOrDefault();

                    GenerarPresupuestosManager.crucerosElegidos.Add(producto);
                }

                this.Close();

                Thread thread = new Thread(OpenMenuGenerarPresupuesto);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("Debes seleccionar Cruceros para poder confirmar el presupuesto");
            }
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
            comboBoxOrigen.SelectedIndex = -1;
            comboBoxDestino.SelectedIndex = -1;
            comboBoxTipoDeCamarote.SelectedIndex = -1;

            listViewProductos.Items.Clear();

            AddProductosToListView(GenerarPresupuestosManager.cruceros);
        }

        private int IsProductInProductosSeleccionados(string codigo)
        {
            var codigos = new List<string>();

            foreach (ListViewItem item in listViewProductosSeleccionados.Items)
            {
                var selectedCodigo = item.SubItems[codigoSubItemIndex].Text;

                if (selectedCodigo == codigo)
                {
                    codigos.Add(selectedCodigo);
                }
            }

            return codigos.Count();
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
