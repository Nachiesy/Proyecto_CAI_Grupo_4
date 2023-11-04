using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Utils;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Models.Productos;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarPresupuestoAereos : VistaBase

    {
    private int PresupuestoId = 0;
    private bool EsNuevo = true;

    public GenerarPresupuestoAereos(int presupuestoId, bool esNuevo) : base(
        tituloModulo: "Generar Presupuesto > Aéreos")
    {
        InitializeComponent();

        PresupuestoId = presupuestoId;
        EsNuevo = esNuevo;
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

        AddProductosToListView(AereosModel.GetAereos(new AereosFilter()
        {
            CantidadMin = 1,
        }));

        AddProductosSeleccionadosToListView(AereosModel.GetAereosElegidos());
    }

    private void btnBuscarProductos_Click(object sender, EventArgs e)
    {
        var filterDto = new AereosFilterDto()
        {
            CantidadMin = 1,
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

            var productos = AereosModel.GetAereos(filter);

            listViewProductos.Items.Clear();

            AddProductosToListView(productos);

            if (!productos.Any())
            {
                MessageBox.Show("No hay Vuelos disponibles para los parámetros ingresados.", "Error",
                    MessageBoxButtons.OK);
            }
        }
    }

    private string ValidacionDeFiltros(AereosFilterDto presupuesto)
    {
        var messages = string.Empty;

        messages += FiltersHelper.ValidarPrecios(presupuesto);

        messages += FiltersHelper.ValidarFechasDeVuelos(presupuesto);

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
                var id = int.Parse(item.Text);

                var producto = AereosModel.GetAereoByID(id);

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
        AereosModel.ClearAereosElegidos();

        foreach (ListViewItem item in listViewProductosSeleccionados.Items)
        {
            var id = int.Parse(item.Text);

            AereosModel.AddAereoElegido(id);
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
        comboBoxOrigen.SelectedIndex = -1;
        comboBoxDestino.SelectedIndex = -1;
        comboBoxTipoDePasajero.SelectedIndex = -1;
        comboBoxItinerario.SelectedIndex = -1;
        comboBoxClase.SelectedIndex = -1;

        listViewProductos.Items.Clear();

        AddProductosToListView(AereosModel.GetAereos(new AereosFilter()
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
