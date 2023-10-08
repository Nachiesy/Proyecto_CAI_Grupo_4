using Proyecto_CAI_Grupo_4.Managers;
using Proyecto_CAI_Grupo_4.Models.Productos;
using Proyecto_CAI_Grupo_4.Utils;
using Proyecto_CAI_Grupo_4.Common.Views;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarPresupuestoMenu : VistaBase
    {
        public GenerarPresupuestoMenu() : base(tituloModulo: "Generar Presupuesto")
        {
            InitializeComponent();
        }

        private void GenerarPresupuestoMenu_Load(object sender, EventArgs e)
        {
            var aereos = GenerarPresupuestosManager.aereosElegidos;

            AddProductosToListView(aereos, productosElegidos);

            var hoteles = GenerarPresupuestosManager.hotelesElegidos;

            AddProductosToListView(hoteles, productosElegidos);

            var cruceros = GenerarPresupuestosManager.crucerosElegidos;

            AddProductosToListView(cruceros, productosElegidos);

            var paquetesTuristicos = GenerarPresupuestosManager.paquetesTuristicosElegidos;

            AddProductosToListView(paquetesTuristicos, productosElegidos);

            decimal total = 0;

            total += aereos.Sum(x => x.Precio);
            total += hoteles.Sum(x => x.Precio);
            total += cruceros.Sum(x => x.Precio);
            total += paquetesTuristicos.Sum(x => x.Precio);

            btnFinalizarPresupuesto.Enabled = total > 0;
            presupuestoTotal.Text = total > 0 ? $"Total: {total:C2}" : "Total: $-";
        }

        private void AddProductosToListView(IEnumerable<Productos> listToAdd, DataGridView listView)
        {
            foreach (var item in listToAdd)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Id.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Nombre });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.TipoDeServicio.GetDescription() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Precio.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = 1.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Precio });

                productosElegidos.Rows.Add(row);
            }
        }

        private void btnMenuAereos_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(OpenGenerarPresupuestoAereos);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenGenerarPresupuestoAereos()
        {
            Application.Run(new GenerarPresupuestoAereos());
        }

        private void btnMenuHoteles_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(OpenGenerarPresupuestoHoteles);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenGenerarPresupuestoHoteles()
        {
            Application.Run(new GenerarPresupuestoHoteles());
        }

        private void btnMenuCruceros_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(OpenGenerarPresupuestoCruceros);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenGenerarPresupuestoCruceros()
        {
            Application.Run(new GenerarPresupuestoCruceros());
        }

        private void btnMenuPaquetes_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(OpenGenerarPresupuestoPaquetes);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenGenerarPresupuestoPaquetes()
        {
            Application.Run(new GenerarPresupuestoPaquetesTuristicos());
        }

        private void btnFinalizarPresupuesto_Click(object sender, EventArgs e)
        {
            if (productosElegidos.RowCount > 0)
            {
                var result = MessageBox.Show("¿Desea generar una Pre Reserva a partir de este Presupuesto?", string.Empty, MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Presupuesto y Pre Reserva generados correctamente.", "Exito", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Presupuesto generado correctamente.", "Exito", MessageBoxButtons.OK);
                }

                btnVolverMenuPrincipal_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Debes elegir productos turisticos para poder generar un Presupuesto.", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(OpenMenuPrincipal);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenMenuPrincipal()
        {
            Application.Run(new MenuPrincipal());
        }

        private void productosElegidos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var idColumnIndex = 0;
            var precioColumnIndex = 3;
            var cantidadColumnIndex = 4;
            var subTotalColumnIndex = 5;

            if (e.RowIndex >= 0 && e.ColumnIndex == cantidadColumnIndex)
            {
                var dataGridView = sender as DataGridView;

                var changedCell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

                var precioCell = dataGridView.Rows[e.RowIndex].Cells[precioColumnIndex];

                var subTotalCell = dataGridView.Rows[e.RowIndex].Cells[subTotalColumnIndex];

                var cantidadValid = int.TryParse(changedCell.Value.ToString(), out int cantidad);

                var precioValid = decimal.TryParse(precioCell.Value.ToString(), out decimal precio);

                if (cantidadValid && precioValid)
                {
                    subTotalCell.Value = precio * cantidad;
                }
                else
                {
                    changedCell.Value = 1;
                    subTotalCell.Value = precioCell.Value;

                    var id = dataGridView.Rows[e.RowIndex].Cells[idColumnIndex].Value;

                    MessageBox.Show($"La Cantidad para el Producto con ID [{id}] debe ser un numero entero.", "Error");
                }

                dataGridView.Refresh();

                UpdateTotalDelPresupuesto(subTotalColumnIndex);
            }
        }

        private void UpdateTotalDelPresupuesto(int subTotalColumnIndex)
        {
            decimal total = 0;

            foreach (DataGridViewRow row in productosElegidos.Rows)
            {
                if (decimal.TryParse(row.Cells[subTotalColumnIndex].Value.ToString(), out decimal subTotal))
                {
                    total += subTotal;
                }
            }

            btnFinalizarPresupuesto.Enabled = total > 0;
            presupuestoTotal.Text = total > 0 ? $"Total: {total:C2}" : "Total: $-";
        }

        private void productosElegidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
