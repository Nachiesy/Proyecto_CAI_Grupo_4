using Proyecto_CAI_Grupo_4.Utils;
using System.Data;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Models;

namespace Proyecto_CAI_Grupo_4
{
    public partial class AgregarPasajeros : VistaBase
    {
        private int _idItinerario;

        AgregarPasajerosModel Model = new AgregarPasajerosModel();

        public AgregarPasajeros() : base(tituloModulo: "Agregar Pasajeros")
        {
            InitializeComponent();
        }

        private void GenerarReserva_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();

            Model.GoToMenuPrinicipal();
        }

        public void RecibirDatosPasajero(Pasajeros SumarPasajero)
        {
            foreach (var i in SumarPasajero.AereosAsignados)
            {
                ListViewItem item = new ListViewItem(i.Id)
                {
                    SubItems =
                    {
                        Model.GetAereoById(i.IdAereo).Nombre,
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
                        Model.GetHotelById(i.IdHotel).Nombre,
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

            Model.Pasajeros.Add(SumarPasajero);
        }

        private void btnAddpasajero_Click(object sender, EventArgs e)
        {
            //var idsNoAsignables = listPasajeros.Items.Cast<ListViewItem>()
            //    .Select(x => x.Text)
            //    .ToList();

            IngresarPasajero Agregar = new IngresarPasajero(_idItinerario);

            DialogResult result = Agregar.ShowDialog();

            if (result == DialogResult.OK && Agregar.Pasajero != null)
            {
                RecibirDatosPasajero(Agregar.Pasajero);
                MessageBox.Show("Se Agregó el pasajero");
            }
        }

        private int GetCantidadProductosAsigadosAPasajeros()
        {
            return Model.Pasajeros
                .Select(x => x.AereosAsignados.Count + x.HotelesAsignados.Count)
                .DefaultIfEmpty(0).Sum();
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
                var presupuestos = Model.GetPresupuestosByDNI(dni);

                listPresupuestos.Items.Clear();

                AddPresupuestosToListView(presupuestos);

                return;
            }

            if (!string.IsNullOrEmpty(codigo))
            {
                var presupuesto = Model.GetPresupuestoById(int.Parse(codigo));

                listPresupuestos.Items.Clear();

                AddPresupuestosToListView(new List<Itinerario>() { presupuesto });
                return;
            }

            listPresupuestos.Items.Clear();

            AddPresupuestosToListView(Model.GetPresupuestos());
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (listPresupuestos.SelectedItems.Count != 1)  
            {
                MessageBox.Show("Seleccione un presupuesto.");

                return;
            }

            ListViewItem presupuesto = listPresupuestos.SelectedItems[0];

            _idItinerario = int.Parse(presupuesto.SubItems[0].Text);

            gbxPasajeros.Enabled = true;
            gbxPresupuesto.Enabled = false;

            ActualizarInformacionPresupuesto(int.Parse(presupuesto.Text));
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

            if (GetCantidadProductosAsigadosAPasajeros() == 0)
            {
                MessageBox.Show("Debe asignar al menos un pasajero");

                return;
            }

            var esValido = Model.ValidarPasajeros();

            if (esValido)
            {
                Model.AgregarPasajeros();

                MessageBox.Show("Pasajeros confirmados para el itinerario: " + _idItinerario);

                Close();

                Model.GoToMenuPrinicipal();
            }
        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            if (listPasajeros.SelectedItems.Count == 0)
            {
                 MessageBox.Show("Seleccione un pasajero");

                return;
            }

            foreach (ListViewItem item in listPasajeros.SelectedItems)
            {
                listPasajeros.Items.Remove(item);

                var indiceAereo = Model.Pasajeros
                    .Find(x => x.Nombre == item.SubItems[2].Text && x.Apellido == item.SubItems[3].Text)
                    .AereosAsignados
                    .FindIndex(x => x.Id == ((AereoSeleccionado)item.Tag).Id);

                var indiceHotel = Model.Pasajeros
                    .Find(x => x.Nombre == item.SubItems[2].Text && x.Apellido == item.SubItems[3].Text)
                    .HotelesAsignados
                    .FindIndex(x => x.Id == ((HotelSeleccionado)item.Tag).Id);

                if (indiceAereo != -1)
                {
                    Model.Pasajeros.Find(x => x.Nombre == item.SubItems[2].Text && x.Apellido == item.SubItems[3].Text).AereosAsignados.RemoveAt(indiceAereo);
                }

                if (indiceHotel != -1)
                {
                    Model.Pasajeros.Find(x => x.Nombre == item.SubItems[2].Text && x.Apellido == item.SubItems[3].Text).HotelesAsignados.RemoveAt(indiceHotel);
                }
            }
        }
    }
}
