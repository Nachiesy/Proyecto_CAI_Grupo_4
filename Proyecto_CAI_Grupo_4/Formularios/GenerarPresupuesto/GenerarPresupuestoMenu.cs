using Proyecto_CAI_Grupo_4.Utils;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Models;

namespace Proyecto_CAI_Grupo_4;

public partial class GenerarPresupuestoMenu : VistaBase
{
    public decimal Total = 0;

    private GenerarPresupuestoMenuModel Model = new GenerarPresupuestoMenuModel();

    public GenerarPresupuestoMenu() : base(tituloModulo: $"Generar Presupuesto")
    {
        InitializeComponent();

        GenerarPresupuestoMenuModel.PresupuestoId = Model.GenerarPresupuestoId();
    }

    public GenerarPresupuestoMenu(GenerarPresupuestoMenuParams parametros) : base(tituloModulo: $"Modificar Presupuesto #{parametros.PresupuestoId}")
    {
        InitializeComponent();

        var presupuesto = Model.GetPresupuestoById();

        textBoxClienteDNI.Text = presupuesto.Cliente.DNI;
        textBoxClienteNombre.Text = presupuesto.Cliente.Nombre;
        textBoxClienteApellido.Text = presupuesto.Cliente.Apellido;

        if (parametros.InitBuscarPresupuesto)
        {
            presupuesto.IdAereosSeleccionados.ForEach(i => Model.AddAereoElegido(i.IdAereo));
            presupuesto.IdHotelesSeleccionados.ForEach(i => Model.AddHotelElegido(i.IdHotel));
        }
    }

    private void GenerarPresupuestoMenu_Load(object sender, EventArgs e)
    {
        var aereos = Model.GetAereosElegidos();

        Model.AddProductosToListView(productosElegidos, aereos);

        var hoteles = Model.GetHotelesElegidos();

        Model.AddProductosToListView(productosElegidos, hoteles);

        Total += aereos.Sum(x => x.Precio);
        Total += hoteles.Sum(x => x.Precio);

        ActualizarTextoPrecioTotal();

        ActualizarEstadoBotones();
    }

    private void btnMenuAereos_Click(object sender, EventArgs e)
    {
        this.Close();

        Model.GoToGenerarPresupuestoAereos();
    }

    private void btnMenuHoteles_Click(object sender, EventArgs e)
    {
        this.Close();

        Model.GoToGenerarPresupuestoHoteles();
    }

    private void btnFinalizarPresupuesto_Click(object sender, EventArgs e)
    {
        var dni = textBoxClienteDNI.Text.Trim();

        var nombre = textBoxClienteNombre.Text.Trim();

        var apellido = textBoxClienteApellido.Text.Trim();

        if (!Model.EsPresupuestoValido(dni, nombre, apellido, productosElegidos.Items.Count))
        {
            return;
        }

        var cliente = Model.GenerarCliente(dni, nombre, apellido);

        var itinerario = Model.GenerarItinerario(productosElegidos, cliente, Total);

        if (GenerarPresupuestoMenuModel.EsNuevo)
        {
            Model.AddPresupuesto(itinerario);

            MessageBox.Show($"Presupuesto con Código: [{GenerarPresupuestoMenuModel.PresupuestoId}] generado correctamente para el cliente con DNI {dni}.", "Exito", MessageBoxButtons.OK);
        }
        else
        {
            Model.UpdatePresupuesto(itinerario);

            MessageBox.Show($"Presupuesto con Código: [{GenerarPresupuestoMenuModel.PresupuestoId}] actualizado correctamente para el cliente con DNI {dni}.", "Exito", MessageBoxButtons.OK);
        }

        Model.ClearAereosElegidos();
        Model.ClearHotelesElegidos();

        Close();

        Model.GoToMenuPrincipal();
    }

    private void btnEliminarTodo_Click(object sender, EventArgs e)
    {
        Model.ClearAereosElegidos();
        Model.ClearHotelesElegidos();

        productosElegidos.Items.Clear();

        presupuestoTotal.Text = "Total: $-";
    }

    private void btnEliminarSeleccion_Click(object sender, EventArgs e)
    {
        foreach (ListViewItem item in productosElegidos.SelectedItems)
        {
            var tag = (ItinearioItemTag)item.Tag;

            Model.RemoveAereoElegido(tag!.IdProducto);

            Model.RemoveHotelElegido(tag!.IdProducto);

            productosElegidos.Items.Remove(item);
        }

        Total = 0;
        Total += Model.GetAereosElegidos().Sum(x => x.Precio);
        Total += Model.GetHotelesElegidos().Sum(x => x.Precio);

        presupuestoTotal.Text = Total > 0 ? $"Total: {Total:C2}" : "Total: $-";
    }

    private void productosElegidos_SelectedIndexChanged(object sender, EventArgs e)
    {
        ActualizarEstadoBotones();
    }

    private void ActualizarEstadoBotones()
    {
        btnEliminarTodo.Enabled = productosElegidos.Items.Count > 0;
        btnEliminarSeleccion.Enabled = productosElegidos.SelectedItems.Count > 0;
    }

    private void ActualizarTextoPrecioTotal()
    {
        presupuestoTotal.Text = Total > 0 ? $"Total: {Total:C2}" : "Total: $-";
    }
}
