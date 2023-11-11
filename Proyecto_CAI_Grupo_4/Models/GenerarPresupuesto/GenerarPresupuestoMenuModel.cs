using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modules;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class GenerarPresupuestoMenuModel
    {
        public readonly string PrefijoCodigoPresupuesto = "P";
        public readonly string PrefijoCodigoAereo = "V";
        public readonly string PrefijoCodigoHotel = "H";
        public readonly int PrefijoCodigoItinerario = 1000;

        public int GenerarIdPresupuesto()
        {
            return PresupuestosModule.GetPresupuestos().Count + 1;
        }

        public static GenerarPresupuestoParams GetGenerarPresupuestoParamsStatic()
        {
            return PresupuestosModule.GetGenerarPresupuestoParams();
        }

        public GenerarPresupuestoParams GetGenerarPresupuestoParams()
        {
            return PresupuestosModule.GetGenerarPresupuestoParams();
        }

        public void SetGenerarPresupuestoParams(GenerarPresupuestoParams generarPresupuestoParams)
        {
            PresupuestosModule.SetGenerarPresupuestoParams(generarPresupuestoParams);
        }

        public Itinerario GetPresupuestoById()
        {
            return PresupuestosModule.GetPresupuestoById(GetGenerarPresupuestoParams().PresupuestoId);
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

        public Itinerario GenerarItinerario(ListView listView, Cliente cliente, decimal total)
        {
            var itinerario = new Itinerario(GetGenerarPresupuestoParams().PresupuestoId, cliente, total);

            for (var i = 0; i < listView.Items.Count; i++)
            {
                var tag = (ItinearioItemTag)listView.Items[i].Tag;

                var idUnico = PrefijoCodigoPresupuesto + GetGenerarPresupuestoParams().PresupuestoId;

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

        public decimal GetTotalDeAereosElegidos()
        {
            return AereosModule.GetAereosElegidos().Sum(x => x.Tarifa.Precio);
        }

        public decimal GetTotalDeHotelesElegidos()
        {
            return HotelesModule.GetHotelesElegidos().Sum(x => x.Disponibilidad.TarifaPorDia);
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

        public void DesasignarPasajerosAsignadosInvalidos(Itinerario itinerario)
        {
            var pasajerosActuales = PasajerosModule.GetPasajerosByIdPresupuesto(itinerario.IdItinerario);
           
            foreach(var pasajero in pasajerosActuales)
            {
                for(var i = 0; i < pasajero.AereosAsignados.Count; i++)
                {
                    var aereo = pasajero.AereosAsignados[i];

                    if (!itinerario.IdAereosSeleccionados.Any(x => x.IdAereo == aereo.IdAereo))
                    {
                        PasajerosModule.EliminarAsignacionesAereosExistentes(aereo.IdAereo, GetGenerarPresupuestoParamsStatic().PresupuestoId);
                    }
                }   

                for(var i = 0; i < pasajero.HotelesAsignados.Count; i++)
                {
                    var hotel = pasajero.HotelesAsignados[i];

                    if (!itinerario.IdHotelesSeleccionados.Any(x => x.IdHotel == hotel.IdHotel))
                    {
                        PasajerosModule.EliminarAsignacionesHotelesExistentes(hotel.IdHotel, GetGenerarPresupuestoParamsStatic().PresupuestoId);
                    }
                }   
            }
        }
    }
}
