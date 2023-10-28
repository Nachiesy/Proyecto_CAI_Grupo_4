using Proyecto_CAI_Grupo_4.Utils;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Models.Productos;
using Proyecto_CAI_Grupo_4.Modelos;
using Proyecto_CAI_Grupo_4.Models;

namespace Proyecto_CAI_Grupo_4;

public partial class GenerarPresupuestoMenu : VistaBase
{
    private decimal Total = 0;
    private int presupuestoId = 0;
    private bool esNuevo = true;

    public GenerarPresupuestoMenu() : base(tituloModulo: "Generar Presupuesto")
    {
        InitializeComponent();
        ActualizarEstadoBotones();
        presupuestoId = PresupuestosModel.GenerarId();
    }

    public GenerarPresupuestoMenu(int presupuestoId) : base(tituloModulo: $"Modificar Presupuesto #{presupuestoId}")
    {
        InitializeComponent();
        ActualizarEstadoBotones();
        this.presupuestoId = presupuestoId;
        esNuevo = false;
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

        presupuestoTotal.Text = Total > 0 ? $"Total: {Total:C2}" : "Total: $-";
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
        Application.Run(new GenerarPresupuestoAereos());
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
        Application.Run(new GenerarPresupuestoHoteles());
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
        var itinerario = new Itinerario(presupuestoId, AereosModel.GetAereosElegidos(), HotelesModel.GetHotelesElegidos(), cliente);

        PresupuestosModel.AgregarPresupuesto(itinerario);


        if (esNuevo)
        {
            MessageBox.Show($"Presupuesto con Código: [{presupuestoId}] generado correctamente para el cliente con DNI {dni}.", "Exito", MessageBoxButtons.OK);
        }
        else
        {
            MessageBox.Show($"Presupuesto con Código: [{presupuestoId}] actualizado correctamente para el cliente con DNI {dni}.", "Exito", MessageBoxButtons.OK);
        }

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

    private void GoToGenerarPreReserva()
    {
        Close();

        Thread thread = new Thread(OpenGenerarPreReserva);
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
    }

    private void OpenGenerarPreReserva()
    {
        Application.Run(new GenerarPreReserva());
    }

    private void btnEliminarTodo_Click(object sender, EventArgs e)
    {
        AereosModel.ClearAereosElegidos();
        HotelesModel.ClearHotelesElegidos();
    }

    private void ProductosSeleccionadosListView_ItemCheck(object sender, ItemCheckEventArgs e)
    {
        ActualizarEstadoBotones();
    }

    private void btnPreReservar_Click(object sender, EventArgs e)
    {

        //TODO: esto esta incompleto, revisar el DC y DF

        var reserva = new Reserva()
        {
            Codigo = 1,
            Estado = ReservaEstadoEnum.pendienteDePago,
            DNI = "",
            TipoDoc = 1,
            Precio = Total,
            Fecha = DateTime.Now,
            prereserva = true,
        };

        ReservaModel.AddReserva(reserva);

        GoToGenerarPreReserva();
    }
}