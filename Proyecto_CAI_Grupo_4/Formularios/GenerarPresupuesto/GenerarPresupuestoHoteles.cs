using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Models;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarPresupuestoHoteles : VistaBase
    {
        private GenerarPresupuestoHotelesModel Model;

        public GenerarPresupuestoHoteles() : base(tituloModulo: "Generar Presupuesto > Hoteles")
        {
            InitializeComponent();
        }

        private void GenerarPresupuestoHoteles_Load(object sender, EventArgs e)
        {
            Model = new GenerarPresupuestoHotelesModel();

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

            AddProductosToListView(Model.GetHoteles(new HotelesFilter() { CantidadMin = 1 }));

            AddProductosSeleccionadosToListView(Model.GetHotelesElegidos());
        }

        private void AddProductosToListView(IEnumerable<HotelEnt> listToAdd)
        {
            foreach (var item in listToAdd)
            {

                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Codigo);
                row.SubItems.Add(item.Nombre);
                row.SubItems.Add(item.Ciudad);
                row.SubItems.Add($"{item.Direccion.Calle} {item.Direccion.Numero}");
                row.SubItems.Add(item.Calificacion);
                row.SubItems.Add(item.Disponibilidad.Disponibilidad.ToString());
                row.SubItems.Add(item.Disponibilidad.NombreHabitacion);
                row.SubItems.Add(item.Disponibilidad.TarifaPorDia.ToFormDecimal());
                row.SubItems.Add(item.Disponibilidad.CapacidadTotal.ToString());
                row.SubItems.Add(item.Disponibilidad.CantidadMaximaAdultos.ToString());
                row.SubItems.Add(item.Disponibilidad.CantidadMaximaMenores.ToString());
                row.SubItems.Add(item.Disponibilidad.CantidadMaximaInfantes.ToString());
                row.SubItems.Add(item.Disponibilidad.FechaDesde.ToFormDate());
                row.SubItems.Add(item.Disponibilidad.FechaHasta.ToFormDate());

                listViewProductos.Items.Add(row);
            }
        }

        private void AddProductosSeleccionadosToListView(IEnumerable<HotelEnt> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Codigo);
                row.SubItems.Add(item.Nombre);
                row.SubItems.Add(item.Ciudad);
                row.SubItems.Add($"{item.Direccion.Calle} {item.Direccion.Numero}");
                row.SubItems.Add(item.Calificacion);
                // row.SubItems.Add(item.Disponibilidad.Disponibilidad.ToString());
                row.SubItems.Add(item.Disponibilidad.NombreHabitacion);
                row.SubItems.Add(item.Disponibilidad.TarifaPorDia.ToFormDecimal());
                row.SubItems.Add(item.Disponibilidad.CapacidadTotal.ToString());
                row.SubItems.Add(item.Disponibilidad.CantidadMaximaAdultos.ToString());
                row.SubItems.Add(item.Disponibilidad.CantidadMaximaMenores.ToString());
                row.SubItems.Add(item.Disponibilidad.CantidadMaximaInfantes.ToString());
                row.SubItems.Add(item.Disponibilidad.FechaDesde.ToFormDate());
                row.SubItems.Add(item.Disponibilidad.FechaHasta.ToFormDate());

                listViewProductosSeleccionados.Items.Add(row);
            }
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

            AddProductosToListView(Model.GetHoteles(filter));

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

            var productosToAdd = new List<HotelEnt>();

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

            GoToGenerarPresupuestoMenu();
        }

        private void GoToGenerarPresupuestoMenu()
        {
            Model.SetGenerarPresupuestoParams();

            var thread = new Thread(OpenGenerarPresupuestoMenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenGenerarPresupuestoMenu()
        {
            Application.Run(new GenerarPresupuestoMenu());
        }

        private void btnVolverAlMenuGenerarPresupuestos_Click(object sender, EventArgs e)
        {
            this.Close();

            GoToGenerarPresupuestoMenu();
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

            AddProductosToListView(Model.GetHoteles(new HotelesFilter() { CantidadMin = 1 }));
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
