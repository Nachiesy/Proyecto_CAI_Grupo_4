using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modelos;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class GenerarReservaModel
    {
        public IEnumerable<Itinerario> GetPreReservasAbonadas()
        {
            return PresupuestosModule
                .GetPresupuestosPrereservadosAbonados()
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

        public Itinerario GetPreReservasAbonadasById(int id)
        {
            return ReservaModule.GetPreReservasAbonadasById(id);
        }

        public Reserva GenerarReserva(Itinerario preReserva)
        {
            PresupuestosModule.ActualizarEstadoAReservado(preReserva.IdItinerario);

            return ReservaModule.GenerarNuevaReserva(preReserva.IdItinerario, preReserva.Cliente);
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
