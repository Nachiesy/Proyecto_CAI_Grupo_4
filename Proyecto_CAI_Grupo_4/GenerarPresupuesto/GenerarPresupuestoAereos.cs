using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Models;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarPresupuestoAereos : VistaBase
    {
        private GenerarPresupuestoAereosModel Model = new GenerarPresupuestoAereosModel();

        public GenerarPresupuestoAereos() : base(tituloModulo: "Generar Presupuesto > Aéreos")
        {
            InitializeComponent();
        }

        private void GenerarPresupuestoAereos_Load(object sender, EventArgs e)
        {
            datePickerFilterFechaDesde.Value = DateTime.Now.Date;
            datePickerFilterFechaHasta.Value = DateTime.Now.AddDays(1).Date;

            Model.InitComboBoxOrigen(comboBoxOrigen);

            Model.InitComboBoxDestino(comboBoxDestino);

            Model.InitComboBoxTipoDePasajero(comboBoxTipoDePasajero);

            Model.InitComboBoxItinerario(comboBoxItinerario);

            Model.InitComboBoxClase(comboBoxClase);
            
            Model.AddProductosToListView(listViewProductos, Model.GetAereos(new AereosFilter() { CantidadMin = 1 }));

            Model.AddProductosSeleccionadosToListView(listViewProductosSeleccionados, Model.GetAereosElegidos());
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            var filter = new AereosFilter()
            {
                CantidadMin = 1,
                PrecioDesdeInput = txtBoxFiltroPrecioDesde.Text,
                PrecioHastaInput = txtBoxFiltroPrecioHasta.Text,
                FechaDesde = datePickerFilterFechaDesde.Enabled ? datePickerFilterFechaDesde.Value : null,
                FechaHasta = datePickerFilterFechaHasta.Enabled ? datePickerFilterFechaHasta.Value : null,
                Origen = comboBoxOrigen.SelectedIndex != -1 ? comboBoxOrigen.SelectedIndex : null,
                Destino = comboBoxDestino.SelectedIndex != -1 ? comboBoxDestino.SelectedIndex : null,
                TipoDePasajero = comboBoxTipoDePasajero.SelectedIndex != -1 ? comboBoxTipoDePasajero.SelectedIndex : null,
                Itinerario = comboBoxItinerario.SelectedIndex != -1 ? comboBoxItinerario.SelectedIndex : null,
                Clase = comboBoxClase.SelectedIndex != -1 ? comboBoxClase.SelectedIndex : null,
            };

            var validacion = Model.ValidacionDeFiltros(filter);

            if (!string.IsNullOrEmpty(validacion))
            {
                MessageBox.Show(validacion, "Error", MessageBoxButtons.OK);

                return;
            }

            listViewProductos.Items.Clear();

            Model.AddProductosToListView(listViewProductos, Model.GetAereos(filter));

            if (listViewProductos.Items.Count == 0)
            {
                MessageBox.Show("No hay Vuelos disponibles para los parámetros ingresados.", "Error",
                    MessageBoxButtons.OK);
            }
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            if (listViewProductos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Ningun vuelo seleccionado para agregar al presupuesto.");

                return;
            }
            
            var productosToAdd = new List<Aereos>();

            foreach (ListViewItem item in listViewProductos.SelectedItems)
            {
                var id = int.Parse(item.Text);

                var producto = Model.GetProductoToAddToProductosSeleccionados(listViewProductosSeleccionados, id);

                if (producto != null) 
                { 
                    productosToAdd.Add(producto);
                }
            }

            Model.AddProductosSeleccionadosToListView(listViewProductosSeleccionados, productosToAdd);
        }

        private void btnRemoverProductos_Click(object sender, EventArgs e)
        {
            if (listViewProductosSeleccionados.SelectedItems.Count == 0)
            {
                MessageBox.Show("Ningun vuelo seleccionado para remover del presupuesto.");

                return;
            }

            foreach (ListViewItem item in listViewProductosSeleccionados.SelectedItems)
            {
                listViewProductosSeleccionados.Items.Remove(item);
            }
        }

        private void btnConfirmarProductosSeleccionados_Click(object sender, EventArgs e)
        {
            Model.ClearAereosElegidos();

            foreach (ListViewItem item in listViewProductosSeleccionados.Items)
            {
                var id = int.Parse(item.Text);

                Model.AddAereoElegido(id);
            }

            this.Close();

            Model.GoToGenerarPresupuestoMenu();
        }

        private void btnVolverAlMenuGenerarPresupuestos_Click(object sender, EventArgs e)
        {
            this.Close();

            Model.GoToGenerarPresupuestoMenu();
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            Model.LimpiarTextBox(txtBoxFiltroPrecioDesde);
            Model.LimpiarTextBox(txtBoxFiltroPrecioHasta);

            datePickerFilterFechaDesde.Value = DateTime.Now.Date;
            datePickerFilterFechaHasta.Value = DateTime.Now.AddDays(1).Date;

            Model.LimpiarComboBox(comboBoxOrigen);
            Model.LimpiarComboBox(comboBoxDestino);
            Model.LimpiarComboBox(comboBoxTipoDePasajero);
            Model.LimpiarComboBox(comboBoxItinerario);
            Model.LimpiarComboBox(comboBoxClase);

            listViewProductos.Items.Clear();

            Model.AddProductosToListView(listViewProductos, Model.GetAereos(new AereosFilter() { CantidadMin = 1 }));
        }

        private void btnDisableDatePickerFilterFechaDesde_Click(object sender, EventArgs e)
        {
            Model.DisableDatePicker(datePickerFilterFechaDesde, btnDisableDatePickerFilterFechaDesde);
        }

        private void btnDisableDatePickerFilterFechaHasta_Click(object sender, EventArgs e)
        {
            Model.DisableDatePicker(datePickerFilterFechaHasta, btnDisableDatePickerFilterFechaHasta);
        }
    }
}
