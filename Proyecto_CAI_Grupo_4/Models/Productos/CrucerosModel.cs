using Proyecto_CAI_Grupo_4.Entities.Productos;
using Proyecto_CAI_Grupo_4.Filters;

namespace Proyecto_CAI_Grupo_4.Models.Productos
{
    public static class CrucerosModel
    {
        private static List<Cruceros> cruceros = new List<Cruceros>()
        {
            new Cruceros()
            {
                Id = Guid.NewGuid(),
                Codigo = "CC11",
                Nombre = "Crucero de la Costa",
                Precio = 500000,
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
                Precio = 500000,
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
                Precio = 500000,
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
                Precio = 500000,
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

        private static List<Cruceros> crucerosElegidos = new List<Cruceros>();

        public static IEnumerable<Cruceros> GetCruceros()
        {
            return cruceros;
        }

        public static IEnumerable<Cruceros> GetCruceros(CrucerosFilter filter)
        {
            return cruceros
                    .Where(x => (!filter.CantidadMin.HasValue || x.Cantidad >= filter.CantidadMin)
                                && (!filter.PrecioDesde.HasValue || x.Precio >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Precio <= filter.PrecioHasta)
                                && (!filter.FechaDesde.HasValue || x.FechaDesde == filter.FechaDesde)
                                && (!filter.FechaHasta.HasValue || x.FechaHasta == filter.FechaHasta)
                                && (!filter.CiudadDePartida.HasValue || (int)x.CiudadDePartida == filter.CiudadDePartida)
                                && (!filter.CiudadDeLlegada.HasValue || (int)x.CiudadDeLlegada == filter.CiudadDeLlegada)
                                && (!filter.TipoDeCamarote.HasValue || (int)x.TipoDeCamarote == filter.TipoDeCamarote));
        }

        public static Cruceros? GetCruceroByID(Guid id)
        {
            return cruceros.Where(x => x.Id == id).SingleOrDefault();
        }

        public static IEnumerable<Cruceros> GetCrucerosElegidos()
        {
            return crucerosElegidos;
        }

        public static void ClearCrucerosElegidos()
        {
            crucerosElegidos.Clear();
        }

        public static void AddCruceroElegido(Guid id)
        {
            var producto = cruceros.Where(x => x.Id == id).SingleOrDefault();

            crucerosElegidos.Add(producto);
        }

        public static void ActualizarCantidadesDeCruceros()
        {
            var crucerosToUpdate = new List<Cruceros>(cruceros.Intersect(crucerosElegidos));

            foreach (var crucero in crucerosToUpdate)
            {
                var cruceroIndex = cruceros.FindIndex(x => x.Id == crucero.Id);

                var cantidadSeleccionada = crucerosElegidos.Where(x => x.Id == crucero.Id).Count();

                crucero.Cantidad = crucero.Cantidad - cantidadSeleccionada;

                if (cruceroIndex != -1)
                {
                    cruceros[cruceroIndex] = crucero;
                }
            }

            crucerosElegidos.Clear();
        }
    }
}
