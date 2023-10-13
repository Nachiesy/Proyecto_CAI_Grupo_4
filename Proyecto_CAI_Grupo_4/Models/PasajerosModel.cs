using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class Pasajeros
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime Fecha_Nac { get; set; }
        public string Tipo_Doc { get; set; }
        public int Doc { get; set; }
        public string Pasaporte { get; set; }
        public DateTime Fecha_Exp { get; set; }
        public string Pais_emisor { get; set; }
        public string Email { get; set; }
        public int Tel_contacto { get; set; }
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

        public static string CamposPasajeros(this Pasajeros nuevopasajero)
        {
            string camposVacios = null;

            if (string.IsNullOrWhiteSpace(nuevopasajero.Nombre))
            {
                camposVacios="Debe completar el Nombre";
                return camposVacios;
            }

            if (string.IsNullOrWhiteSpace(nuevopasajero.Apellido))
            {
                camposVacios = "Debe completar el Apellido";
                return camposVacios;
            }

            if (nuevopasajero.Fecha_Nac>DateTime.Today)
            {
                camposVacios = "La fecha nacimiento debe ser anterior al día de hoy";
                return camposVacios;
            }

            if (string.IsNullOrWhiteSpace(nuevopasajero.Nacionalidad))
            {
                camposVacios = "Debe seleccionar una Nacionalidad";
                return camposVacios;
            }

            if (string.IsNullOrWhiteSpace(nuevopasajero.Tipo_Doc))
            {
                camposVacios = "Debe seleccionar un tipo de documento";
                return camposVacios;
            }
            if (nuevopasajero.Doc ==0)
            {
                camposVacios = "Debe completar el Documento";
                return camposVacios;
            }
            else if(!nuevopasajero.Doc.ToString().EsDNI()) {
                camposVacios = "DNI ingresado invalido";
                return camposVacios;
            }
            if (nuevopasajero.Fecha_Exp < DateTime.Today)
            {
                camposVacios = "Documento expirado, revise la fecha ingresada";
                return camposVacios;
            }
            if (string.IsNullOrWhiteSpace(nuevopasajero.Pais_emisor))
            {
                camposVacios = "Debe completar el País Emisor";
                return camposVacios;
            }
            if (string.IsNullOrWhiteSpace(nuevopasajero.Email))
            {
                camposVacios = "Debe completar el Email";
                return camposVacios;
            }
            else
            {
                if (EsCorreoElectronicoValido(nuevopasajero.Email) == false) {
                    camposVacios = "Ingrese un Email valido";
                    return camposVacios;
                };

            }
            if (nuevopasajero.Tel_contacto== 0)
            {
                camposVacios = "Debe completar un Telefono valido";
                return camposVacios;
            }
            return camposVacios;
        }
    }
}
