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
            return PresupuestosModule.GetPresupuestoParaId().Count + 1;
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

        public PresupuestoEnt GetPresupuestoById()
        {
            return PresupuestosModule.GetPresupuestoById(GetGenerarPresupuestoParams().PresupuestoId);
        }

        public void AddPresupuesto(PresupuestoEnt itinerario)
        {
            PresupuestosModule.AddPresupuesto(itinerario);
        }

        public void UpdatePresupuesto(PresupuestoEnt itinerarioActualizado)
        {
            PresupuestosModule.UpdatePresupuesto(itinerarioActualizado);
        }

        public string EsPresupuestoValido(string dni, string nombre, string apellido, int productosElegidos)
        {
            if (!dni.EsDNI())
            {
                return $"Debes ingresar un DNI correcto. El mismo debe ser numérico y tener entre 7 y 8 cifras.";
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

        public PresupuestoEnt GenerarItinerario(ListView listView, Cliente cliente, decimal total)
        {
            var itinerario = new PresupuestoEnt(GetGenerarPresupuestoParams().PresupuestoId, cliente, total);

            for (var i = 0; i < listView.Items.Count; i++)
            {
                var tag = (ItinerarioItemTag)listView.Items[i].Tag;

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

        public decimal GetTotalDeProductosElegidos()
        {
            decimal total = 0;

            total += AereosModule.GetAereosElegidos().Sum(x => x.Tarifa.Precio);
            total += HotelesModule.GetHotelesElegidos().Sum(x => x.Disponibilidad.TarifaPorDia);

            return total;
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

        public void LimpiarAsignacionesPasajerosExistentes(PresupuestoEnt itinerario)
        {
            PasajerosModule.LimpiarAsignacionesPasajerosPorIdPresupuesto(GetGenerarPresupuestoParamsStatic().PresupuestoId);
        }
    }
}
