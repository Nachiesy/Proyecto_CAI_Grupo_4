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
                .Where(x => PrereservaModule.GetPrereservaByItinerario(x.IdItinerario).Count == 0)
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

        public Prereserva GenerarPreReserva(Itinerario itinerario)
        {
            return PrereservaModule.GenerarNuevaPrereserva(
                    idItinerario: itinerario.IdItinerario,
                    /*ESTADO HARDCODEADO PORQUE MAGICAMENTE DE UNA U OTRA FORMA TIENEN QUE SER PAGADAS PARA PODER GENERAR RESERVA. EL LISTADO FILTRA PAGADAS.*/
                    estado: PrereservaEstadoEnum.Pagada, /* PrereservaEstadoEnum.PendienteDePago */
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
