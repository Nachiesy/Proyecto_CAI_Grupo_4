using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_CAI_Grupo_4.Entities;

namespace Proyecto_CAI_Grupo_4.Models
{
    public static class PresupuestosModel
    {
        public static List<Itinerario> Presupuestos { get; set; } = new List<Itinerario>();

        public static void AgregarPresupuesto(Itinerario itinerario)
        {
            Presupuestos.Add(itinerario);
        }

        public static Itinerario? ObtenerPresupuesto(int id)
        {
            return Presupuestos.FirstOrDefault(x => x.IdItinerario == id);
        }

        public static int GenerarId()
        {
            return Presupuestos.Count + 1;
        }
    }
}
