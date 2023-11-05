using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modelos;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class GenerarReservaModel
    {
        public IEnumerable<Reserva> GetPreReservasAbonadas()
        {
            return ReservaModule
                .GetPreReservasAbonadas()
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

        public Reserva GetPreReservasAbonadasById(int id)
        {
            return ReservaModule.GetPreReservasAbonadasById(id);
        }

        public Reserva GenerarReserva(Reserva preReserva)
        {
            return ReservaModule.ConvertirPreReservaEnReserva(preReserva.Codigo);
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
