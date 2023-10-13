using Proyecto_CAI_Grupo_4.Models;

namespace Proyecto_CAI_Grupo_4.Managers
{
    public class ReservasManager
    {
        public static List<Reserva> reservas = new List<Reserva>()
        {
            new Reserva()
            {
                Codigo = 120,
                Estado = ReservaEstadoEnum.pagada,
                TipoDoc = 1,
                DNI = "39117825",
                CantPasajeros = 2,
                CantMayores = 2,
                CantMenores = 0,
                Precio = (decimal)100000.50,
                Fecha = DateTime.Now.AddDays(-7),
                prereserva = true,

            },
            new Reserva()
            {
                Codigo = 132,
                Estado = ReservaEstadoEnum.pagada,
                TipoDoc = 1,
                CantMayores = 2,
                CantMenores = 3,
                DNI = "27098332",
                CantPasajeros = 5,
                Precio = (decimal)50000,
                Fecha = DateTime.Now.AddDays(-14),
                prereserva=false,

            },
            new Reserva()
            {
                Codigo = 133,
                Estado = ReservaEstadoEnum.pagada,
                TipoDoc = 1,
                CantMayores = 2,
                CantMenores = 0,
                DNI = "30945665",
                CantPasajeros = 2,
                Precio = (decimal)500000.95,
                Fecha = DateTime.Now.AddDays(-21),
                prereserva=false,

            },
                        new Reserva()
            {
                Codigo = 150,
                Estado = ReservaEstadoEnum.pagada,
                TipoDoc = 1,
                CantMayores = 1,
                CantMenores = 1,
                DNI = "20945665",
                CantPasajeros = 2,
                Precio = (decimal)500000.95,
                Fecha = DateTime.Now.AddDays(-21),
                prereserva=false,

            },
        };
    }
}
