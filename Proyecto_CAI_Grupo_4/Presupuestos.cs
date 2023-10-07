using Proyecto_CAI_Grupo_4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_CAI_Grupo_4
{
    public partial class Presupuestos : Form
    {
        public Presupuestos()
        {
            InitializeComponent();
        }

        private void buscarPresupuesto_Click(object sender, EventArgs e)
        {
            var presupuesto = new PresupuestoDto()
            {
                TipoDeServicio = tipoDeServicio.SelectedIndex,
                NombreDelServicio = nombreDelServicio.Text,
                CantidadDePasajerosAdultos = pasajerosAdultos.Text,
                CantidadDePasajerosMenores = pasajerosMenores.Text,
                PrecioDesde = precioDesde.Text,
                PrecioHasta = precioHasta.Text,
                FechaDesde = fechaDesde.Value,
                FechaHasta = fechaHasta.Value,
            };

            var validacion = ValidacionDePresupuesto(presupuesto);

            if (!string.IsNullOrEmpty(validacion))
            {
                MessageBox.Show(validacion, "Error", MessageBoxButtons.OK);
            }
        }

        private string ValidacionDePresupuesto(PresupuestoDto presupuesto)
        {
            var messages = string.Empty;

            messages += ValidarTipoDeServicio(presupuesto.TipoDeServicio);

            messages += ValidarPrecios(presupuesto);

            messages += ValidarPasajerosAdultosMenores(presupuesto);

            messages += ValidarFechas(presupuesto);

            return messages;
        }

        private string ValidarTipoDeServicio(int tipoDeServicio)
        {
            var messages = string.Empty;

            if (tipoDeServicio == -1)
            {
                messages += "Debes seleccionar un Tipo de Servicio" + Environment.NewLine;
            }

            return messages;
        }

        private string ValidarPrecios(PresupuestoDto presupuesto)
        {
            var messages = string.Empty;

            var precioDesdeEmpty = string.IsNullOrEmpty(presupuesto.PrecioDesde);
            var precioHastaEmpty = string.IsNullOrEmpty(presupuesto.PrecioHasta);

            var isPrecioDesdeDecimal = decimal.TryParse(presupuesto.PrecioDesde, out decimal precioDesde);
            var isPrecioHastaDecimal = decimal.TryParse(presupuesto.PrecioHasta, out decimal precioHasta);

            var precioMin = (decimal)0;
            var precioMax = (decimal)999.999;

            if (!precioDesdeEmpty)
            {
                if (!isPrecioDesdeDecimal)
                {
                    messages += $"Precio Desde debe ser un numero decimal" + Environment.NewLine;
                }
                else if (precioDesde < precioMin || precioDesde > precioMax)
                {
                    messages += $"El Precio Desde debe estar entre {precioMin} y {precioMax}" + Environment.NewLine;
                }
            }

            if (!precioHastaEmpty)
            {
                if (!isPrecioHastaDecimal)
                {
                    messages += $"Precio Hasta debe ser un numero decimal" + Environment.NewLine;
                }
                else if (precioHasta < precioMin || precioHasta > precioMax)
                {
                    messages += $"El Precio Hasta debe estar entre {precioMin} y {precioMax}" + Environment.NewLine;
                }
            }

            if (string.IsNullOrEmpty(messages) && !precioDesdeEmpty && !precioHastaEmpty)
            {
                if (precioDesde >= precioHasta)
                {
                    messages += "El Precio Desde debe ser menor al Precio Hasta" + Environment.NewLine;
                }
            }

            return messages;
        }

        private string ValidarPasajerosAdultosMenores(PresupuestoDto presupuesto)
        {
            var messages = string.Empty;

            messages += ValidarPasajeros(presupuesto.CantidadDePasajerosAdultos, "Pasajeros Adultos", 1, 10);

            messages += ValidarPasajeros(presupuesto.CantidadDePasajerosMenores, "Pasajeros Menores", 0, 10);

            if (string.IsNullOrEmpty(messages))
            {
                var adultos = int.Parse(presupuesto.CantidadDePasajerosAdultos);
                var menores = int.Parse(presupuesto.CantidadDePasajerosMenores);

                if (menores > adultos)
                {
                    messages += "Los Pasajeros Menores deben ser menores o igual a los Pasajeros Adultos" + Environment.NewLine;
                }
            }

            return messages;
        }

        private string ValidarPasajeros(string pasajeros, string label, int cantidadMin, int cantidadMax)
        {
            var messages = string.Empty;

            if (!int.TryParse(pasajeros, out int cantidad))
            {
                messages += $"{label} debe ser un numero entero" + Environment.NewLine;
            }
            else if (cantidad < cantidadMin || cantidad > cantidadMax)
            {
                messages += $"{label} debe ser del {cantidadMin} al {cantidadMax}" + Environment.NewLine;
            }

            return messages;
        }

        private string ValidarFechas(PresupuestoDto presupuesto)
        {
            var messages = string.Empty;

            if (presupuesto.FechaDesde.Date <= DateTime.Now.Date)
            {
                messages += "La Fecha Desde debe ser mayor a hoy" + Environment.NewLine;
            }
            else if (presupuesto.FechaDesde.Date >= presupuesto.FechaHasta.Date)
            {
                messages += "La Fecha Desde debe ser menor a la Fecha Hasta" + Environment.NewLine;
            }

            return messages;
        }
    }
}
