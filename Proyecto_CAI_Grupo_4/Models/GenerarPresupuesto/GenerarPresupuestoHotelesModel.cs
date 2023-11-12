using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Modules;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class GenerarPresupuestoHotelesModel
    {
        public IEnumerable<string> GetCiudades()
        {
            return HotelesModule.GetHoteles().Select(p => p.Ciudad).Distinct();
        }

        public IEnumerable<string> GetHabitaciones()
        {
            return HotelesModule.GetHoteles().Select(p => p.Disponibilidad.NombreHabitacion).Distinct();
        }

        public IEnumerable<string> GetCalificaciones()
        {
            return HotelesModule.GetHoteles().Select(p => p.Calificacion).Distinct();
        }

        public string ValidacionDeFiltros(HotelesFilter filter)
        {
            var messages = string.Empty;

            messages += ValidarPrecios(filter);

            messages += ValidarFechas(filter);

            return messages;
        }

        private string ValidarPrecios(HotelesFilter filter)
        {
            var precioDesdeEmpty = string.IsNullOrEmpty(filter.PrecioDesdeInput);
            var precioHastaEmpty = string.IsNullOrEmpty(filter.PrecioHastaInput);

            var isPrecioDesdeDecimal = decimal.TryParse(filter.PrecioDesdeInput, out decimal precioDesde);
            var isPrecioHastaDecimal = decimal.TryParse(filter.PrecioHastaInput, out decimal precioHasta);

            if (!precioDesdeEmpty && !isPrecioDesdeDecimal)
            {
                return $"El Precio Desde debe ser un número decimal" + Environment.NewLine;
            }

            if (!precioHastaEmpty && !isPrecioHastaDecimal)
            {
                return $"El Precio Hasta debe ser un número decimal" + Environment.NewLine;
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

        private string ValidarFechas(HotelesFilter filter)
        {
            var fechaDesdeHasValue = filter.FechaDesde.HasValue;
            var fechaHastaHasValue = filter.FechaHasta.HasValue;

            if (fechaDesdeHasValue && filter.FechaDesde.Value.Date < DateTime.Now.Date)
            {
                return "La Fecha Desde debe ser mayor a hoy" + Environment.NewLine;
            }

            if (fechaHastaHasValue && filter.FechaHasta.Value.Date < DateTime.Now.Date)
            {
                return "La Fecha Hasta debe ser mayor a hoy" + Environment.NewLine;
            }

            if (fechaDesdeHasValue && fechaHastaHasValue && filter.FechaDesde.Value.Date >= filter.FechaHasta.Value.Date)
            {
                return "La Fecha Desde debe ser menor a la Fecha Hasta" + Environment.NewLine;
            }

            return string.Empty;
        }

        public IEnumerable<HotelEnt> GetHoteles(HotelesFilter filter)
        {
            return HotelesModule.GetHoteles()
                .Where(x => (!filter.CantidadMin.HasValue || x.Disponibilidad.Disponibilidad >= filter.CantidadMin)
                                && (!filter.PrecioDesde.HasValue || x.Disponibilidad.TarifaPorDia >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Disponibilidad.TarifaPorDia <= filter.PrecioHasta)
                                && (!filter.FechaDesde.HasValue || x.Disponibilidad.FechaDesde == filter.FechaDesde)
                                && (!filter.FechaHasta.HasValue || x.Disponibilidad.FechaHasta == filter.FechaHasta)
                                && (string.IsNullOrEmpty(filter.Nombre) || x.Nombre == filter.Nombre)
                                && (string.IsNullOrEmpty(filter.Ciudad) || x.Ciudad == filter.Ciudad)
                                && (string.IsNullOrEmpty(filter.TipoDeHabitacion) || x.Disponibilidad.NombreHabitacion == filter.TipoDeHabitacion)
                                && (string.IsNullOrEmpty(filter.Calificacion) || x.Calificacion == filter.Calificacion));
        }

        public IEnumerable<HotelEnt> GetHotelesElegidos()
        {
            return HotelesModule.GetHotelesElegidos();
        }

        public HotelEnt? GetProductoToAddToProductosSeleccionados(ListView listView, int id)
        {
            var producto = HotelesModule.GetHotelByID(id);

            return producto;

            //var cantidad = GetCantidadSeleccionadaDelProducto(listView, producto.Id);

            // if (producto.Tarifa.Disponibilidad > cantidad)
            // {
            // return producto;
            // }

            // return null;
        }

        private int GetCantidadSeleccionadaDelProducto(ListView listView, int id)
        {
            var selectedIDs = new List<int>();

            foreach (ListViewItem item in listView.Items)
            {
                var selectedID = int.Parse(item.Text);

                if (selectedID == id)
                {
                    selectedIDs.Add(selectedID);
                }
            }

            return selectedIDs.Count();
        }

        public void ClearHotelesElegidos()
        {
            HotelesModule.ClearHotelesElegidos();
        }

        public void AddHotelElegido(int id)
        {
            HotelesModule.AddHotelElegido(id);
        }

        public GenerarPresupuestoParams GetGenerarPresupuestoParams()
        {
            return PresupuestosModule.GetGenerarPresupuestoParams();
        }

        public void SetGenerarPresupuestoParams(GenerarPresupuestoParams generarPresupuestoParams)
        {
            PresupuestosModule.SetGenerarPresupuestoParams(generarPresupuestoParams);
        }
    }
}
