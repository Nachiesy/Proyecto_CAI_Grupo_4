using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modelos;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class GenerarPrereservaModel
    {
        public IEnumerable<Itinerario> GetPreReservas()
        {
            return PresupuestosModule
            .GetPresupuestos()
                .Where(x => ReservaModule.GetPrereservaByItinerario(x.IdItinerario).Count == 0)
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

        public Reserva GenerarPreReserva(Itinerario itinerario)
        {
            return ReservaModule.GenerarNuevaPreReserva(
                    idItinerario: itinerario.IdItinerario,
                    cliente: itinerario.Cliente);
        }

        public void GoToMenuPrincipal()
        {
            Thread thread = new Thread(MenuPrincipalModel.OpenMenuPrincipal);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public static void OpenGenerarPrereserva()
        {
            Application.Run(new GenerarPrereserva());
        }
    }
}
