using Proyecto_CAI_Grupo_4.Almacenes;
using System.Text.Json.Serialization;
using System.Text.Json;

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
            ConfigureJsonSerialization();
            Application.Run(new MenuPrincipal());
            Application.ApplicationExit += new EventHandler(GuardarAlmacenes);
        }

        private static void GuardarAlmacenes(object? sender, EventArgs e)
        {
            AlmacenAereos.Guardar();
            AlmacenHoteles.Guardar();
            AlmacenPresupuestos.Guardar();
            AlmacenPasajeros.Guardar();
            AlmacenReservas.Guardar();
        }

        private static void ConfigureJsonSerialization()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Converters = { new JsonStringEnumConverter() }
            };

            options.Converters.Add(new JsonStringEnumConverter());
        }
    }
}
