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
        public Pasajeros Pasajero { get; private set; }
        private List<Aereos> aereosAsignables { get; set; }
        private List<Hoteles> hotelesAsignables { get; set; }
        private int IdItinerario { get; set; }
        private Itinerario Itinerario { get; set; }

        private IngresarPasajeroModel Model = new IngresarPasajeroModel();

        private class ItinerarioItemTag
        {
            public string Id { get; set; }
            public int IdProducto { get; set; }
            public string TipoServicio { get; set; }
        }

        public IngresarPasajero(int presupuestoId) : base(tituloModulo: "Ingresar Pasajero", deshabilitarBotones: true)
        {
            Itinerario = Model.GetPresupuestoById(presupuestoId);

            aereosAsignables = AereosModule
                .GetAereosByIds(Itinerario.IdAereosSeleccionados
                    .Select(x => x.IdAereo))
                .ToList();

            hotelesAsignables = HotelesModule
                .GetHotelesByIds(Itinerario.IdHotelesSeleccionados
                    .Select(x => x.IdHotel))
                .ToList();

            IdItinerario = presupuestoId;

            InitializeComponent();
        }

        private void cancelpasajbtn_Click(object sender, EventArgs e)
        {
            Pasajero = null;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void confirmpasajerobtn_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            Pasajero = new Pasajeros(IdItinerario,
                nombrepasajerotxt.Text,
                apellidopasajerotxt.Text,
                int.Parse(dnipasajerotxt.Text),
                DateTime.Parse(dtnacmiento.Text));

            foreach (ListViewItem productoParaAsignar in lv_ListadoProductos.SelectedItems)
            {
                var tag = (ItinerarioItemTag)productoParaAsignar.Tag;

                if (tag.TipoServicio == TipoDeServicioEnum.aereo.ToString())
                {
                    Pasajero.AsignarAereo(new AereoSeleccionado(tag.Id, tag.IdProducto));
                }
                else if (tag.TipoServicio == TipoDeServicioEnum.hotel.ToString())
                {
                    Pasajero.AsignarHotel(new HotelSeleccionado(tag.Id, tag.IdProducto));
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void IngresarPasajero_Load(object sender, EventArgs e)
        {
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
                             $"{aereo.Nombre} - {aereo.TipoDePasajero.ToString().ToUpper()}"
                        },
                        Tag = new ItinerarioItemTag()
                        {
                            Id = aereoSeleccionadoEnItinerario.Id,
                            IdProducto = aereo.Id,
                            TipoServicio = TipoDeServicioEnum.aereo.ToString()
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
                             $"{hotel.Nombre} - {GetTextoPermitidosHoteles(hotel.CantidadMaximaDeMenores, hotel.CantidadMaximaDeInfantes)}"
                        },
                        Tag = new ItinerarioItemTag()
                        {
                            Id = hotelSeleccionadoEnItinerario.Id,
                            IdProducto = hotel.Id,
                            TipoServicio = TipoDeServicioEnum.hotel.ToString()
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
