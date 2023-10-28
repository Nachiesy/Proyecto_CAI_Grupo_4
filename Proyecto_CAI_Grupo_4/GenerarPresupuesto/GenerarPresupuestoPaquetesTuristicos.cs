using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Managers;
using Proyecto_CAI_Grupo_4.Utils;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities.Productos;
using Proyecto_CAI_Grupo_4.Models.Productos;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarPresupuestoPaquetesTuristicos : VistaBase
    {
        public GenerarPresupuestoPaquetesTuristicos() : base(tituloModulo: "Generar Presupuesto > Paquetes Turísticos")
        {
            InitializeComponent();
        }

        private void GenerarPresupuestoPaquetesTuristicos_Load(object sender, EventArgs e)
        {
            datePickerFilterFechaDesde.Value = DateTime.Now.Date;
            datePickerFilterFechaHasta.Value = DateTime.Now.AddDays(1).Date;

            foreach (PaquetesTuristicosOrigenEnum value in Enum.GetValues(typeof(PaquetesTuristicosOrigenEnum)))
            {
                comboBoxOrigen.Items.Add(value.GetDescription());
            }

            foreach (PaquetesTuristicosDestinoEnum value in Enum.GetValues(typeof(PaquetesTuristicosDestinoEnum)))
            {
                comboBoxDestino.Items.Add(value.GetDescription());
            }

            AddProductosToListView(PaquetesTuristicosModel.GetPaquetesTuristicos(new PaquetesTuristicosFilter()
            {
                CantidadMin = 1,
            }));

            AddProductosSeleccionadosToListView(PaquetesTuristicosModel.GetPaquetesTuristicosElegidos());
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            var filterDto = new PaquetesTuristicosFilterDto()
            {
                CantidadMin = 1,
                PrecioDesde = txtBoxFiltroPrecioDesde.Text,
                PrecioHasta = txtBoxFiltroPrecioHasta.Text,
                FechaDesde = datePickerFilterFechaDesde.Enabled ? datePickerFilterFechaDesde.Value : null,
                FechaHasta = datePickerFilterFechaHasta.Enabled ? datePickerFilterFechaHasta.Value : null,
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
                var filter = new PaquetesTuristicosFilter(filterDto);

                var productos = PaquetesTuristicosModel.GetPaquetesTuristicos(filter);

                listViewProductos.Items.Clear();

                AddProductosToListView(productos);

                if (!productos.Any())
                {
                    MessageBox.Show("No hay Paquetes disponibles para los parámetros ingresados.", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private string ValidacionDeFiltros(PaquetesTuristicosFilterDto presupuesto)
        {
            var messages = string.Empty;

            messages += FiltrosManager.ValidarPrecios(presupuesto);

            messages += FiltrosManager.ValidarFechas(presupuesto);

            return messages;
        }

        private void AddProductosToListView(IEnumerable<PaquetesTuristicos> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Codigo);
                row.SubItems.Add(item.Nombre);
                row.SubItems.Add(item.Origen.GetDescription());
                row.SubItems.Add(item.Destino.GetDescription());
                row.SubItems.Add(item.Cantidad.ToString());
                row.SubItems.Add(item.Precio.ToFormDecimal());
                row.SubItems.Add(item.CapacidadMaximaAdultos.ToString());
                row.SubItems.Add(item.CapacidadMaximaMenores.ToString());
                row.SubItems.Add(item.FechaDesde.ToFormDate());
                row.SubItems.Add(item.FechaHasta.ToFormDate());

                listViewProductos.Items.Add(row);
            }
        }

        private void AddProductosSeleccionadosToListView(IEnumerable<PaquetesTuristicos> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Codigo);
                row.SubItems.Add(item.Nombre);
                row.SubItems.Add(item.Origen.GetDescription());
                row.SubItems.Add(item.Destino.GetDescription());
                // row.SubItems.Add(item.Cantidad.ToString());
                row.SubItems.Add(item.Precio.ToFormDecimal());
                row.SubItems.Add(item.CapacidadMaximaAdultos.ToString());
                row.SubItems.Add(item.CapacidadMaximaMenores.ToString());
                row.SubItems.Add(item.FechaDesde.ToFormDate());
                row.SubItems.Add(item.FechaHasta.ToFormDate());

                listViewProductosSeleccionados.Items.Add(row);
            }
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            if (listViewProductos.SelectedItems.Count > 0)
            {
                var productosToAdd = new List<PaquetesTuristicos>();

                foreach (ListViewItem item in listViewProductos.SelectedItems)
                {
                    var id = Guid.Parse(item.Text);

                    var producto = PaquetesTuristicosModel.GetPaqueteTuristicoByID(id);

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
                MessageBox.Show("Ningun paquete seleccionado para agregar al presupuesto.");
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
                MessageBox.Show("Ningun paquete seleccionado para remover del presupuesto.");
            }
        }

        private void btnConfirmarProductosSeleccionados_Click(object sender, EventArgs e)
        {
            PaquetesTuristicosModel.ClearPaquetesTuristicosElegidos();

            foreach (ListViewItem item in listViewProductosSeleccionados.Items)
            {
                var id = Guid.Parse(item.Text);

                PaquetesTuristicosModel.AddPaqueteTuristicoElegido(id);
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
            comboBoxOrigen.SelectedIndex = -1;
            comboBoxDestino.SelectedIndex = -1;

            listViewProductos.Items.Clear();

            AddProductosToListView(PaquetesTuristicosModel.GetPaquetesTuristicos(new PaquetesTuristicosFilter()
            {
                CantidadMin = 1,
            }));
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
