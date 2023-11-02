using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_CAI_Grupo_4.Enums;

namespace Proyecto_CAI_Grupo_4.Entities;

public class Itinerario
{
    public Itinerario(int id,
        Cliente cliente,
        decimal precioTotal,
        PresupuestoEstadoEnum estado) 
    {
        IdItinerario = id;
        FechaEstado = DateTime.Now;
        PrecioTotal = precioTotal;
        Cliente = cliente;
        Estado = estado;
    }

    public Itinerario(int id,
        List<AereoSeleccionado> idAereosSeleccionados,
        List<HotelSeleccionado> idHotelesSeleccionados,
        Cliente cliente,
        PresupuestoEstadoEnum estado,
        decimal precioTotal) : this(id, cliente, precioTotal, estado)
    {
        IdAereosSeleccionados = idAereosSeleccionados;
        IdHotelesSeleccionados = idHotelesSeleccionados;
    }

    public int IdItinerario { get; set; }
    public List<AereoSeleccionado> IdAereosSeleccionados { get; set; } = new List<AereoSeleccionado>();
    public List<HotelSeleccionado> IdHotelesSeleccionados { get; set; } = new List<HotelSeleccionado>();
    public Cliente Cliente { get; set; }
    public DateTime FechaEstado { get; set; }
    public decimal PrecioTotal { get; set; }

    public PresupuestoEstadoEnum Estado { get; set; }

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