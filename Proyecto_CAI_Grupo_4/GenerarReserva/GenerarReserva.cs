using Proyecto_CAI_Grupo_4.Models;
using Proyecto_CAI_Grupo_4.Utils;
using System.Data;
using System.Linq.Expressions;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Modelos;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Models.Productos;
using Proyecto_CAI_Grupo_4.Enums;

namespace Proyecto_CAI_Grupo_4
{

    public partial class GenerarReserva : VistaBase
    {
        private Reserva Reserva = null;
        private Pasajeros Pasajero = null;

        private int cantidadMaxPasajeros = 0;

        public GenerarReserva() : base(tituloModulo: "Generar Reserva")
        {
            InitializeComponent();
        }

        private void GenerarReservao_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
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


        public void RecibirDatosPasajero(Pasajeros SumarPasajero)
        {
            foreach (var i in SumarPasajero.IdsAereosAsignados)
            {
                ListViewItem item = new ListViewItem(AereosModel.GetAereoByID(i).Codigo)
                {
                    SubItems =
                    {
                        AereosModel.GetAereoByID(i).Nombre,
                        SumarPasajero.Nombre,
                        SumarPasajero.Apellido,
                        SumarPasajero.FechaNacimiento.ToShortDateString(),
                        SumarPasajero.GetEdad().ToString(),
                        i.ToString()
                    }
                };

                listPasajeros.Items.Add(item);
            }

            foreach (var i in SumarPasajero.IdsHotelesAsignados)
            {
                ListViewItem item = new ListViewItem(HotelesModel.GetHotelByID(i).Codigo)
                {
                    SubItems =
                    {
                        HotelesModel.GetHotelByID(i).Nombre,
                        SumarPasajero.Nombre,
                        SumarPasajero.Apellido,
                        SumarPasajero.FechaNacimiento.ToShortDateString(),
                        SumarPasajero.GetEdad().ToString(),
                        i.ToString()
                    }
                };

                listPasajeros.Items.Add(item);
            }

            Pasajero = SumarPasajero;
        }
        private void btnAddpasajero_Click(object sender, EventArgs e)
        {
            var cantAgregadaPasajeros = Pasajero is null ? 0 : Pasajero.TotalAsignados();

            if (cantAgregadaPasajeros < cantidadMaxPasajeros)
            {
                IngresarPasajero Agregar = new IngresarPasajero(Reserva.IdItinerario);

                DialogResult result = Agregar.ShowDialog();

                if (result == DialogResult.OK && Agregar.Pasajero != null)
                {
                    RecibirDatosPasajero(Agregar.Pasajero);
                    MessageBox.Show("Se Agregó el pasajero");

                    cantAgregadaPasajeros = Pasajero.TotalAsignados();

                    ActualizarCantidadDisponiblePasajeros(cantidadMaxPasajeros - cantAgregadaPasajeros);
                }
            }
            else
            {
                MessageBox.Show("Limite de Pasajeros alcanzado");
            }
        }


        private void listPresupuestos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddPresupuestosToListView(IEnumerable<Itinerario> listaItinerarios)
        {
            var itinerarios = listaItinerarios.Select(item => new ListViewItem(item.IdItinerario.ToString())
            {
                SubItems =
                {
                    item.Cliente.DNI,
                    (AereosModel.GetAereosByIds(item.IdAereosSeleccionados).Count()
                        + HotelesModel.GetHotelesByIds(item.IdHotelesSeleccionados).Count()).ToString(),
                    "0", //cant mayores
                    "0", //cant menores
                    item.PrecioTotal.ToString("C2"),
                    item.Estado,
                    item.FechaEstado.ToFormDate(),
                    item.Estado == "Pre-Reserva" ? "Si" : "No"
                }
            }).ToArray();


            listPresupuestos.Items.AddRange(itinerarios);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var codigo = nroPresupuestotxt.Text.Trim();
            var dni = txbDocumento.Text.Trim();

            if (!string.IsNullOrEmpty(dni) && !dni.EsDNI())
            {
                MessageBox.Show("Ingrese un DNI valido por favor.");
                return;
            }

            if (!string.IsNullOrEmpty(codigo) && !int.TryParse(codigo, out _))
            {
                MessageBox.Show("Ingrese un codigo valido por favor.");
                return;
            }

            if (!string.IsNullOrEmpty(dni))
            {
                var presupuestos = PresupuestosModel
                    .GetPresupuestosByDNI(dni);

                listPresupuestos.Items.Clear();

                AddPresupuestosToListView(presupuestos);
                return;
            }

            if (!string.IsNullOrEmpty(codigo))
            {
                var presupuestos = PresupuestosModel
                    .GetPresupuestosById(int.Parse(codigo));

                listPresupuestos.Items.Clear();

                AddPresupuestosToListView(presupuestos);
                return;
            }

            listPresupuestos.Items.Clear();

            AddPresupuestosToListView(PresupuestosModel.GetPresupuestos());
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (listPresupuestos.SelectedItems.Count == 1)
            {
                ListViewItem presupuesto = listPresupuestos.SelectedItems[0];

                int idItinerario = int.Parse(presupuesto.SubItems[0].Text);

                Reserva = ReservaModel.GenerarNuevaReserva(idItinerario, ReservaEstadoEnum.pendienteDeConfirmacion, PresupuestosModel.GetPresupuesto(idItinerario).Cliente);

                gbxPasajeros.Enabled = true;
                gbxPresupuesto.Enabled = false;
                cantidadMaxPasajeros = int.Parse(presupuesto.SubItems[2].Text);

                ActualizarInformacionPresupuesto(int.Parse(presupuesto.Text));
                ActualizarCantidadDisponiblePasajeros(int.Parse(presupuesto.SubItems[2].Text));
            }
            else
            {
                MessageBox.Show("Seleccione un presupuesto.");
            }
        }

        private void ActualizarInformacionPresupuesto(int idPresupuesto)
        {
            lblcodigp.Text = "ID Presupuesto: " + idPresupuesto;
        }

        private void ActualizarCantidadDisponiblePasajeros(int nuevaCantidad)
        {
            cantidadMaxPasajeros = nuevaCantidad;

            lblcantpasajeros.Text = "Pasajeros Disponibles: " + nuevaCantidad;
        }

        private void GenerarReserva_Load(object sender, EventArgs e)
        {

        }

        private void btnGenreserva_Click(object sender, EventArgs e)
        {
            if (listPresupuestos.SelectedItems.Count > 0)
            {
                if (Pasajero is not null && Pasajero.TotalAsignados() == cantidadMaxPasajeros)
                {
                    ReservaModel.AddReserva(Reserva);
                    PasajerosModel.AgregarPasajero(Pasajero);

                    MessageBox.Show("Reserva Generada Exitosamente");
                    this.Close();

                    Thread thread = new Thread(OpenMenuPrincipal);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
                else
                {
                    MessageBox.Show("Debe Completar todos los pasajeros");

                }
            }
            else
            {
                MessageBox.Show("Seleccione un presupuesto");
            }
        }

        private void listPasajeros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gpProsupuesto_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            if (listPasajeros.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listPasajeros.SelectedItems)
                {
                    listPasajeros.Items.Remove(item);
                    Pasajero.IdsAereosAsignados.Remove(Guid.Parse(item.SubItems[6].Text));
                    Pasajero.IdsHotelesAsignados.Remove(Guid.Parse(item.SubItems[6].Text));
                }
            }
        }
    }
}
