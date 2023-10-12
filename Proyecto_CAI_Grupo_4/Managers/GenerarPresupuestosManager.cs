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
                PrecioAdultos = 20,
                PrecioMenores = 10,
                Cantidad = 1,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.buenosAires,
                Destino = AereosDestinoEnum.montevideo,
                FechaDeSalida = DateTime.Now.AddDays(10).Date,
                FechaDeLlegada = DateTime.Now.AddDays(20).Date,
                TipoDeClaseAerea = TipoDeClaseAereaEnum.turista,
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Nombre = "Vuelo 201",
                PrecioAdultos = 20,
                PrecioMenores = 10,
                Cantidad = 2,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.madrid,
                Destino = AereosDestinoEnum.paris,
                FechaDeSalida = DateTime.Now.AddDays(10).Date,
                FechaDeLlegada = DateTime.Now.AddDays(20).Date,
                TipoDeClaseAerea = TipoDeClaseAereaEnum.ejecutivo,
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Nombre = "Vuelo 369",
                PrecioAdultos = 20,
                PrecioMenores = 10,
                Cantidad = 3,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.londres,
                Destino = AereosDestinoEnum.sanFrancisco,
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
                CiudadDePartida = CrucerosOrigenEnum.buenosAires,
                CiudadDeLlegada = CrucerosDestinoEnum.marDelPlata,
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
                CiudadDePartida = CrucerosOrigenEnum.montevideo,
                CiudadDeLlegada = CrucerosDestinoEnum.rioDeJaneiro,
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
                CiudadDePartida = CrucerosOrigenEnum.miami,
                CiudadDeLlegada = CrucerosDestinoEnum.cancun,
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
                CiudadDePartida = CrucerosOrigenEnum.atenas,
                CiudadDeLlegada = CrucerosDestinoEnum.marruecos,
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
                Origen = PaquetesTuristicosOrigenEnum.buenosAires,
                Destino = PaquetesTuristicosDestinoEnum.marDelPlata,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
                Actividades = new List<PaquetesTuristicosActividades>()
                {
                    new PaquetesTuristicosActividades()
                    {
                        Nombre = "Montaña Rusa",
                    },
                    new PaquetesTuristicosActividades()
                    {
                        Nombre = "Tobogan Acuatico",
                    },
                },
            },
            new PaquetesTuristicos()
            {
                Id = Guid.NewGuid(),
                Nombre = "Paquete Sudafrica",
                Precio = 10,
                Cantidad = 2,
                TipoDeServicio = TipoDeServicioEnum.paquete,
                Origen = PaquetesTuristicosOrigenEnum.saoPablo,
                Destino = PaquetesTuristicosDestinoEnum.pretoria,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
                Actividades = new List<PaquetesTuristicosActividades>()
                {
                    new PaquetesTuristicosActividades()
                    {
                        Nombre = "Safari",
                    },
                    new PaquetesTuristicosActividades()
                    {
                        Nombre = "Playa",
                    },
                },
            },
            new PaquetesTuristicos()
            {
                Id = Guid.NewGuid(),
                Nombre = "Paque Italia",
                Precio = 10,
                Cantidad = 3,
                TipoDeServicio = TipoDeServicioEnum.paquete,
                Origen = PaquetesTuristicosOrigenEnum.filadelfia,
                Destino = PaquetesTuristicosDestinoEnum.napoles,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
                Actividades = new List<PaquetesTuristicosActividades>()
                {
                    new PaquetesTuristicosActividades()
                    {
                        Nombre = "Coliseo de Roma",
                    },
                    new PaquetesTuristicosActividades()
                    {
                        Nombre = "Tour por Venecia",
                    },
                },
            },
            new PaquetesTuristicos()
            {
                Id = Guid.NewGuid(),
                Nombre = "Paquete Japon",
                Precio = 10,
                Cantidad = 4,
                TipoDeServicio = TipoDeServicioEnum.paquete,
                Origen = PaquetesTuristicosOrigenEnum.sidney,
                Destino = PaquetesTuristicosDestinoEnum.tokio,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
                Actividades = new List<PaquetesTuristicosActividades>()
                {
                    new PaquetesTuristicosActividades()
                    {
                        Nombre = "Tour por Tokio",
                    },
                    new PaquetesTuristicosActividades()
                    {
                        Nombre = "Viaje a la Montaña",
                    },
                },
            },
        };

        public static List<PaquetesTuristicos> paquetesTuristicosElegidos = new List<PaquetesTuristicos>();
    }
}
