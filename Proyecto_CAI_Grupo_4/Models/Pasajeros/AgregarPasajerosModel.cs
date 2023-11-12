using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modules;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class AgregarPasajerosModel
    {
        public List<Pasajeros> Pasajeros = new List<Pasajeros>();

        public static AgregarPasajerosParams GetAgregarPasajerosParamsStatic()
        {
            return PasajerosModule.GetAgregarPasajerosParams();
        }

        public AgregarPasajerosParams GetAgregarPasajerosParams()
        {
            return PasajerosModule.GetAgregarPasajerosParams();
        }

        public void SetAgregarPasajerosParams(AgregarPasajerosParams agregarPasajerosParams)
        {
            PasajerosModule.SetAgregarPasajerosParams(agregarPasajerosParams);
        }

        public AereoEnt GetAereoById(int id)
        {
            return AereosModule.GetAereoByID(id);
        }

        public HotelEnt GetHotelById(int id)
        {
            return HotelesModule.GetHotelByID(id);
        }

        public IEnumerable<Pasajeros> GetPasajerosByIdPresupuesto(int idPresupuesto)
        {
            return PasajerosModule.GetPasajerosByIdPresupuesto(idPresupuesto);
        }

        public IEnumerable<Itinerario> GetPresupuestosByDNI(string dni) 
        {
            return PresupuestosModule.GetPresupuestosByDNI(dni);
        }

        public Itinerario GetPresupuestoById(int id)
        {
            return PresupuestosModule.GetPresupuestoById(id);
        }

        public IEnumerable<Itinerario> GetPresupuestos()
        {
            return PresupuestosModule.GetPresupuestos();
        }

        public void AgregarPasajero(Pasajeros pasajero)
        {
            Pasajeros.Add(pasajero);
        }

        public void EliminarPasajero(Pasajeros pasajeroParaEliminar)
        {
            PasajerosModule.EliminarPasajero(pasajeroParaEliminar);
        }

        public string? ValidarCamposBusqueda(string codigo, string dni)
        {
            if (!string.IsNullOrEmpty(dni) && !dni.EsDNI())
            {
                return "Ingrese un DNI valido por favor.";
            }

            if (!string.IsNullOrEmpty(codigo) && !int.TryParse(codigo, out _))
            {
                return "Ingrese un codigo valido por favor.";
            }

            return null;
        }
    }
}
