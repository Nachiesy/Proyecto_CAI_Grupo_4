using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public static class PasajerosModel
    {
        public static List<Pasajeros> Pasajeros { get; set; } = new List<Pasajeros>();

        public static void AgregarPasajero(Pasajeros pasajero)
        {
            Pasajeros.Add(pasajero);
        }
    }
}
