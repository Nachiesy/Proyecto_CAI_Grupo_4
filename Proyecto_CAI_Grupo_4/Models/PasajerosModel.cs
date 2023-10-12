using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public string Pasaporte { get; set; }
        public DateTime Fecha_Exp { get; set; }
        public string Pais_emisor { get; set; }
        public string Email { get; set; }
        public string Tel_contacto { get; set; }
        public int Edad {  get; set; }
        public string Tipo { get; set; }

    }

    public enum TipoDoc
    {
        [Description("DNI")]
        dni,

        [Description("Pasaporte")]
        pasaporte,

    }

    public static class Validaciones
    {
        public static int Calculoedad(this DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaNacimiento > fechaActual.AddYears(-edad))
            {
                edad--;
            }
            return edad;
        }

        public static bool EsCorreoElectronicoValido(string email)
        {
            // Expresión regular para validar una dirección de correo electrónico
            string patron = @"^[\w\.-]+@[\w\.-]+\.\w+$";

            if (Regex.IsMatch(email, patron))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string TipoPasajero(this int edad)
        {
            string tipo = "";

            if (edad > 17) { tipo = "Adulto"; } else if (edad > 2) { tipo = "Menor"; } else { tipo = "Infante"; };

            return tipo;
        }

        public static List<string> CamposPasajeros(this Pasajeros nuevopasajero)
        {
            List<string> camposVacios = new List<string>();

            if (string.IsNullOrWhiteSpace(nuevopasajero.Nombre))
            {
                camposVacios.Add("Nombre");
            }

            if (string.IsNullOrWhiteSpace(nuevopasajero.Apellido))
            {
                camposVacios.Add("Apellido");
            }

            if (nuevopasajero.Fecha_Nac>DateTime.Today)
            {
                camposVacios.Add("Fecha de nacimiento Incorrecta");
            }

            if (string.IsNullOrWhiteSpace(nuevopasajero.Nacionalidad))
            {
                camposVacios.Add("Nacionalidad");
            }

            if (nuevopasajero.Tipo_Doc==0)
            {
                camposVacios.Add("Tipo de Documento");
            }
            if (string.IsNullOrWhiteSpace(nuevopasajero.Doc))
            {
                camposVacios.Add("Documento");
            }
            if (nuevopasajero.Fecha_Exp < DateTime.Today)
            {
                camposVacios.Add("Fecha de Expiración Incorrecta");
            }
            if (string.IsNullOrWhiteSpace(nuevopasajero.Pais_emisor))
            {
                camposVacios.Add("Pais Emisor");
            }
            if (string.IsNullOrWhiteSpace(nuevopasajero.Email))
            {
                camposVacios.Add( "Email");
            }
            else
            {
                if (EsCorreoElectronicoValido(nuevopasajero.Email) == false) {
                    camposVacios.Add("Ingrese un Mail Valido");
                };

            }
            if (string.IsNullOrWhiteSpace(nuevopasajero.Tel_contacto))
            {
                camposVacios.Add("Telefono");        }
            return camposVacios;
        }
    }
}
