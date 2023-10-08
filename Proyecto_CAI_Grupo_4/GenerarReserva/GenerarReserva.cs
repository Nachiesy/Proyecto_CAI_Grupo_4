﻿using Proyecto_CAI_Grupo_4.Models;
using Proyecto_CAI_Grupo_4.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_CAI_Grupo_4
{

    public partial class GenerarReserva : Form
    {

        public GenerarReserva()
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
        public event Action<Pasajeros> DatosPasajeros;
        private void btnAddpasajero_Click(object sender, EventArgs e)
        {
  
            Thread thread = new Thread(AgregarPasajero);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void AgregarPasajero()
        {
            Application.Run(new IngresarPasajero());
        }

        private void listPresupuestos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private List<Reserva> reservas = new List<Reserva>()
        {
            new Reserva()
            {
                Codigo = Guid.NewGuid(),
                Estado = ReservaEstadoEnum.pagada,
                TipoDoc = 1,
                DNI = "39117825",
                CantPasajeros = 2,
                Precio = (decimal)100000.50,
                Fecha = DateTime.Now.AddDays(-7),
                FechaDesde = DateTime.Now.AddDays(21),
                FechaHasta = DateTime.Now.AddDays(14),
            },
            new Reserva()
            {
                Codigo = Guid.NewGuid(),
                Estado = ReservaEstadoEnum.pagada,
                TipoDoc = 1,
                DNI = "27098332",
                CantPasajeros = 5,
                Precio = (decimal)50000,
                Fecha = DateTime.Now.AddDays(-14),
                FechaDesde = DateTime.Now.AddDays(14),
                FechaHasta = DateTime.Now.AddDays(7),
            },
            new Reserva()
            {
                Codigo = Guid.NewGuid(),
                Estado = ReservaEstadoEnum.pagada,
                TipoDoc = 1,
                DNI = "30945665",
                CantPasajeros = 2,
                Precio = (decimal)500000.95,
                Fecha = DateTime.Now.AddDays(-21),
                FechaDesde = DateTime.Now.AddDays(7),
                FechaHasta = DateTime.Now.AddDays(21),
            },
                        new Reserva()
            {
                Codigo = Guid.NewGuid(),
                Estado = ReservaEstadoEnum.pagada,
                TipoDoc = 1,
                DNI = "20945665",
                CantPasajeros = 2,
                Precio = (decimal)500000.95,
                Fecha = DateTime.Now.AddDays(-21),
                FechaDesde = DateTime.Now.AddDays(7),
                FechaHasta = DateTime.Now.AddDays(21),
            },
        };
        private void btnBuscar_Click(object sender, EventArgs e, Guid nropresup)
        {
            Guid nropresuo = new Guid(nroPresupuestotxt.Text.Trim());

            var tipodoc = cbxTipodoc.SelectedIndex;

            var nroDeDoc = txbDocumento.Text.Trim();

            var filteredReservas = reservas
                .Where(x =>
                            (tipodoc == -1 || (int)x.TipoDoc == tipodoc)
                            && (string.IsNullOrEmpty(nroDeDoc) || x.DNI == nroDeDoc));

            if (filteredReservas.Any())
            {
                listPresupuestos.Items.Clear();

                AddReservasToListView(filteredReservas);
            }
            else
            {
                MessageBox.Show("No hay reservas disponibles para los parámetros ingresados.", "Error", MessageBoxButtons.OK);
            }
        }
        private void AddReservasToListView(IEnumerable<Reserva> list)
        {
            foreach (var item in list)
            {
                var row = new ListViewItem(item.Codigo.ToString());
                row.SubItems.Add(item.DNI);
                row.SubItems.Add(item.CantPasajeros.ToString());
                row.SubItems.Add(item.Precio.ToString());
                row.SubItems.Add(item.Estado.GetDescription());
                row.SubItems.Add(item.FechaDesde.ToFormDate());
                row.SubItems.Add(item.FechaHasta.ToFormDate());
                row.SubItems.Add(item.Fecha.ToFormDate());

                listPresupuestos.Items.Add(row);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var codigo = nroPresupuestotxt.Text.Trim();

            var tipodoc = cbxTipodoc.SelectedIndex;

            var dni = txbDocumento.Text.Trim();

            var filteredReservas = reservas
                .Where(x => (string.IsNullOrEmpty(codigo) || x.Codigo == Guid.Parse(codigo))
                            && (tipodoc == -1 || (int)x.Estado == tipodoc)
                           && (string.IsNullOrEmpty(dni) || x.DNI == dni));

            if (filteredReservas.Any())
            {
                listPresupuestos.Items.Clear();

                AddReservasToListView(filteredReservas);
            }
            else
            {
                MessageBox.Show("No hay reservas disponibles para los parámetros ingresados.", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {


            if (listPresupuestos.SelectedItems.Count > 0)
            {
                // Reserva ReservaSelecc = listPresupuestos.SelectedItems;

                gbxPasajeros.Enabled = true;

            lblcantpasajeros.Text = "Pasajeros Disponibles " + listPresupuestos.SelectedItems;
            }
            else{
                MessageBox.Show("Seleccione un presupuesto.");
            }

        }

        private void GenerarReserva_Load(object sender, EventArgs e)
        {

        }
    }
}
