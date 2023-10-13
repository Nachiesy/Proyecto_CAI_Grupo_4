using Proyecto_CAI_Grupo_4.Models;
using Proyecto_CAI_Grupo_4.Utils;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Managers;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarPreReserva : VistaBase
    {
        private readonly Reserva reserva = GenerarPresupuestosManager.reservas.Last();

        int controlPasajeros = 0;

        public GenerarPreReserva() : base(tituloModulo: "Generar Presupuesto > Pre Reserva")
        {
            InitializeComponent();
        }

        private void GenerarPreReserva_Load(object sender, EventArgs e)
        {
            lblcantpasajeros.Text = "Pasajeros Disponibles: " + (reserva.CantPasajeros - controlPasajeros);
            lblcodigp.Text = $"ID Presupuesto:  - {reserva.Codigo.ToString()}";
        }

        public void RecibirDatosPasajero(Pasajeros SumarPasajero)
        {
            ListViewItem item = new ListViewItem(SumarPasajero.Nombre);
            item.SubItems.Add(SumarPasajero.Apellido.ToString());
            item.SubItems.Add(SumarPasajero.Fecha_Nac.ToFormDate());
            item.SubItems.Add(SumarPasajero.Edad.ToString());
            item.SubItems.Add(SumarPasajero.Tipo.ToString());
            item.SubItems.Add(SumarPasajero.Nacionalidad.ToString());
            item.SubItems.Add(SumarPasajero.Tipo_Doc.ToString());
            item.SubItems.Add(SumarPasajero.Doc.ToString());
            item.SubItems.Add(SumarPasajero.Pais_emisor.ToString());
            item.SubItems.Add(SumarPasajero.Fecha_Exp.ToFormDate());
            item.SubItems.Add(SumarPasajero.Email.ToString());
            item.SubItems.Add(SumarPasajero.Tel_contacto.ToString());

            listPasajeros.Items.Add(item);
        }

        private void btnAddpasajero_Click(object sender, EventArgs e)
        {
            if (controlPasajeros < reserva.CantPasajeros)
            {
                IngresarPasajero Agregar = new IngresarPasajero();
                DialogResult result = Agregar.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (Agregar.pasajero != null)
                    {
                        RecibirDatosPasajero(Agregar.pasajero);
                        MessageBox.Show("Se Agregó el pasajero");
                        lblcantpasajeros.Text = "Pasajeros Disponibles: " + (reserva.CantPasajeros - controlPasajeros);
                        controlPasajeros++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Limite de Pasajeros alcanzado");
            }
        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            if (listPasajeros.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listPasajeros.SelectedItems)
                {
                    listPasajeros.Items.Remove(item);
                    controlPasajeros--;
                }
            }
        }

        private void btnGenreserva_Click(object sender, EventArgs e)
        {
            if (reserva.CantPasajeros == controlPasajeros)
            {
                MessageBox.Show("Pre Reserva Generada Exitosamente");
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

        private void OpenMenuPrincipal()
        {
            Application.Run(new MenuPrincipal());
        }
    }
}
