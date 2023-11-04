using Proyecto_CAI_Grupo_4.Almacenes;

namespace Proyecto_CAI_Grupo_4
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MenuPrincipal());

            AlmacenAereos.Guardar();
            AlmacenHoteles.Guardar();
            AlmacenPresupuestos.Guardar();
            AlmacenPasajeros.Guardar();
            AlmacenReservas.Guardar();
            AlmacenPreReservas.Guardar();
        }
    }
}
