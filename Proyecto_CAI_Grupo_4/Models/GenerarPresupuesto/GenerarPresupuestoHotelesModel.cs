using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Modules;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class GenerarPresupuestoHotelesModel
    {
        public static int PresupuestoId = 0;
        public static bool EsNuevo = true;

        public void InitComboBoxCiudad(ComboBox comboBox)
        {
            foreach (HotelesCiudadEnum value in Enum.GetValues(typeof(HotelesCiudadEnum)))
            {
                comboBox.Items.Add(value.GetDescription());
            }
        }

        public void InitComboBoxTipoDeHabitacion(ComboBox comboBox)
        {
            foreach (TipoDeHabitacionEnum value in Enum.GetValues(typeof(TipoDeHabitacionEnum)))
            {
                comboBox.Items.Add(value.GetDescription());
            }
        }

        public void InitComboBoxCalificacion(ComboBox comboBox)
        {
            foreach (HotelesCalificacionEnum value in Enum.GetValues(typeof(HotelesCalificacionEnum)))
            {
                comboBox.Items.Add(value.GetDescription());
            }
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

        public IEnumerable<Hoteles> GetHoteles(HotelesFilter filter)
        {
            return HotelesModule.GetHoteles(filter);
        }

        public IEnumerable<Hoteles> GetHotelesElegidos()
        {
            return HotelesModule.GetHotelesElegidos();
        }

        public void AddProductosToListView(ListView listView, IEnumerable<Hoteles> listToAdd)
        {
            foreach (var item in listToAdd)
            {

                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Codigo);
                row.SubItems.Add(item.Nombre);
                row.SubItems.Add(item.Ciudad.GetDescription());
                row.SubItems.Add(item.Direccion);
                row.SubItems.Add(item.Calificacion.GetDescription());
                row.SubItems.Add(item.Cantidad.ToString());
                row.SubItems.Add(item.TipoDeHabitacion.GetDescription());
                row.SubItems.Add(item.Precio.ToFormDecimal());
                row.SubItems.Add(item.CantidadDePersonas.ToString());
                row.SubItems.Add(item.CantidadMaximaDeAdultos.ToString());
                row.SubItems.Add(item.CantidadMaximaDeMenores.ToString());
                row.SubItems.Add(item.CantidadMaximaDeInfantes.ToString());
                row.SubItems.Add(item.FechaDesde.ToFormDate());
                row.SubItems.Add(item.FechaHasta.ToFormDate());

                listView.Items.Add(row);
            }
        }

        public void AddProductosSeleccionadosToListView(ListView listView, IEnumerable<Hoteles> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Codigo);
                row.SubItems.Add(item.Nombre);
                row.SubItems.Add(item.Ciudad.GetDescription());
                row.SubItems.Add(item.Direccion);
                row.SubItems.Add(item.Calificacion.GetDescription());
                // row.SubItems.Add(item.Cantidad.ToString()); NO MOSTRAR LA CANTIDAD
                row.SubItems.Add(item.TipoDeHabitacion.GetDescription());
                row.SubItems.Add(item.Precio.ToFormDecimal());
                row.SubItems.Add(item.CantidadDePersonas.ToString());
                row.SubItems.Add(item.CantidadMaximaDeAdultos.ToString());
                row.SubItems.Add(item.CantidadMaximaDeMenores.ToString());
                row.SubItems.Add(item.CantidadMaximaDeInfantes.ToString());
                row.SubItems.Add(item.FechaDesde.ToFormDate());
                row.SubItems.Add(item.FechaHasta.ToFormDate());

                listView.Items.Add(row);
            }
        }

        public Hoteles? GetProductoToAddToProductosSeleccionados(ListView listView, int id)
        {
            var producto = HotelesModule.GetHotelByID(id);

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

        public void ClearHotelesElegidos()
        {
            HotelesModule.ClearHotelesElegidos();
        }

        public void AddHotelElegido(int id)
        {
            HotelesModule.AddHotelElegido(id);
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
            Thread thread = new Thread(OpenGenerarPresupuestoMenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenGenerarPresupuestoMenu()
        {
            if (EsNuevo)
            {
                Application.Run(new GenerarPresupuestoMenu());
            }
            else
            {
                Application.Run(new GenerarPresupuestoMenu(new GenerarPresupuestoMenuParams()
                {
                    PresupuestoId = PresupuestoId,
                    EsNuevo = EsNuevo,
                    InitBuscarPresupuesto = false,
                }));
            }
        }
    }
}
