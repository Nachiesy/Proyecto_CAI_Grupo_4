using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Models;
using Proyecto_CAI_Grupo_4.Utils;

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

            foreach (var value in Model.GetOrigenes())
            {
                comboBoxOrigen.Items.Add(value);
            }

            foreach (var value in Model.GetDestinos())
            {
                comboBoxDestino.Items.Add(value);
            }

            foreach (var value in Model.GetTipoDePasajeros())
            {
                comboBoxTipoDePasajero.Items.Add(value);
            }

            foreach (var value in Model.GetClases())
            {
                comboBoxClase.Items.Add(value);
            }

            AddProductosToListView(Model.GetAereos(new AereosFilter() { CantidadMin = 1 }));

            AddProductosSeleccionadosToListView(Model.GetAereosElegidos());
        }

        private void AddProductosToListView(IEnumerable<AereosEnt> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Codigo);
                row.SubItems.Add(item.Origen);
                row.SubItems.Add(item.Destino);
                row.SubItems.Add(item.Tarifa.Clase);
                row.SubItems.Add(item.Tarifa.Disponibilidad.ToString());
                row.SubItems.Add(item.Tarifa.TipoDePasajero);
                row.SubItems.Add(item.Tarifa.Precio.ToFormDecimal());
                row.SubItems.Add(item.Aerolinea);
                row.SubItems.Add(item.CantidadDeParadas.ToString());
                row.SubItems.Add(item.FechaDeSalida.ToFormVueloDate());
                row.SubItems.Add(item.FechaDeLlegada.ToFormVueloDate());

                listViewProductos.Items.Add(row);
            }
        }

        private void AddProductosSeleccionadosToListView(IEnumerable<AereosEnt> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Codigo);
                row.SubItems.Add(item.Origen);
                row.SubItems.Add(item.Destino);
                row.SubItems.Add(item.Tarifa.Clase);
                // row.SubItems.Add(item.Tarifa.Disponibilidad.ToString());
                row.SubItems.Add(item.Tarifa.TipoDePasajero);
                row.SubItems.Add(item.Tarifa.Precio.ToFormDecimal());
                row.SubItems.Add(item.Aerolinea);
                row.SubItems.Add(item.CantidadDeParadas.ToString());
                row.SubItems.Add(item.FechaDeSalida.ToFormVueloDate());
                row.SubItems.Add(item.FechaDeLlegada.ToFormVueloDate());

                listViewProductosSeleccionados.Items.Add(row);
            }
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
                Origen = comboBoxOrigen.SelectedIndex != -1 ? comboBoxOrigen.Text : null,
                Destino = comboBoxDestino.SelectedIndex != -1 ? comboBoxDestino.Text : null,
                TipoDePasajero = comboBoxTipoDePasajero.SelectedIndex != -1 ? comboBoxTipoDePasajero.Text : null,
                Clase = comboBoxClase.SelectedIndex != -1 ? comboBoxClase.Text : null,
            };

            var validacion = Model.ValidacionDeFiltros(filter);

            if (!string.IsNullOrEmpty(validacion))
            {
                MessageBox.Show(validacion, "Error", MessageBoxButtons.OK);

                return;
            }

            listViewProductos.Items.Clear();

            AddProductosToListView(Model.GetAereos(filter));

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

            var productosToAdd = new List<AereosEnt>();

            foreach (ListViewItem item in listViewProductos.SelectedItems)
            {
                var id = int.Parse(item.Text);

                var producto = Model.GetProductoToAddToProductosSeleccionados(listViewProductosSeleccionados, id);

                if (producto != null)
                {
                    productosToAdd.Add(producto);
                }
            }

            AddProductosSeleccionadosToListView(productosToAdd);
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
            LimpiarTextBox(txtBoxFiltroPrecioDesde);
            LimpiarTextBox(txtBoxFiltroPrecioHasta);

            datePickerFilterFechaDesde.Value = DateTime.Now.Date;
            datePickerFilterFechaHasta.Value = DateTime.Now.AddDays(1).Date;

            LimpiarComboBox(comboBoxOrigen);
            LimpiarComboBox(comboBoxDestino);
            LimpiarComboBox(comboBoxTipoDePasajero);
            LimpiarComboBox(comboBoxClase);

            listViewProductos.Items.Clear();

            AddProductosToListView(Model.GetAereos(new AereosFilter() { CantidadMin = 1 }));
        }

        private void btnDisableDatePickerFilterFechaDesde_Click(object sender, EventArgs e)
        {
            DisableDatePicker(datePickerFilterFechaDesde, btnDisableDatePickerFilterFechaDesde);
        }

        private void btnDisableDatePickerFilterFechaHasta_Click(object sender, EventArgs e)
        {
            DisableDatePicker(datePickerFilterFechaHasta, btnDisableDatePickerFilterFechaHasta);
        }

        private void LimpiarTextBox(TextBox textBox)
        {
            textBox.Clear();
        }

        private void LimpiarComboBox(ComboBox comboBox)
        {
            comboBox.SelectedIndex = -1;
        }

        private void DisableDatePicker(DateTimePicker dateTimePicker, Button btnDisable)
        {
            if (dateTimePicker.Enabled)
            {
                dateTimePicker.Enabled = false;
                btnDisable.Text = "Habilitar";
            }
            else
            {
                dateTimePicker.Enabled = true;
                btnDisable.Text = "Deshabilitar";
            }
        }
    }
}
