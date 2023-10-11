using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class Pasajeros
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime Fecha_Nac { get; set; }
        public int Tipo_Doc { get; set; }
        public string Doc { get; set; }
        public DateTime Fecha_Exp { get; set; }
        public string Pais_emisor { get; set; }
        public string Email { get; set; }
        public string Tel_contacto { get; set; }
        public int Edad {  get; set; }
        public string Estado { get; set; }

    }

    public enum TipoDoc
    {
        [Description("DNI")]
        dni,

        [Description("Pasaporte")]
        pasaporte,

    }


}
