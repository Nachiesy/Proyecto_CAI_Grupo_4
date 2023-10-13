using Proyecto_CAI_Grupo_4.Filters;
using Proyecto_CAI_Grupo_4.Managers;
using Proyecto_CAI_Grupo_4.Models.Productos;
using Proyecto_CAI_Grupo_4.Utils;
using System.Data;
using Proyecto_CAI_Grupo_4.Common.Views;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarPresupuestoPaquetesTuristicos : VistaBase
    {
        private readonly int idColumnIndex = 0;
        private readonly int precioColumnIndex = 3;
        private readonly int cantidadDisponibleColumnIndex = 4;
        private readonly int cantidadSeleccionadaColumnIndex = 5;
        private readonly int subTotalColumnIndex = 6;

        public GenerarPresupuestoPaquetesTuristicos() : base(tituloModulo: "Generar Presupuesto > Paquetes Turísticos")
        {
            InitializeComponent();
        }

        private void GenerarPresupuestoPaquetesTuristicos_Load(object sender, EventArgs e)
        {
            datePickerFilterFechaDesde.Value = DateTime.Now.Date;
            datePickerFilterFechaHasta.Value = DateTime.Now.AddDays(1).Date;

            foreach (PaquetesTuristicosOrigenEnum value in Enum.GetValues(typeof(PaquetesTuristicosOrigenEnum)))
            {
                comboBoxOrigen.Items.Add(value.GetDescription());
            }

            foreach (PaquetesTuristicosDestinoEnum value in Enum.GetValues(typeof(PaquetesTuristicosDestinoEnum)))
            {
                comboBoxDestino.Items.Add(value.GetDescription());
            }

            AddProductosToDataGridViewProductos(GenerarPresupuestosManager.paquetesTuristicos.Where(x => x.Cantidad > 0));

            AddProductosSeleccionadosToDataGridView(GenerarPresupuestosManager.paquetesTuristicosElegidos, true);
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            var filterDto = new PaquetesTuristicosFilterDto()
            {
                PrecioDesde = txtBoxFiltroPrecioDesde.Text,
                PrecioHasta = txtBoxFiltroPrecioHasta.Text,
                FechaDesde = datePickerFilterFechaDesde.Enabled ? datePickerFilterFechaDesde.Value : null,
                FechaHasta = datePickerFilterFechaHasta.Enabled ? datePickerFilterFechaHasta.Value : null,
                Origen = comboBoxOrigen.SelectedIndex != -1 ? comboBoxOrigen.SelectedIndex : null,
                Destino = comboBoxDestino.SelectedIndex != -1 ? comboBoxDestino.SelectedIndex : null,
            };

            var validacion = ValidacionDeFiltros(filterDto);

            if (!string.IsNullOrEmpty(validacion))
            {
                MessageBox.Show(validacion, "Error", MessageBoxButtons.OK);
            }
            else
            {
                var filter = new PaquetesTuristicosFilter(filterDto);

                var productos = GenerarPresupuestosManager.paquetesTuristicos
                    .Where(x => x.Cantidad > 0
                                && (!filter.PrecioDesde.HasValue || x.Precio >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Precio <= filter.PrecioHasta)
                                && (!filter.FechaDesde.HasValue || x.FechaDesde == filter.FechaDesde)
                                && (!filter.FechaHasta.HasValue || x.FechaHasta == filter.FechaHasta)
                                && (!filter.Origen.HasValue || (int)x.Origen == filter.Origen)
                                && (!filter.Destino.HasValue || (int)x.Destino == filter.Destino));

                dataGridViewProductos.Rows.Clear();

                AddProductosToDataGridViewProductos(productos);

                if (!productos.Any())
                {
                    MessageBox.Show("No hay Paquetes disponibles para los parámetros ingresados.", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private string ValidacionDeFiltros(PaquetesTuristicosFilterDto presupuesto)
        {
            var messages = string.Empty;

            messages += FiltrosManager.ValidarPrecios(presupuesto);

            messages += FiltrosManager.ValidarFechas(presupuesto);

            return messages;
        }

        private void AddProductosToDataGridViewProductos(IEnumerable<PaquetesTuristicos> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Id.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Codigo });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Nombre });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Precio.ToFormDecimal() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Cantidad.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.FechaDesde.ToFormDate() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.FechaHasta.ToFormDate() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Origen.GetDescription() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Destino.GetDescription() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.GetActividades() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.CapacidadMaximaAdultos });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.CapacidadMaximaMenores });

                dataGridViewProductos.Rows.Add(row);
            }
        }

        private void AddProductosSeleccionadosToDataGridView(IEnumerable<PaquetesTuristicos> listToAdd, bool isInitForm)
        {
            foreach (var item in listToAdd)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Id.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Codigo });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Nombre });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Precio.ToFormDecimal() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Cantidad.ToString() });

                if (isInitForm)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = item.CantidadSeleccionada });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = item.SubTotal.Value.ToFormDecimal() });
                }
                else
                {
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = 1.ToString() }); // Cantidad Seleccionada
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Precio.ToFormDecimal() }); // Sub Total
                }

                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.FechaDesde.ToFormDate() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.FechaHasta.ToFormDate() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Origen.GetDescription() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Destino.GetDescription() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.GetActividades() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.CapacidadMaximaAdultos });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.CapacidadMaximaMenores });

                dataGridViewProductosSeleccionados.Rows.Add(row);
            }
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.SelectedRows.Count > 0)
            {
                var productosToAdd = new List<PaquetesTuristicos>();

                foreach (DataGridViewRow row in dataGridViewProductos.SelectedRows)
                {
                    var id = Guid.Parse(row.Cells[idColumnIndex].Value.ToString());

                    var producto = GenerarPresupuestosManager.paquetesTuristicos.Where(x => x.Id == id).SingleOrDefault();

                    if (!IsProductInDataGridViewProductosSeleccionados(id))
                    {
                        productosToAdd.Add(producto);
                    }
                }

                AddProductosSeleccionadosToDataGridView(productosToAdd, false);
            }
            else
            {
                MessageBox.Show("Ningun paquete seleccionado para agregar al presupuesto.");
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
                MessageBox.Show("Ningun paquete seleccionado para remover del presupuesto.");
            }
        }

        private void btnConfirmarProductosSeleccionados_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductosSeleccionados.RowCount > 0)
            {
                GenerarPresupuestosManager.paquetesTuristicosElegidos.Clear();

                foreach (DataGridViewRow row in dataGridViewProductosSeleccionados.Rows)
                {
                    var id = Guid.Parse(row.Cells[idColumnIndex].Value.ToString());

                    var producto = GenerarPresupuestosManager.paquetesTuristicos.Where(x => x.Id == id).SingleOrDefault();

                    producto.CantidadSeleccionada = int.Parse(row.Cells[cantidadSeleccionadaColumnIndex].Value.ToString());
                    producto.SubTotal = decimal.Parse(row.Cells[subTotalColumnIndex].Value.ToString());

                    GenerarPresupuestosManager.paquetesTuristicosElegidos.Add(producto);
                }

                this.Close();

                Thread thread = new Thread(OpenMenuGenerarPresupuesto);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("Debes seleccionar Paquetes para poder confirmar el presupuesto");
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
            datePickerFilterFechaDesde.Value = DateTime.Now.Date;
            datePickerFilterFechaHasta.Value = DateTime.Now.AddDays(1).Date;
            comboBoxOrigen.SelectedIndex = -1;
            comboBoxDestino.SelectedIndex = -1;

            dataGridViewProductos.Rows.Clear();

            AddProductosToDataGridViewProductos(GenerarPresupuestosManager.paquetesTuristicos);
        }

        private bool IsProductInDataGridViewProductosSeleccionados(Guid id)
        {
            var idList = new List<Guid>();

            foreach (DataGridViewRow row in dataGridViewProductosSeleccionados.Rows)
            {
                var selectedId = Guid.Parse(row.Cells[idColumnIndex].Value.ToString());

                idList.Add(selectedId);
            }

            return idList.Any(x => x == id);
        }

        private void dataGridViewProductosSeleccionados_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == cantidadSeleccionadaColumnIndex)
            {
                var dataGridView = sender as DataGridView;

                // ID
                var idCell = dataGridView.Rows[e.RowIndex].Cells[idColumnIndex];
                var id = idCell.Value.ToString();

                // Precio
                var precioCell = dataGridView.Rows[e.RowIndex].Cells[precioColumnIndex];
                var precio = decimal.Parse(precioCell.Value.ToString());

                // Cantidad Disponible
                var cantidadDisponibleCell = dataGridView.Rows[e.RowIndex].Cells[cantidadDisponibleColumnIndex];
                var cantidadDisponible = int.Parse(cantidadDisponibleCell.Value.ToString());

                // Cantidad Seleccionada
                var cantidadSeleccionadaCell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var isCantidadSeleccionadaValid = int.TryParse(cantidadSeleccionadaCell.Value.ToString(), out int cantidadSeleccionada);

                // SubTotal
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
                return $"La Cantidad para el Paquete con ID [{id}] debe ser un numero entero.";
            }

            if (cantidadDisponible < cantidadSeleccionada)
            {
                return $"La Cantidad Seleccionada para el Paquete con ID [{id}] debe ser un menor o igual a la Cantidad Disponible.";
            }

            if (cantidadSeleccionada <= 0)
            {
                return $"La Cantidad Seleccionada para el Paquete con ID [{id}] debe ser mayor a 0.";
            }

            return string.Empty;
        }

        private void btnDisableDatePickerFilterFechaDesde_Click(object sender, EventArgs e)
        {
            if (datePickerFilterFechaDesde.Enabled)
            {
                datePickerFilterFechaDesde.Enabled = false;
                btnDisableDatePickerFilterFechaDesde.Text = "Habilitar";
            }
            else
            {
                datePickerFilterFechaDesde.Enabled = true;
                btnDisableDatePickerFilterFechaDesde.Text = "Deshabilitar";
            }
        }

        private void btnDisableDatePickerFilterFechaHasta_Click(object sender, EventArgs e)
        {
            if (datePickerFilterFechaHasta.Enabled)
            {
                datePickerFilterFechaHasta.Enabled = false;
                btnDisableDatePickerFilterFechaHasta.Text = "Habilitar";
            }
            else
            {
                datePickerFilterFechaHasta.Enabled = true;
                btnDisableDatePickerFilterFechaHasta.Text = "Deshabilitar";
            }
        }
    }
}
