using Proyecto_CAI_Grupo_4.GenerarPresupuesto;
using Proyecto_CAI_Grupo_4.Modelos;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class BuscarPresupuestoModel
    {
        public int PresupuestoId;

        public string ValidarBuscarPresupuesto(string numeroDePresupuesto)
        {
            var nroPresupuestoValido = int.TryParse(numeroDePresupuesto, out int nroPresupuesto);

            if (!nroPresupuestoValido)
            {
                return "El Id de presupuesto ingresado no es válido";
            }

            var presupuesto = PresupuestosModule.GetPresupuestoById(nroPresupuesto);

            if (presupuesto is null)
            {
                return "El Id de presupuesto ingresado no existe";
            }

            var esModificable = PresupuestosModule.EsPresupuestoModificable(presupuesto.IdItinerario);

            if (!esModificable)
            {
                return $"El Id de presupuesto #{presupuesto.IdItinerario} coincide con un presupuesto que" +
                       $" no puede ser modificado ya que esta en estado {presupuesto.Estado}";
            }

            PresupuestoId = nroPresupuesto;

            return string.Empty;
        }

        public void SetGenerarPresupuestoParams(GenerarPresupuestoParams generarPresupuestoParams)
        {
            PresupuestosModule.SetGenerarPresupuestoParams(generarPresupuestoParams);
        }
    }
}
