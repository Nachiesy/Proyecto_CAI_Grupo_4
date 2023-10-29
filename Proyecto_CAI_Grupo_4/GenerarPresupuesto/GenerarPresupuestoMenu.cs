using Proyecto_CAI_Grupo_4.Utils;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Enums;
using Proyecto_CAI_Grupo_4.Models.Productos;
using Proyecto_CAI_Grupo_4.Modelos;
using Proyecto_CAI_Grupo_4.Models;

namespace Proyecto_CAI_Grupo_4;

public partial class GenerarPresupuestoMenu : VistaBase
{
    private decimal Total = 0;
    private int PresupuestoId = 0;
    private bool EsNuevo = true;

    public GenerarPresupuestoMenu() : base(tituloModulo: $"Generar Presupuesto")
    {
        InitializeComponent();

        PresupuestoId = PresupuestosModel.GenerarId();
    }

    public GenerarPresupuestoMenu(GenerarPresupuestoMenuParams parametros) : base(tituloModulo: $"Modificar Presupuesto #{parametros.PresupuestoId}")
    {
        InitializeComponent();

        PresupuestoId = parametros.PresupuestoId;
        EsNuevo = parametros.EsNuevo;

        var presupuesto = PresupuestosModel.GetPresupuesto(PresupuestoId)!;

        textBoxClienteDNI.Text = presupuesto.Cliente.DNI;
        textBoxClienteNombre.Text = presupuesto.Cliente.Nombre;
        textBoxClienteApellido.Text = presupuesto.Cliente.Apellido;

        if (parametros.InitBuscarPresupuesto)
        {
            presupuesto.IdAereosSeleccionados.ForEach(id => AereosModel.AddAereoElegido(id));
            presupuesto.IdHotelesSeleccionados.ForEach(id => HotelesModel.AddHotelElegido(id));
        }
    }

    private void ActualizarEstadoBotones()
    {
        btnEliminarTodo.Enabled = productosElegidos.Items.Count > 0;
        btnEliminarSeleccion.Enabled = productosElegidos.SelectedItems.Count > 0;
    }

    private void GenerarPresupuestoMenu_Load(object sender, EventArgs e)
    {
        var aereos = AereosModel.GetAereosElegidos();

        AddProductosToListView(aereos);

        var hoteles = HotelesModel.GetHotelesElegidos();

        AddProductosToListView(hoteles);

        Total += aereos.Sum(x => x.Precio);
        Total += hoteles.Sum(x => x.Precio);

        ActualizarTextoPrecioTotal();
    }

    private void ActualizarTextoPrecioTotal()
    {
        presupuestoTotal.Text = Total > 0 ? $"Total: {Total:C2}" : "Total: $-";

        ActualizarEstadoBotones();
    }

    private void AddProductosToListView(IEnumerable<Productos> listToAdd)
    {
        var productosAListar = listToAdd.Select(item => new ListViewItem(item.Id.ToString())
        {
            SubItems =
            {
                item.Codigo,
                item.Nombre,
                item.TipoDeServicio.GetDescription(),
                item.Precio.ToFormDecimal()
            }
        }).ToArray();

        productosElegidos.Items.AddRange(productosAListar);
    }

    private void btnMenuAereos_Click(object sender, EventArgs e)
    {
        this.Close();

        Thread thread = new Thread(OpenGenerarPresupuestoAereos);
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
    }

    private void OpenGenerarPresupuestoAereos()
    {
        Application.Run(new GenerarPresupuestoAereos(PresupuestoId, EsNuevo));
    }

    private void btnMenuHoteles_Click(object sender, EventArgs e)
    {
        this.Close();

        Thread thread = new Thread(OpenGenerarPresupuestoHoteles);
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
    }

    private void OpenGenerarPresupuestoHoteles()
    {
        Application.Run(new GenerarPresupuestoHoteles(PresupuestoId, EsNuevo));
    }

    private void btnFinalizarPresupuesto_Click(object sender, EventArgs e)
    {
        var dni = textBoxClienteDNI.Text.Trim();

        var nombre = textBoxClienteNombre.Text.Trim();

        var apellido = textBoxClienteApellido.Text.Trim();

        var validacionProductos = productosElegidos.Items.Count > 0;

        var validacionDNI = dni.EsDNI();

        if (!validacionDNI)
        {
            MessageBox.Show($"Debes ingresar un DNI correcto.", "Error", MessageBoxButtons.OK);
            return;
        }

        if (!validacionProductos)
        {
            MessageBox.Show($"Debes elegir productos para poder generar un Presupuesto.", "Error", MessageBoxButtons.OK);
            return;
        }

        var cliente = new Cliente(dni, nombre, apellido);
        var itinerario = new Itinerario(PresupuestoId, AereosModel.GetIdsAereosElegidos(), HotelesModel.GetIdsHotelesElegidos(), cliente, Total);

        if (EsNuevo)
        {
            PresupuestosModel.AddPresupuesto(itinerario);

            MessageBox.Show($"Presupuesto con Código: [{PresupuestoId}] generado correctamente para el cliente con DNI {dni}.", "Exito", MessageBoxButtons.OK);
        }
        else
        {
            PresupuestosModel.UpdatePresupuesto(itinerario);

            MessageBox.Show($"Presupuesto con Código: [{PresupuestoId}] actualizado correctamente para el cliente con DNI {dni}.", "Exito", MessageBoxButtons.OK);
        }

        //TODO: ActualizarCantidadesDeProductos
        //Mepa que esto ta mal, no deberia actualizar el stock el presupuesto, solamente cuando se confirma la pre-reserva se baja el stock
        //ActualizarCantidadesDeProductos();

        LimpiarSeleccionDeProductos();
        GoToMenuPrincipal();
    }

    public void LimpiarSeleccionDeProductos()
    {
        AereosModel.ClearAereosElegidos();
        HotelesModel.ClearHotelesElegidos();
    }

    private void ActualizarCantidadesDeProductos()
    {
        AereosModel.ActualizarCantidadesDeAereos();

        HotelesModel.ActualizarCantidadesDeHoteles();
    }

    private void GoToMenuPrincipal()
    {
        Close();

        Thread thread = new Thread(OpenMenuPrincipal);
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
    }

    private void OpenMenuPrincipal()
    {
        Application.Run(new MenuPrincipal());
    }

    private void btnEliminarTodo_Click(object sender, EventArgs e)
    {
        AereosModel.ClearAereosElegidos();
        HotelesModel.ClearHotelesElegidos();

        productosElegidos.Items.Clear();

        presupuestoTotal.Text = "Total: $-";
    }

    private void btnPreReservar_Click(object sender, EventArgs e)
    {
        var dni = textBoxClienteDNI.Text.Trim();

        var nombre = textBoxClienteNombre.Text.Trim();

        var apellido = textBoxClienteApellido.Text.Trim();

        var validacionProductos = productosElegidos.Items.Count > 0;

        var validacionDNI = dni.EsDNI();

        if (!validacionDNI)
        {
            MessageBox.Show($"Debes ingresar un DNI correcto.", "Error", MessageBoxButtons.OK);
            return;
        }

        if (!validacionProductos)
        {
            MessageBox.Show($"Debes elegir productos para poder generar un Presupuesto.", "Error", MessageBoxButtons.OK);
            return;
        }

        var cliente = new Cliente(dni, nombre, apellido);
        var itinerario = new Itinerario(PresupuestoId, AereosModel.GetIdsAereosElegidos(), HotelesModel.GetIdsHotelesElegidos(), cliente, Total);

        if (EsNuevo)
        {
            PresupuestosModel.AddPresupuesto(itinerario);

            MessageBox.Show($"Presupuesto con Código: [{PresupuestoId}] generado correctamente para el cliente con DNI {dni}.", "Exito", MessageBoxButtons.OK);
        }
        else
        {
            PresupuestosModel.UpdatePresupuesto(itinerario);

            MessageBox.Show($"Presupuesto con Código: [{PresupuestoId}] actualizado correctamente para el cliente con DNI {dni}.", "Exito", MessageBoxButtons.OK);
        }


        var reserva = ReservaModel.GenerarNuevaReserva(itinerario.IdItinerario, ReservaEstadoEnum.pendienteDePago);

        ReservaModel.AddReserva(reserva);

        GoToMenuPrincipal();
    }

    private void btnEliminarSeleccion_Click(object sender, EventArgs e)
    {
        foreach (ListViewItem item in productosElegidos.SelectedItems)
        {
            var id = Guid.Parse(item.Text);

            AereosModel.RemoveAereoElegido(id);

            HotelesModel.RemoveHotelElegido(id);

            productosElegidos.Items.Remove(item);
        }

        Total = 0;
        Total += AereosModel.GetAereosElegidos().Sum(x => x.Precio);
        Total += HotelesModel.GetHotelesElegidos().Sum(x => x.Precio);

        presupuestoTotal.Text = Total > 0 ? $"Total: {Total:C2}" : "Total: $-";
    }

    private void productosElegidos_SelectedIndexChanged(object sender, EventArgs e)
    {
        ActualizarEstadoBotones();
    }
}