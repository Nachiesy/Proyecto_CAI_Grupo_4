using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modules;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class ItinearioItemTag
    {
        public int IdProducto { get; set; }
        public string TipoDeServicio { get; set; }
    }

    public class GenerarPresupuestoMenuModel
    {
        public static int PresupuestoId = 0;
        public static bool EsNuevo = true;
        public static bool InitBuscarPresupuesto = false;

        public readonly string PrefijoCodigoPresupuesto = "P";
        public readonly string PrefijoCodigoAereo = "V";
        public readonly string PrefijoCodigoHotel = "H";
        public readonly int PrefijoCodigoItinerario = 1000;

        public int GenerarPresupuestoId()
        {
            return PresupuestosModule.GenerarId();
        }

        public Itinerario GetPresupuestoById()
        {
            return PresupuestosModule.GetPresupuestoById(PresupuestoId);
        }

        public void AddPresupuesto(Itinerario itinerario)
        {
            PresupuestosModule.AddPresupuesto(itinerario);
        }

        public void UpdatePresupuesto(Itinerario itinerarioActualizado)
        {
            PresupuestosModule.UpdatePresupuesto(itinerarioActualizado);
        }

        public string EsPresupuestoValido(string dni, string nombre, string apellido, int productosElegidos)
        {
            if (!dni.EsDNI())
            {
                return $"Debes ingresar un DNI correcto.";
            }

            if (string.IsNullOrEmpty(nombre))
            {
                return $"Debes ingresar un Nombre.";
            }

            if (string.IsNullOrEmpty(apellido))
            {
                return $"Debes ingresar un Apellido.";
            }

            if (productosElegidos == 0)
            {
                return $"Debes elegir productos para poder generar un Presupuesto.";
            }

            return null;
        }

        public Cliente GenerarCliente(string dni, string nombre, string apellido)
        {
            return new Cliente(dni, nombre, apellido);
        }

        public Itinerario GenerarItinerario(ListView listView, Cliente cliente, decimal total)
        {
            var itinerario = new Itinerario(PresupuestoId, cliente, total);

            for (var i = 0; i < listView.Items.Count; i++)
            {
                var tag = (ItinearioItemTag)listView.Items[i].Tag;

                var idUnico = PrefijoCodigoPresupuesto + PresupuestoId;

                if (tag.TipoDeServicio == "Aereo")
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

        public IEnumerable<AereoEnt> GetAereosElegidos()
        {
            return AereosModule.GetAereosElegidos();
        }

        public IEnumerable<HotelEnt> GetHotelesElegidos()
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
            Thread thread = new Thread(GenerarPresupuestoAereosModel.OpenGenerarPresupuestoAereos);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public static void OpenGenerarPresupuestoMenu()
        {
            if (EsNuevo)
            {
                Application.Run(new GenerarPresupuestoMenu());
            }
            else
            {
                Application.Run(new GenerarPresupuestoMenu(new GenerarPresupuestoMenuParams()
                {
                    PresupuestoId = PresupuestoId,
                    EsNuevo = EsNuevo,
                    InitBuscarPresupuesto = InitBuscarPresupuesto,
                }));
            }
        }

        public void GoToGenerarPresupuestoHoteles()
        {
            Thread thread = new Thread(GenerarPresupuestoHotelesModel.OpenGenerarPresupuestoHoteles);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public void GoToMenuPrincipal()
        {
            Thread thread = new Thread(MenuPrincipalModel.OpenMenuPrincipal);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
