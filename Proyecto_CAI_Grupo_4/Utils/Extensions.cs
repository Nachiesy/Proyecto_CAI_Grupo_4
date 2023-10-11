using Proyecto_CAI_Grupo_4.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Proyecto_CAI_Grupo_4.Utils
{
    public static class EnumExtensions
    {
        public static string GetDescription<T>(this T enumerationValue)
          where T : struct
        {
            var type = enumerationValue.GetType();
            if (!type.IsEnum)
            {
                throw new ArgumentException($"{nameof(enumerationValue)} must be of Enum type", nameof(enumerationValue));
            }
            var memberInfo = type.GetMember(enumerationValue.ToString());
            if (memberInfo.Length > 0)
            {
                var attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }
            return enumerationValue.ToString();
        }
    }

    public static class DateTimeExtensions
    {
        public static string ToFormDate(this DateTime dateTime)
        {
            return dateTime.ToString("dd/MM/yyyy");
        }
    }

    public static class Validaciones
    {
        public static int Calculoedad(DateTime fechaNacimiento)
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

        public static string TipoPasajero(int edad)
        {
            string tipo = "";

            if(edad > 17) { tipo = "Adulto";  }else if(edad >2){ tipo = "Menor"; } else { tipo = "Infante"; };

            return tipo;
        }

        public static List<string> CamposPasajeros(Pasajeros nuevopasajero)
        {
            List<string> camposVacios = new List<string>();

            return camposVacios;
        }
    }

}
