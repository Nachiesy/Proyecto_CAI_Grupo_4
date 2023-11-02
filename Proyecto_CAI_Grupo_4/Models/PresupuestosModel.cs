using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Enums;

namespace Proyecto_CAI_Grupo_4.Models
{
    public static class PresupuestosModel
    {
        private static List<Itinerario> Presupuestos { get; set; } = new List<Itinerario>()
        {
            new Itinerario(
                id: 1, 
                idAereosSeleccionados: new List<AereoSeleccionado>() { new ("V1001", 1) },
                idHotelesSeleccionados: new List<HotelSeleccionado> () { new ("H1002", 25) },
                cliente: new Cliente("53944876", "Lionel", "Messi"),
                estado: PresupuestoEstadoEnum.Presupuesto_Pendiente_De_Pago,
                precioTotal: 20000)
        };

        public static List<Itinerario> GetPresupuestos() => Presupuestos;

        public static List<Itinerario> GetPresupuestosByDNI(string dni) => Presupuestos.FindAll(x => x.Cliente.DNI == dni);

        public static Itinerario? GetPresupuestoById(int id) => Presupuestos.FirstOrDefault(x => x.IdItinerario == id);

        public static void AddPresupuesto(Itinerario itinerario) => Presupuestos.Add(itinerario);

        public static void UpdatePresupuesto(Itinerario itinerarioActualizado)
        {
            var index = Presupuestos.FindIndex(x => x.IdItinerario == itinerarioActualizado.IdItinerario);

            if (index != -1)
            {
                Presupuestos[index] = itinerarioActualizado;
            }
        }

        public static int GenerarId() => Presupuestos.Count + 1;
    }
}
