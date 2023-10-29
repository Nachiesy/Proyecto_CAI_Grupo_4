using System.Windows.Forms;

namespace Proyecto_CAI_Grupo_4.Filters
{
    public static class FiltersHelper
    {
        public static string ValidarPrecios(ProductosFilterDto presupuesto)
        {
            var precioDesdeEmpty = string.IsNullOrEmpty(presupuesto.PrecioDesde);
            var precioHastaEmpty = string.IsNullOrEmpty(presupuesto.PrecioHasta);

            var isPrecioDesdeDecimal = decimal.TryParse(presupuesto.PrecioDesde, out decimal precioDesde);
            var isPrecioHastaDecimal = decimal.TryParse(presupuesto.PrecioHasta, out decimal precioHasta);

            if (!precioDesdeEmpty && !isPrecioDesdeDecimal)
            {
                return $"Precio Desde debe ser un numero decimal" + Environment.NewLine;
            }

            if (!precioHastaEmpty && !isPrecioHastaDecimal)
            {
                return $"Precio Hasta debe ser un numero decimal" + Environment.NewLine;
            }

            if (!precioDesdeEmpty)
            {
                if (precioDesde < 1 || precioDesde > 999999)
                {
                    return "El Precio Desde debe estar entre 1 y 999999" + Environment.NewLine;
                }
            }

            if (!precioHastaEmpty)
            {
                if (precioHasta < 1 || precioHasta > 999999)
                {
                    return "El Precio Hasta debe estar entre 1 y 999999" + Environment.NewLine;
                }
            }

            if (!precioDesdeEmpty && !precioHastaEmpty)
            {
                if (precioDesde >= precioHasta)
                {
                    return "El Precio Desde debe ser menor al Precio Hasta" + Environment.NewLine;
                }
            }

            return string.Empty;
        }

        public static string ValidarFechas(ProductosFilterDto presupuesto)
        {
            var fechaDesdeHasValue = presupuesto.FechaDesde.HasValue;
            var fechaHastaHasValue = presupuesto.FechaHasta.HasValue;

            if (fechaDesdeHasValue && presupuesto.FechaDesde.Value.Date < DateTime.Now.Date)
            {
                return "La Fecha Desde debe ser mayor a hoy" + Environment.NewLine;
            }

            if (fechaHastaHasValue && presupuesto.FechaHasta.Value.Date < DateTime.Now.Date)
            {
                return "La Fecha Hasta debe ser mayor a hoy" + Environment.NewLine;
            }

            if (fechaDesdeHasValue && fechaHastaHasValue && presupuesto.FechaDesde.Value.Date >= presupuesto.FechaHasta.Value.Date)
            {
                return "La Fecha Desde debe ser menor a la Fecha Hasta" + Environment.NewLine;
            }

            return string.Empty;
        }

        public static string ValidarFechasDeVuelos(ProductosFilterDto presupuesto)
        {
            var fechaDesdeHasValue = presupuesto.FechaDesde.HasValue;
            var fechaHastaHasValue = presupuesto.FechaHasta.HasValue;

            if (fechaDesdeHasValue && presupuesto.FechaDesde.Value.Date < DateTime.Now.Date)
            {
                return "La Fecha Desde debe ser mayor a hoy" + Environment.NewLine;
            }

            if (fechaHastaHasValue && presupuesto.FechaHasta.Value.Date < DateTime.Now.Date)
            {
                return "La Fecha Hasta debe ser mayor a hoy" + Environment.NewLine;
            }

            return string.Empty;
        }
    }
}
