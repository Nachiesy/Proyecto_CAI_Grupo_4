using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Managers;
using Proyecto_CAI_Grupo_4.Models.Productos;
using Proyecto_CAI_Grupo_4.Utils;
using System.Data;
using Proyecto_CAI_Grupo_4.Common.Views;

namespace Proyecto_CAI_Grupo_4
{
    public partial class ConsultarPaquetesTuristicos : VistaBase
    {
        public ConsultarPaquetesTuristicos() : base(tituloModulo: "Consultar Productos > Paquetes Turisticos")
        {
            InitializeComponent();
        }

        private void GenerarPresupuestoAereos_Load(object sender, EventArgs e)
        {
            datePickerFechaSalida.Checked = false;
            datePickerFechaSalida.Value = DateTime.Now.Date;
            datePickerFechaLlegada.Checked = false;
            datePickerFechaLlegada.Value = DateTime.Now.AddDays(1).Date;

            AddProductosToListView(GenerarPresupuestosManager.paquetesTuristicos, lstViewProductos);
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            var filterDto = new ProductosFilterDto()
            {
                PrecioDesde = txtBoxPrecioDesde.Text,
                PrecioHasta = txtBoxPrecioHasta.Text,
                FechaDesde = datePickerFechaSalida.Checked ? datePickerFechaSalida.Value : null,
                FechaHasta = datePickerFechaLlegada.Checked ? datePickerFechaLlegada.Value : null,
            };

            var validacion = ValidacionDeFiltros(filterDto);

            if (!string.IsNullOrEmpty(validacion))
            {
                MessageBox.Show(validacion, "Error", MessageBoxButtons.OK);
            }
            else
            {
                var filter = new ProductosFilter(filterDto);

                var productos = GenerarPresupuestosManager.paquetesTuristicos
                    .Where(x => (!filter.PrecioDesde.HasValue || x.Precio >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Precio <= filter.PrecioHasta)
                                && (!filter.FechaDesde.HasValue || x.FechaDesde == filter.FechaDesde)
                                && (!filter.FechaHasta.HasValue || x.FechaHasta == filter.FechaHasta));

                lstViewProductos.Items.Clear();

                AddProductosToListView(productos, lstViewProductos);

                if (!productos.Any())
                {
                    MessageBox.Show("No hay Paquetes disponibles para los parámetros ingresados.", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private string ValidacionDeFiltros(ProductosFilterDto presupuesto)
        {
            var messages = string.Empty;

            messages += ValidarPrecios(presupuesto);

            if (presupuesto.FechaDesde.HasValue && presupuesto.FechaHasta.HasValue)
            {
                messages += ValidarFechas(presupuesto);
            }

            return messages;
        }

        private string ValidarPrecios(ProductosFilterDto presupuesto)
        {
            var messages = string.Empty;

            var precioDesdeEmpty = string.IsNullOrEmpty(presupuesto.PrecioDesde);
            var precioHastaEmpty = string.IsNullOrEmpty(presupuesto.PrecioHasta);

            var isPrecioDesdeDecimal = decimal.TryParse(presupuesto.PrecioDesde, out decimal precioDesde);
            var isPrecioHastaDecimal = decimal.TryParse(presupuesto.PrecioHasta, out decimal precioHasta);

            if (!precioDesdeEmpty && !isPrecioDesdeDecimal)
            {
                messages += $"Precio Desde debe ser un numero decimal" + Environment.NewLine;
            }

            if (!precioHastaEmpty && !isPrecioHastaDecimal)
            {
                messages += $"Precio Hasta debe ser un numero decimal" + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(messages) && !precioDesdeEmpty && !precioHastaEmpty)
            {
                if (precioDesde >= precioHasta)
                {
                    messages += "El Precio Desde debe ser menor al Precio Hasta" + Environment.NewLine;
                }
            }

            return messages;
        }

        private string ValidarFechas(ProductosFilterDto presupuesto)
        {
            var messages = string.Empty;

            if (presupuesto.FechaDesde.Value.Date < DateTime.Now.Date)
            {
                messages += "La Fecha Desde debe ser mayor a hoy" + Environment.NewLine;
            }
            else if (presupuesto.FechaDesde.Value.Date >= presupuesto.FechaHasta.Value.Date)
            {
                messages += "La Fecha Desde debe ser menor a la Fecha Hasta" + Environment.NewLine;
            }

            return messages;
        }

        private void AddProductosToListView(IEnumerable<PaquetesTuristicos> listToAdd, ListView listView)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Nombre);
                row.SubItems.Add(item.Origen);
                row.SubItems.Add(item.Destino);
                row.SubItems.Add(item.Precio.ToString());
                row.SubItems.Add(item.FechaDesde.ToFormDate());
                row.SubItems.Add(item.FechaHasta.ToFormDate());

                listView.Items.Add(row);
            }
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            txtBoxPrecioDesde.Clear();
            txtBoxPrecioHasta.Clear();
            datePickerFechaSalida.Checked = false;
            datePickerFechaSalida.Value = DateTime.Now.Date;
            datePickerFechaLlegada.Checked = false;
            datePickerFechaLlegada.Value = DateTime.Now.AddDays(1).Date;

            btnBuscarProductos_Click(sender, e);
        }

        private void btnVolverMenuGenerarPresupuestos_Click(object sender, EventArgs e)
        {
            Close();

            Thread thread = new Thread(OpenMenuConsultarProductos);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenMenuConsultarProductos()
        {
            Application.Run(new ConsultarProductosMenu());
        }
    }
}
