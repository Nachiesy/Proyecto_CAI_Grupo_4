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

            AddProductosToListView(aereos);

            var hoteles = GenerarPresupuestosManager.hotelesElegidos;

            AddProductosToListView(hoteles);

            var cruceros = GenerarPresupuestosManager.crucerosElegidos;

            AddProductosToListView(cruceros);

            var paquetesTuristicos = GenerarPresupuestosManager.paquetesTuristicosElegidos;

            AddProductosToListView(paquetesTuristicos);

            decimal total = 0;

            total += aereos.Sum(x => x.SubTotal.Value);
            total += hoteles.Sum(x => x.SubTotal.Value);
            total += cruceros.Sum(x => x.SubTotal.Value);
            total += paquetesTuristicos.Sum(x => x.SubTotal.Value);

            btnFinalizarPresupuesto.Enabled = total > 0 && ValidarDNI();
            presupuestoTotal.Text = total > 0 ? $"Total: {total:C2}" : "Total: $-";
        }

        private void AddProductosToListView(IEnumerable<Productos> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Id.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Nombre });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.TipoDeServicio.GetDescription() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Precio.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.CantidadSeleccionada });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.SubTotal });

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
            var dni = textBoxClienteDNI.Text.Trim();

            if (productosElegidos.RowCount > 0 && ValidarDNI())
            {
                var result = MessageBox.Show("¿Desea generar una Pre Reserva a partir de este Presupuesto?", string.Empty, MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"Presupuesto y Pre Reserva generados correctamente para el cliente con DNI {dni}.", "Exito", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show($"Presupuesto generado correctamente para el cliente con DNI {dni}.", "Exito", MessageBoxButtons.OK);
                }

                ActualizarCantidadesDeProductos();

                btnVolverMenuPrincipal_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Debes ingresar el DNI del Cliente a generarle el presupuesto y Debes elegir productos turisticos para poder generar un Presupuesto.", "Error", MessageBoxButtons.OK);
            }
        }

        private void ActualizarCantidadesDeProductos()
        {
            foreach (DataGridViewRow row in productosElegidos.Rows)
            {
                // ID
                var idCellIndex = 0;
                var id = Guid.Parse(row.Cells[idCellIndex].Value.ToString());

                // Tipo de Servicio
                var tipoDeServicioIndex = 2;
                var tipoDeServicio = TipoDeServicioEnumHelper.GetTipoDeServicioEnum(row.Cells[tipoDeServicioIndex].Value.ToString());

                // Cantidad Seleccionada
                var cantidadSeleccionadaIndex = 4;
                var cantidadSeleccionada = int.Parse(row.Cells[cantidadSeleccionadaIndex].Value.ToString());

                switch (tipoDeServicio)
                {
                    case TipoDeServicioEnum.aereo:
                        var indexAereo = GenerarPresupuestosManager.aereos.FindIndex(x => x.Id == id);
                        var aereo = GenerarPresupuestosManager.aereos.SingleOrDefault(x => x.Id == id);

                        aereo.Cantidad = aereo.Cantidad - cantidadSeleccionada;

                        if (indexAereo != -1)
                        {
                            GenerarPresupuestosManager.aereos[indexAereo] = aereo;
                        }

                        break;

                    case TipoDeServicioEnum.hotel:
                        var indexHotel = GenerarPresupuestosManager.hoteles.FindIndex(x => x.Id == id);
                        var hotel = GenerarPresupuestosManager.hoteles.SingleOrDefault(x => x.Id == id);

                        hotel.Cantidad = hotel.Cantidad - cantidadSeleccionada;

                        if (indexHotel != -1)
                        {
                            GenerarPresupuestosManager.hoteles[indexHotel] = hotel;
                        }

                        break;

                    case TipoDeServicioEnum.crucero:
                        var cruceroIndex = GenerarPresupuestosManager.cruceros.FindIndex(x => x.Id == id);
                        var crucero = GenerarPresupuestosManager.cruceros.SingleOrDefault(x => x.Id == id);

                        crucero.Cantidad = crucero.Cantidad - cantidadSeleccionada;

                        if (cruceroIndex != -1)
                        {
                            GenerarPresupuestosManager.cruceros[cruceroIndex] = crucero;
                        }

                        break;

                    case TipoDeServicioEnum.paquete:
                        var paqueteIndex = GenerarPresupuestosManager.paquetesTuristicos.FindIndex(x => x.Id == id);
                        var paquete = GenerarPresupuestosManager.paquetesTuristicos.SingleOrDefault(x => x.Id == id);

                        paquete.Cantidad = paquete.Cantidad - cantidadSeleccionada;

                        if (paqueteIndex != -1)
                        {
                            GenerarPresupuestosManager.paquetesTuristicos[paqueteIndex] = paquete;
                        }

                        break;
                }
            }

            GenerarPresupuestosManager.aereosElegidos.Clear();
            GenerarPresupuestosManager.hotelesElegidos.Clear();
            GenerarPresupuestosManager.crucerosElegidos.Clear();
            GenerarPresupuestosManager.paquetesTuristicosElegidos.Clear();
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

        private void textBoxClienteDNI_TextChanged(object sender, EventArgs e)
        {
            var subTotalColumnIndex = 5;

            decimal total = 0;

            foreach (DataGridViewRow row in productosElegidos.Rows)
            {
                if (decimal.TryParse(row.Cells[subTotalColumnIndex].Value.ToString(), out decimal subTotal))
                {
                    total += subTotal;
                }
            }

            btnFinalizarPresupuesto.Enabled = total > 0 && ValidarDNI();
        }

        private bool ValidarDNI()
        {
            var dni = textBoxClienteDNI.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                return false;
            }

            if (!int.TryParse(dni, out int nroDeDoc))
            {
                return false;
            }

            if (nroDeDoc < 0 || nroDeDoc > 99999999)
            {
                return false;
            }

            return true;
        }
    }
}
