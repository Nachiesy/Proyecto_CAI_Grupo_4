using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Modules;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class GenerarPresupuestoAereosModel
    {
        public void InitComboBoxOrigen(ComboBox comboBox)
        {
            foreach (AereosOrigenEnum value in Enum.GetValues(typeof(AereosOrigenEnum)))
            {
                comboBox.Items.Add(value.GetDescription());
            }
        }

        public void InitComboBoxDestino(ComboBox comboBox)
        {
            foreach (AereosDestinoEnum value in Enum.GetValues(typeof(AereosDestinoEnum)))
            {
                comboBox.Items.Add(value.GetDescription());
            }
        }

        public void InitComboBoxTipoDePasajero(ComboBox comboBox)
        {
            foreach (TipoDePasajeroEnum value in Enum.GetValues(typeof(TipoDePasajeroEnum)))
            {
                comboBox.Items.Add(value.GetDescription());
            }
        }

        public void InitComboBoxItinerario(ComboBox comboBox)
        {
            foreach (AereosItinerarioEnum value in Enum.GetValues(typeof(AereosItinerarioEnum)))
            {
                comboBox.Items.Add(value.GetDescription());
            }
        }

        public void InitComboBoxClase(ComboBox comboBox)
        {
            foreach (TipoDeClaseAereaEnum value in Enum.GetValues(typeof(TipoDeClaseAereaEnum)))
            {
                comboBox.Items.Add(value.GetDescription());
            }
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

        public IEnumerable<Aereos> GetAereos(AereosFilter filter)
        {
            return AereosModule.GetAereos(filter);
        }

        public IEnumerable<Aereos> GetAereosElegidos()
        {
            return AereosModule.GetAereosElegidos();
        }

        public void AddProductosToListView(ListView listView, IEnumerable<Aereos> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Codigo);
                row.SubItems.Add(item.Origen.GetDescription());
                row.SubItems.Add(item.Destino.GetDescription());
                row.SubItems.Add(item.Clase.GetDescription());
                row.SubItems.Add(item.Itinerario.GetDescription());
                row.SubItems.Add(item.Cantidad.ToString());
                row.SubItems.Add(item.TipoDePasajero.GetDescription());
                row.SubItems.Add(item.Precio.ToFormDecimal());
                row.SubItems.Add(item.Aerolinea.GetDescription());
                row.SubItems.Add(item.Paradas.Count().ToString());
                row.SubItems.Add(item.FechaDeSalida.ToFormVueloDate());
                row.SubItems.Add(item.FechaDeLlegada.ToFormVueloDate());

                listView.Items.Add(row);
            }
        }

        public void AddProductosSeleccionadosToListView(ListView listView, IEnumerable<Aereos> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Codigo);
                row.SubItems.Add(item.Origen.GetDescription());
                row.SubItems.Add(item.Destino.GetDescription());
                row.SubItems.Add(item.Clase.GetDescription());
                row.SubItems.Add(item.Itinerario.GetDescription());
                // row.SubItems.Add(item.Cantidad.ToString()); NO MOSTRAR CANTIDAD
                row.SubItems.Add(item.TipoDePasajero.GetDescription());
                row.SubItems.Add(item.Precio.ToFormDecimal());
                row.SubItems.Add(item.Aerolinea.GetDescription());
                row.SubItems.Add(item.Paradas.Count().ToString());
                row.SubItems.Add(item.FechaDeSalida.ToFormVueloDate());
                row.SubItems.Add(item.FechaDeLlegada.ToFormVueloDate());

                listView.Items.Add(row);
            }
        }

        public Aereos? GetProductoToAddToProductosSeleccionados(ListView listView, int id)
        {
            var producto = AereosModule.GetAereoByID(id);

            var cantidad = GetCantidadSeleccionadaDelProducto(listView, producto.Id);

            if (producto.Cantidad > cantidad)
            {
                return producto;
            }

            return null;
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

        public void LimpiarTextBox(TextBox textBox)
        {
            textBox.Clear();
        }

        public void LimpiarComboBox(ComboBox comboBox)
        {
            comboBox.SelectedIndex = -1;
        }

        public void DisableDatePicker(DateTimePicker dateTimePicker, Button btnDisable)
        {
            if (dateTimePicker.Enabled)
            {
                dateTimePicker.Enabled = false;
                btnDisable.Text = "Habilitar";
            }
            else
            {
                dateTimePicker.Enabled = true;
                btnDisable.Text = "Deshabilitar";
            }
        }

        public void GoToGenerarPresupuestoMenu()
        {
            GenerarPresupuestoMenuModel.InitBuscarPresupuesto = false;

            Thread thread = new Thread(GenerarPresupuestoMenuModel.OpenGenerarPresupuestoMenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public static void OpenGenerarPresupuestoAereos()
        {
            Application.Run(new GenerarPresupuestoAereos());
        }
    }
}
