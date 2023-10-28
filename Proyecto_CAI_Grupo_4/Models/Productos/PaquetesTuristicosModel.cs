using Proyecto_CAI_Grupo_4.Entities.Productos;
using Proyecto_CAI_Grupo_4.Filters;

namespace Proyecto_CAI_Grupo_4.Models.Productos
{
    public static class PaquetesTuristicosModel
    {
        private static List<PaquetesTuristicos> paquetesTuristicos = new List<PaquetesTuristicos>()
        {
            new PaquetesTuristicos()
            {
                Id = Guid.NewGuid(),
                Codigo = "PC11",
                Nombre = "Paquete de la Costa",
                Precio = 300000,
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
                Precio = 900000,
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
                Precio = 900000,
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
                Precio = 900000,
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

        private static List<PaquetesTuristicos> paquetesTuristicosElegidos = new List<PaquetesTuristicos>();

        public static IEnumerable<PaquetesTuristicos> GetPaquetesTuristicos()
        {
            return paquetesTuristicos;
        }

        public static IEnumerable<PaquetesTuristicos> GetPaquetesTuristicos(PaquetesTuristicosFilter filter)
        {
            return paquetesTuristicos
                    .Where(x => (!filter.CantidadMin.HasValue || x.Cantidad >= filter.CantidadMin)
                                && (!filter.PrecioDesde.HasValue || x.Precio >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Precio <= filter.PrecioHasta)
                                && (!filter.FechaDesde.HasValue || x.FechaDesde == filter.FechaDesde)
                                && (!filter.FechaHasta.HasValue || x.FechaHasta == filter.FechaHasta)
                                && (!filter.Origen.HasValue || (int)x.Origen == filter.Origen)
                                && (!filter.Destino.HasValue || (int)x.Destino == filter.Destino));
        }

        public static PaquetesTuristicos? GetPaqueteTuristicoByID(Guid id)
        {
            return paquetesTuristicos.Where(x => x.Id == id).SingleOrDefault();
        }

        public static IEnumerable<PaquetesTuristicos> GetPaquetesTuristicosElegidos()
        {
            return paquetesTuristicosElegidos;
        }

        public static void ClearPaquetesTuristicosElegidos()
        {
            paquetesTuristicosElegidos.Clear();
        }

        public static void AddPaqueteTuristicoElegido(Guid id)
        {
            var producto = paquetesTuristicos.Where(x => x.Id == id).SingleOrDefault();

            paquetesTuristicosElegidos.Add(producto);
        }

        public static void ActualizarCantidadesDePaquetes()
        {
            var paquetesToUpdate = new List<PaquetesTuristicos>(paquetesTuristicos.Intersect(paquetesTuristicosElegidos));

            foreach (var paquete in paquetesToUpdate)
            {
                var paqueteIndex = paquetesTuristicos.FindIndex(x => x.Id == paquete.Id);

                var cantidadSeleccionada = paquetesTuristicosElegidos.Where(x => x.Id == paquete.Id).Count();

                paquete.Cantidad = paquete.Cantidad - cantidadSeleccionada;

                if (paqueteIndex != -1)
                {
                    paquetesTuristicos[paqueteIndex] = paquete;
                }
            }

            paquetesTuristicosElegidos.Clear();
        }
    }
}
