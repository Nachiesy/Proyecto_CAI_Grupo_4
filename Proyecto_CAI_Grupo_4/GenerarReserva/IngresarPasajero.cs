using Proyecto_CAI_Grupo_4.Models;
using Proyecto_CAI_Grupo_4.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Models.Productos;

namespace Proyecto_CAI_Grupo_4
{
    public partial class IngresarPasajero : VistaBase
    {
        public Pasajeros Pasajero { get; private set; }
        private List<Aereos> aereosAsignables { get; set; }
        private List<Hoteles> hotelesAsignables { get; set; }
        private int IdItinerario { get; set; }

        private class ListBoxItem
        {
            public string Display { get; set; }
            public int Id { get; set; }
            public string TipoServicio { get; set; }
        }

        public IngresarPasajero(int presupuestoId) : base(tituloModulo: "Ingresar Pasajero", deshabilitarBotones: true)
        {

            var itinerario = PresupuestosModel.GetPresupuesto(presupuestoId);

            aereosAsignables = AereosModel.GetAereosByIds(itinerario.IdAereosSeleccionados).ToList();

            hotelesAsignables = HotelesModel.GetHotelesByIds(itinerario.IdHotelesSeleccionados).ToList();

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

            foreach (ListBoxItem productoParaAsignar in listaProductosPorAsignar.SelectedItems)
            {
                if (productoParaAsignar.TipoServicio == TipoDeServicioEnum.aereo.ToString())
                {
                    Pasajero.AsignarAereo(productoParaAsignar.Id);
                }
                else if (productoParaAsignar.TipoServicio == TipoDeServicioEnum.hotel.ToString())
                {
                    Pasajero.AsignarHotel(productoParaAsignar.Id);
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void IngresarPasajero_Load(object sender, EventArgs e)
        {
            listaProductosPorAsignar.Items.Clear();
            listaProductosPorAsignar.DisplayMember = "Display";

            listaProductosPorAsignar.Items.AddRange(aereosAsignables.Select(x => new ListBoxItem
            {
                Display = $"{x.Id} - {x.Nombre} - {x.TipoDePasajero.ToString().ToUpper()}",
                Id = x.Id,
                TipoServicio = x.TipoDeServicio.ToString()
            }).ToArray());

            listaProductosPorAsignar.Items.AddRange(hotelesAsignables.Select(x => new ListBoxItem
            {
                Display = $"{x.Id} - {x.Nombre} - {GetTextoPermitidosHoteles(x.CantidadMaximaDeMenores, x.CantidadMaximaDeInfantes)}",
                Id = x.Id,
                TipoServicio = x.TipoDeServicio.ToString()
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

            if (DateTime.Parse(dtnacmiento.Text) > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser mayor a la fecha actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (listaProductosPorAsignar.SelectedItems.Count < 1)
            {
                MessageBox.Show("Debe seleccionar al menos un producto para asignar al pasajero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
