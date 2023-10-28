﻿using Proyecto_CAI_Grupo_4.Utils;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Models.Productos;
using Proyecto_CAI_Grupo_4.Modelos;

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
            ActualizarEstadoBotones();
        }

        private void ActualizarEstadoBotones()
        {
            btnEliminarTodo.Enabled = productosElegidos.Items.Count > 0;
            btnEliminarSeleccion.Enabled = productosElegidos.SelectedItems.Count > 0;
        }

        private void GenerarPresupuestoMenu_Load(object sender, EventArgs e)
        {
            var aereos = AereosModel.GetAereosElegidos();

            AddProductosToListView(aereos);

            var hoteles = HotelesModel.GetHotelesElegidos();

            AddProductosToListView(hoteles);

            Total += aereos.Sum(x => x.Precio);
            Total += hoteles.Sum(x => x.Precio);

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

        private void btnFinalizarPresupuesto_Click(object sender, EventArgs e)
        {
            var dni = textBoxClienteDNI.Text.Trim();

            var validacionProductos = productosElegidos.Items.Count > 0;

            var validacionDNI = dni.EsDNI();


            if (validacionProductos && validacionDNI)
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

                    ReservaModel.AddReserva(reserva);

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
            }
        }

        private void ActualizarCantidadesDeProductos()
        {
            AereosModel.ActualizarCantidadesDeAereos();

            HotelesModel.ActualizarCantidadesDeHoteles();
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

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            AereosModel.ClearAereosElegidos();
            HotelesModel.ClearHotelesElegidos();
        }

        private void ProductosSeleccionadosListView_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ActualizarEstadoBotones();
        }
    }
}
