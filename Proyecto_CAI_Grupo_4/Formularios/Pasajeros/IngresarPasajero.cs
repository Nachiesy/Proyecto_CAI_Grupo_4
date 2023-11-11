using Proyecto_CAI_Grupo_4.Models;
using Proyecto_CAI_Grupo_4.Utils;
using System.Data;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modules;

namespace Proyecto_CAI_Grupo_4
{
    public partial class IngresarPasajero : VistaBase
    {
        private int IdItinerario { get; set; }
        private Itinerario Itinerario { get; set; }
        private IngresarPasajeroModel Model;

        private class ItinerarioItemTag
        {
            public string Id { get; set; }
            public int IdProducto { get; set; }
            public string TipoServicio { get; set; }
        }

        public IngresarPasajero() : base(tituloModulo: "Ingresar Pasajero", deshabilitarBotones: true)
        {
            InitializeComponent();
        }

        private void btnCancelarIngresoPasajeros_Click(object sender, EventArgs e)
        {
            GoToAgregarPasajeros();

            Close();
        }

        private void btnConfirmarPasajerosIngresados_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var pasajero = new Pasajeros(IdItinerario,
                nombrepasajerotxt.Text,
                apellidopasajerotxt.Text,
                int.Parse(dnipasajerotxt.Text),
                DateTime.Parse(dtnacmiento.Text));

            foreach (ListViewItem productoParaAsignar in lv_ListadoProductos.SelectedItems)
            {
                var tag = (ItinerarioItemTag)productoParaAsignar.Tag;

                if (tag.TipoServicio == "Aereo")
                {
                    pasajero.AsignarAereo(new AereoSeleccionado(tag.Id, tag.IdProducto));
                }
                else if (tag.TipoServicio == "Hotel")
                {
                    pasajero.AsignarHotel(new HotelSeleccionado(tag.Id, tag.IdProducto));
                }
            }

            Model.AgregarPasajeroPorConfirmar(pasajero);

            GoToAgregarPasajeros();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void GoToAgregarPasajeros()
        {
            Model.SetAgregarPasajerosParams(new AgregarPasajerosParams()
            {
                InitBuscarPasajeros = true,
                PresupuestoId = IdItinerario,
            });

            var thread = new Thread(OpenAgregarPasajeros);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenAgregarPasajeros()
        {
            Application.Run(new AgregarPasajeros());
        }

        private void IngresarPasajero_Load(object sender, EventArgs e)
        {
            Model = new IngresarPasajeroModel();

            var presupuestoId = Model.GetAgregarPasajerosParams().PresupuestoId;

            Itinerario = Model.GetPresupuestoById(presupuestoId);
            IdItinerario = presupuestoId;

            var aereosAsignables = AereosModule
                .GetAereosByIds(Itinerario.IdAereosSeleccionados
                    .Select(x => x.IdAereo))
                .ToList();

            var hotelesAsignables = HotelesModule
                .GetHotelesByIds(Itinerario.IdHotelesSeleccionados
                    .Select(x => x.IdHotel))
                .ToList();

            lv_ListadoProductos.Items.Clear();

            lv_ListadoProductos.Items
                .AddRange(Itinerario.IdAereosSeleccionados
                .Join(
                    aereosAsignables,
                    aereoSeleccionadoEnItinerario => aereoSeleccionadoEnItinerario.IdAereo,
                    aereo => aereo.Id,
                    (aereoSeleccionadoEnItinerario, aereo) => new ListViewItem(aereoSeleccionadoEnItinerario.Id)
                    {
                        SubItems =
                        {
                             $"{aereo.Nombre} - {aereo.Tarifa.TipoDePasajero.ToUpper()}"
                        },
                        Tag = new ItinerarioItemTag()
                        {
                            Id = aereoSeleccionadoEnItinerario.Id,
                            IdProducto = aereo.Id,
                            TipoServicio = "Aereo"
                        }
                    }).ToArray());

            lv_ListadoProductos.Items
                .AddRange(Itinerario.IdHotelesSeleccionados
                .Join(
                    hotelesAsignables,
                    hotelSeleccionadoEnItinerario => hotelSeleccionadoEnItinerario.IdHotel,
                    hotel => hotel.Id,
                    (hotelSeleccionadoEnItinerario, hotel) => new ListViewItem(hotelSeleccionadoEnItinerario.Id)
                    {
                        SubItems =
                        {
                             $"{hotel.Nombre} - {GetTextoPermitidosHoteles(hotel.Disponibilidad.CantidadMaximaMenores, hotel.Disponibilidad.CantidadMaximaInfantes)}"
                        },
                        Tag = new ItinerarioItemTag()
                        {
                            Id = hotelSeleccionadoEnItinerario.Id,
                            IdProducto = hotel.Id,
                            TipoServicio = "Hotel"
                        }
                    }).ToArray());
        }

        private string GetTextoPermitidosHoteles(int cantidadMaximaMenores, int cantidadMaximaInfantes)
        {
            var str = "";

            if (cantidadMaximaInfantes > 0 && cantidadMaximaMenores > 0)
            {
                str += "Permite Infantes y Menores";
            }
            else if (cantidadMaximaInfantes > 0)
            {
                str += "Permite Infantes";
            }
            else if (cantidadMaximaMenores > 0)
            {
                str += "Permite Menores";
            }
            else
            {
                str += "Permite solo adultos";
            }
            return str;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(nombrepasajerotxt.Text))
            {
                MessageBox.Show("Debe ingresar un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(apellidopasajerotxt.Text))
            {
                MessageBox.Show("Debe ingresar un apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(dnipasajerotxt.Text))
            {
                MessageBox.Show("Debe ingresar un DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!dnipasajerotxt.Text.EsDNI())
            {
                MessageBox.Show("Debe ingresar un DNI valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (DateTime.Parse(dtnacmiento.Text) > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser mayor a la fecha actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (lv_ListadoProductos.SelectedItems.Count < 1)
            {
                MessageBox.Show("Debe seleccionar al menos un producto para asignar al pasajero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
