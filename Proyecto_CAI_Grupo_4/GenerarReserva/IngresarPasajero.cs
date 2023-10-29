using Proyecto_CAI_Grupo_4.Models;
using Proyecto_CAI_Grupo_4.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
            public Guid Id { get; set; }
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
            //TODO: Validaciones

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
                Display = $"{x.Codigo} - {x.Nombre}",
                Id = x.Id,
                TipoServicio = x.TipoDeServicio.ToString()
            }).ToArray());

            listaProductosPorAsignar.Items.AddRange(hotelesAsignables.Select(x => new ListBoxItem
            {
                Display = $"{x.Codigo} - {x.Nombre}",
                Id = x.Id,
                TipoServicio = x.TipoDeServicio.ToString()
            }).ToArray());
        }
    }
}
