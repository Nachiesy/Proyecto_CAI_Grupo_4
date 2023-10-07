using Proyecto_CAI_Grupo_4.Models;
using Proyecto_CAI_Grupo_4.Utils;
using System.Data;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarPresupuesto : Form
    {
        private static List<Presupuesto> presupuestos = new List<Presupuesto>()
        {
            new Presupuesto()
            {
                Id = 1,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                NombreDelServicio = "Promo Familias",
                CantidadDePasajerosAdultos = 2,
                CantidadDePasajerosMenores = 2,
                PrecioDesde = 10,
                PrecioHasta = 20,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
            },
            new Presupuesto()
            {
                Id = 2,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                NombreDelServicio = "Promo Familias",
                CantidadDePasajerosAdultos = 2,
                CantidadDePasajerosMenores = 2,
                PrecioDesde = 100,
                PrecioHasta = 200,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
            },
            new Presupuesto()
            {
                Id = 3,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                NombreDelServicio = "Promo Familias",
                CantidadDePasajerosAdultos = 2,
                CantidadDePasajerosMenores = 2,
                PrecioDesde = 200,
                PrecioHasta = 300,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
            },
            new Presupuesto()
            {
                Id = 4,
                TipoDeServicio = TipoDeServicioEnum.hotel,
                NombreDelServicio = "Promo Pareja",
                CantidadDePasajerosAdultos = 2,
                CantidadDePasajerosMenores = 0,
                PrecioDesde = 5,
                PrecioHasta = 10,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
            },
            new Presupuesto()
            {
                Id = 5,
                TipoDeServicio = TipoDeServicioEnum.crucero,
                NombreDelServicio = "Promo Amigos y Familia",
                CantidadDePasajerosAdultos = 10,
                CantidadDePasajerosMenores = 10,
                PrecioDesde = 100,
                PrecioHasta = 200,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
            },
        };

        private static List<Presupuesto> presupuestosFinalizar = new List<Presupuesto>();

        public GenerarPresupuesto()
        {
            InitializeComponent();
        }

        private void BuscarPresupuestos_Load(object sender, EventArgs e)
        {
            AddPresupuestosToListView(presupuestos, presupuestosBuscados);
        }

        private void buscarPresupuesto_Click(object sender, EventArgs e)
        {
            var presupuestoDto = new PresupuestoDto()
            {
                TipoDeServicio = tipoDeServicio.SelectedIndex,
                NombreDelServicio = nombreDelServicio.Text,
                CantidadDePasajerosAdultos = pasajerosAdultos.Text,
                CantidadDePasajerosMenores = pasajerosMenores.Text,
                PrecioDesde = precioDesde.Text,
                PrecioHasta = precioHasta.Text,
                FechaDesde = fechaDesde.Value,
                FechaHasta = fechaHasta.Value,
            };

            var validacion = ValidacionDePresupuesto(presupuestoDto);

            if (!string.IsNullOrEmpty(validacion))
            {
                MessageBox.Show(validacion, "Error", MessageBoxButtons.OK);
            }
            else
            {
                var filter = new Presupuesto(presupuestoDto);

                var searchedPresupuestos = presupuestos
                    .Where(x => x.TipoDeServicio == filter.TipoDeServicio
                                && (string.IsNullOrEmpty(filter.NombreDelServicio) || x.NombreDelServicio == filter.NombreDelServicio)
                                && x.CantidadDePasajerosAdultos == filter.CantidadDePasajerosAdultos
                                && x.CantidadDePasajerosMenores == filter.CantidadDePasajerosMenores
                                && (!filter.PrecioDesde.HasValue || x.PrecioDesde == filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.PrecioHasta == filter.PrecioHasta)
                                && filter.FechaDesde == x.FechaDesde
                                && filter.FechaHasta == x.FechaHasta)
                    .ToList();

                presupuestosBuscados.Items.Clear();

                AddPresupuestosToListView(searchedPresupuestos, presupuestosBuscados);

                if (!searchedPresupuestos.Any())
                {
                    MessageBox.Show("No hay productos disponibles para los parámetros ingresados.", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private string ValidacionDePresupuesto(PresupuestoDto presupuesto)
        {
            var messages = string.Empty;

            messages += ValidarTipoDeServicio(presupuesto.TipoDeServicio);

            messages += ValidarPrecios(presupuesto);

            messages += ValidarPasajerosAdultosMenores(presupuesto);

            messages += ValidarFechas(presupuesto);

            return messages;
        }

        private string ValidarTipoDeServicio(int tipoDeServicio)
        {
            var messages = string.Empty;

            if (tipoDeServicio == -1)
            {
                messages += "Debes seleccionar un Tipo de Servicio" + Environment.NewLine;
            }

            return messages;
        }

        private string ValidarPrecios(PresupuestoDto presupuesto)
        {
            var messages = string.Empty;

            var precioDesdeEmpty = string.IsNullOrEmpty(presupuesto.PrecioDesde);
            var precioHastaEmpty = string.IsNullOrEmpty(presupuesto.PrecioHasta);

            var isPrecioDesdeDecimal = decimal.TryParse(presupuesto.PrecioDesde, out decimal precioDesde);
            var isPrecioHastaDecimal = decimal.TryParse(presupuesto.PrecioHasta, out decimal precioHasta);

            var precioMin = (decimal)0;
            var precioMax = (decimal)999.999;

            if (!precioDesdeEmpty)
            {
                if (!isPrecioDesdeDecimal)
                {
                    messages += $"Precio Desde debe ser un numero decimal" + Environment.NewLine;
                }
                else if (precioDesde < precioMin || precioDesde > precioMax)
                {
                    messages += $"El Precio Desde debe estar entre {precioMin} y {precioMax}" + Environment.NewLine;
                }
            }

            if (!precioHastaEmpty)
            {
                if (!isPrecioHastaDecimal)
                {
                    messages += $"Precio Hasta debe ser un numero decimal" + Environment.NewLine;
                }
                else if (precioHasta < precioMin || precioHasta > precioMax)
                {
                    messages += $"El Precio Hasta debe estar entre {precioMin} y {precioMax}" + Environment.NewLine;
                }
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

        private string ValidarPasajerosAdultosMenores(PresupuestoDto presupuesto)
        {
            var messages = string.Empty;

            messages += ValidarPasajeros(presupuesto.CantidadDePasajerosAdultos, "Pasajeros Adultos", 1, 10);

            messages += ValidarPasajeros(presupuesto.CantidadDePasajerosMenores, "Pasajeros Menores", 0, 10);

            if (string.IsNullOrEmpty(messages))
            {
                var adultos = int.Parse(presupuesto.CantidadDePasajerosAdultos);
                var menores = int.Parse(presupuesto.CantidadDePasajerosMenores);

                if (menores > adultos)
                {
                    messages += "Los Pasajeros Menores deben ser menores o igual a los Pasajeros Adultos" + Environment.NewLine;
                }
            }

            return messages;
        }

        private string ValidarPasajeros(string pasajeros, string label, int cantidadMin, int cantidadMax)
        {
            var messages = string.Empty;

            if (!int.TryParse(pasajeros, out int cantidad))
            {
                messages += $"{label} debe ser un numero entero" + Environment.NewLine;
            }
            else if (cantidad < cantidadMin || cantidad > cantidadMax)
            {
                messages += $"{label} debe ser del {cantidadMin} al {cantidadMax}" + Environment.NewLine;
            }

            return messages;
        }

        private string ValidarFechas(PresupuestoDto presupuesto)
        {
            var messages = string.Empty;

            if (presupuesto.FechaDesde.Date <= DateTime.Now.Date)
            {
                messages += "La Fecha Desde debe ser mayor a hoy" + Environment.NewLine;
            }
            else if (presupuesto.FechaDesde.Date >= presupuesto.FechaHasta.Date)
            {
                messages += "La Fecha Desde debe ser menor a la Fecha Hasta" + Environment.NewLine;
            }

            return messages;
        }

        private void AddPresupuestosToListView(IEnumerable<Presupuesto> listToAdd, ListView listView)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.TipoDeServicio.GetDescription());
                row.SubItems.Add(item.NombreDelServicio);
                row.SubItems.Add(item.CantidadDePasajerosAdultos.ToString());
                row.SubItems.Add(item.CantidadDePasajerosMenores.ToString());
                row.SubItems.Add(item.PrecioDesde.ToString());
                row.SubItems.Add(item.PrecioHasta.ToString());
                row.SubItems.Add(item.FechaDesde.ToFormDate());
                row.SubItems.Add(item.FechaHasta.ToFormDate());

                listView.Items.Add(row);
            }
        }

        private void agregarPresupuesto_Click(object sender, EventArgs e)
        {
            if (presupuestosBuscados.SelectedItems.Count > 0)
            {
                var listToAdd = new List<Presupuesto>();

                foreach (ListViewItem selectedItem in presupuestosBuscados.SelectedItems)
                {
                    var id = int.Parse(selectedItem.Text);

                    var presupuesto = presupuestos.Where(x => x.Id == id).FirstOrDefault();

                    if (!presupuestosFinalizar.Any(x => x.Id == presupuesto.Id))
                    {
                        listToAdd.Add(presupuesto);
                    }
                }

                AddPresupuestosToListView(listToAdd, presupuestosElegidos);

                presupuestosFinalizar.AddRange(listToAdd);
            }
            else
            {
                MessageBox.Show("Ningun vuelo seleccionado para agregar al presupuesto.");
            }
        }

        private void removerPresupuesto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vuelo removido del presupuesto satisfactoriamente.");
        }

        private void finalizarPresupuesto_Click(object sender, EventArgs e)
        {

        }
    }
}
