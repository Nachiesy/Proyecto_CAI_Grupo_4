using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CAI_Grupo_4.Entities
{
    public class Cliente
    {
        public Cliente()
        {
            DNI = string.Empty;
            Nombre = string.Empty;
            Apellido = string.Empty;
        }

        public Cliente(string dni, string nombre, string apellido)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
        }

        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
