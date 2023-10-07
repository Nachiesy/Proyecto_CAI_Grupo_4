using Proyecto_CAI_Grupo_4.Models;
using Proyecto_CAI_Grupo_4.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarPresupuesto : Form
    {
        public static List<Presupuesto> presupuestos = new List<Presupuesto>()
        {
            new Presupuesto()
            {
                TipoDeServicio = TipoDeServicioEnum.aereo,
                NombreDelServicio = "Promo Familias",
                CantidadDePasajerosAdultos = 2,
                CantidadDePasajerosMenores = 2,
                PrecioDesde = 10,
                PrecioHasta = 20,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
            },
            new Presupuesto()
            {
                TipoDeServicio = TipoDeServicioEnum.hotel,
                NombreDelServicio = "Promo Pareja",
                CantidadDePasajerosAdultos = 2,
                CantidadDePasajerosMenores = 0,
                PrecioDesde = 5,
                PrecioHasta = 10,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
            },
            new Presupuesto()
            {
                TipoDeServicio = TipoDeServicioEnum.crucero,
                NombreDelServicio = "Promo Amigos y Familia",
                CantidadDePasajerosAdultos = 10,
                CantidadDePasajerosMenores = 10,
                PrecioDesde = 100,
                PrecioHasta = 200,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
            },
        };

        public static List<Presupuesto> searchedPresupuestos = new List<Presupuesto>();

        public GenerarPresupuesto()
        {
            InitializeComponent();
        }

        private void GenerarPresupuesto_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione la opción que desea agregar al presupuesto");

            AddPresupuestosToListView(searchedPresupuestos, presupuestosBuscados);
        }

        private void AddPresupuestosToListView(IEnumerable<Presupuesto> listToAdd, ListView listView)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.TipoDeServicio.GetDescription());

                row.SubItems.Add(item.NombreDelServicio);
                row.SubItems.Add(item.CantidadDePasajerosAdultos.ToString());
                row.SubItems.Add(item.CantidadDePasajerosMenores.ToString());
                row.SubItems.Add(item.PrecioDesde.ToString());
                row.SubItems.Add(item.PrecioHasta.ToString());
                row.SubItems.Add(item.FechaDesde.ToFormDate());
                row.SubItems.Add(item.FechaHasta.ToFormDate());

                listView.Items.Add(row);
            }
        }
    }
}
