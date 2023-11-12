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
                return "Debes ingresar un DNI correcto. El mismo debe ser númerico y tener entre 7 y 8 cifras.";
            }

            if (!string.IsNullOrEmpty(codigo) && !int.TryParse(codigo, out _))
            {
                return "Debes ingresar un Id correcto. El mismo tiene que ser un número entero.";
            }

            return null;
        }

        public IEnumerable<Itinerario> GetPresupuestosModificables(string inputCodigo, string inputDni)
        {
            var presupuestos = GetPresupuestos();

            if(!string.IsNullOrEmpty(inputCodigo))
            {
                var codigo = int.Parse(inputCodigo);

                presupuestos = presupuestos.Where(x => x.IdItinerario == codigo);
            }

            if(!string.IsNullOrEmpty(inputDni))
            {
                presupuestos = presupuestos.Where(x => x.Cliente.DNI == inputDni);
            }

            return presupuestos;
        }
    }
}
