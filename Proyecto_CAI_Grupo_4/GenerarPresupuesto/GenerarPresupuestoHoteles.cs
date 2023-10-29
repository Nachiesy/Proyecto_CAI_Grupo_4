using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Utils;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Models.Productos;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarPresupuestoHoteles : VistaBase
    {
        private int PresupuestoId = 0;
        private bool EsNuevo = true;

        public GenerarPresupuestoHoteles(int presupuestoId, bool esNuevo) : base(tituloModulo: "Generar Presupuesto > Hoteles")
        {
            InitializeComponent();

            PresupuestoId = presupuestoId;
            EsNuevo = esNuevo;
        }

        private void GenerarPresupuestoHoteles_Load(object sender, EventArgs e)
        {
            datePickerFilterFechaDesde.Value = DateTime.Now.Date;
            datePickerFilterFechaHasta.Value = DateTime.Now.AddDays(1).Date;

            foreach (HotelesCiudadEnum value in Enum.GetValues(typeof(HotelesCiudadEnum)))
            {
                comboBoxCiudad.Items.Add(value.GetDescription());
            }

            foreach (TipoDeHabitacionEnum value in Enum.GetValues(typeof(TipoDeHabitacionEnum)))
            {
                comboBoxTipoDeHabitacion.Items.Add(value.GetDescription());
            }

            foreach (HotelesCalificacionEnum value in Enum.GetValues(typeof(HotelesCalificacionEnum)))
            {
                comboBoxCalificacion.Items.Add(value.GetDescription());
            }

            AddProductosToListView(HotelesModel.GetHoteles(new HotelesFilter()
            {
                CantidadMin = 1,
            }));

            AddProductosSeleccionadosToListView(HotelesModel.GetHotelesElegidos());
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            var filterDto = new HotelesFilterDto()
            {
                CantidadMin = 1,
                PrecioDesde = txtBoxFiltroPrecioDesde.Text,
                PrecioHasta = txtBoxFiltroPrecioHasta.Text,
                FechaDesde = datePickerFilterFechaDesde.Enabled ? datePickerFilterFechaDesde.Value : null,
                FechaHasta = datePickerFilterFechaHasta.Enabled ? datePickerFilterFechaHasta.Value : null,
                Nombre = textBoxNombre.Text,
                Ciudad = comboBoxCiudad.SelectedIndex != -1 ? comboBoxCiudad.SelectedIndex : null,
                TipoDeHabitacion = comboBoxTipoDeHabitacion.SelectedIndex != -1 ? comboBoxTipoDeHabitacion.SelectedIndex : null,
                Calificacion = comboBoxCalificacion.SelectedIndex != -1 ? comboBoxCalificacion.SelectedIndex : null,
            };

            var validacion = ValidacionDeFiltros(filterDto);

            if (!string.IsNullOrEmpty(validacion))
            {
                MessageBox.Show(validacion, "Error", MessageBoxButtons.OK);
            }
            else
            {
                var filter = new HotelesFilter(filterDto);

                var productos = HotelesModel.GetHoteles(filter);

                listViewProductos.Items.Clear();

                AddProductosToListView(productos);

                if (!productos.Any())
                {
                    MessageBox.Show("No hay Hoteles disponibles para los parámetros ingresados.", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private string ValidacionDeFiltros(HotelesFilterDto presupuesto)
        {
            var messages = string.Empty;

            messages += FiltersHelper.ValidarPrecios(presupuesto);

            messages += FiltersHelper.ValidarFechas(presupuesto);

            return messages;
        }

        private void AddProductosToListView(IEnumerable<Hoteles> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Codigo);
                row.SubItems.Add(item.Nombre);
                row.SubItems.Add(item.Ciudad.GetDescription());
                row.SubItems.Add(item.Direccion);
                row.SubItems.Add(item.Calificacion.GetDescription());
                row.SubItems.Add(item.Cantidad.ToString());
                row.SubItems.Add(item.TipoDeHabitacion.GetDescription());
                row.SubItems.Add(item.Precio.ToFormDecimal());
                row.SubItems.Add(item.CantidadDePersonas.ToString());
                row.SubItems.Add(item.CantidadMaximaDeAdultos.ToString());
                row.SubItems.Add(item.CantidadMaximaDeMenores.ToString());
                row.SubItems.Add(item.CantidadMaximaDeInfantes.ToString());
                row.SubItems.Add(item.FechaDesde.ToFormDate());
                row.SubItems.Add(item.FechaHasta.ToFormDate());

                listViewProductos.Items.Add(row);
            }
        }

        private void AddProductosSeleccionadosToListView(IEnumerable<Hoteles> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Codigo);
                row.SubItems.Add(item.Nombre);
                row.SubItems.Add(item.Ciudad.GetDescription());
                row.SubItems.Add(item.Direccion);
                row.SubItems.Add(item.Calificacion.GetDescription());
                // row.SubItems.Add(item.Cantidad.ToString()); NO MOSTRAR LA CANTIDAD
                row.SubItems.Add(item.TipoDeHabitacion.GetDescription());
                row.SubItems.Add(item.Precio.ToFormDecimal());
                row.SubItems.Add(item.CantidadDePersonas.ToString());
                row.SubItems.Add(item.CantidadMaximaDeAdultos.ToString());
                row.SubItems.Add(item.CantidadMaximaDeMenores.ToString());
                row.SubItems.Add(item.CantidadMaximaDeInfantes.ToString());
                row.SubItems.Add(item.FechaDesde.ToFormDate());
                row.SubItems.Add(item.FechaHasta.ToFormDate());

                listViewProductosSeleccionados.Items.Add(row);
            }
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            if (listViewProductos.SelectedItems.Count > 0)
            {
                var productosToAdd = new List<Hoteles>();

                foreach (ListViewItem item in listViewProductos.SelectedItems)
                {
                    var id = int.Parse(item.Text);

                    var producto = HotelesModel.GetHotelByID(id);

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
                MessageBox.Show("Ningun hotel seleccionado para agregar al presupuesto.");
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
                MessageBox.Show("Ningun hotel seleccionado para remover del presupuesto.");
            }
        }

        private void btnConfirmarProductosSeleccionados_Click(object sender, EventArgs e)
        {
            HotelesModel.ClearHotelesElegidos();

            foreach (ListViewItem item in listViewProductosSeleccionados.Items)
            {
                var id = int.Parse(item.Text);

                HotelesModel.AddHotelElegido(id);
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
            if (EsNuevo)
            {
                Application.Run(new GenerarPresupuestoMenu());
            }
            else
            {
                Application.Run(new GenerarPresupuestoMenu(new GenerarPresupuestoMenuParams()
                {
                    PresupuestoId = PresupuestoId,
                    EsNuevo = EsNuevo,
                    InitBuscarPresupuesto = false,
                }));
            }
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            txtBoxFiltroPrecioDesde.Clear();
            txtBoxFiltroPrecioHasta.Clear();
            datePickerFilterFechaDesde.Value = DateTime.Now.Date;
            datePickerFilterFechaHasta.Value = DateTime.Now.AddDays(1).Date;
            textBoxNombre.Clear();
            comboBoxCiudad.SelectedIndex = -1;
            comboBoxTipoDeHabitacion.SelectedIndex = -1;
            comboBoxCalificacion.SelectedIndex = -1;

            listViewProductos.Items.Clear();

            AddProductosToListView(HotelesModel.GetHoteles(new HotelesFilter()
            {
                CantidadMin = 1,
            }));
        }

        private int IsProductInProductosSeleccionados(int id)
        {
            var selectedIDs = new List<int>();

            foreach (ListViewItem item in listViewProductosSeleccionados.Items)
            {
                var selectedID = int.Parse(item.Text);

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
    }
}
