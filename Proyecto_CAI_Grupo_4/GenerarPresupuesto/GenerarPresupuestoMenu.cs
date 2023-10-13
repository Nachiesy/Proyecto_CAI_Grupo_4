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

            total += aereos.Sum(x => x.Precio);
            total += hoteles.Sum(x => x.Precio);
            total += cruceros.Sum(x => x.Precio);
            total += paquetesTuristicos.Sum(x => x.Precio);

            presupuestoTotal.Text = total > 0 ? $"Total: {total:C2}" : "Total: $-";
        }

        private void AddProductosToListView(IEnumerable<Productos> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Id.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Codigo });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Nombre });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.TipoDeServicio.GetDescription() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Precio.ToFormDecimal() });

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

            var validacionProductos = productosElegidos.RowCount > 0;

            var dniMsg = ValidarDNI();

            var validacionDNI = string.IsNullOrEmpty(dniMsg);

            if (validacionProductos && validacionDNI)
            {
                var result = MessageBox.Show("¿Desea generar una Pre Reserva a partir de este Presupuesto?", string.Empty, MessageBoxButtons.YesNo);

                var presupuestoID = Guid.NewGuid();
                var reservaID = Guid.NewGuid();

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"Presupuesto [{presupuestoID}] y Pre Reserva [{reservaID}] generados correctamente para el cliente con DNI {dni}.", "Exito", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show($"Presupuesto [{presupuestoID}] generado correctamente para el cliente con DNI {dni}.", "Exito", MessageBoxButtons.OK);
                }

                ActualizarCantidadesDeProductos();

                btnVolverMenuPrincipal_Click(sender, e);
            }
            else
            {
                var productosMsg = "Debes elegir productos";

                var msgFinal = "para poder generar un Presupuesto.";

                if (!validacionProductos && !validacionDNI)
                {
                    MessageBox.Show($"{dniMsg} y {productosMsg} {msgFinal}", "Error", MessageBoxButtons.OK);
                }
                else if (!validacionProductos)
                {
                    MessageBox.Show($"{productosMsg} {msgFinal}", "Error", MessageBoxButtons.OK);
                }
                else if (!validacionDNI)
                {
                    MessageBox.Show($"{dniMsg} {msgFinal}", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void ActualizarCantidadesDeProductos()
        {
            ActualizarCantidadesDeAereos();

            ActualizarCantidadesDeHoteles();

            ActualizarCantidadesDeCruceros();

            ActualizarCantidadesDePaquetes();
        }

        private void ActualizarCantidadesDeAereos()
        {
            var aereosToUpdate = new List<Aereos>(GenerarPresupuestosManager.aereos.Intersect(GenerarPresupuestosManager.aereosElegidos));

            foreach (var aereo in aereosToUpdate)
            {
                var indexAereo = GenerarPresupuestosManager.aereos.FindIndex(x => x.Id == aereo.Id);

                var cantidadSeleccionada = GenerarPresupuestosManager.aereosElegidos.Where(x => x.Id == aereo.Id).Count();

                aereo.Cantidad = aereo.Cantidad - cantidadSeleccionada;

                if (indexAereo != -1)
                {
                    GenerarPresupuestosManager.aereos[indexAereo] = aereo;
                }
            }

            GenerarPresupuestosManager.aereosElegidos.Clear();
        }

        private void ActualizarCantidadesDeHoteles()
        {
            var hotelesToUpdate = new List<Hoteles>(GenerarPresupuestosManager.hoteles.Intersect(GenerarPresupuestosManager.hotelesElegidos));

            foreach (var hotel in hotelesToUpdate)
            {
                var indexHotel = GenerarPresupuestosManager.hoteles.FindIndex(x => x.Id == hotel.Id);

                var cantidadSeleccionada = GenerarPresupuestosManager.hotelesElegidos.Where(x => x.Id == hotel.Id).Count();

                hotel.Cantidad = hotel.Cantidad - cantidadSeleccionada;

                if (indexHotel != -1)
                {
                    GenerarPresupuestosManager.hoteles[indexHotel] = hotel;
                }
            }

            GenerarPresupuestosManager.hotelesElegidos.Clear();
        }

        private void ActualizarCantidadesDeCruceros()
        {
            var crucerosToUpdate = new List<Cruceros>(GenerarPresupuestosManager.cruceros.Intersect(GenerarPresupuestosManager.crucerosElegidos));

            foreach (var crucero in crucerosToUpdate)
            {
                var cruceroIndex = GenerarPresupuestosManager.cruceros.FindIndex(x => x.Id == crucero.Id);

                var cantidadSeleccionada = GenerarPresupuestosManager.crucerosElegidos.Where(x => x.Id == crucero.Id).Count();

                crucero.Cantidad = crucero.Cantidad - cantidadSeleccionada;

                if (cruceroIndex != -1)
                {
                    GenerarPresupuestosManager.cruceros[cruceroIndex] = crucero;
                }
            }

            GenerarPresupuestosManager.crucerosElegidos.Clear();
        }

        private void ActualizarCantidadesDePaquetes()
        {
            var paquetesToUpdate = new List<PaquetesTuristicos>(GenerarPresupuestosManager.paquetesTuristicos.Intersect(GenerarPresupuestosManager.paquetesTuristicosElegidos));

            foreach (var paquete in paquetesToUpdate)
            {
                var paqueteIndex = GenerarPresupuestosManager.paquetesTuristicos.FindIndex(x => x.Id == paquete.Id);

                var cantidadSeleccionada = GenerarPresupuestosManager.paquetesTuristicosElegidos.Where(x => x.Id == paquete.Id).Count();

                paquete.Cantidad = paquete.Cantidad - cantidadSeleccionada;

                if (paqueteIndex != -1)
                {
                    GenerarPresupuestosManager.paquetesTuristicos[paqueteIndex] = paquete;
                }
            }

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

        private string ValidarDNI()
        {
            var dni = textBoxClienteDNI.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                return "Debes ingresar el DNI del Cliente";
            }

            if (!int.TryParse(dni, out int nroDeDoc))
            {
                return "El DNI debe ser un numero entero";
            }

            if (nroDeDoc < 0 || nroDeDoc > 99999999)
            {
                return "El DNI no puede ser menor a 0 ni mayor a 99999999";
            }

            return string.Empty;
        }
    }
}
