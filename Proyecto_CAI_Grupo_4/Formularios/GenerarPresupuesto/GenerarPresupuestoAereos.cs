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
            LimpiarTextBox(txtBoxFiltroPrecioDesde);
            LimpiarTextBox(txtBoxFiltroPrecioHasta);

            datePickerFilterFechaDesde.Value = DateTime.Now.Date;
            datePickerFilterFechaHasta.Value = DateTime.Now.AddDays(1).Date;

            LimpiarComboBox(comboBoxOrigen);
            LimpiarComboBox(comboBoxDestino);
            LimpiarComboBox(comboBoxTipoDePasajero);
            LimpiarComboBox(comboBoxClase);

            listViewProductos.Items.Clear();

            Model.AddProductosToListView(listViewProductos, Model.GetAereos(new AereosFilter() { CantidadMin = 1 }));
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
