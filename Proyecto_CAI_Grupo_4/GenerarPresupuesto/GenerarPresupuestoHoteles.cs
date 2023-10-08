using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Managers;
using Proyecto_CAI_Grupo_4.Models.Productos;
using Proyecto_CAI_Grupo_4.Utils;
using System.Data;
using Proyecto_CAI_Grupo_4.Common.Views;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarPresupuestoHoteles : VistaBase
    {
        public GenerarPresupuestoHoteles() : base(tituloModulo: "Generar Presupuesto > Hoteles")
        {
            InitializeComponent();
        }

        private void GenerarPresupuestoHoteles_Load(object sender, EventArgs e)
        {
            datePickerFilterFechaDesde.Checked = false;
            datePickerFilterFechaDesde.Value = DateTime.Now.Date;
            datePickerFilterFechaHasta.Checked = false;
            datePickerFilterFechaHasta.Value = DateTime.Now.AddDays(1).Date;

            AddProductosToDataGridViewProductos(GenerarPresupuestosManager.hoteles.Where(x => x.Cantidad > 0));

            AddProductosSeleccionadosToDataGridView(GenerarPresupuestosManager.hotelesElegidos);
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            var filterDto = new HotelesFilterDto()
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
                var filter = new HotelesFilter(filterDto);

                var productos = GenerarPresupuestosManager.hoteles
                    .Where(x => x.Cantidad > 0
                                && (!filter.PrecioDesde.HasValue || x.Precio >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Precio <= filter.PrecioHasta)
                                && (!filter.FechaDesde.HasValue || x.FechaDesde == filter.FechaDesde)
                                && (!filter.FechaHasta.HasValue || x.FechaHasta == filter.FechaHasta));

                dataGridViewProductos.Rows.Clear();

                AddProductosToDataGridViewProductos(productos);

                if (!productos.Any())
                {
                    MessageBox.Show("No hay Hoteles disponibles para los parámetros ingresados.", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private string ValidacionDeFiltros(HotelesFilterDto presupuesto)
        {
            var messages = string.Empty;

            messages += ValidarPrecios(presupuesto);

            if (presupuesto.FechaDesde.HasValue && presupuesto.FechaHasta.HasValue)
            {
                messages += ValidarFechas(presupuesto);
            }

            return messages;
        }

        private string ValidarPrecios(HotelesFilterDto presupuesto)
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

        private string ValidarFechas(HotelesFilterDto presupuesto)
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

        private void AddProductosToDataGridViewProductos(IEnumerable<Hoteles> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Id.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Nombre });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Precio.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Cantidad.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.FechaDesde.ToFormDate() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.FechaHasta.ToFormDate() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Ciudad });

                dataGridViewProductos.Rows.Add(row);
            }
        }

        private void AddProductosSeleccionadosToDataGridView(IEnumerable<Hoteles> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Id.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Nombre });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Precio.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Cantidad.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = 1.ToString() }); // Cantidad Seleccionada
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Precio.ToString() }); // Sub Total
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.FechaDesde.ToFormDate() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.FechaHasta.ToFormDate() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Ciudad });

                dataGridViewProductosSeleccionados.Rows.Add(row);
            }
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.SelectedRows.Count > 0)
            {
                var productosToAdd = new List<Hoteles>();

                foreach (DataGridViewRow row in dataGridViewProductos.SelectedRows)
                {
                    var idCellIndex = 0;

                    var id = Guid.Parse(row.Cells[idCellIndex].Value.ToString());

                    var producto = GenerarPresupuestosManager.hoteles.Where(x => x.Id == id).SingleOrDefault();

                    if (!IsProductInDataGridViewProductosSeleccionados(id))
                    {
                        productosToAdd.Add(producto);
                    }
                }

                AddProductosSeleccionadosToDataGridView(productosToAdd);
            }
            else
            {
                MessageBox.Show("Ningun hotel seleccionado para agregar al presupuesto.");
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
                MessageBox.Show("Ningun hotel seleccionado para remover del presupuesto.");
            }
        }

        private void btnConfirmarProductosSeleccionados_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductosSeleccionados.RowCount > 0)
            {
                GenerarPresupuestosManager.hotelesElegidos.Clear();

                foreach (DataGridViewRow row in dataGridViewProductosSeleccionados.Rows)
                {
                    var idCellIndex = 0;
                    var cantidadSeleccionadaColumnIndex = 4;
                    var subTotalColumnIndex = 5;

                    var id = Guid.Parse(row.Cells[idCellIndex].Value.ToString());

                    var producto = GenerarPresupuestosManager.hoteles.Where(x => x.Id == id).SingleOrDefault();

                    producto.CantidadSeleccionada = int.Parse(row.Cells[cantidadSeleccionadaColumnIndex].Value.ToString());
                    producto.SubTotal = decimal.Parse(row.Cells[subTotalColumnIndex].Value.ToString());

                    GenerarPresupuestosManager.hotelesElegidos.Add(producto);
                }

                this.Close();

                Thread thread = new Thread(OpenMenuGenerarPresupuesto);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("Debes seleccionar Hoteles para poder confirmar el presupuesto");
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
            var cantidadSeleccionadaColumnIndex = 4;

            if (e.RowIndex >= 0 && e.ColumnIndex == cantidadSeleccionadaColumnIndex)
            {
                var dataGridView = sender as DataGridView;

                // ID
                var idColumnIndex = 0;
                var idCell = dataGridView.Rows[e.RowIndex].Cells[idColumnIndex];
                var id = idCell.Value.ToString();

                // Precio
                var precioColumnIndex = 2;
                var precioCell = dataGridView.Rows[e.RowIndex].Cells[precioColumnIndex];
                var precio = decimal.Parse(precioCell.Value.ToString());

                // Cantidad Disponible
                var cantidadDisponibleColumnIndex = 3;
                var cantidadDisponibleCell = dataGridView.Rows[e.RowIndex].Cells[cantidadDisponibleColumnIndex];
                var cantidadDisponible = int.Parse(cantidadDisponibleCell.Value.ToString());

                // Cantidad Seleccionada
                var cantidadSeleccionadaCell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var isCantidadSeleccionadaValid = int.TryParse(cantidadSeleccionadaCell.Value.ToString(), out int cantidadSeleccionada);

                // SubTotal
                var subTotalColumnIndex = 5;
                var subTotalCell = dataGridView.Rows[e.RowIndex].Cells[subTotalColumnIndex];

                var validation = ValidarCantidadSeleccionada(id, isCantidadSeleccionadaValid, cantidadSeleccionada, cantidadDisponible);

                if (string.IsNullOrEmpty(validation))
                {
                    subTotalCell.Value = precio * cantidadSeleccionada;
                }
                else
                {
                    cantidadSeleccionadaCell.Value = 1;
                    subTotalCell.Value = precioCell.Value;

                    MessageBox.Show(validation, "Error");
                }

                dataGridView.Refresh();
            }
        }

        private string ValidarCantidadSeleccionada(string id, bool isCantidadSeleccionadaValid, int? cantidadSeleccionada, int cantidadDisponible)
        {
            if (!isCantidadSeleccionadaValid)
            {
                return $"La Cantidad para el Hotel con ID [{id}] debe ser un numero entero.";
            }

            if (cantidadDisponible < cantidadSeleccionada)
            {
                return $"La Cantidad Seleccionada para el Hotel con ID [{id}] debe ser un menor o igual a la Cantidad Disponible.";
            }

            if (cantidadSeleccionada <= 0)
            {
                return $"La Cantidad Seleccionada para el Hotel con ID [{id}] debe ser mayor a 0.";
            }

            return string.Empty;
        }
    }
}
