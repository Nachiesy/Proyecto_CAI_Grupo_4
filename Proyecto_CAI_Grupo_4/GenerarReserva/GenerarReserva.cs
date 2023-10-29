using Proyecto_CAI_Grupo_4.Models;
using Proyecto_CAI_Grupo_4.Utils;
using System.Data;
using System.Linq.Expressions;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Modelos;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Models.Productos;
using Proyecto_CAI_Grupo_4.Enums;
using System.Linq;

namespace Proyecto_CAI_Grupo_4
{

    public partial class GenerarReserva : VistaBase
    {
        private Reserva Reserva = null;
        private Pasajeros Pasajero = null;
        private int CantidadMaximaPasajeros = 0;
        private int CantidadMaximaPasajerosAdultos = 0;
        private int CantidadMaximaPasajerosMenores = 0;
        private int CantidadMaximaPasajerosInfantes = 0;

        public GenerarReserva() : base(tituloModulo: "Generar Reserva")
        {
            InitializeComponent();
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

            if (cantAgregadaPasajeros == CantidadMaximaPasajeros)
            {
                MessageBox.Show("Limite de Pasajeros alcanzado");
                return;
            }

            IngresarPasajero Agregar = new IngresarPasajero(Reserva.IdItinerario);

            DialogResult result = Agregar.ShowDialog();

            if (result == DialogResult.OK && Agregar.Pasajero != null)
            {
                RecibirDatosPasajero(Agregar.Pasajero);
                MessageBox.Show("Se Agregó el pasajero");

                cantAgregadaPasajeros = Pasajero.TotalAsignados();

                ActualizarCantidadDisponiblePasajeros(CantidadMaximaPasajeros - cantAgregadaPasajeros);
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
                    (AereosModel.GetAereosByIds(item.IdAereosSeleccionados)
                         .Where(x => x.TipoDePasajero == TipoDePasajeroEnum.adulto).Count()
                        + HotelesModel.GetHotelesByIds(item.IdHotelesSeleccionados)
                            .Where(x => x.CantidadMaximaDeAdultos > 0)
                            .Count()).ToString(),
                    (AereosModel.GetAereosByIds(item.IdAereosSeleccionados)
                         .Where(x => x.TipoDePasajero == TipoDePasajeroEnum.menor).Count()
                     + HotelesModel.GetHotelesByIds(item.IdHotelesSeleccionados)
                         .Where(x => x.CantidadMaximaDeMenores > 0)
                         .Count()).ToString(),
                    (AereosModel.GetAereosByIds(item.IdAereosSeleccionados)
                         .Where(x => x.TipoDePasajero == TipoDePasajeroEnum.infante).Count()
                     + HotelesModel.GetHotelesByIds(item.IdHotelesSeleccionados)
                         .Where(x => x.CantidadMaximaDeInfantes > 0)
                         .Count()).ToString(),
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

                ConfigurarMaximoDePasajerosPorTipo(presupuesto.SubItems[2].Text,
                    presupuesto.SubItems[3].Text,
                    presupuesto.SubItems[4].Text,
                    presupuesto.SubItems[5].Text);

                ActualizarInformacionPresupuesto(int.Parse(presupuesto.Text));
            }
            else
            {
                MessageBox.Show("Seleccione un presupuesto.");
            }
        }

        private void ConfigurarMaximoDePasajerosPorTipo(string totalPasajeros, string maximoPasajerosAdultos, string maximoPasajerosMenores, string maximoPasajerosInfantes)
        {
            CantidadMaximaPasajeros = int.Parse(totalPasajeros);
            CantidadMaximaPasajerosAdultos = int.Parse(maximoPasajerosAdultos);
            CantidadMaximaPasajerosMenores = int.Parse(maximoPasajerosMenores);
            CantidadMaximaPasajerosInfantes = int.Parse(maximoPasajerosInfantes);

            ActualizarCantidadDisponiblePasajeros(int.Parse(totalPasajeros));
        }

        private void ActualizarInformacionPresupuesto(int idPresupuesto)
        {
            lblcodigp.Text = "ID Presupuesto: " + idPresupuesto;
        }

        private void ActualizarCantidadDisponiblePasajeros(int nuevaCantidad)
        {
            lblcantpasajeros.Text = "Pasajeros Disponibles: " + nuevaCantidad;
        }

        private void GenerarReserva_Load(object sender, EventArgs e)
        {

        }

        private void btnGenreserva_Click(object sender, EventArgs e)
        {
            if (listPresupuestos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un presupuesto");
                return;
            }

            if (Pasajero is not null && Pasajero.TotalAsignados() == CantidadMaximaPasajeros)
            {
                ValidarEdadesPasajerosAsignados();

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

        private void ValidarEdadesPasajerosAsignados()
        {
            var cantidadPasajerosAdultosAsignados = Pasajero.IdsAereosAsignados
                .Select(x => AereosModel.GetAereoByID(x))
                .Where(x => x.TipoDePasajero == TipoDePasajeroEnum.adulto)
                .Count();

            cantidadPasajerosAdultosAsignados += Pasajero.IdsHotelesAsignados
                .Select(x => HotelesModel.GetHotelByID(x))
                .Where(x => x.CantidadMaximaDeAdultos > 0)
                .Count();

            var cantidadPasajerosMenoresAsignados = Pasajero.IdsAereosAsignados
                .Select(x => AereosModel.GetAereoByID(x))
                .Where(x => x.TipoDePasajero == TipoDePasajeroEnum.menor)
                .Count();

            cantidadPasajerosMenoresAsignados += Pasajero.IdsHotelesAsignados
                .Select(x => HotelesModel.GetHotelByID(x))
                .Where(x => x.CantidadMaximaDeMenores > 0)
                .Count();

            var cantidadPasajerosInfantesAsignados = Pasajero.IdsAereosAsignados
                .Select(x => AereosModel.GetAereoByID(x))
                .Where(x => x.TipoDePasajero == TipoDePasajeroEnum.infante)
                .Count();

            cantidadPasajerosInfantesAsignados += Pasajero.IdsHotelesAsignados
                .Select(x => HotelesModel.GetHotelByID(x))
                .Where(x => x.CantidadMaximaDeInfantes > 0)
                .Count();

            if (cantidadPasajerosAdultosAsignados > CantidadMaximaPasajerosAdultos)
            {
                MessageBox.Show("La cantidad de pasajeros adultos asignados supera el maximo permitido.");
                return;
            }

            if (cantidadPasajerosMenoresAsignados > CantidadMaximaPasajerosMenores)
            {
                MessageBox.Show("La cantidad de pasajeros menores asignados supera el maximo permitido.");
                return;
            }

            if (cantidadPasajerosInfantesAsignados > CantidadMaximaPasajerosInfantes)
            {
                MessageBox.Show("La cantidad de pasajeros infantes asignados supera el maximo permitido.");
                return;
            }

            //if (Pasajero.IdsAereosAsignados.Count + Pasajero.IdsHotelesAsignados.Count != CantidadMaximaPasajeros)
            //{
            //    MessageBox.Show("La cantidad de pasajeros asignados no coincide con la cantidad maxima permitida.");
            //    return;
            //}

            if (Pasajero.IdsAereosAsignados.Count != Pasajero.IdsAereosAsignados.Distinct().Count())
            {
                MessageBox.Show("No puede asignar el mismo aereo a mas de un pasajero.");
                return;
            }

            if (Pasajero.IdsHotelesAsignados.Count != Pasajero.IdsHotelesAsignados.Distinct().Count())
            {
                MessageBox.Show("No puede asignar el mismo hotel a mas de un pasajero.");
                return;
            }

            if (cantidadPasajerosAdultosAsignados + cantidadPasajerosMenoresAsignados +
                cantidadPasajerosInfantesAsignados != Pasajero.TotalAsignados())
            {
                MessageBox.Show("La cantidad de pasajeros asignados no coincide con el total necesario.");
                return;
            }

            if (cantidadPasajerosAdultosAsignados < CantidadMaximaPasajerosAdultos)
            {
                MessageBox.Show("La cantidad de pasajeros adultos asignados no coincide con el total necesario.");
                return;
            }

            if (cantidadPasajerosMenoresAsignados < CantidadMaximaPasajerosMenores)
            {
                MessageBox.Show("La cantidad de pasajeros menores asignados no coincide con el total necesario.");
                return;
            }

            if (cantidadPasajerosInfantesAsignados < CantidadMaximaPasajerosInfantes)
            {
                MessageBox.Show("La cantidad de pasajeros infantes asignados no coincide con el total necesario.");
                return;
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
