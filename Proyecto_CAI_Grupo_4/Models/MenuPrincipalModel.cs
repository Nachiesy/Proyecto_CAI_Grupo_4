namespace Proyecto_CAI_Grupo_4.Models
{
    public class MenuPrincipalModel
    {
        public void GoToBuscarPresupuesto()
        {
            var thread = new Thread(BuscarPresupuestoModel.OpenBuscarPresupuesto);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public void GoToGenerarPresupuestoMenu()
        {
            var thread = new Thread(GenerarPresupuestoMenuModel.OpenGenerarPresupuestoMenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public void GoToAgregarPasajeros()
        {
            Thread thread = new Thread(AgregarPasajerosModel.OpenAgregarPasajeros);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public void GoToGenerarPrereserva()
        {
            var thread = new Thread(GenerarPrereservaModel.OpenGenerarPrereserva);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public void GoToGenerarReserva()
        {
            var thread = new Thread(GenerarReservaModel.OpenGenerarReserva);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public void GoToConfirmarReserva()
        {
            Thread thread = new Thread(ConfirmarReservaModel.OpenConfirmarReserva);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public void GoToConsultarReservas()
        {
            Thread thread = new Thread(ConsultarReservasModel.OpenConsultarReservas);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public static void OpenMenuPrincipal()
        {
            Application.Run(new MenuPrincipal());
        }
    }
}
