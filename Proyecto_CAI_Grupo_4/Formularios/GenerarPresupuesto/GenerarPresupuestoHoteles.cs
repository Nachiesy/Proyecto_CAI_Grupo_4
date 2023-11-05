using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Models;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarPresupuestoHoteles : VistaBase
    {
        private GenerarPresupuestoHotelesModel Model = new GenerarPresupuestoHotelesModel();

        public GenerarPresupuestoHoteles() : base(tituloModulo: "Generar Presupuesto > Hoteles")
        {
            InitializeComponent();
        }

        private void GenerarPresupuestoHoteles_Load(object sender, EventArgs e)
        {
            datePickerFilterFechaDesde.Value = DateTime.Now.Date;
            datePickerFilterFechaHasta.Value = DateTime.Now.AddDays(1).Date;

            foreach (var value in Model.GetCiudades())
            {
                comboBoxCiudad.Items.Add(value);
            }

            foreach (var value in Model.GetHabitaciones())
            {
                comboBoxTipoDeHabitacion.Items.Add(value);
            }

            foreach (var value in Model.GetCalificaciones())
            {
                comboBoxCalificacion.Items.Add(value);
            }

            Model.AddProductosToListView(listViewProductos, Model.GetHoteles(new HotelesFilter() { CantidadMin = 1 }));

            Model.AddProductosSeleccionadosToListView(listViewProductosSeleccionados, Model.GetHotelesElegidos());
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            var filter = new HotelesFilter()
            {
                CantidadMin = 1,
                PrecioDesdeInput = txtBoxFiltroPrecioDesde.Text,
                PrecioHastaInput = txtBoxFiltroPrecioHasta.Text,
                FechaDesde = datePickerFilterFechaDesde.Enabled ? datePickerFilterFechaDesde.Value : null,
                FechaHasta = datePickerFilterFechaHasta.Enabled ? datePickerFilterFechaHasta.Value : null,
                Nombre = textBoxNombre.Text,
                Ciudad = comboBoxCiudad.SelectedIndex != -1 ? comboBoxCiudad.Text : null,
                TipoDeHabitacion = comboBoxTipoDeHabitacion.SelectedIndex != -1 ? comboBoxTipoDeHabitacion.Text : null,
                Calificacion = comboBoxCalificacion.SelectedIndex != -1 ? comboBoxCalificacion.Text : null,
            };

            var validacion = Model.ValidacionDeFiltros(filter);

            if (!string.IsNullOrEmpty(validacion))
            {
                MessageBox.Show(validacion, "Error", MessageBoxButtons.OK);

                return;
            }

            listViewProductos.Items.Clear();

            Model.AddProductosToListView(listViewProductos, Model.GetHoteles(filter));

            if (listViewProductos.Items.Count == 0)
            {
                MessageBox.Show("No hay Hoteles disponibles para los parámetros ingresados.", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            if (listViewProductos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Ningun hotel seleccionado para agregar al presupuesto.");

                return;
            }

            var productosToAdd = new List<Hoteles>();

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
                MessageBox.Show("Ningun hotel seleccionado para remover del presupuesto.");

                return;
            }

            foreach (ListViewItem row in listViewProductosSeleccionados.SelectedItems)
            {
                listViewProductosSeleccionados.Items.Remove(row);
            }
        }

        private void btnConfirmarProductosSeleccionados_Click(object sender, EventArgs e)
        {
            Model.ClearHotelesElegidos();

            foreach (ListViewItem item in listViewProductosSeleccionados.Items)
            {
                var id = int.Parse(item.Text);

                Model.AddHotelElegido(id);
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
            LimpiarTextBox(textBoxNombre);

            datePickerFilterFechaDesde.Value = DateTime.Now.Date;
            datePickerFilterFechaHasta.Value = DateTime.Now.AddDays(1).Date;

            LimpiarComboBox(comboBoxCiudad);
            LimpiarComboBox(comboBoxTipoDeHabitacion);
            LimpiarComboBox(comboBoxCalificacion);

            listViewProductos.Items.Clear();

            Model.AddProductosToListView(listViewProductos, Model.GetHoteles(new HotelesFilter() { CantidadMin = 1 }));
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
