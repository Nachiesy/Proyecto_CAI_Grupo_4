using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Filters;

namespace Proyecto_CAI_Grupo_4.Models.Productos
{
    public static class AereosModel
    {
        private static List<Aereos> aereos = new List<Aereos>()
        {
            // A113
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "A113",
                Nombre = "Vuelo 113",
                Precio = 30000,
                Cantidad = 1,
                Aerolinea = AerolineaEnum.argentinas,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.buenosAires,
                Destino = AereosDestinoEnum.montevideo,
                FechaDeSalida = DateTime.Now.AddDays(7).Date,
                FechaDeLlegada = DateTime.Now.AddDays(7).Date.AddHours(2),
                Clase = TipoDeClaseAereaEnum.economy,
                Itinerario = AereosItinerarioEnum.oneWay,
                TipoDePasajero = TipoDePasajeroEnum.adulto,
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "A113",
                Nombre = "Vuelo 113",
                Precio = 25000,
                Cantidad = 1,
                Aerolinea = AerolineaEnum.argentinas,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.buenosAires,
                Destino = AereosDestinoEnum.montevideo,
                FechaDeSalida = DateTime.Now.AddDays(7).Date,
                FechaDeLlegada = DateTime.Now.AddDays(7).Date.AddHours(2),
                Clase = TipoDeClaseAereaEnum.economy,
                Itinerario = AereosItinerarioEnum.oneWay,
                TipoDePasajero = TipoDePasajeroEnum.menor,
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "A113",
                Nombre = "Vuelo 113",
                Precio = 15000,
                Cantidad = 1,
                Aerolinea = AerolineaEnum.argentinas,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.buenosAires,
                Destino = AereosDestinoEnum.montevideo,
                FechaDeSalida = DateTime.Now.AddDays(7).Date,
                FechaDeLlegada = DateTime.Now.AddDays(7).Date.AddHours(2),
                Clase = TipoDeClaseAereaEnum.economy,
                Itinerario = AereosItinerarioEnum.oneWay,
                TipoDePasajero = TipoDePasajeroEnum.infante,
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "A113",
                Nombre = "Vuelo 113",
                Precio = 35000,
                Cantidad = 1,
                Aerolinea = AerolineaEnum.argentinas,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.buenosAires,
                Destino = AereosDestinoEnum.montevideo,
                FechaDeSalida = DateTime.Now.AddDays(7).Date,
                FechaDeLlegada = DateTime.Now.AddDays(7).Date.AddHours(2),
                Clase = TipoDeClaseAereaEnum.business,
                Itinerario = AereosItinerarioEnum.oneWay,
                TipoDePasajero = TipoDePasajeroEnum.adulto,
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "A113",
                Nombre = "Vuelo 113",
                Precio = 40000,
                Cantidad = 2,
                Aerolinea = AerolineaEnum.argentinas,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.buenosAires,
                Destino = AereosDestinoEnum.montevideo,
                FechaDeSalida = DateTime.Now.AddDays(7).Date,
                FechaDeLlegada = DateTime.Now.AddDays(7).Date.AddHours(2),
                Clase = TipoDeClaseAereaEnum.premium,
                Itinerario = AereosItinerarioEnum.oneWay,
                TipoDePasajero = TipoDePasajeroEnum.adulto,
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "A113",
                Nombre = "Vuelo 113",
                Precio = 45000,
                Cantidad = 3,
                Aerolinea = AerolineaEnum.argentinas,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.buenosAires,
                Destino = AereosDestinoEnum.montevideo,
                FechaDeSalida = DateTime.Now.AddDays(7).Date,
                FechaDeLlegada = DateTime.Now.AddDays(7).Date.AddHours(2),
                Clase = TipoDeClaseAereaEnum.first,
                Itinerario = AereosItinerarioEnum.oneWay,
                TipoDePasajero = TipoDePasajeroEnum.adulto,
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "A113",
                Nombre = "Vuelo 113",
                Precio = 30000,
                Cantidad = 1,
                Aerolinea = AerolineaEnum.argentinas,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.buenosAires,
                Destino = AereosDestinoEnum.montevideo,
                FechaDeSalida = DateTime.Now.AddDays(7).Date,
                FechaDeLlegada = DateTime.Now.AddDays(7).Date.AddHours(2),
                Clase = TipoDeClaseAereaEnum.business,
                Itinerario = AereosItinerarioEnum.oneWay,
                TipoDePasajero = TipoDePasajeroEnum.menor,
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "A113",
                Nombre = "Vuelo 113",
                Precio = 35000,
                Cantidad = 1,
                Aerolinea = AerolineaEnum.argentinas,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.buenosAires,
                Destino = AereosDestinoEnum.montevideo,
                FechaDeSalida = DateTime.Now.AddDays(7).Date,
                FechaDeLlegada = DateTime.Now.AddDays(7).Date.AddHours(2),
                Clase = TipoDeClaseAereaEnum.premium,
                Itinerario = AereosItinerarioEnum.oneWay,
                TipoDePasajero = TipoDePasajeroEnum.menor,
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "A113",
                Nombre = "Vuelo 113",
                Precio = 40000,
                Cantidad = 2,
                Aerolinea = AerolineaEnum.argentinas,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.buenosAires,
                Destino = AereosDestinoEnum.montevideo,
                FechaDeSalida = DateTime.Now.AddDays(7).Date,
                FechaDeLlegada = DateTime.Now.AddDays(7).Date.AddHours(2),
                Clase = TipoDeClaseAereaEnum.first,
                Itinerario = AereosItinerarioEnum.oneWay,
                TipoDePasajero = TipoDePasajeroEnum.menor,
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "A113",
                Nombre = "Vuelo 113",
                Precio = 20000,
                Cantidad = 1,
                Aerolinea = AerolineaEnum.argentinas,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.buenosAires,
                Destino = AereosDestinoEnum.montevideo,
                FechaDeSalida = DateTime.Now.AddDays(7).Date,
                FechaDeLlegada = DateTime.Now.AddDays(7).Date.AddHours(2),
                Clase = TipoDeClaseAereaEnum.business,
                Itinerario = AereosItinerarioEnum.oneWay,
                TipoDePasajero = TipoDePasajeroEnum.infante,
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "A113",
                Nombre = "Vuelo 113",
                Precio = 25000,
                Cantidad = 2,
                Aerolinea = AerolineaEnum.argentinas,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.buenosAires,
                Destino = AereosDestinoEnum.montevideo,
                FechaDeSalida = DateTime.Now.AddDays(7).Date,
                FechaDeLlegada = DateTime.Now.AddDays(7).Date.AddHours(2),
                Clase = TipoDeClaseAereaEnum.premium,
                Itinerario = AereosItinerarioEnum.oneWay,
                TipoDePasajero = TipoDePasajeroEnum.infante,
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "A113",
                Nombre = "Vuelo 113",
                Precio = 30000,
                Cantidad = 1,
                Aerolinea = AerolineaEnum.argentinas,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.buenosAires,
                Destino = AereosDestinoEnum.montevideo,
                FechaDeSalida = DateTime.Now.AddDays(7).Date,
                FechaDeLlegada = DateTime.Now.AddDays(7).Date.AddHours(2),
                Clase = TipoDeClaseAereaEnum.first,
                Itinerario = AereosItinerarioEnum.oneWay,
                TipoDePasajero = TipoDePasajeroEnum.infante,
            },
            // C369
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "C369",
                Nombre = "Vuelo 369",
                Precio = 60000 * 2,
                Cantidad = 1,
                Aerolinea = AerolineaEnum.latam,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.londres,
                Destino = AereosDestinoEnum.sanFrancisco,
                FechaDeSalida = DateTime.Now.AddDays(10).Date,
                FechaDeLlegada = DateTime.Now.AddDays(11).Date,
                Clase = TipoDeClaseAereaEnum.economy,
                Itinerario = AereosItinerarioEnum.roundTrip,
                TipoDePasajero = TipoDePasajeroEnum.adulto,
                Paradas = new List<AereosParadas>()
                {
                    new AereosParadas()
                    {
                        Nombre = "Nueva York",
                    },
                },
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "C369",
                Nombre = "Vuelo 369",
                Precio = 55000 * 2,
                Cantidad = 1,
                Aerolinea = AerolineaEnum.latam,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.londres,
                Destino = AereosDestinoEnum.sanFrancisco,
                FechaDeSalida = DateTime.Now.AddDays(10).Date,
                FechaDeLlegada = DateTime.Now.AddDays(11).Date,
                Clase = TipoDeClaseAereaEnum.economy,
                Itinerario = AereosItinerarioEnum.roundTrip,
                TipoDePasajero = TipoDePasajeroEnum.menor,
                Paradas = new List<AereosParadas>()
                {
                    new AereosParadas()
                    {
                        Nombre = "Nueva York",
                    },
                },
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "C369",
                Nombre = "Vuelo 369",
                Precio = 45000 * 2,
                Cantidad = 1,
                Aerolinea = AerolineaEnum.latam,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.londres,
                Destino = AereosDestinoEnum.sanFrancisco,
                FechaDeSalida = DateTime.Now.AddDays(10).Date,
                FechaDeLlegada = DateTime.Now.AddDays(11).Date,
                Clase = TipoDeClaseAereaEnum.economy,
                Itinerario = AereosItinerarioEnum.roundTrip,
                TipoDePasajero = TipoDePasajeroEnum.infante,
                Paradas = new List<AereosParadas>()
                {
                    new AereosParadas()
                    {
                        Nombre = "Nueva York",
                    },
                },
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "C369",
                Nombre = "Vuelo 369",
                Precio = 65000 * 2,
                Cantidad = 1,
                Aerolinea = AerolineaEnum.latam,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.londres,
                Destino = AereosDestinoEnum.sanFrancisco,
                FechaDeSalida = DateTime.Now.AddDays(10).Date,
                FechaDeLlegada = DateTime.Now.AddDays(11).Date,
                Clase = TipoDeClaseAereaEnum.business,
                Itinerario = AereosItinerarioEnum.roundTrip,
                TipoDePasajero = TipoDePasajeroEnum.adulto,
                Paradas = new List<AereosParadas>()
                {
                    new AereosParadas()
                    {
                        Nombre = "Nueva York",
                    },
                },
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "C369",
                Nombre = "Vuelo 369",
                Precio = 70000 * 2,
                Cantidad = 2,
                Aerolinea = AerolineaEnum.latam,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.londres,
                Destino = AereosDestinoEnum.sanFrancisco,
                FechaDeSalida = DateTime.Now.AddDays(10).Date,
                FechaDeLlegada = DateTime.Now.AddDays(11).Date,
                Clase = TipoDeClaseAereaEnum.premium,
                Itinerario = AereosItinerarioEnum.roundTrip,
                TipoDePasajero = TipoDePasajeroEnum.adulto,
                Paradas = new List<AereosParadas>()
                {
                    new AereosParadas()
                    {
                        Nombre = "Nueva York",
                    },
                },
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "C369",
                Nombre = "Vuelo 369",
                Precio = 75000 * 2,
                Cantidad = 3,
                Aerolinea = AerolineaEnum.latam,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.londres,
                Destino = AereosDestinoEnum.sanFrancisco,
                FechaDeSalida = DateTime.Now.AddDays(10).Date,
                FechaDeLlegada = DateTime.Now.AddDays(11).Date,
                Clase = TipoDeClaseAereaEnum.first,
                Itinerario = AereosItinerarioEnum.roundTrip,
                TipoDePasajero = TipoDePasajeroEnum.adulto,
                Paradas = new List<AereosParadas>()
                {
                    new AereosParadas()
                    {
                        Nombre = "Nueva York",
                    },
                },
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "C369",
                Nombre = "Vuelo 369",
                Precio = 60000 * 2,
                Cantidad = 1,
                Aerolinea = AerolineaEnum.latam,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.londres,
                Destino = AereosDestinoEnum.sanFrancisco,
                FechaDeSalida = DateTime.Now.AddDays(10).Date,
                FechaDeLlegada = DateTime.Now.AddDays(11).Date,
                Clase = TipoDeClaseAereaEnum.business,
                Itinerario = AereosItinerarioEnum.roundTrip,
                TipoDePasajero = TipoDePasajeroEnum.menor,
                Paradas = new List<AereosParadas>()
                {
                    new AereosParadas()
                    {
                        Nombre = "Nueva York",
                    },
                },
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "C369",
                Nombre = "Vuelo 369",
                Precio = 65000 * 2,
                Cantidad = 1,
                Aerolinea = AerolineaEnum.latam,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.londres,
                Destino = AereosDestinoEnum.sanFrancisco,
                FechaDeSalida = DateTime.Now.AddDays(10).Date,
                FechaDeLlegada = DateTime.Now.AddDays(11).Date,
                Clase = TipoDeClaseAereaEnum.premium,
                Itinerario = AereosItinerarioEnum.roundTrip,
                TipoDePasajero = TipoDePasajeroEnum.menor,
                Paradas = new List<AereosParadas>()
                {
                    new AereosParadas()
                    {
                        Nombre = "Nueva York",
                    },
                },
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "C369",
                Nombre = "Vuelo 369",
                Precio = 70000 * 2,
                Cantidad = 2,
                Aerolinea = AerolineaEnum.latam,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.londres,
                Destino = AereosDestinoEnum.sanFrancisco,
                FechaDeSalida = DateTime.Now.AddDays(10).Date,
                FechaDeLlegada = DateTime.Now.AddDays(11).Date,
                Clase = TipoDeClaseAereaEnum.first,
                Itinerario = AereosItinerarioEnum.roundTrip,
                TipoDePasajero = TipoDePasajeroEnum.menor,
                Paradas = new List<AereosParadas>()
                {
                    new AereosParadas()
                    {
                        Nombre = "Nueva York",
                    },
                },
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "C369",
                Nombre = "Vuelo 369",
                Precio = 50000 * 2,
                Cantidad = 1,
                Aerolinea = AerolineaEnum.latam,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.londres,
                Destino = AereosDestinoEnum.sanFrancisco,
                FechaDeSalida = DateTime.Now.AddDays(10).Date,
                FechaDeLlegada = DateTime.Now.AddDays(11).Date,
                Clase = TipoDeClaseAereaEnum.business,
                Itinerario = AereosItinerarioEnum.roundTrip,
                TipoDePasajero = TipoDePasajeroEnum.infante,
                Paradas = new List<AereosParadas>()
                {
                    new AereosParadas()
                    {
                        Nombre = "Nueva York",
                    },
                },
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "C369",
                Nombre = "Vuelo 369",
                Precio = 55000 * 2,
                Cantidad = 2,
                Aerolinea = AerolineaEnum.latam,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.londres,
                Destino = AereosDestinoEnum.sanFrancisco,
                FechaDeSalida = DateTime.Now.AddDays(10).Date,
                FechaDeLlegada = DateTime.Now.AddDays(11).Date,
                Clase = TipoDeClaseAereaEnum.premium,
                Itinerario = AereosItinerarioEnum.roundTrip,
                TipoDePasajero = TipoDePasajeroEnum.infante,
                Paradas = new List<AereosParadas>()
                {
                    new AereosParadas()
                    {
                        Nombre = "Nueva York",
                    },
                },
            },
            new Aereos()
            {
                Id = Guid.NewGuid(),
                Codigo = "C369",
                Nombre = "Vuelo 369",
                Precio = 60000 * 2,
                Cantidad = 1,
                Aerolinea = AerolineaEnum.latam,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = AereosOrigenEnum.londres,
                Destino = AereosDestinoEnum.sanFrancisco,
                FechaDeSalida = DateTime.Now.AddDays(10).Date,
                FechaDeLlegada = DateTime.Now.AddDays(11).Date,
                Clase = TipoDeClaseAereaEnum.first,
                Itinerario = AereosItinerarioEnum.roundTrip,
                TipoDePasajero = TipoDePasajeroEnum.infante,
                Paradas = new List<AereosParadas>()
                {
                    new AereosParadas()
                    {
                        Nombre = "Nueva York",
                    },
                },
            },
        };

        private static List<Aereos> aereosElegidos = new List<Aereos>();

        public static IEnumerable<Aereos> GetAereos()
        {
            return aereos;
        }

        public static IEnumerable<Aereos> GetAereos(AereosFilter filter)
        {
            return aereos
                    .Where(x => (!filter.CantidadMin.HasValue || x.Cantidad >= filter.CantidadMin)
                                && (!filter.PrecioDesde.HasValue || x.Precio >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Precio <= filter.PrecioHasta)
                                && (!filter.FechaDesde.HasValue || x.FechaDeSalida.Date == filter.FechaDesde)
                                && (!filter.FechaHasta.HasValue || x.FechaDeLlegada.Date == filter.FechaHasta)
                                && (!filter.Origen.HasValue || (int)x.Origen == filter.Origen)
                                && (!filter.Destino.HasValue || (int)x.Destino == filter.Destino)
                                && (!filter.TipoDePasajero.HasValue || (int)x.TipoDePasajero == filter.TipoDePasajero)
                                && (!filter.Itinerario.HasValue || (int)x.Itinerario == filter.Itinerario)
                                && (!filter.Clase.HasValue || (int)x.Clase == filter.Clase));
        }

        public static Aereos? GetAereoByID(Guid id)
        {
            return aereos.Where(x => x.Id == id).SingleOrDefault();
        }

        public static IEnumerable<Aereos> GetAereosElegidos()
        {
            return aereosElegidos;
        }

        public static void ClearAereosElegidos()
        {
            aereosElegidos.Clear();
        }

        public static void AddAereoElegido(Guid id)
        {
            var producto = aereos.Where(x => x.Id == id).SingleOrDefault();

            aereosElegidos.Add(producto);
        }

        public static void RemoveAereoElegido(Guid id)
        {
            var index = aereosElegidos.FindIndex(x => x.Id == id);

            if (index != -1)
            {
                aereosElegidos.RemoveAt(index);
            }
        }

        public static void ActualizarCantidadesDeAereos()
        {
            var aereosToUpdate = new List<Aereos>(aereos.Intersect(aereosElegidos));

            foreach (var aereo in aereosToUpdate)
            {
                var indexAereo = aereos.FindIndex(x => x.Id == aereo.Id);

                var cantidadSeleccionada = aereosElegidos.Where(x => x.Id == aereo.Id).Count();

                aereo.Cantidad = aereo.Cantidad - cantidadSeleccionada;

                if (indexAereo != -1)
                {
                    aereos[indexAereo] = aereo;
                }
            }

            aereosElegidos.Clear();
        }
    }
}
