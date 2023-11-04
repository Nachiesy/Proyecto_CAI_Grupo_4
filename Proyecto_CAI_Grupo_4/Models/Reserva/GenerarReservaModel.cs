using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modelos;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class GenerarReservaModel
    {
        public IEnumerable<Prereserva> GetPreReservas()
        {
            return PrereservaModule
            .GetPrereservaAbonadas()
                .Where(x => ReservaModule.GetReservasByItinerario(x.IdItinerario).Count == 0)
                .AsQueryable();
        }

        public int GetTotalDePasajeros(int idItinerario)
        {
            return PasajerosModule.GetTotalPasajerosByIdPresupuesto(idItinerario);
        }

        public Itinerario? GetPresupuestoById(int idItinerario)
        {
            return PresupuestosModule.GetPresupuestoById(idItinerario);
        }

        public Prereserva GetPreReservaById(int idItinerario)
        {
            return PrereservaModule.GetPrereservaById(idItinerario);
        }

        public Reserva GenerarReserva(Prereserva preReserva)
        {
            return ReservaModule.GenerarNuevaReserva(
                    idItinerario: preReserva.IdItinerario,
                    estado: ReservaEstadoEnum.PendienteDeConfirmacion,
                    cliente: preReserva.Cliente);
        }

        public void GoToMenuPrincipal()
        {
            Thread thread = new Thread(MenuPrincipalModel.OpenMenuPrincipal);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        
        public static void OpenGenerarReserva()
        {
            Application.Run(new GenerarReserva());
        }
    }
}
