using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modules;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class AgregarPasajerosModel
    {
        public List<PasajerosEnt> Pasajeros = new List<PasajerosEnt>();

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

        public IEnumerable<PasajerosEnt> GetPasajerosByIdPresupuesto(int idPresupuesto)
        {
            return PasajerosModule.GetPasajerosByIdPresupuesto(idPresupuesto);
        }

        public IEnumerable<PresupuestoEnt> GetPresupuestosByDNI(string dni) 
        {
            return PresupuestosModule.GetPresupuestosByDNI(dni);
        }

        public PresupuestoEnt GetPresupuestoById(int id)
        {
            return PresupuestosModule.GetPresupuestoById(id);
        }

        public IEnumerable<PresupuestoEnt> GetPresupuestos()
        {
            return PresupuestosModule.GetPresupuestos();
        }

        public void AgregarPasajero(PasajerosEnt pasajero)
        {
            Pasajeros.Add(pasajero);
        }

        public void EliminarPasajero(PasajerosEnt pasajeroParaEliminar)
        {
            PasajerosModule.EliminarPasajero(pasajeroParaEliminar);
        }

        public string? ValidarCamposBusqueda(string codigo, string dni)
        {
            if (!string.IsNullOrEmpty(dni) && !dni.EsDNI())
            {
                return "Debes ingresar un DNI correcto. El mismo debe ser numérico y tener entre 7 y 8 cifras.";
            }

            if (!string.IsNullOrEmpty(codigo) && !int.TryParse(codigo, out _))
            {
                return "Debes ingresar un Id correcto. El mismo tiene que ser un número entero.";
            }

            return null;
        }

        public IEnumerable<PresupuestoEnt> GetPresupuestosModificables(string inputCodigo, string inputDni)
        {
            var presupuestos = GetPresupuestos();

            if(!string.IsNullOrEmpty(inputCodigo))
            {
                var codigo = int.Parse(inputCodigo);

                presupuestos = presupuestos.Where(x => x.IdPresupuesto == codigo);
            }

            if(!string.IsNullOrEmpty(inputDni))
            {
                presupuestos = presupuestos.Where(x => x.Cliente.DNI == inputDni);
            }

            return presupuestos;
        }
    }
}
