using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Modules;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class GenerarPresupuestoAereosModel
    {
        public IEnumerable<string> GetOrigenes()
        {
            return AereosModule.GetAereos().Select(p => p.Origen).Distinct();
        }

        public IEnumerable<string> GetDestinos()
        {
            return AereosModule.GetAereos().Select(p => p.Destino).Distinct();
        }

        public IEnumerable<string> GetTipoDePasajeros()
        {
            return AereosModule.GetAereos().Select(p => p.Tarifa.TipoDePasajero).Distinct();
        }

        public IEnumerable<string> GetClases()
        {
            return AereosModule.GetAereos().Select(p => p.Tarifa.Clase).Distinct();
        }

        public string ValidacionDeFiltros(AereosFilter filter)
        {
            var messages = string.Empty;

            messages += ValidarPrecios(filter);

            messages += ValidarFechas(filter);

            return messages;
        }

        private string ValidarPrecios(AereosFilter filter)
        {
            var precioDesdeEmpty = string.IsNullOrEmpty(filter.PrecioDesdeInput);
            var precioHastaEmpty = string.IsNullOrEmpty(filter.PrecioHastaInput);

            var isPrecioDesdeDecimal = decimal.TryParse(filter.PrecioDesdeInput, out decimal precioDesde);
            var isPrecioHastaDecimal = decimal.TryParse(filter.PrecioHastaInput, out decimal precioHasta);

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

        private string ValidarFechas(AereosFilter filter)
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

            return string.Empty;
        }

        public IEnumerable<AereoEnt> GetAereos(AereosFilter filter)
        {
            return AereosModule.GetAereos()
                .Where(x => (!filter.CantidadMin.HasValue || x.Tarifa.Disponibilidad >= filter.CantidadMin)
                                && (!filter.PrecioDesde.HasValue || x.Tarifa.Precio >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Tarifa.Precio <= filter.PrecioHasta)
                                && (!filter.FechaDesde.HasValue || x.FechaDeSalida.Date == filter.FechaDesde)
                                && (!filter.FechaHasta.HasValue || x.FechaDeLlegada.Date == filter.FechaHasta)
                                && (string.IsNullOrEmpty(filter.Origen) || x.Origen == filter.Origen)
                                && (string.IsNullOrEmpty(filter.Destino) || x.Destino == filter.Destino)
                                && (string.IsNullOrEmpty(filter.TipoDePasajero) || x.Tarifa.TipoDePasajero == filter.TipoDePasajero)
                                && (string.IsNullOrEmpty(filter.Clase) || x.Tarifa.Clase == filter.Clase));
        }

        public IEnumerable<AereoEnt> GetAereosElegidos()
        {
            return AereosModule.GetAereosElegidos();
        }

        public AereoEnt? GetProductoToAddToProductosSeleccionados(ListView listView, int id)
        {
            var producto = AereosModule.GetAereoByID(id);

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

        public void ClearAereosElegidos()
        {
            AereosModule.ClearAereosElegidos();
        }

        public void AddAereoElegido(int id)
        {
            AereosModule.AddAereoElegido(id);
        }

        public void GoToGenerarPresupuestoMenu()
        {
            GenerarPresupuestoMenuModel.InitBuscarPresupuesto = false;

            Thread thread = new Thread(GenerarPresupuestoMenuModel.OpenGenerarPresupuestoMenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
