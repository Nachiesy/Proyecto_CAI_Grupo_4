﻿using Proyecto_CAI_Grupo_4.Models.Productos;

namespace Proyecto_CAI_Grupo_4.Managers
{
    public class GenerarPresupuestosManager
    {
        public static List<Aereos> aereos = new List<Aereos>()
        {
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "A113",
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
                Codigo = "B201",
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
                Codigo = "C369",
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
                Codigo = "HIL",
                Nombre = "Hilton",
                Precio = 10,
                Cantidad = 1,
                TipoDeServicio = TipoDeServicioEnum.hotel,
                Ciudad = HotelesCiudadEnum.buenosAires,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
                TipoDeHabitacion = TipoDeHabitacionEnum.simple,
                Calificacion = HotelesCalificacionEnum.cinco,
                CantidadDePersonas = 2,
            },
            new Hoteles()
            {
                Id = Guid.NewGuid(),
                Codigo = "SHE",
                Nombre = "Sheraton",
                Precio = 10,
                Cantidad = 2,
                TipoDeServicio = TipoDeServicioEnum.hotel,
                Ciudad = HotelesCiudadEnum.montevideo,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
                TipoDeHabitacion = TipoDeHabitacionEnum.doble,
                Calificacion = HotelesCalificacionEnum.cinco,
                CantidadDePersonas = 4,
            },
            new Hoteles()
            {
                Id = Guid.NewGuid(),
                Codigo = "INT",
                Nombre = "Intercontinental",
                Precio = 10,
                Cantidad = 3,
                TipoDeServicio = TipoDeServicioEnum.hotel,
                Ciudad = HotelesCiudadEnum.madrid,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
                TipoDeHabitacion = TipoDeHabitacionEnum.triple,
                Calificacion = HotelesCalificacionEnum.cuatro,
                CantidadDePersonas = 6,
            },
        };

        public static List<Hoteles> hotelesElegidos = new List<Hoteles>();

        public static List<Cruceros> cruceros = new List<Cruceros>()
        {
            new Cruceros()
            {
                Id = Guid.NewGuid(),
                Codigo = "CC11",
                Nombre = "Crucero de la Costa",
                Precio = 10,
                Cantidad = 1,
                TipoDeServicio = TipoDeServicioEnum.crucero,
                CiudadDePartida = CrucerosOrigenEnum.buenosAires,
                CiudadDeLlegada = CrucerosDestinoEnum.marDelPlata,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
                TipoDeCamarote = TipoDeCamaroteEnum.interior,
                Paradas = new List<CrucerosParadas>()
                {
                    new CrucerosParadas()
                    {
                        Nombre = "Mar del Plata",
                    },
                    new CrucerosParadas()
                    {
                        Nombre = "Bahia Blanca",
                    },
                },
            },
            new Cruceros()
            {
                Id = Guid.NewGuid(),
                Codigo = "CB22",
                Nombre = "Crucero dou Brasil",
                Precio = 10,
                Cantidad = 2,
                TipoDeServicio = TipoDeServicioEnum.crucero,
                CiudadDePartida = CrucerosOrigenEnum.montevideo,
                CiudadDeLlegada = CrucerosDestinoEnum.rioDeJaneiro,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
                TipoDeCamarote = TipoDeCamaroteEnum.exterior,
                Paradas = new List<CrucerosParadas>()
                {
                    new CrucerosParadas()
                    {
                        Nombre = "Isla Grande",
                    },
                    new CrucerosParadas()
                    {
                        Nombre = "Rio de Janeiro",
                    },
                },
            },
            new Cruceros()
            {
                Id = Guid.NewGuid(),
                Codigo = "CA33",
                Nombre = "Crucero del Caribe",
                Precio = 10,
                Cantidad = 3,
                TipoDeServicio = TipoDeServicioEnum.crucero,
                CiudadDePartida = CrucerosOrigenEnum.miami,
                CiudadDeLlegada = CrucerosDestinoEnum.cancun,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
                TipoDeCamarote = TipoDeCamaroteEnum.conBalcon,
                Paradas = new List<CrucerosParadas>()
                {
                    new CrucerosParadas()
                    {
                        Nombre = "Cancun",
                    },
                    new CrucerosParadas()
                    {
                        Nombre = "Republica Dominicana",
                    },
                },
            },
            new Cruceros()
            {
                Id = Guid.NewGuid(),
                Codigo = "CM44",
                Nombre = "Crucero del Mediterraneo",
                Precio = 10,
                Cantidad = 4,
                TipoDeServicio = TipoDeServicioEnum.crucero,
                CiudadDePartida = CrucerosOrigenEnum.atenas,
                CiudadDeLlegada = CrucerosDestinoEnum.marruecos,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
                TipoDeCamarote = TipoDeCamaroteEnum.suite,
                Paradas = new List<CrucerosParadas>()
                {
                    new CrucerosParadas()
                    {
                        Nombre = "Barcelona",
                    },
                    new CrucerosParadas()
                    {
                        Nombre = "Marsella",
                    },
                },
            },
        };

        public static List<Cruceros> crucerosElegidos = new List<Cruceros>();

        public static List<PaquetesTuristicos> paquetesTuristicos = new List<PaquetesTuristicos>()
        {
            new PaquetesTuristicos()
            {
                Id = Guid.NewGuid(),
                Codigo = "PC11",
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
                CapacidadMaximaAdultos = 2,
                CapacidadMaximaMenores = 2,
            },
            new PaquetesTuristicos()
            {
                Id = Guid.NewGuid(),
                Codigo = "PS22",
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
                CapacidadMaximaAdultos = 10,
                CapacidadMaximaMenores = 20,
            },
            new PaquetesTuristicos()
            {
                Id = Guid.NewGuid(),
                Codigo = "PI33",
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
                CapacidadMaximaAdultos = 4,
                CapacidadMaximaMenores = 6,
            },
            new PaquetesTuristicos()
            {
                Id = Guid.NewGuid(),
                Codigo = "PJ44",
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
                CapacidadMaximaAdultos = 6,
                CapacidadMaximaMenores = 8,
            },
        };

        public static List<PaquetesTuristicos> paquetesTuristicosElegidos = new List<PaquetesTuristicos>();
    }
}
