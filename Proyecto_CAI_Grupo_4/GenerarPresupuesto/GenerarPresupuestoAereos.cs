using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Managers;
using Proyecto_CAI_Grupo_4.Models.Productos;
using Proyecto_CAI_Grupo_4.Utils;
using System.Data;
using Proyecto_CAI_Grupo_4.Common.Views;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarPresupuestoAereos : VistaBase
    {
        public GenerarPresupuestoAereos() : base(tituloModulo: "Generar Presupuesto > Aereos")
        {
            InitializeComponent();
        }

        private void GenerarPresupuestoAereos_Load(object sender, EventArgs e)
        {
            datePickerFilterFechaDesde.Checked = false;
            datePickerFilterFechaDesde.Value = DateTime.Now.Date;
            datePickerFilterFechaHasta.Checked = false;
            datePickerFilterFechaHasta.Value = DateTime.Now.AddDays(1).Date;

            AddProductosToDataGridViewProductos(GenerarPresupuestosManager.aereos.Where(x => x.Cantidad > 0));

            AddProductosSeleccionadosToDataGridView(GenerarPresupuestosManager.aereosElegidos);
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            var filterDto = new AereosFilterDto()
            {
                PrecioDesde = txtBoxFiltroPrecioDesde.Text,
                PrecioHasta = txtBoxFiltroPrecioHasta.Text,
                FechaDesde = datePickerFilterFechaDesde.Checked ? datePickerFilterFechaDesde.Value : null,
                FechaHasta = datePickerFilterFechaHasta.Checked ? datePickerFilterFechaHasta.Value : null,
            };

            var validacion = ValidacionDeFiltros(filterDto);

            if (!string.IsNullOrEmpty(validacion))
            {
                MessageBox.Show(validacion, "Error", MessageBoxButtons.OK);
            }
            else
            {
                var filter = new AereosFilter(filterDto);

                var productos = GenerarPresupuestosManager.aereos
                    .Where(x => x.Cantidad > 0
                                && (!filter.PrecioDesde.HasValue || x.Precio >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Precio <= filter.PrecioHasta)
                                && (!filter.FechaDesde.HasValue || x.FechaDeSalida == filter.FechaDesde)
                                && (!filter.FechaHasta.HasValue || x.FechaDeLlegada == filter.FechaHasta));

                dataGridViewProductos.Rows.Clear();

                AddProductosToDataGridViewProductos(productos);

                if (!productos.Any())
                {
                    MessageBox.Show("No hay Vuelos disponibles para los parámetros ingresados.", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private string ValidacionDeFiltros(AereosFilterDto presupuesto)
        {
            var messages = string.Empty;

            messages += ValidarPrecios(presupuesto);

            if (presupuesto.FechaDesde.HasValue && presupuesto.FechaHasta.HasValue)
            {
                messages += ValidarFechas(presupuesto);
            }

            return messages;
        }

        private string ValidarPrecios(AereosFilterDto presupuesto)
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

        private string ValidarFechas(AereosFilterDto presupuesto)
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

        private void AddProductosToDataGridViewProductos(IEnumerable<Aereos> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Id.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Nombre });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.PrecioAdultos.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.PrecioMenores.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Cantidad.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.FechaDeSalida.ToFormDate() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.FechaDeLlegada.ToFormDate() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Origen });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Destino });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.TipoDeClaseAerea.GetDescription() });

                dataGridViewProductos.Rows.Add(row);
            }
        }

        private void AddProductosSeleccionadosToDataGridView(IEnumerable<Aereos> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Id.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Nombre });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.PrecioAdultos.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.PrecioMenores.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Cantidad.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = 1.ToString() }); // Cantidad Seleccionada Adultos
                row.Cells.Add(new DataGridViewTextBoxCell { Value = 0.ToString() }); // Cantidad Seleccionada Menores
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.PrecioAdultos.ToString() }); // Sub Total
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.FechaDeSalida.ToFormDate() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.FechaDeLlegada.ToFormDate() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Origen });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Destino });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.TipoDeClaseAerea.GetDescription() });

                dataGridViewProductosSeleccionados.Rows.Add(row);
            }
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.SelectedRows.Count > 0)
            {
                var productosToAdd = new List<Aereos>();

                foreach (DataGridViewRow row in dataGridViewProductos.SelectedRows)
                {
                    var idCellIndex = 0;

                    var id = Guid.Parse(row.Cells[idCellIndex].Value.ToString());

                    var producto = GenerarPresupuestosManager.aereos.Where(x => x.Id == id).SingleOrDefault();

                    if (!IsProductInDataGridViewProductosSeleccionados(id))
                    {
                        productosToAdd.Add(producto);
                    }
                }

                AddProductosSeleccionadosToDataGridView(productosToAdd);
            }
            else
            {
                MessageBox.Show("Ningun vuelo seleccionado para agregar al presupuesto.");
            }
        }

        private void btnRemoverProductos_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductosSeleccionados.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewProductosSeleccionados.SelectedRows)
                {
                    dataGridViewProductosSeleccionados.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Ningun vuelo seleccionado para remover del presupuesto.");
            }
        }

        private void btnConfirmarProductosSeleccionados_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductosSeleccionados.RowCount > 0)
            {
                GenerarPresupuestosManager.aereosElegidos.Clear();

                foreach (DataGridViewRow row in dataGridViewProductosSeleccionados.Rows)
                {
                    var idCellIndex = 0;
                    var cantidadSeleccionadaColumnIndex = 4;
                    var subTotalColumnIndex = 5;

                    var id = Guid.Parse(row.Cells[idCellIndex].Value.ToString());

                    var producto = GenerarPresupuestosManager.aereos.Where(x => x.Id == id).SingleOrDefault();

                    producto.CantidadSeleccionada = int.Parse(row.Cells[cantidadSeleccionadaColumnIndex].Value.ToString());
                    producto.SubTotal = decimal.Parse(row.Cells[subTotalColumnIndex].Value.ToString());

                    GenerarPresupuestosManager.aereosElegidos.Add(producto);
                }

                this.Close();

                Thread thread = new Thread(OpenMenuGenerarPresupuesto);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("Debes seleccionar Vuelos para poder confirmar el presupuesto");
            }
        }

        private void btnVolverAlMenuGenerarPresupuestos_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(OpenMenuGenerarPresupuesto);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenMenuGenerarPresupuesto()
        {
            Application.Run(new GenerarPresupuestoMenu());
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            txtBoxFiltroPrecioDesde.Clear();
            txtBoxFiltroPrecioHasta.Clear();
            datePickerFilterFechaDesde.Checked = false;
            datePickerFilterFechaDesde.Value = DateTime.Now.Date;
            datePickerFilterFechaHasta.Checked = false;
            datePickerFilterFechaHasta.Value = DateTime.Now.AddDays(1).Date;

            btnBuscarProductos_Click(sender, e);
        }

        private bool IsProductInDataGridViewProductosSeleccionados(Guid id)
        {
            var idList = new List<Guid>();

            foreach (DataGridViewRow row in dataGridViewProductosSeleccionados.Rows)
            {
                var idCellIndex = 0;

                var selectedId = Guid.Parse(row.Cells[idCellIndex].Value.ToString());

                idList.Add(selectedId);
            }

            return idList.Any(x => x == id);
        }

        private void dataGridViewProductosSeleccionados_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var cantidadSeleccionadaAdultosColumnIndex = 5;
            var cantidadSeleccionadaMenoresColumnIndex = 6;

            var precioAdultosChanged = e.ColumnIndex == cantidadSeleccionadaAdultosColumnIndex;
            var precioMenoresChanged = e.ColumnIndex == cantidadSeleccionadaMenoresColumnIndex;

            if (e.RowIndex >= 0 && (precioAdultosChanged || precioMenoresChanged))
            {
                var dataGridView = sender as DataGridView;

                // ID
                var idColumnIndex = 0;
                var idCell = dataGridView.Rows[e.RowIndex].Cells[idColumnIndex];
                var id = idCell.Value.ToString();

                // Precio Adultos
                var precioAdultosColumnIndex = 2;
                var precioAdultosCell = dataGridView.Rows[e.RowIndex].Cells[precioAdultosColumnIndex];
                var precioAdultos = decimal.Parse(precioAdultosCell.Value.ToString());

                // Precio Menores
                var precioMenoresColumnIndex = 3;
                var precioMenoresCell = dataGridView.Rows[e.RowIndex].Cells[precioMenoresColumnIndex];
                var precioMenores = decimal.Parse(precioMenoresCell.Value.ToString());

                // Cantidad Disponible
                var cantidadDisponibleColumnIndex = 4;
                var cantidadDisponibleCell = dataGridView.Rows[e.RowIndex].Cells[cantidadDisponibleColumnIndex];
                var cantidadDisponible = int.Parse(cantidadDisponibleCell.Value.ToString());

                // Cantidad Seleccionada Adultos
                var cantidadSeleccionadaAdultosCell = dataGridView.Rows[e.RowIndex].Cells[cantidadSeleccionadaAdultosColumnIndex];
                var isCantidadSeleccionadaAdultosValid = int.TryParse(cantidadSeleccionadaAdultosCell.Value.ToString(), out int cantidadSeleccionadaAdultos);

                // Cantidad Seleccionada Menores
                var cantidadSeleccionadaMenoresCell = dataGridView.Rows[e.RowIndex].Cells[cantidadSeleccionadaMenoresColumnIndex];
                var isCantidadSeleccionadaMenoresValid = int.TryParse(cantidadSeleccionadaMenoresCell.Value.ToString(), out int cantidadSeleccionadaMenores);

                // SubTotal
                var subTotalColumnIndex = 7;
                var subTotalCell = dataGridView.Rows[e.RowIndex].Cells[subTotalColumnIndex];

                if (precioAdultosChanged)
                {
                    cantidadDisponible = cantidadDisponible - cantidadSeleccionadaMenores;

                    var validacion = ValidarCantidadSeleccionada(id, isCantidadSeleccionadaAdultosValid, cantidadSeleccionadaAdultos, cantidadDisponible, 1, "Adultos");

                    if (string.IsNullOrEmpty(validacion))
                    {
                        subTotalCell.Value = (precioAdultos * cantidadSeleccionadaAdultos) + (precioMenores * cantidadSeleccionadaMenores);
                    }
                    else
                    {
                        cantidadSeleccionadaAdultosCell.Value = 1;
                        subTotalCell.Value = precioAdultos + (precioMenores * cantidadSeleccionadaMenores);

                        MessageBox.Show(validacion, "Error");
                    }
                }

                if (precioMenoresChanged)
                {
                    cantidadDisponible = cantidadDisponible - cantidadSeleccionadaAdultos;

                    var validacion = ValidarCantidadSeleccionada(id, isCantidadSeleccionadaMenoresValid, cantidadSeleccionadaMenores, cantidadDisponible, 0, "Menores");

                    if (string.IsNullOrEmpty(validacion))
                    {
                        subTotalCell.Value = (precioAdultos * cantidadSeleccionadaAdultos) + (precioMenores * cantidadSeleccionadaMenores);
                    }
                    else
                    {
                        cantidadSeleccionadaMenoresCell.Value = 0;
                        subTotalCell.Value = precioAdultos * cantidadSeleccionadaAdultos;

                        MessageBox.Show(validacion, "Error");
                    }
                }

                dataGridView.Refresh();
            }
        }

        private string ValidarCantidadSeleccionada(string id, bool isCantidadSeleccionadaValid, int? cantidadSeleccionada, int cantidadDisponible, int cantidadSeleccionadaMinima, string label)
        {
            if (!isCantidadSeleccionadaValid)
            {
                return $"La Cantidad Seleccionada de {label} para el Vuelo con ID [{id}] debe ser un numero entero.";
            }

            if (cantidadDisponible < cantidadSeleccionada)
            {
                return $"La Cantidad Seleccionada de {label} para el Vuelo con ID [{id}] supera la Cantidad Disponible.";
            }

            if (cantidadSeleccionada < cantidadSeleccionadaMinima)
            {
                return $"La Cantidad Seleccionada de {label} para el Vuelo con ID [{id}] no puede ser menor a {cantidadSeleccionadaMinima}.";
            }

            return string.Empty;
        }
    }
}
