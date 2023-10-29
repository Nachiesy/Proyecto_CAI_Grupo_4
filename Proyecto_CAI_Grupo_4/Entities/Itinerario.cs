using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CAI_Grupo_4.Entities;

public class Itinerario
{
    public Itinerario(int id, IEnumerable<Guid> aereosSeleccionados, IEnumerable<Guid> hotelesSeleccionados, Cliente cliente)
    {
        IdItinerario = id;
        Estado = "Presupuesto";
        FechaEstado = DateTime.Now;

        Cliente = cliente;
        IdAereosSeleccionados = aereosSeleccionados.ToList();
        IdHotelesSeleccionados = hotelesSeleccionados.ToList();
    }

    public int IdItinerario { get; set; }
    public List<Guid> IdAereosSeleccionados { get; set; }
    public List<Guid> IdHotelesSeleccionados { get; set; }
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