using Proyecto_CAI_Grupo_4.Utils;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Enums;
using Proyecto_CAI_Grupo_4.Models.Productos;
using Proyecto_CAI_Grupo_4.Models;

namespace Proyecto_CAI_Grupo_4;

public partial class GenerarPresupuestoMenu : VistaBase
{
    private decimal Total = 0;
    private int PresupuestoId = 0;
    private bool EsNuevo = true;

    private readonly string PrefijoCodigoPresupuesto = "P";
    private readonly string PrefijoCodigoAereo = "V";
    private readonly string PrefijoCodigoHotel = "H";
    private readonly int PrefijoCodigoItinerario = 1000;

    protected class ItinearioItemTag
    {
        public int IdProducto { get; set; }
        public TipoDeServicioEnum TipoDeServicio { get; set; }
    }

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

        var presupuesto = PresupuestosModel.GetPresupuestoById(PresupuestoId)!;

        textBoxClienteDNI.Text = presupuesto.Cliente.DNI;
        textBoxClienteNombre.Text = presupuesto.Cliente.Nombre;
        textBoxClienteApellido.Text = presupuesto.Cliente.Apellido;

        if (parametros.InitBuscarPresupuesto)
        {
            presupuesto.IdAereosSeleccionados.ForEach(i => AereosModel.AddAereoElegido(i.IdAereo));
            presupuesto.IdHotelesSeleccionados.ForEach(i => HotelesModel.AddHotelElegido(i.IdHotel));
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

    private void AddProductosToListView(IEnumerable<Productos> productos)
    {
        var filasProducto = productos.Select(item => new ListViewItem(item.Codigo)
        {
            SubItems =
            {
                item.Codigo,
                item.Nombre,
                item.TipoDeServicio.GetDescription(),
                item.Precio.ToFormDecimal()
            },
            Tag = new ItinearioItemTag
            {
                IdProducto = item.Id,
                TipoDeServicio = item.TipoDeServicio
            }
        }).ToArray();

        productosElegidos.Items.AddRange(filasProducto);
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
        if (!EsPresupuestoValido(out var dni, out var nombre, out var apellido))
            return;

        var cliente = new Cliente(dni, nombre, apellido);

        var itinerario = GenerarItinerario(cliente, PresupuestoEstadoEnum.Presupuesto_Pendiente_De_Pago);

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

        LimpiarSeleccionDeProductos();
        GoToMenuPrincipal();
    }

    private Itinerario GenerarItinerario(Cliente cliente, PresupuestoEstadoEnum estado)
    {

        var itinerario = new Itinerario(PresupuestoId, cliente, Total, estado);

        for (var i = 0; i < productosElegidos.Items.Count; i++)
        {
            var tag = (ItinearioItemTag)productosElegidos.Items[i].Tag;

            var idUnico = PrefijoCodigoPresupuesto + PresupuestoId;

            if (tag.TipoDeServicio == TipoDeServicioEnum.aereo)
            {
                idUnico += PrefijoCodigoAereo + (PrefijoCodigoItinerario + i);

                itinerario.AddAereo(idUnico, tag.IdProducto);
            }
            else
            {
                idUnico += PrefijoCodigoHotel + (PrefijoCodigoItinerario + i);

                itinerario.AddHotel(idUnico, tag.IdProducto);
            }
        }

        return itinerario;
    }

    private bool EsPresupuestoValido(out string dni, out string nombre, out string apellido)
    {
        dni = textBoxClienteDNI.Text.Trim();

        nombre = textBoxClienteNombre.Text.Trim();

        apellido = textBoxClienteApellido.Text.Trim();

        var validacionProductos = productosElegidos.Items.Count > 0;

        var validacionDNI = dni.EsDNI();

        if (!validacionDNI)
        {
            MessageBox.Show($"Debes ingresar un DNI correcto.", "Error", MessageBoxButtons.OK);
            return false;
        }

        if (string.IsNullOrEmpty(nombre))
        {
            MessageBox.Show($"Debes ingresar un Nombre.", "Error", MessageBoxButtons.OK);
            return false;
        }

        if (string.IsNullOrEmpty(apellido))
        {
            MessageBox.Show($"Debes ingresar un Apellido.", "Error", MessageBoxButtons.OK);
            return false;
        }

        if (!validacionProductos)
        {
            MessageBox.Show($"Debes elegir productos para poder generar un Presupuesto.", "Error", MessageBoxButtons.OK);
            return false;
        }

        return true;
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

    private void btnEliminarSeleccion_Click(object sender, EventArgs e)
    {
        foreach (ListViewItem item in productosElegidos.SelectedItems)
        {
            var tag = (ItinearioItemTag)item.Tag;

            AereosModel.RemoveAereoElegido(tag!.IdProducto);

            HotelesModel.RemoveHotelElegido(tag!.IdProducto);

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