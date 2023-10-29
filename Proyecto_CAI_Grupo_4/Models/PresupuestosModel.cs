using Proyecto_CAI_Grupo_4.Entities;

namespace Proyecto_CAI_Grupo_4.Models
{
    public static class PresupuestosModel
    {
        private static List<Itinerario> Presupuestos { get; set; } = new List<Itinerario>()
        {
            new Itinerario(1, 
                new List<Guid>() {
                    Guid.Parse("b3bac23e-b28c-4db8-bfd8-107776ef929d")
                }, new List<Guid> () {
                    Guid.Parse("55be2c9a-987a-4bfe-a7de-23025f7dc2fe")
                },
                new Cliente("53944876", "Lionel", "Messi"))
        };

        public static List<Itinerario> GetPresupuestos()
        {
            return Presupuestos;
        }

        public static List<Itinerario> GetPresupuestosByDNI(string dni)
        {
            return Presupuestos.FindAll(x => x.Cliente.DNI == dni);
        }

        public static List<Itinerario> GetPresupuestosById(int id)
        {
            return Presupuestos.FindAll(x => x.IdItinerario == id);
        }

        public static void AddPresupuesto(Itinerario itinerario)
        {
            Presupuestos.Add(itinerario);
        }

        public static void UpdatePresupuesto(Itinerario itinerarioActualizado)
        {
            var index = Presupuestos.FindIndex(x => x.IdItinerario == itinerarioActualizado.IdItinerario);

            if (index != -1)
            {
                Presupuestos[index] = itinerarioActualizado;
            }
        }

        public static Itinerario? GetPresupuesto(int id)
        {
            return Presupuestos.FirstOrDefault(x => x.IdItinerario == id);
        }

        public static int GenerarId()
        {
            return Presupuestos.Count + 1;
        }
    }
}
