using Proyecto_CAI_Grupo_4.Utils;
using System.Data;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Models;

namespace Proyecto_CAI_Grupo_4
{
    public partial class AgregarPasajeros : VistaBase
    {
        private AgregarPasajerosModel Model;

        public AgregarPasajeros() : base(tituloModulo: SetBaseTitle())
        {
            InitializeComponent();
        }

        private void AgregarPasajeros_Load(object sender, EventArgs e)
        {
            Model = new AgregarPasajerosModel();

            gbxPasajeros.Enabled = false;
            gbxPresupuesto.Enabled = true;

            if (Model.GetAgregarPasajerosParams().InitBuscarPasajeros)
            {
                //Traer el itinerario
                var presupuestoId = Model.GetAgregarPasajerosParams().PresupuestoId;

                var presupuesto = Model.GetPresupuestoById(presupuestoId);

                //Mostrarlo en la lista y deshabilitar el boton de buscar
                AddPresupuestoToListView(presupuesto);

                //Marcarlo como seleccionado en la listview
                listPresupuestos.Items[0].Selected = true;

                //Traer los pasajeros del itinerario existentes y los que estan x confirmar y listarlos en la lista de pasajeros
                var pasajeros = Model.GetPasajerosByIdPresupuesto(presupuestoId);

                foreach (var pasajero in pasajeros)
                {
                    AgregarPasajerosAereosAlListado(pasajero);

                    AgregarPasajerosHotelesAlListado(pasajero);

                    Model.AgregarPasajero(pasajero);
                }

                ActualizarInformacionPresupuesto(presupuestoId);

                gbxPasajeros.Enabled = true;
                gbxPresupuesto.Enabled = false;
            }
        }

        private static string SetBaseTitle()
        {
            return AgregarPasajerosModel.GetAgregarPasajerosParamsStatic().InitBuscarPasajeros
                ? $"Agregar Pasajeros - Presupuesto #{AgregarPasajerosModel.GetAgregarPasajerosParamsStatic().PresupuestoId}" : $"Agregar Pasajeros";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();

            var thread = new Thread(OpenMenuPrincipal);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void AddPresupuestoToListView(Itinerario itinerario)
        {
            listPresupuestos.Items.Add(new ListViewItem(itinerario.IdItinerario.ToString())
            {
                SubItems =
                {
                    itinerario.Cliente.DNI,
                    itinerario.PrecioTotal.ToString("C2"),
                }
            });
        }

        private void AddPresupuestosToListView(IEnumerable<Itinerario> listaItinerarios)
        {
            var itinerarios = listaItinerarios.Select(item => new ListViewItem(item.IdItinerario.ToString())
            {
                SubItems =
                {
                    item.Cliente.DNI,
                    item.PrecioTotal.ToString("C2"),
                }
            }).ToArray();


            listPresupuestos.Items.AddRange(itinerarios);
        }

        private void AgregarPasajerosHotelesAlListado(Pasajeros pasajero)
        {
            foreach (var i in pasajero.AereosAsignados)
            {
                listPasajeros.Items.Add(new ListViewItem(i.Id)
                {
                    SubItems =
                    {
                        Model.GetAereoById(i.IdAereo).Nombre,
                        pasajero.Nombre,
                        pasajero.Apellido,
                        pasajero.FechaNacimiento.ToShortDateString(),
                        pasajero.GetEdad().ToString(),
                        i.ToString()
                    },
                    Tag = pasajero
                });
            }
        }

        private void AgregarPasajerosAereosAlListado(Pasajeros pasajero)
        {
            foreach (var i in pasajero.HotelesAsignados)
            {
                listPasajeros.Items.Add(new ListViewItem(i.Id)
                {
                    SubItems =
                    {
                        Model.GetHotelById(i.IdHotel).Nombre,
                        pasajero.Nombre,
                        pasajero.Apellido,
                        pasajero.FechaNacimiento.ToShortDateString(),
                        pasajero.GetEdad().ToString(),
                        i.ToString()
                    },
                    Tag = pasajero
                });
            }
        }

        private void OpenIngresarPasajeros()
        {
            Application.Run(new IngresarPasajero());
        }

        private void btnAddPasajero_Click(object sender, EventArgs e)
        {
            this.Close();

            Model.SetAgregarPasajerosParams(new AgregarPasajerosParams()
            {
                InitBuscarPasajeros = true,
                PresupuestoId = Model.GetAgregarPasajerosParams().PresupuestoId,
            });

            var thread = new Thread(OpenIngresarPasajeros);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var codigo = nroPresupuestotxt.Text.Trim();
            var dni = txbDocumento.Text.Trim();

            var msg = Model.ValidarCamposBusqueda(codigo, dni);

            if (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listPresupuestos.Items.Clear();

            AddPresupuestosToListView(Model.GetPresupuestosModificables(codigo, dni));
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (listPresupuestos.SelectedItems.Count != 1)  
            {
                MessageBox.Show("Seleccione un presupuesto.");

                return;
            }

            ListViewItem presupuesto = listPresupuestos.SelectedItems[0];

            var idItinerarioSeleccionado = int.Parse(presupuesto.SubItems[0].Text);

            gbxPasajeros.Enabled = true;
            gbxPresupuesto.Enabled = false;

            ActualizarInformacionPresupuesto(int.Parse(presupuesto.Text));
            ActualizarPasajeros(idItinerarioSeleccionado);
        }

        private void ActualizarPasajeros(int presupuestoId)
        {
            var pasajeros = Model.GetPasajerosByIdPresupuesto(presupuestoId);

            foreach(var pasajero in pasajeros)
            {
                AgregarPasajerosAereosAlListado(pasajero);

                AgregarPasajerosHotelesAlListado(pasajero);

                Model.AgregarPasajero(pasajero);
            }

            Model.SetAgregarPasajerosParams(new AgregarPasajerosParams()
            {
                InitBuscarPasajeros = true,
                PresupuestoId = presupuestoId,
            });
        }

        private void ActualizarInformacionPresupuesto(int idPresupuesto)
        {
            lblcodigp.Text = "ID Presupuesto: " + idPresupuesto;
        }

        private void btnConfirmarPasajeros_Click(object sender, EventArgs e)
        {
            if (listPresupuestos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un presupuesto");

                return;
            }

            var idPresupuesto = int.Parse(listPresupuestos.SelectedItems[0].Text);

            MessageBox.Show("Pasajeros agregados al itinerario. ");

            Close();

            var thread = new Thread(OpenMenuPrincipal);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            if (listPasajeros.SelectedItems.Count == 0)
            {
                 MessageBox.Show("Seleccione un pasajero");

                return;
            }

            var idProducto = listPasajeros.SelectedItems[0].Text;
           
            var pasajero = (Pasajeros)listPasajeros.SelectedItems[0].Tag;

            listPasajeros.SelectedItems[0].Remove();

            Model.EliminarPasajero(pasajero);
        }
    }
}
