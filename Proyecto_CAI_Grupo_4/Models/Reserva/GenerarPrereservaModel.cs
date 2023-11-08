using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modelos;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class GenerarPrereservaModel
    {
        public IEnumerable<Itinerario> GetPreReservables()
        {
            return PresupuestosModule
                .GetPresupuestosPrereservables()
                .AsQueryable();
        }

        public int GetTotalPasajerosByIdPresupuesto(int idItinerario)
        {
            return PasajerosModule.GetTotalPasajerosByIdPresupuesto(idItinerario);
        }

        public Itinerario GetPresupuestoById(int id)
        {
            return PresupuestosModule.GetPresupuestoById(id);
        }

        public Itinerario GenerarPreReserva(Itinerario itinerario)
        {
            itinerario.ActualizarEstadoAPrereservado();

            PresupuestosModule.UpdatePresupuesto(itinerario);

            return itinerario;
        }
    }
}
