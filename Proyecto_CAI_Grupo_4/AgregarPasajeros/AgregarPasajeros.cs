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

    public partial class AgregarPasajeros : VistaBase
    {
        private Reserva Reserva = null;
        private List<Pasajeros> Pasajeros = new List<Pasajeros>();

        public AgregarPasajeros() : base(tituloModulo: "Agregar Pasajeros")
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
            foreach (var i in SumarPasajero.AereosAsignados)
            {
                ListViewItem item = new ListViewItem(i.Id)
                {
                    SubItems =
                    {
                        AereosModel.GetAereoByID(i.IdAereo).Nombre,
                        SumarPasajero.Nombre,
                        SumarPasajero.Apellido,
                        SumarPasajero.FechaNacimiento.ToShortDateString(),
                        SumarPasajero.GetEdad().ToString(),
                        i.ToString()
                    },
                    Tag = new AereoSeleccionado(i.Id, i.IdAereo)
                };

                listPasajeros.Items.Add(item);
            }

            foreach (var i in SumarPasajero.HotelesAsignados)
            {
                ListViewItem item = new ListViewItem(i.Id)
                {
                    SubItems =
                    {
                        HotelesModel.GetHotelByID(i.IdHotel).Nombre,
                        SumarPasajero.Nombre,
                        SumarPasajero.Apellido,
                        SumarPasajero.FechaNacimiento.ToShortDateString(),
                        SumarPasajero.GetEdad().ToString(),
                        i.ToString()
                    },
                    Tag = new HotelSeleccionado(i.Id, i.IdHotel)
                };

                listPasajeros.Items.Add(item);
            }

            Pasajeros.Add(SumarPasajero);
        }
        private void btnAddpasajero_Click(object sender, EventArgs e)
        {
            //var idsNoAsignables = listPasajeros.Items.Cast<ListViewItem>()
            //    .Select(x => x.Text)
            //    .ToList();

            IngresarPasajero Agregar = new IngresarPasajero(Reserva.IdItinerario);

            DialogResult result = Agregar.ShowDialog();

            if (result == DialogResult.OK && Agregar.Pasajero != null)
            {
                RecibirDatosPasajero(Agregar.Pasajero);
                MessageBox.Show("Se Agregó el pasajero");
            }
        }

        private int GetCantidadProductosAsigadosAPasajeros()
        {
            return Pasajeros
                .Select(x => x.AereosAsignados.Count + x.HotelesAsignados.Count)
                .DefaultIfEmpty(0).Sum();
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
                    ObtenerEstadoFormateado(item.Estado),
                    item.FechaEstado.ToFormDate(),
                    item.PrecioTotal.ToString("C2"),
                }
            }).ToArray();


            listPresupuestos.Items.AddRange(itinerarios);
        }

        private string ObtenerEstadoFormateado(PresupuestoEstadoEnum estado)
        {
            if (estado == PresupuestoEstadoEnum.Presupuesto_Pendiente_De_Pago)
            {
                return PresupuestoEstadoEnum.Presupuesto_Abonado.GetDescription();
            }

            return PresupuestoEstadoEnum.EstadoInvalido.GetDescription();
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
                var presupuesto = PresupuestosModel
                    .GetPresupuestoById(int.Parse(codigo));

                listPresupuestos.Items.Clear();

                AddPresupuestosToListView(new List<Itinerario>() { presupuesto });
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

                Reserva = ReservaModel.GenerarNuevaReserva(idItinerario, ReservaEstadoEnum.PendienteDeConfirmacion, PresupuestosModel.GetPresupuestoById(idItinerario).Cliente);

                gbxPasajeros.Enabled = true;
                gbxPresupuesto.Enabled = false;

                ActualizarInformacionPresupuesto(int.Parse(presupuesto.Text));
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

            if (GetCantidadProductosAsigadosAPasajeros() == 0)
            {
                MessageBox.Show("Debe asignar al menos un pasajero");
                return;
            }

            var esValido = ValidarReserva();

            if (esValido)
            {
                ReservaModel.AddReserva(Reserva);

                var pasajerosConAsignaciones =
                    Pasajeros
                        .Where(x => x.HotelesAsignados.Any() || x.HotelesAsignados.Any()).ToList();

                PasajerosModel.AgregarPasajeros(pasajerosConAsignaciones);

                MessageBox.Show("Reserva Generada Exitosamente");
                this.Close();

                Thread thread = new Thread(OpenMenuPrincipal);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        private bool ValidarReserva()
        {
            //var cantidadAdultos = Pasajeros
            //    .Where(x => x.GetTipoDePasajero() == TipoDePasajeroEnum.adulto && (x.HotelesAsignados.Any() || x.AereosAsignados.Any()))
            //    .Count();

            //var cantidadMenores = Pasajeros
            //    .Where(x => x.GetTipoDePasajero() == TipoDePasajeroEnum.menor && (x.HotelesAsignados.Any() || x.AereosAsignados.Any()))
            //    .Count();

            //var cantidadInfantes = Pasajeros
            //    .Where(x => x.GetTipoDePasajero() == TipoDePasajeroEnum.infante && (x.HotelesAsignados.Any() || x.AereosAsignados.Any()))
            //    .Count();

            //! Nunca voy a tener problemas con las cantidades de ID's unicos, ya que se limita a la hora del agregado en el presupuesto


            //cantidad Agrupada PorTipo De Pasajero Y IdHotel y COUNT por cada grupo
            var agrupacionCantidadesHotelesSeleccionados = Pasajeros
                .SelectMany(x => 
                    x.HotelesAsignados.Select(y => 
                        new { TipoPasajero = x.GetTipoDePasajero(), IdHotel = y.IdHotel }))
                .GroupBy(x => new { x.IdHotel, x.TipoPasajero })
                .Select(x => new { x.Key.IdHotel, x.Key.TipoPasajero, Cantidad = x.Count() })
                .ToList();


            foreach(var pasajero in Pasajeros)
            {
                foreach (var aereoSeleccionado in pasajero.AereosAsignados)
                {
                    var aereo = AereosModel.GetAereoByID(aereoSeleccionado.IdAereo);

                    if (aereo.TipoDePasajero != pasajero.GetTipoDePasajero())
                    {
                        MessageBox.Show($"El pasajero {pasajero.Nombre} {pasajero.Apellido} no puede viajar en el aereo {aereo.Nombre} porque no es de su tipo de pasajero");
                        return false;
                    }
                }

                foreach (var hotelSeleccionado in pasajero.HotelesAsignados)
                {
                    var hotel = HotelesModel.GetHotelByID(hotelSeleccionado.IdHotel);
                    var tipoPasajero = pasajero.GetTipoDePasajero();

                    if (hotel.CantidadMaximaDeAdultos == 0 && tipoPasajero == TipoDePasajeroEnum.adulto)
                    {
                        MessageBox.Show($"El pasajero {pasajero.Nombre} {pasajero.Apellido} no puede hospedarse en el hotel {hotel.Nombre} porque no permite adultos");
                        return false;
                    }

                    if (hotel.CantidadMaximaDeMenores == 0 && tipoPasajero == TipoDePasajeroEnum.menor)
                    {
                        MessageBox.Show($"El pasajero {pasajero.Nombre} {pasajero.Apellido} no puede hospedarse en el hotel {hotel.Nombre} porque no permite menores");
                        return false;
                    }

                    if(hotel.CantidadMaximaDeInfantes == 0 && tipoPasajero == TipoDePasajeroEnum.infante)
                    {
                        MessageBox.Show($"El pasajero {pasajero.Nombre} {pasajero.Apellido} no puede hospedarse en el hotel {hotel.Nombre} porque no permite infantes");
                        return false;
                    }

                    var cantidadActualDelMismoHotelParaTipoPasajeroConcreto = agrupacionCantidadesHotelesSeleccionados
                        .SingleOrDefault(x => x.IdHotel == hotelSeleccionado.IdHotel && x.TipoPasajero == tipoPasajero)
                        .Cantidad;

                    if (tipoPasajero == TipoDePasajeroEnum.adulto &&
                        cantidadActualDelMismoHotelParaTipoPasajeroConcreto > hotel.CantidadMaximaDeAdultos)
                    {
                        MessageBox.Show($"El pasajero {pasajero.Nombre} {pasajero.Apellido} no puede hospedarse en el hotel {hotel.Nombre} porque ya hay {cantidadActualDelMismoHotelParaTipoPasajeroConcreto} adultos hospedados y el maximo es {hotel.CantidadMaximaDeAdultos}.", "Error de Validacion", MessageBoxButtons.OK);
                        return false;
                    }

                    if (tipoPasajero == TipoDePasajeroEnum.menor &&
                        cantidadActualDelMismoHotelParaTipoPasajeroConcreto > hotel.CantidadMaximaDeMenores)
                    {
                        MessageBox.Show($"El pasajero {pasajero.Nombre} {pasajero.Apellido} no puede hospedarse en el hotel {hotel.Nombre} porque ya hay {cantidadActualDelMismoHotelParaTipoPasajeroConcreto} menores hospedados y el maximo es {hotel.CantidadMaximaDeMenores}.", "Error de Validacion", MessageBoxButtons.OK);
                        return false;
                    }

                    if (tipoPasajero == TipoDePasajeroEnum.infante &&
                        cantidadActualDelMismoHotelParaTipoPasajeroConcreto > hotel.CantidadMaximaDeInfantes)
                    {
                        MessageBox.Show($"El pasajero {pasajero.Nombre} {pasajero.Apellido} no puede hospedarse en el hotel {hotel.Nombre} porque ya hay {cantidadActualDelMismoHotelParaTipoPasajeroConcreto} infantes hospedados y el maximo es {hotel.CantidadMaximaDeInfantes}.", "Error de Validacion", MessageBoxButtons.OK);
                        return false;
                    }

                }
            }

            //Para el caso de los hoteles esta bien a priori, ver el ejemplo de una habitacion cuadruple que permite 2 adultos y 2 menores...
            //if (Pasajeros.Any(x => x.HotelesAsignados.Any(y =>
            //        Pasajeros.Any(z => z.HotelesAsignados.Any(w => w.Id == y.Id && z != x)))))
            //{
            //    MessageBox.Show("Algun pasajero tiene asignado un mismo producto de hotel mas de una vez");
            //    return false;
            //}

            var agrupacionCantidadesVuelosSeleccionados = Pasajeros
                .SelectMany(x =>
                    x.AereosAsignados.Select(y =>
                        new { y.Id }))
                .GroupBy(x => new { x.Id })
                .Select(x => new { x.Key, Cantidad = x.Count() })
                .ToList();

            if (agrupacionCantidadesVuelosSeleccionados.Any(x => x.Cantidad > 1))
            {
                MessageBox.Show("Algun pasajero tiene asignado un mismo vuelo mas de una vez");
                return false;
            }

            //var agrupacionClientes = Pasajeros
            //    .GroupBy(x => x.DNI)
            //    .Select(x => new { x.Key, Cantidad = x.Count() })
            //    .ToList();

            //if (agrupacionClientes.Count > 1)
            //{
            //    MessageBox.Show("Algun pasajero se repite");
            //    return false;
            //}


            return true;
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

                    var indiceAereo = Pasajeros
                        .Find(x => x.Nombre == item.SubItems[2].Text && x.Apellido == item.SubItems[3].Text)
                        .AereosAsignados
                        .FindIndex(x => x.Id == ((AereoSeleccionado)item.Tag).Id);

                    var indiceHotel = Pasajeros
                        .Find(x => x.Nombre == item.SubItems[2].Text && x.Apellido == item.SubItems[3].Text)
                        .HotelesAsignados
                        .FindIndex(x => x.Id == ((HotelSeleccionado)item.Tag).Id);

                    if (indiceAereo != -1)
                    {
                        Pasajeros.Find(x => x.Nombre == item.SubItems[2].Text && x.Apellido == item.SubItems[3].Text).AereosAsignados.RemoveAt(indiceAereo);
                    }

                    if (indiceHotel != -1)
                    {
                        Pasajeros.Find(x => x.Nombre == item.SubItems[2].Text && x.Apellido == item.SubItems[3].Text).HotelesAsignados.RemoveAt(indiceHotel);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un pasajero");
            }
        }
    }
}
