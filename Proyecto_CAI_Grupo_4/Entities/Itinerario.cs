using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CAI_Grupo_4.Entities;

public class Itinerario
{
    public Itinerario(int id, IEnumerable<int> aereosSeleccionados, IEnumerable<int> hotelesSeleccionados, Cliente cliente, Decimal precioTotal)
    {
        IdItinerario = id;
        Estado = "Presupuesto";
        FechaEstado = DateTime.Now;
        PrecioTotal = precioTotal;

        Cliente = cliente;
        IdAereosSeleccionados = aereosSeleccionados.ToList();
        IdHotelesSeleccionados = hotelesSeleccionados.ToList();
    }

    public int IdItinerario { get; set; }
    public List<int> IdAereosSeleccionados { get; set; }
    public List<int> IdHotelesSeleccionados { get; set; }
    public Cliente Cliente { get; set; }
    public string Estado { get; set; }
    public DateTime FechaEstado { get; set; }
    public decimal PrecioTotal { get; set; }


    public void PreReservar()
    {
        Estado = "Pre-Reserva";
        FechaEstado = DateTime.Now;
    }
}