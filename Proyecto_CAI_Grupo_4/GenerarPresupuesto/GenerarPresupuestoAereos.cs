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
        private readonly int codigoSubItemIndex = 1;

        public GenerarPresupuestoAereos() : base(tituloModulo: "Generar Presupuesto > Aéreos")
        {
            InitializeComponent();
        }

        private void GenerarPresupuestoAereos_Load(object sender, EventArgs e)
        {
            datePickerFilterFechaDesde.Value = DateTime.Now.Date;
            datePickerFilterFechaHasta.Value = DateTime.Now.AddDays(1).Date;

            foreach (AereosOrigenEnum value in Enum.GetValues(typeof(AereosOrigenEnum)))
            {
                comboBoxOrigen.Items.Add(value.GetDescription());
            }

            foreach (AereosDestinoEnum value in Enum.GetValues(typeof(AereosDestinoEnum)))
            {
                comboBoxDestino.Items.Add(value.GetDescription());
            }

            foreach (TipoDePasajeroEnum value in Enum.GetValues(typeof(TipoDePasajeroEnum)))
            {
                comboBoxTipoDePasajero.Items.Add(value.GetDescription());
            }

            foreach (AereosItinerarioEnum value in Enum.GetValues(typeof(AereosItinerarioEnum)))
            {
                comboBoxItinerario.Items.Add(value.GetDescription());
            }

            foreach (TipoDeClaseAereaEnum value in Enum.GetValues(typeof(TipoDeClaseAereaEnum)))
            {
                comboBoxClase.Items.Add(value.GetDescription());
            }

            AddProductosToListView(GenerarPresupuestosManager.aereos.Where(x => x.Cantidad > 0));

            AddProductosSeleccionadosToListView(GenerarPresupuestosManager.aereosElegidos);
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            var filterDto = new AereosFilterDto()
            {
                PrecioDesde = txtBoxFiltroPrecioDesde.Text,
                PrecioHasta = txtBoxFiltroPrecioHasta.Text,
                FechaDesde = datePickerFilterFechaDesde.Enabled ? datePickerFilterFechaDesde.Value : null,
                FechaHasta = datePickerFilterFechaHasta.Enabled ? datePickerFilterFechaHasta.Value : null,
                Origen = comboBoxOrigen.SelectedIndex != -1 ? comboBoxOrigen.SelectedIndex : null,
                Destino = comboBoxDestino.SelectedIndex != -1 ? comboBoxDestino.SelectedIndex : null,
                TipoDePasajero = comboBoxTipoDePasajero.SelectedIndex != -1 ? comboBoxTipoDePasajero.SelectedIndex : null,
                Itinerario = comboBoxItinerario.SelectedIndex != -1 ? comboBoxItinerario.SelectedIndex : null,
                Clase = comboBoxClase.SelectedIndex != -1 ? comboBoxClase.SelectedIndex : null,
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
                    .Where(x => x.Cantidad > 0
                                && (!filter.PrecioDesde.HasValue || x.Precio >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Precio <= filter.PrecioHasta)
                                && (!filter.FechaDesde.HasValue || x.FechaDeSalida == filter.FechaDesde)
                                && (!filter.FechaHasta.HasValue || x.FechaDeLlegada == filter.FechaHasta)
                                && (!filter.Origen.HasValue || (int)x.Origen == filter.Origen)
                                && (!filter.Destino.HasValue || (int)x.Destino == filter.Destino)
                                && (!filter.TipoDePasajero.HasValue || (int)x.TipoDePasajero == filter.TipoDePasajero)
                                && (!filter.Itinerario.HasValue || (int)x.Itinerario == filter.Itinerario)
                                && (!filter.Clase.HasValue || (int)x.Clase == filter.Clase));

                listViewProductos.Items.Clear();

                AddProductosToListView(productos);

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

        private void AddProductosToListView(IEnumerable<Aereos> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Codigo);
                row.SubItems.Add(item.Origen.GetDescription());
                row.SubItems.Add(item.Destino.GetDescription());
                row.SubItems.Add(item.Clase.GetDescription());
                row.SubItems.Add(item.Itinerario.GetDescription());
                row.SubItems.Add(item.Cantidad.ToString());
                row.SubItems.Add(item.TipoDePasajero.GetDescription());
                row.SubItems.Add(item.Precio.ToFormDecimal());
                row.SubItems.Add(item.Aerolinea.GetDescription());
                row.SubItems.Add(item.Paradas.Count().ToString());
                row.SubItems.Add(item.FechaDeSalida.ToFormVueloDate());
                row.SubItems.Add(item.FechaDeLlegada.ToFormVueloDate());

                listViewProductos.Items.Add(row);
            }
        }

        private void AddProductosSeleccionadosToListView(IEnumerable<Aereos> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Codigo);
                row.SubItems.Add(item.Origen.GetDescription());
                row.SubItems.Add(item.Destino.GetDescription());
                row.SubItems.Add(item.Clase.GetDescription());
                row.SubItems.Add(item.Itinerario.GetDescription());
                // row.SubItems.Add(item.Cantidad.ToString()); NO MOSTRAR CANTIDAD
                row.SubItems.Add(item.TipoDePasajero.GetDescription());
                row.SubItems.Add(item.Precio.ToFormDecimal());
                row.SubItems.Add(item.Aerolinea.GetDescription());
                row.SubItems.Add(item.Paradas.Count().ToString());
                row.SubItems.Add(item.FechaDeSalida.ToFormVueloDate());
                row.SubItems.Add(item.FechaDeLlegada.ToFormVueloDate());

                listViewProductosSeleccionados.Items.Add(row);
            }
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            if (listViewProductos.SelectedItems.Count > 0)
            {
                var productosToAdd = new List<Aereos>();

                foreach (ListViewItem item in listViewProductos.SelectedItems)
                {
                    var id = Guid.Parse(item.Text);

                    var producto = GenerarPresupuestosManager.aereos.Where(x => x.Id == id).SingleOrDefault();

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
                MessageBox.Show("Ningun vuelo seleccionado para agregar al presupuesto.");
            }
        }

        private void btnRemoverProductos_Click(object sender, EventArgs e)
        {
            if (listViewProductosSeleccionados.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewProductosSeleccionados.SelectedItems)
                {
                    listViewProductosSeleccionados.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Ningun vuelo seleccionado para remover del presupuesto.");
            }
        }

        private void btnConfirmarProductosSeleccionados_Click(object sender, EventArgs e)
        {
            if (listViewProductosSeleccionados.Items.Count > 0)
            {
                GenerarPresupuestosManager.aereosElegidos.Clear();

                foreach (ListViewItem item in listViewProductosSeleccionados.Items)
                {
                    var id = Guid.Parse(item.Text);

                    var producto = GenerarPresupuestosManager.aereos.Where(x => x.Id == id).SingleOrDefault();

                    GenerarPresupuestosManager.aereosElegidos.Add(producto);
                }

                this.Close();

                Thread thread = new Thread(OpenMenuGenerarPresupuesto);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("Debes seleccionar Vuelos para poder confirmar el presupuesto");
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
            comboBoxTipoDePasajero.SelectedIndex = -1;
            comboBoxItinerario.SelectedIndex = -1;
            comboBoxClase.SelectedIndex = -1;

            listViewProductos.Items.Clear();

            AddProductosToListView(GenerarPresupuestosManager.aereos);
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
