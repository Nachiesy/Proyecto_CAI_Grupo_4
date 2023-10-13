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

        public static string ToFormVueloDate(this DateTime dateTime)
        {
            return dateTime.ToString("dd/MM/yyyy HH:mm");
        }
    }

    public static class DecimalExtensions
    {
        public static string ToFormDecimal(this decimal number)
        {
            return number.ToString("0.00");
        }
    }
}
