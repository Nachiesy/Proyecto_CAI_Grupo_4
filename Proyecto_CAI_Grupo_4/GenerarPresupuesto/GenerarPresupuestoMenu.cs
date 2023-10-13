using Proyecto_CAI_Grupo_4.Managers;
using Proyecto_CAI_Grupo_4.Models.Productos;
using Proyecto_CAI_Grupo_4.Utils;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Models;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarPresupuestoMenu : VistaBase
    {
        private decimal Total = 0;

        private int PasajerosAdultos = 0;
        private int PasajerosMenores = 0;
        private int PasajerosInfantes = 0;

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

            Total += aereos.Sum(x => x.Precio);
            Total += hoteles.Sum(x => x.Precio);
            Total += cruceros.Sum(x => x.Precio);
            Total += paquetesTuristicos.Sum(x => x.Precio);

            presupuestoTotal.Text = Total > 0 ? $"Total: {Total:C2}" : "Total: $-";
        }

        private void AddProductosToListView(IEnumerable<Productos> listToAdd)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Codigo);
                row.SubItems.Add(item.Nombre);
                row.SubItems.Add(item.TipoDeServicio.GetDescription());
                row.SubItems.Add(item.Precio.ToFormDecimal());

                productosElegidos.Items.Add(row);
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

            var validacionProductos = productosElegidos.Items.Count > 0;

            var validacionDNI = dni.EsDNI();

            var pasajerosMsg = ValidarCantidadPasajeros();

            var validacionPasajeros = string.IsNullOrEmpty(pasajerosMsg);

            if (validacionProductos && validacionDNI && validacionPasajeros)
            {
                var result = MessageBox.Show("¿Desea generar una Pre Reserva a partir de este Presupuesto?", string.Empty, MessageBoxButtons.YesNo);

                var isPreReserva = result == DialogResult.Yes;

                if (isPreReserva)
                {
                    var adultos = PasajerosAdultos;
                    var menores = PasajerosMenores;
                    var infantes = PasajerosInfantes;

                    var pasajeros = adultos + menores + infantes;

                    var reserva = new Reserva()
                    {
                        Codigo = 1,
                        Estado = ReservaEstadoEnum.pendienteDePago,
                        DNI = dni,
                        TipoDoc = 1,
                        Precio = Total,
                        Fecha = DateTime.Now,
                        CantPasajeros = pasajeros,
                        CantMayores = adultos,
                        CantMenores = menores,
                        prereserva = true,
                    };

                    GenerarPresupuestosManager.reservas.Add(reserva);

                    GoToGenerarPreReserva();
                }
                else
                {
                    MessageBox.Show($"Presupuesto con Código: [{1}] generado correctamente para el cliente con DNI {dni}.", "Exito", MessageBoxButtons.OK);

                    GoToMenuPrincipal();
                }

                ActualizarCantidadesDeProductos();
            }
            else
            {
                var msgFinal = "para poder generar un Presupuesto.";

                if (!validacionDNI)
                {
                    MessageBox.Show($"Debes ingresar un DNI correcto {msgFinal}", "Error", MessageBoxButtons.OK);
                }
                else if (!validacionProductos)
                {
                    MessageBox.Show($"Debes elegir productos {msgFinal}", "Error", MessageBoxButtons.OK);
                }
                else if (!validacionPasajeros)
                {
                    MessageBox.Show($"{pasajerosMsg} {msgFinal}", "Error", MessageBoxButtons.OK);
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

        private void GoToMenuPrincipal()
        {
            Close();

            Thread thread = new Thread(OpenMenuPrincipal);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenMenuPrincipal()
        {
            Application.Run(new MenuPrincipal());
        }

        private void GoToGenerarPreReserva()
        {
            Close();

            Thread thread = new Thread(OpenGenerarPreReserva);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenGenerarPreReserva()
        {
            Application.Run(new GenerarPreReserva());
        }

        private string ValidarCantidadPasajeros()
        {
            if (string.IsNullOrEmpty(textBoxPasajerosAdultos.Text))
            {
                return "Debes seleccionar una cantidad de pasajeros adultos";
            }

            if (!int.TryParse(textBoxPasajerosAdultos.Text, out PasajerosAdultos))
            {
                return "La cantidad de pasajeros adultos debe ser un numero entero";
            }

            if (PasajerosAdultos <= 0)
            {
                return "Debes seleccionar como minimo 1 pasajero adulto";
            }

            if (!int.TryParse(textBoxPasajerosMenores.Text, out PasajerosMenores) && !string.IsNullOrEmpty(textBoxPasajerosMenores.Text))
            {
                return "La cantidad de pasajeros menores debe ser un numero entero";
            }

            if (PasajerosMenores < 0)
            {
                return "La cantidad de pasajeros menores no puede ser menor a 0";
            }

            if (!int.TryParse(textBoxPasajerosInfantes.Text, out PasajerosInfantes) && !string.IsNullOrEmpty(textBoxPasajerosInfantes.Text))
            {
                return "La cantidad de pasajeros infantes debe ser un numero entero";
            }

            if (PasajerosInfantes < 0)
            {
                return "La cantidad de pasajeros infantes no puede ser menor a 0";
            }

            return string.Empty;
        }
    }
}
