﻿using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modules;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class ItinearioItemTag
    {
        public int IdProducto { get; set; }
        public TipoDeServicioEnum TipoDeServicio { get; set; }
    }

    public class GenerarPresupuestoMenuModel
    {
        public static int PresupuestoId = 0;
        public static bool EsNuevo = true;

        public decimal Total = 0;

        public readonly string PrefijoCodigoPresupuesto = "P";
        public readonly string PrefijoCodigoAereo = "V";
        public readonly string PrefijoCodigoHotel = "H";
        public readonly int PrefijoCodigoItinerario = 1000;

        public void ActualizarEstadoBotones(ListView listView, Button btnEliminarTodo, Button btnEliminarSeleccion)
        {
            btnEliminarTodo.Enabled = listView.Items.Count > 0;
            btnEliminarSeleccion.Enabled = listView.SelectedItems.Count > 0;
        }

        public void ActualizarTextoPrecioTotal(Label label)
        {
            label.Text = Total > 0 ? $"Total: {Total:C2}" : "Total: $-";
        }

        public void AddProductosToListView(ListView listView, IEnumerable<Productos> productosToAdd)
        {
            var filasProducto = productosToAdd.Select(item => new ListViewItem(item.Codigo)
            {
                SubItems =
            {
                item.Codigo,
                item.Nombre,
                item.TipoDeServicio.GetDescription(),
                item.Precio.ToFormDecimal()
            },
                Tag = new ItinearioItemTag
                {
                    IdProducto = item.Id,
                    TipoDeServicio = item.TipoDeServicio
                }
            }).ToArray();

            listView.Items.AddRange(filasProducto);
        }

        public bool EsPresupuestoValido(string dni, string nombre, string apellido, int productosElegidos)
        {
            if (!dni.EsDNI())
            {
                MessageBox.Show($"Debes ingresar un DNI correcto.", "Error", MessageBoxButtons.OK);

                return false;
            }

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show($"Debes ingresar un Nombre.", "Error", MessageBoxButtons.OK);

                return false;
            }

            if (string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show($"Debes ingresar un Apellido.", "Error", MessageBoxButtons.OK);

                return false;
            }

            if (productosElegidos == 0)
            {
                MessageBox.Show($"Debes elegir productos para poder generar un Presupuesto.", "Error", MessageBoxButtons.OK);

                return false;
            }
            return true;
        }

        public Cliente GenerarCliente(string dni, string nombre, string apellido)
        {
            return new Cliente(dni, nombre, apellido);
        }

        public Itinerario GenerarItinerario(ListView listView, Cliente cliente)
        {
            var itinerario = new Itinerario(PresupuestoId, cliente, Total);

            for (var i = 0; i < listView.Items.Count; i++)
            {
                var tag = (ItinearioItemTag)listView.Items[i].Tag;

                var idUnico = PrefijoCodigoPresupuesto + PresupuestoId;

                if (tag.TipoDeServicio == TipoDeServicioEnum.aereo)
                {
                    idUnico += PrefijoCodigoAereo + (PrefijoCodigoItinerario + i);

                    itinerario.AddAereo(idUnico, tag.IdProducto);
                }
                else
                {
                    idUnico += PrefijoCodigoHotel + (PrefijoCodigoItinerario + i);

                    itinerario.AddHotel(idUnico, tag.IdProducto);
                }
            }

            return itinerario;
        }

        public void ActualizarCantidadesDeProductos()
        {
            AereosModule.ActualizarCantidadesDeAereos();

            HotelesModule.ActualizarCantidadesDeHoteles();
        }

        public void AddAereoElegido(int id)
        {
            AereosModule.AddAereoElegido(id);
        }

        public void AddHotelElegido(int id)
        {
            HotelesModule.AddHotelElegido(id);
        }

        public IEnumerable<Aereos> GetAereosElegidos()
        {
            return AereosModule.GetAereosElegidos();
        }

        public IEnumerable<Hoteles> GetHotelesElegidos()
        {
            return HotelesModule.GetHotelesElegidos();
        }

        public void ClearAereosElegidos()
        {
            AereosModule.ClearAereosElegidos();
        }

        public void ClearHotelesElegidos()
        {
            HotelesModule.ClearHotelesElegidos();
        }

        public void RemoveAereoElegido(int id)
        {
            AereosModule.RemoveAereoElegido(id);
        }

        public void RemoveHotelElegido(int id)
        {
            HotelesModule.RemoveHotelElegido(id);
        }

        public void ActualizarCantidadesDeAereos()
        {
            AereosModule.ActualizarCantidadesDeAereos();
        }

        public void ActualizarCantidadesDeHoteles()
        {
            HotelesModule.ActualizarCantidadesDeHoteles();
        }

        public void GoToGenerarPresupuestoAereos()
        {
            Thread thread = new Thread(OpenGenerarPresupuestoAereos);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenGenerarPresupuestoAereos()
        {
            Application.Run(new GenerarPresupuestoAereos());
        }

        public void GoToGenerarPresupuestoHoteles()
        {
            Thread thread = new Thread(OpenGenerarPresupuestoHoteles);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenGenerarPresupuestoHoteles()
        {
            Application.Run(new GenerarPresupuestoHoteles());
        }

        public void GoToMenuPrincipal()
        {
            Thread thread = new Thread(OpenMenuPrincipal);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenMenuPrincipal()
        {
            Application.Run(new MenuPrincipal());
        }
    }
}
