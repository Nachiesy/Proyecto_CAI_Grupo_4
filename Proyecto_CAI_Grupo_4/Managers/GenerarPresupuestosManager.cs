using Proyecto_CAI_Grupo_4.Models.Productos;

namespace Proyecto_CAI_Grupo_4.Managers
{
    public class GenerarPresupuestosManager
    {
        public static List<Aereos> aereos = new List<Aereos>()
        {
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Nombre = "Vuelo 113",
                Precio = 10,
                Cantidad = 1,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = "Buenos Aires",
                Destino = "Montevideo",
                FechaDeSalida = DateTime.Now.AddDays(10).Date,
                FechaDeLlegada = DateTime.Now.AddDays(20).Date,
                TipoDeClaseAerea = TipoDeClaseAereaEnum.turista,
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Nombre = "Vuelo 201",
                Precio = 10,
                Cantidad = 2,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = "Madrid",
                Destino = "Paris",
                FechaDeSalida = DateTime.Now.AddDays(10).Date,
                FechaDeLlegada = DateTime.Now.AddDays(20).Date,
                TipoDeClaseAerea = TipoDeClaseAereaEnum.ejecutivo,
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Nombre = "Vuelo 369",
                Precio = 10,
                Cantidad = 3,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = "Londres",
                Destino = "San Francisco",
                FechaDeSalida = DateTime.Now.AddDays(10).Date,
                FechaDeLlegada = DateTime.Now.AddDays(20).Date,
                TipoDeClaseAerea = TipoDeClaseAereaEnum.primeraClase,
            },
        };

        public static List<Aereos> aereosElegidos = new List<Aereos>();

        public static List<Hoteles> hoteles = new List<Hoteles>()
        {
            new Hoteles()
            {
                Id = Guid.NewGuid(),
                Nombre = "Hilton",
                Precio = 10,
                Cantidad = 1,
                TipoDeServicio = TipoDeServicioEnum.hotel,
                Ciudad = "Buenos Aires",
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
            },
            new Hoteles()
            {
                Id = Guid.NewGuid(),
                Nombre = "Sheraton",
                Precio = 10,
                Cantidad = 2,
                TipoDeServicio = TipoDeServicioEnum.hotel,
                Ciudad = "Montevideo",
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
            },
            new Hoteles()
            {
                Id = Guid.NewGuid(),
                Nombre = "Intercontinental",
                Precio = 10,
                Cantidad = 3,
                TipoDeServicio = TipoDeServicioEnum.hotel,
                Ciudad = "Madrid",
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
            },
        };

        public static List<Hoteles> hotelesElegidos = new List<Hoteles>();

        public static List<Cruceros> cruceros = new List<Cruceros>()
        {
            new Cruceros()
            {
                Id = Guid.NewGuid(),
                Nombre = "Crucero de la Costa",
                Precio = 10,
                Cantidad = 1,
                TipoDeServicio = TipoDeServicioEnum.crucero,
                CiudadDePartida = "Buenos Aires",
                CiudadDeLlegada = "Mar del Plata",
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
            },
            new Cruceros()
            {
                Id = Guid.NewGuid(),
                Nombre = "Crucero dou Brasil",
                Precio = 10,
                Cantidad = 2,
                TipoDeServicio = TipoDeServicioEnum.crucero,
                CiudadDePartida = "Montevideo",
                CiudadDeLlegada = "Rio de Janeiro",
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
            },
            new Cruceros()
            {
                Id = Guid.NewGuid(),
                Nombre = "Crucero del Caribe",
                Precio = 10,
                Cantidad = 3,
                TipoDeServicio = TipoDeServicioEnum.crucero,
                CiudadDePartida = "Miami",
                CiudadDeLlegada = "Cancun",
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
            },
            new Cruceros()
            {
                Id = Guid.NewGuid(),
                Nombre = "Crucero del Mediterraneo",
                Precio = 10,
                Cantidad = 4,
                TipoDeServicio = TipoDeServicioEnum.crucero,
                CiudadDePartida = "Atenas",
                CiudadDeLlegada = "Marruecos",
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
            },
        };

        public static List<Cruceros> crucerosElegidos = new List<Cruceros>();

        public static List<PaquetesTuristicos> paquetesTuristicos = new List<PaquetesTuristicos>()
        {
            new PaquetesTuristicos()
            {
                Id = Guid.NewGuid(),
                Nombre = "Paquete de la Costa",
                Precio = 10,
                Cantidad = 1,
                TipoDeServicio = TipoDeServicioEnum.paquete,
                Origen = "Buenos Aires",
                Destino = "Mar del Plata",
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
            },
            new PaquetesTuristicos()
            {
                Id = Guid.NewGuid(),
                Nombre = "Paquete Sudafrica",
                Precio = 10,
                Cantidad = 2,
                TipoDeServicio = TipoDeServicioEnum.paquete,
                Origen = "Sao Pablo",
                Destino = "Pretoria",
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
            },
            new PaquetesTuristicos()
            {
                Id = Guid.NewGuid(),
                Nombre = "Paque Italia",
                Precio = 10,
                Cantidad = 3,
                TipoDeServicio = TipoDeServicioEnum.paquete,
                Origen = "Filadelfia",
                Destino = "Napoles",
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
            },
            new PaquetesTuristicos()
            {
                Id = Guid.NewGuid(),
                Nombre = "Paquete Japon",
                Precio = 10,
                Cantidad = 4,
                TipoDeServicio = TipoDeServicioEnum.paquete,
                Origen = "Sidney",
                Destino = "Tokio",
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
            },
        };

        public static List<PaquetesTuristicos> paquetesTuristicosElegidos = new List<PaquetesTuristicos>();
    }
}
