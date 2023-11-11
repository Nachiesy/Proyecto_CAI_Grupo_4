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
        private IngresarPasajeroModel Model;

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
            var nombre = nombrepasajerotxt.Text;
            var apellido = apellidopasajerotxt.Text;
            var dni = dnipasajerotxt.Text;
            var fchNacimiento = dtnacmiento.Text;
            var cantidadProductosSeleccionados = lv_ListadoProductos.SelectedItems.Count;

            var msg = Model.ValidarDatos(nombre, apellido, dni, fchNacimiento, cantidadProductosSeleccionados);

            if (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Model.CrearPasajero(nombre, apellido, dni, fchNacimiento);

            foreach (ListViewItem productoParaAsignar in lv_ListadoProductos.SelectedItems)
            {
                var tag = (ItinerarioItemTag)productoParaAsignar.Tag;

                if (tag.TipoDeServicio == "Aereo")
                {
                    Model.AsignarAereoSeleccionadoAPasajero(tag.Id, tag.IdProducto);
                }
                else if (tag.TipoDeServicio == "Hotel")
                {
                    Model.AsignarHotelSeleccionadoAPasajero(tag.Id, tag.IdProducto);
                }
            }

            Model.GuardarPasajero();

            GoToAgregarPasajeros();

            Close();
        }

        private void GoToAgregarPasajeros()
        {
            Model.ConfigurarParametros();

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

            var aereosAsignables = Model.TraerAereosAsignables();

            var hotelesAsignables = Model.TraerHotelesAsignables();

            lv_ListadoProductos.Items.Clear();


            foreach(var aereoAsignable in aereosAsignables)
            {
                lv_ListadoProductos.Items.Add(new ListViewItem(aereoAsignable.Id)
                {
                    SubItems =
                    {
                        aereoAsignable.TextoMostrado
                    },
                    Tag = new ItinerarioItemTag()
                    {
                        Id = aereoAsignable.Id,
                        IdProducto = aereoAsignable.IdProducto,
                        TipoDeServicio = "Aereo"
                    }
                });
            }

            foreach(var hotelAsignable in hotelesAsignables)
            {
                lv_ListadoProductos.Items.Add(new ListViewItem(hotelAsignable.Id)
                {
                    SubItems =
                    {
                        hotelAsignable.TextoMostrado
                    },
                    Tag = new ItinerarioItemTag()
                    {
                        Id = hotelAsignable.Id,
                        IdProducto = hotelAsignable.IdProducto,
                        TipoDeServicio = "Hotel"
                    }
                });
            }
        }
    }
}
