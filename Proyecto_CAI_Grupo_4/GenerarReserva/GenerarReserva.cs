using Proyecto_CAI_Grupo_4.Models;
using Proyecto_CAI_Grupo_4.Utils;
using System.Data;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Managers;

namespace Proyecto_CAI_Grupo_4
{

    public partial class GenerarReserva : VistaBase
    {
        Reserva reservaselct = new Reserva();
        int controlPasajeros = 0;
        public GenerarReserva() : base(tituloModulo: "Generar Reserva")
        {
            InitializeComponent();
        }
        private void GenerarReservao_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)

        {
            this.Close();

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


            ListViewItem item = new ListViewItem(SumarPasajero.Nombre);
            item.SubItems.Add(SumarPasajero.Apellido.ToString());
            item.SubItems.Add(SumarPasajero.Fecha_Nac.ToFormDate());
            item.SubItems.Add(SumarPasajero.Edad.ToString());
            item.SubItems.Add(SumarPasajero.Tipo.ToString());
            item.SubItems.Add(SumarPasajero.Nacionalidad.ToString());
            item.SubItems.Add(SumarPasajero.Tipo_Doc.ToString());
            item.SubItems.Add(SumarPasajero.Doc.ToString());
            item.SubItems.Add(SumarPasajero.Fecha_Exp.ToFormDate());
            item.SubItems.Add(SumarPasajero.Pais_emisor.ToString());
            item.SubItems.Add(SumarPasajero.Email.ToString());
            item.SubItems.Add(SumarPasajero.Tel_contacto.ToString());

            listPasajeros.Items.Add(item);

        }
        private void btnAddpasajero_Click(object sender, EventArgs e)
        {

            if (controlPasajeros < reservaselct.CantPasajeros)
            {
                IngresarPasajero Agregar = new IngresarPasajero();
                DialogResult result = Agregar.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (Agregar.pasajero == null)
                    {
                    }
                    else
                    {
                        RecibirDatosPasajero(Agregar.pasajero);
                        MessageBox.Show("Se Agregó el pasajero");
                        lblcantpasajeros.Text = "Pasajeros Disponibles: " + (reservaselct.CantPasajeros - controlPasajeros);
                        controlPasajeros++;
                    }



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
        private List<Reserva> reservas = ReservasManager.reservas;

        private void AddReservasToListView(IEnumerable<Reserva> list)
        {
            foreach (var item in list)
            {
                var row = new ListViewItem(item.Codigo.ToString());
                row.SubItems.Add(item.DNI);
                row.SubItems.Add(item.CantPasajeros.ToString());
                row.SubItems.Add(item.CantMayores.ToString());
                row.SubItems.Add(item.CantMenores.ToString());
                row.SubItems.Add(item.Precio.ToString());
                row.SubItems.Add(item.Estado.GetDescription());
                row.SubItems.Add(item.Fecha.ToFormDate());
                if (item.prereserva==true){row.SubItems.Add("Si");}else { row.SubItems.Add("No"); }


                listPresupuestos.Items.Add(row);
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var codigo = nroPresupuestotxt.Text.Trim();
            var dni = txbDocumento.Text.Trim();

            if (dni == "")
            {

                var filteredReservas = reservas
                .Where(x => (string.IsNullOrEmpty(codigo) || (int)x.Codigo == int.Parse(codigo))
                 && (string.IsNullOrEmpty(dni) || x.DNI == dni));
                if (filteredReservas.Any())
                {
                    listPresupuestos.Items.Clear();

                    AddReservasToListView(filteredReservas);
                }
                else
                {
                    listPresupuestos.Items.Clear();
                }
            }
            else if (!dni.EsDNI())
            {
                MessageBox.Show("Ingrese un DNI valido por favor.");
            }
            else
            {
                var filteredReservas = reservas
                .Where(x => (string.IsNullOrEmpty(codigo) || (int)x.Codigo == int.Parse(codigo))
                 && (string.IsNullOrEmpty(dni) || x.DNI == dni));
                if (filteredReservas.Any())
                {
                    listPresupuestos.Items.Clear();

                    AddReservasToListView(filteredReservas);
                }
                else
                {
                    listPresupuestos.Items.Clear();
                }
            };
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {


            if (listPresupuestos.SelectedItems.Count > 0)
            {


                ListViewItem presupuesto = listPresupuestos.SelectedItems[0];
                reservaselct.Codigo = int.Parse(presupuesto.SubItems[0].Text);
                reservaselct.CantPasajeros = int.Parse(presupuesto.SubItems[2].Text);
                reservaselct.CantMayores = int.Parse(presupuesto.SubItems[3].Text);
                reservaselct.CantMenores = int.Parse(presupuesto.SubItems[4].Text);
                if (presupuesto.SubItems[8].Text =="Si") { reservaselct.prereserva = true; } else { reservaselct.prereserva = false; };

                gbxPasajeros.Enabled = true;
                gpProsupuesto.Enabled = false;

                if (reservaselct.prereserva == true)
                {
                    DialogResult resultado = MessageBox.Show("El presupuesto seleccionado ya posee una prereserva  ¿Desea crear la reserva con los mismos datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        MessageBox.Show("Reserva generada");
                        this.Close();

                        Thread thread = new Thread(OpenMenuPrincipal);
                        thread.SetApartmentState(ApartmentState.STA);
                        thread.Start();
                    }
                    else
                    {
                        lblcantpasajeros.Text = "Pasajeros Disponibles: " + reservaselct.CantPasajeros;
                        lblcodigp.Text = "ID Presupuesto: " + reservaselct.Codigo;
                    }
                }
                else
                {
                    lblcantpasajeros.Text = "Pasajeros Disponibles: " + reservaselct.CantPasajeros;
                    lblcodigp.Text = "ID Presupuesto: " + reservaselct.Codigo;
                }




            }
            else
            {
                MessageBox.Show("Seleccione un presupuesto.");
            }

        }

        private void GenerarReserva_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGenreserva_Click(object sender, EventArgs e)
        {
            if (listPresupuestos.SelectedItems.Count > 0)
            {
                if (reservaselct.CantPasajeros == controlPasajeros)
            {
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
                    controlPasajeros--;
                }
            }
        }
    }
}
