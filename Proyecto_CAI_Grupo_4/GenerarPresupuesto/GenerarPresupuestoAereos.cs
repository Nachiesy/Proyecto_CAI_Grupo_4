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
        private readonly int idColumnIndex = 0;
        private readonly int precioAdultosColumnIndex = 3;
        private readonly int precioMenoresColumnIndex = 4;
        private readonly int cantidadDisponibleColumnIndex = 5;
        private readonly int cantidadSeleccionadaAdultosColumnIndex = 6;
        private readonly int cantidadSeleccionadaMenoresColumnIndex = 7;
        private readonly int subTotalColumnIndex = 8;

        public GenerarPresupuestoAereos() : base(tituloModulo: "Generar Presupuesto > Aéreos")
        {
            InitializeComponent();
        }

        private void GenerarPresupuestoAereos_Load(object sender, EventArgs e)
        {
            datePickerFilterFechaDesde.Value = DateTime.Now.Date;
            datePickerFilterFechaHasta.Value = DateTime.Now.AddDays(1).Date;

            foreach (AereosOrigenEnum value in Enum.GetValues(typeof(AereosOrigenEnum)))
            {
                comboBoxOrigen.Items.Add(value.GetDescription());
            }

            foreach (AereosDestinoEnum value in Enum.GetValues(typeof(AereosDestinoEnum)))
            {
                comboBoxDestino.Items.Add(value.GetDescription());
            }

            AddProductosToDataGridViewProductos(GenerarPresupuestosManager.aereos.Where(x => x.Cantidad > 0));

            AddProductosSeleccionadosToDataGridView(GenerarPresupuestosManager.aereosElegidos, true);
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            var filterDto = new AereosFilterDto()
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
                var filter = new AereosFilter(filterDto);

                var productos = GenerarPresupuestosManager.aereos
                    .Where(x => x.Cantidad > 0
                                && (!filter.PrecioDesde.HasValue || x.Precio >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Precio <= filter.PrecioHasta)
                                && (!filter.FechaDesde.HasValue || x.FechaDeSalida == filter.FechaDesde)
                                && (!filter.FechaHasta.HasValue || x.FechaDeLlegada == filter.FechaHasta)
                                && (!filter.Origen.HasValue || (int)x.Origen == filter.Origen)
                                && (!filter.Destino.HasValue || (int)x.Destino == filter.Destino));

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

            messages += FiltrosManager.ValidarPrecios(presupuesto);

            messages += FiltrosManager.ValidarFechas(presupuesto);

            return messages;
        }

        private void AddProductosToDataGridViewProductos(IEnumerable<Aereos> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Id.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Codigo });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Nombre });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.PrecioAdultos.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.PrecioMenores.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Cantidad.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.FechaDeSalida.ToFormDate() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.FechaDeLlegada.ToFormDate() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Origen.GetDescription() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Destino.GetDescription() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.TipoDeClaseAerea.GetDescription() });

                dataGridViewProductos.Rows.Add(row);
            }
        }

        private void AddProductosSeleccionadosToDataGridView(IEnumerable<Aereos> listToAdd, bool isInitForm)
        {
            foreach (var item in listToAdd)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Id.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Codigo });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Nombre });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.PrecioAdultos.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.PrecioMenores.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Cantidad.ToString() });

                if (isInitForm)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = item.CantidadSeleccionadaAdultos.ToString() });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = item.CantidadSeleccionadaMenores.ToString() });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = item.SubTotal.ToString() });
                }
                else
                {
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = 1.ToString() }); // Cantidad Seleccionada Adultos
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = 0.ToString() }); // Cantidad Seleccionada Menores
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = item.PrecioAdultos.ToString() }); // Sub Total
                }

                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.FechaDeSalida.ToFormDate() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.FechaDeLlegada.ToFormDate() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Origen.GetDescription() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Destino.GetDescription() });
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
                    var id = Guid.Parse(row.Cells[idColumnIndex].Value.ToString());

                    var producto = GenerarPresupuestosManager.aereos.Where(x => x.Id == id).SingleOrDefault();

                    if (!IsProductInDataGridViewProductosSeleccionados(id))
                    {
                        productosToAdd.Add(producto);
                    }
                }

                AddProductosSeleccionadosToDataGridView(productosToAdd, false);
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
                    var id = Guid.Parse(row.Cells[idColumnIndex].Value.ToString());

                    var producto = GenerarPresupuestosManager.aereos.Where(x => x.Id == id).SingleOrDefault();

                    var cantidadSeleccionadaAdultos = int.Parse(row.Cells[cantidadSeleccionadaAdultosColumnIndex].Value.ToString());
                    var cantidadSeleccionadaMenores = int.Parse(row.Cells[cantidadSeleccionadaMenoresColumnIndex].Value.ToString());

                    producto.CantidadSeleccionadaAdultos = cantidadSeleccionadaAdultos;
                    producto.CantidadSeleccionadaMenores = cantidadSeleccionadaMenores;
                    producto.CantidadSeleccionada = producto.CantidadSeleccionadaAdultos + producto.CantidadSeleccionadaMenores;
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
            datePickerFilterFechaDesde.Value = DateTime.Now.Date;
            datePickerFilterFechaHasta.Value = DateTime.Now.AddDays(1).Date;
            comboBoxOrigen.SelectedIndex = -1;
            comboBoxDestino.SelectedIndex = -1;

            dataGridViewProductos.Rows.Clear();

            AddProductosToDataGridViewProductos(GenerarPresupuestosManager.aereos);
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
            var precioAdultosChanged = e.ColumnIndex == cantidadSeleccionadaAdultosColumnIndex;
            var precioMenoresChanged = e.ColumnIndex == cantidadSeleccionadaMenoresColumnIndex;

            if (e.RowIndex >= 0 && (precioAdultosChanged || precioMenoresChanged))
            {
                var dataGridView = sender as DataGridView;

                // ID
                var idCell = dataGridView.Rows[e.RowIndex].Cells[idColumnIndex];
                var id = idCell.Value.ToString();

                // Precio Adultos
                var precioAdultosCell = dataGridView.Rows[e.RowIndex].Cells[precioAdultosColumnIndex];
                var precioAdultos = decimal.Parse(precioAdultosCell.Value.ToString());

                // Precio Menores
                var precioMenoresCell = dataGridView.Rows[e.RowIndex].Cells[precioMenoresColumnIndex];
                var precioMenores = decimal.Parse(precioMenoresCell.Value.ToString());

                // Cantidad Disponible
                var cantidadDisponibleCell = dataGridView.Rows[e.RowIndex].Cells[cantidadDisponibleColumnIndex];
                var cantidadDisponible = int.Parse(cantidadDisponibleCell.Value.ToString());

                // Cantidad Seleccionada Adultos
                var cantidadSeleccionadaAdultosCell = dataGridView.Rows[e.RowIndex].Cells[cantidadSeleccionadaAdultosColumnIndex];
                var isCantidadSeleccionadaAdultosValid = int.TryParse(cantidadSeleccionadaAdultosCell.Value.ToString(), out int cantidadSeleccionadaAdultos);

                // Cantidad Seleccionada Menores
                var cantidadSeleccionadaMenoresCell = dataGridView.Rows[e.RowIndex].Cells[cantidadSeleccionadaMenoresColumnIndex];
                var isCantidadSeleccionadaMenoresValid = int.TryParse(cantidadSeleccionadaMenoresCell.Value.ToString(), out int cantidadSeleccionadaMenores);

                // SubTotal
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
