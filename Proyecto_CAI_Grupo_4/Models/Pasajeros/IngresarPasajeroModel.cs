using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class IngresarPasajeroModel
    {
        public Itinerario GetPresupuestoById(int id)
        {
            return PresupuestosModule.GetPresupuestoById(id);
        }

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

        public void AgregarPasajero(Pasajeros pasajero)
        {
            PasajerosModule.AgregarPasajero(pasajero);
        }
    }
}
