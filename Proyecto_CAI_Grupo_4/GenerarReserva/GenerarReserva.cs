﻿using Proyecto_CAI_Grupo_4.Models;
using Proyecto_CAI_Grupo_4.Utils;
using System.Data;
using System.Linq.Expressions;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Modelos;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Models.Productos;

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
            ListViewItem item = new ListViewItem(SumarPasajero.Nombre);
            item.SubItems.Add(SumarPasajero.Apellido.ToString());

            listPasajeros.Items.Add(item);

        }
        private void btnAddpasajero_Click(object sender, EventArgs e)
        {

            //if (controlPasajeros < reservaselct.CantPasajeros)
            //{
            //    IngresarPasajero Agregar = new IngresarPasajero();
            //    DialogResult result = Agregar.ShowDialog();

            //    if (result == DialogResult.OK)
            //    {
            //        if (Agregar.pasajero == null)
            //        {
            //        }
            //        else
            //        {
            //            RecibirDatosPasajero(Agregar.pasajero);
            //            MessageBox.Show("Se Agregó el pasajero");
            //            lblcantpasajeros.Text = "Pasajeros Disponibles: " + (reservaselct.CantPasajeros - controlPasajeros);
            //            controlPasajeros++;
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Limite de Pasajeros alcanzado");
            //}
        }


        private void listPresupuestos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private List<Reserva> reservas = ReservaModel.GetReservas();

        private void AddPresupuestosToListView(IEnumerable<Itinerario> listaItinerarios)
        {
            //var cantPasajeros = 0;
            //var aereos = AereosModel.GetAereosByIds(listaItinerarios.SelectMany(x => x.IdAereosSeleccionados));
            //var hoteles = HotelesModel.GetHotelesByIds(listaItinerarios.SelectMany(x => x.IdHotelesSeleccionados));

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
            //if (listPresupuestos.SelectedItems.Count > 0)
            //{
            //    ListViewItem presupuesto = listPresupuestos.SelectedItems[0];
            //    reservaselct.Codigo = int.Parse(presupuesto.SubItems[0].Text);
            //    reservaselct.CantPasajeros = int.Parse(presupuesto.SubItems[2].Text);
            //    reservaselct.CantMayores = int.Parse(presupuesto.SubItems[3].Text);
            //    reservaselct.CantMenores = int.Parse(presupuesto.SubItems[4].Text);
            //    if (presupuesto.SubItems[8].Text =="Si") { reservaselct.prereserva = true; } else { reservaselct.prereserva = false; };

            //    gbxPasajeros.Enabled = true;
            //    gpProsupuesto.Enabled = false;

            //    if (reservaselct.prereserva == true)
            //    {
            //        DialogResult resultado = MessageBox.Show("El presupuesto seleccionado ya posee una prereserva  ¿Desea crear la reserva con los mismos datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //        if (resultado == DialogResult.Yes)
            //        {
            //            MessageBox.Show("Reserva generada");
            //            this.Close();

            //            Thread thread = new Thread(OpenMenuPrincipal);
            //            thread.SetApartmentState(ApartmentState.STA);
            //            thread.Start();
            //        }
            //        else
            //        {
            //            lblcantpasajeros.Text = "Pasajeros Disponibles: " + reservaselct.CantPasajeros;
            //            lblcodigp.Text = "ID Presupuesto: " + reservaselct.Codigo;
            //        }
            //    }
            //    else
            //    {
            //        lblcantpasajeros.Text = "Pasajeros Disponibles: " + reservaselct.CantPasajeros;
            //        lblcodigp.Text = "ID Presupuesto: " + reservaselct.Codigo;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Seleccione un presupuesto.");
            //}

        }

        private void GenerarReserva_Load(object sender, EventArgs e)
        {

        }

        private void btnGenreserva_Click(object sender, EventArgs e)
        {
            //if (listPresupuestos.SelectedItems.Count > 0)
            //{
            //    if (reservaselct.CantPasajeros == controlPasajeros)
            //{
            //    MessageBox.Show("Reserva Generada Exitosamente");
            //    this.Close();

            //    Thread thread = new Thread(OpenMenuPrincipal);
            //    thread.SetApartmentState(ApartmentState.STA);
            //    thread.Start();
            //}
            //else
            //{
            //    MessageBox.Show("Debe Completar todos los pasajeros");

            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Seleccione un presupuesto");
            //}
        }

        private void listPasajeros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gpProsupuesto_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
        //    if (listPasajeros.SelectedItems.Count > 0)
        //    {
        //        foreach (ListViewItem item in listPasajeros.SelectedItems)
        //        {
        //            listPasajeros.Items.Remove(item);
        //            controlPasajeros--;
        //        }
        //    }
        }
    }
}
