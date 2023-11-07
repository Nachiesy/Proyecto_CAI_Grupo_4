namespace Proyecto_CAI_Grupo_4.Entities;

public class Itinerario
{
    public Itinerario(int id, Cliente cliente, decimal precioTotal) 
    {
        IdItinerario = id;
        PrecioTotal = precioTotal;
        Cliente = cliente;
        Estado = "Presupuestado";
        FechaEstado = DateTime.Now;
    }

    public int IdItinerario { get; set; }

    public string Estado { get; set; }

    public DateTime FechaEstado { get; set; }

    public List<AereoSeleccionado> IdAereosSeleccionados { get; set; } = new List<AereoSeleccionado>();

    public List<HotelSeleccionado> IdHotelesSeleccionados { get; set; } = new List<HotelSeleccionado>();

    public Cliente Cliente { get; set; }

    public decimal PrecioTotal { get; set; }

    public Itinerario ActualizarEstadoAPendienteDeConfirmacion()
    {
        Estado = "Pendiente de confirmación";
        FechaEstado = DateTime.Now;

        return this;
    }

    public Itinerario ActualizarEstadoAPrereservado()
    {
        Estado = "Prereservado";
        FechaEstado = DateTime.Now;

        return this;
    }

    public Itinerario ActualizarEstadoAReservado()
    {
        Estado = "Reservado";
        FechaEstado = DateTime.Now;

        return this;
    }

    public bool EsPrereservable()
    {
        return Estado == "Presupuestado";
    }

    public bool EsPrereserva()
    {
        return Estado == "Prereservado" 
                || Estado == "Prereservado Abonado";
    }

    public bool EsPrereservaNoAbonada()
    {
        return Estado == "Prereservado";
    }

    public bool EsPrereservaAbonada()
    {
        return Estado == "Prereservado Abonado";
    }

    public bool EsModificable()
    {
        return Estado != "Prereservado"
               || Estado != "Prereservado Abonado"
               || Estado != "Reservado";
    }

    public Itinerario AddAereo(string idUnico, int idAereo)
    {
        IdAereosSeleccionados.Add(new AereoSeleccionado(idUnico, idAereo));

        return this;
    }

    public Itinerario AddHotel(string idUnico, int idHotel)
    {
        IdHotelesSeleccionados.Add(new HotelSeleccionado(idUnico, idHotel));

        return this;
    }
}
