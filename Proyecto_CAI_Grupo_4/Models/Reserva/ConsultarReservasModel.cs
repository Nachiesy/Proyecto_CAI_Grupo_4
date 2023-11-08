using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modelos;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class ConsultarReservasModel
    {
        public IEnumerable<Reserva> GetReservas()
        {
            return ReservaModule.GetReservas();
        }

        public Itinerario GetPresupuestoById(int id)
        {
            return PresupuestosModule.GetPresupuestoById(id);
        }
    }
}
