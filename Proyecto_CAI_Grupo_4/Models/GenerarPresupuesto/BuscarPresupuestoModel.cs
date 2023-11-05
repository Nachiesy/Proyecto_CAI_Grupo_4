using Proyecto_CAI_Grupo_4.GenerarPresupuesto;
using Proyecto_CAI_Grupo_4.Modelos;

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
                return "El número de presupuesto ingresado no es válido";
            }

            var presupuesto = PresupuestosModule.GetPresupuestoById(nroPresupuesto);

            if (presupuesto is null)
            {
                return "El número de presupuesto ingresado no existe";
            }

            var preReserva = ReservaModule.GetPrereservaAbonadaByItinerario(presupuesto.IdItinerario);

            if (preReserva.Count > 0)
            {
                return "El número de presupuesto ingresado ya fue abonado en la pre-reserva " + preReserva.First().IdItinerario + " y no se puede editar";
            }

            PresupuestoId = nroPresupuesto;

            return null;
        }

        public void GoToGenerarPresupuestoMenu()
        {
            GenerarPresupuestoMenuModel.PresupuestoId = PresupuestoId;
            GenerarPresupuestoMenuModel.EsNuevo = false;
            GenerarPresupuestoMenuModel.InitBuscarPresupuesto = true;

            Thread thread = new Thread(GenerarPresupuestoMenuModel.OpenGenerarPresupuestoMenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public void GoToMenuPrincipal()
        {
            Thread thread = new Thread(MenuPrincipalModel.OpenMenuPrincipal);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public static void OpenBuscarPresupuesto()
        {
            Application.Run(new BuscarPresupuesto());
        }
    }
}
