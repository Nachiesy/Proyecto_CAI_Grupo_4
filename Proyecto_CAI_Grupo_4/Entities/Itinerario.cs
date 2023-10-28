using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CAI_Grupo_4.Entities;

public class Itinerario
{
    public Itinerario(int id, IEnumerable<Aereos> aereosSeleccionados, IEnumerable<Hoteles> hotelesSeleccionados, Cliente cliente)
    {
        IdItinerario = id;
        Estado = "Presupuesto";
        FechaEstado = DateTime.Now;

        AereosSeleccionados = aereosSeleccionados.ToList();
        HotelesSeleccionados = hotelesSeleccionados.ToList();

        CalcularTotal();
    }

    public int IdItinerario { get; set; }
    public List<Aereos> AereosSeleccionados { get; set; }
    public List<Hoteles> HotelesSeleccionados { get; set; }
    public Cliente Cliente { get; set; }
    public string Estado { get; set; }
    public DateTime FechaEstado { get; set; }
    public decimal PrecioTotal { get; set; }

    public void CalcularTotal()
    {
        var totalAereos = AereosSeleccionados.Sum(x => x.Precio);
        var totalHoteles = HotelesSeleccionados.Sum(x => x.Precio);

        PrecioTotal = totalAereos + totalHoteles;
    }

    public void PreReservar()
    {
        Estado = "Pre-Reserva";
        FechaEstado = DateTime.Now;
    }
}