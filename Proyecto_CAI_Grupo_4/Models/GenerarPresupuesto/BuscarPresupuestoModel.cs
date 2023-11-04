using Proyecto_CAI_Grupo_4.GenerarPresupuesto;
using Proyecto_CAI_Grupo_4.Modelos;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class BuscarPresupuestoModel
    {
        public int PresupuestoId;

        public bool ValidarBuscarPresupuesto(string numeroDePresupuesto)
        {
            var nroPresupuestoValido = int.TryParse(numeroDePresupuesto, out int nroPresupuesto);

            if (!nroPresupuestoValido)
            {
                MessageBox.Show("El número de presupuesto ingresado no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            var presupuesto = PresupuestosModule.GetPresupuestoById(nroPresupuesto);

            if (presupuesto is null)
            {
                MessageBox.Show("El número de presupuesto ingresado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return false;
            }

            var preReserva = PrereservaModule.GetPrereservaByItinerario(presupuesto.IdItinerario);

            if (preReserva.Count > 0)
            {
                MessageBox.Show("El número de presupuesto ingresado ya fue abonado en la pre-reserva " + preReserva.First().IdItinerario + " y no se puede editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            PresupuestoId = nroPresupuesto;

            return true;
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
