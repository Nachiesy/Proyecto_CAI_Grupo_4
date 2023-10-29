using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Filters;

namespace Proyecto_CAI_Grupo_4.Models.Productos
{
    public static class AereosModel
    {
        private static List<Aereos> aereos = new List<Aereos>()
        {
            new Aereos()
            {
                Id = Guid.Parse("b3bac23e-b28c-4db8-bfd8-107776ef929d"),
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
                Id = Guid.Parse("1b1df411-3025-4e20-ac50-f4d82265c0e1"),
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
                Id = Guid.Parse("2167b9e7-2651-456d-9794-a0258530d288"),
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
                Id = Guid.Parse("b2cee040-cf9f-4ca9-acef-c0538e782290"),
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
                Id = Guid.Parse("76aed05d-8ed7-47dd-af29-7e7e6f5355ec"),
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
                Id = Guid.Parse("a39f6b63-a97c-4544-8e89-e603df6aced6"),
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
                Id = Guid.Parse("d5836629-adfb-42d1-b074-fa530a97c80f"),
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
                Id = Guid.Parse("0abeb0b2-c59f-4776-99b9-e6a8c2bac549"),
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
                Id = Guid.Parse("21c5a5f7-ef9e-4663-8455-4cd93b803f92"),
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
                Id = Guid.Parse("36039fda-7d8a-4df6-992f-6448b6af0aea"),
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
                Id = Guid.Parse("095a5da3-2351-439e-8070-77e529974c04"),
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
                Id = Guid.Parse("6d1e8f23-de0c-4459-9b3f-0465c5457f27"),
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
            new Aereos()
            {
                Id = Guid.Parse("b22a65f4-eeeb-47b7-9afc-9761604191c3"),
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
                Id = Guid.Parse("5e6336ca-994a-48d1-ba41-0ffe37ebcd4f"),
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
                Id = Guid.Parse("fe26b9e8-9856-49ba-9c6d-570efbb1b2e3"),
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
                Id = Guid.Parse("a966c57d-e54c-48cc-a6a1-6e31ab6ca7d1"),
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
                Id = Guid.Parse("6d848e8b-7eb8-458f-927c-aa14faf2f0be"),
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
                Id = Guid.Parse("beae21d7-5b14-4cac-b7a6-e45cff3ec576"),
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
                Id = Guid.Parse("eb420ddd-18db-496e-8af4-01b1a4066ef5"),
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
                Id = Guid.Parse("727ef558-2791-44c5-b396-9d205bbc201c"),
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
                Id = Guid.Parse("c281fcb8-f21b-4f26-8231-a93f9c53c9fc"),
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
                Id = Guid.Parse("ba3a4b4f-b5e7-4aa7-b201-5770cde34a94"),
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
                Id = Guid.Parse("dfc99e4b-bd9e-4e92-9333-2e4a7b018cb5"),
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
                Id = Guid.Parse("d1bd5ae1-f58d-4752-82ad-2f9d28aef55d"),
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

        public static IEnumerable<Aereos> GetAereosByIds(IEnumerable<Guid> ids)
        {
            return aereos.Where(x => ids.Contains(x.Id));
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
            return aereos.SingleOrDefault(x => x.Id == id);
        }

        public static IEnumerable<Aereos> GetAereosElegidos()
        {
            return aereosElegidos;
        }

        public static IEnumerable<Guid> GetIdsAereosElegidos()
        {
            return aereosElegidos.Select(x => x.Id);
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
