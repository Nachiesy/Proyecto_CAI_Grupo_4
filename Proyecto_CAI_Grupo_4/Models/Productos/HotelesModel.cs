using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Filters;

namespace Proyecto_CAI_Grupo_4.Models.Productos
{
    public static class HotelesModel
    {
        private static List<Hoteles> hoteles = new List<Hoteles>()
        {
            new Hoteles()
            {
                Id = 25,
                Codigo = "HIL",
                Nombre = "Hilton",
                Precio = 10000,
                Cantidad = 4,
                TipoDeServicio = TipoDeServicioEnum.hotel,
                Ciudad = HotelesCiudadEnum.buenosAires,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(11).Date,
                TipoDeHabitacion = TipoDeHabitacionEnum.simple,
                Calificacion = HotelesCalificacionEnum.cinco,
                CantidadMaximaDeAdultos = 2,
                CantidadMaximaDeMenores = 0,
                CantidadMaximaDeInfantes = 0,
                Direccion = "Av Libertador 100",
            },
            new Hoteles()
            {
                Id = 26,
                Codigo = "HIL",
                Nombre = "Hilton",
                Precio = 20000,
                Cantidad = 3,
                TipoDeServicio = TipoDeServicioEnum.hotel,
                Ciudad = HotelesCiudadEnum.buenosAires,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(11).Date,
                TipoDeHabitacion = TipoDeHabitacionEnum.doble,
                Calificacion = HotelesCalificacionEnum.cinco,
                CantidadMaximaDeAdultos = 2,
                CantidadMaximaDeMenores = 2,
                CantidadMaximaDeInfantes = 0,
                Direccion = "Av Libertador 100",
            },
            new Hoteles()
            {
                Id = 27,
                Codigo = "HIL",
                Nombre = "Hilton",
                Precio = 30000,
                Cantidad = 2,
                TipoDeServicio = TipoDeServicioEnum.hotel,
                Ciudad = HotelesCiudadEnum.buenosAires,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(11).Date,
                TipoDeHabitacion = TipoDeHabitacionEnum.triple,
                Calificacion = HotelesCalificacionEnum.cinco,
                CantidadMaximaDeAdultos = 2,
                CantidadMaximaDeMenores = 3,
                CantidadMaximaDeInfantes = 1,
                Direccion = "Av Libertador 100",
            },
            new Hoteles()
            {
                Id = 28,
                Codigo = "HIL",
                Nombre = "Hilton",
                Precio = 40000,
                Cantidad = 1,
                TipoDeServicio = TipoDeServicioEnum.hotel,
                Ciudad = HotelesCiudadEnum.buenosAires,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(11).Date,
                TipoDeHabitacion = TipoDeHabitacionEnum.cuadruple,
                Calificacion = HotelesCalificacionEnum.cinco,
                CantidadMaximaDeAdultos = 4,
                CantidadMaximaDeMenores = 2,
                CantidadMaximaDeInfantes = 2,
                Direccion = "Av Libertador 100",
            },
            new Hoteles()
            {
                Id = 29,
                Codigo = "SHE",
                Nombre = "Sheraton",
                Precio = 10000,
                Cantidad = 4,
                TipoDeServicio = TipoDeServicioEnum.hotel,
                Ciudad = HotelesCiudadEnum.madrid,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(11).Date,
                TipoDeHabitacion = TipoDeHabitacionEnum.simple,
                Calificacion = HotelesCalificacionEnum.cuatro,
                CantidadMaximaDeAdultos = 2,
                CantidadMaximaDeMenores = 0,
                CantidadMaximaDeInfantes = 0,
                Direccion = "Av Cordoba 300",
            },
            new Hoteles()
            {
                Id = 30,
                Codigo = "SHE",
                Nombre = "Sheraton",
                Precio = 20000,
                Cantidad = 3,
                TipoDeServicio = TipoDeServicioEnum.hotel,
                Ciudad = HotelesCiudadEnum.madrid,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(11).Date,
                TipoDeHabitacion = TipoDeHabitacionEnum.doble,
                Calificacion = HotelesCalificacionEnum.cuatro,
                CantidadMaximaDeAdultos = 2,
                CantidadMaximaDeMenores = 2,
                CantidadMaximaDeInfantes = 0,
                Direccion = "Av Cordoba 300",
            },
            new Hoteles()
            {
                Id = 31,
                Codigo = "SHE",
                Nombre = "Sheraton",
                Precio = 30000,
                Cantidad = 2,
                TipoDeServicio = TipoDeServicioEnum.hotel,
                Ciudad = HotelesCiudadEnum.madrid,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(11).Date,
                TipoDeHabitacion = TipoDeHabitacionEnum.triple,
                Calificacion = HotelesCalificacionEnum.cuatro,
                CantidadMaximaDeAdultos = 2,
                CantidadMaximaDeMenores = 3,
                CantidadMaximaDeInfantes = 1,
                Direccion = "Av Cordoba 300",
            },
            new Hoteles()
            {
                Id = 32,
                Codigo = "SHE",
                Nombre = "Sheraton",
                Precio = 40000,
                Cantidad = 1,
                TipoDeServicio = TipoDeServicioEnum.hotel,
                Ciudad = HotelesCiudadEnum.madrid,
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(11).Date,
                TipoDeHabitacion = TipoDeHabitacionEnum.cuadruple,
                Calificacion = HotelesCalificacionEnum.cuatro,
                CantidadMaximaDeAdultos = 4,
                CantidadMaximaDeMenores = 2,
                CantidadMaximaDeInfantes = 2,
                Direccion = "Av Cordoba 300",
            },
        };

        private static List<Hoteles> hotelesElegidos = new List<Hoteles>();

        public static IEnumerable<Hoteles> GetHoteles()
        {
            return hoteles;
        }

        public static IEnumerable<Hoteles> GetHotelesByIds(IEnumerable<Guid> ids)
        {
            return hoteles.Where(x => ids.Contains(x.Id));
        }

        public static IEnumerable<Hoteles> GetHoteles(HotelesFilter filter)
        {
            return hoteles
                    .Where(x => (!filter.CantidadMin.HasValue || x.Cantidad >= filter.CantidadMin)
                                && (!filter.PrecioDesde.HasValue || x.Precio >= filter.PrecioDesde)
                                && (!filter.PrecioHasta.HasValue || x.Precio <= filter.PrecioHasta)
                                && (!filter.FechaDesde.HasValue || x.FechaDesde == filter.FechaDesde)
                                && (!filter.FechaHasta.HasValue || x.FechaHasta == filter.FechaHasta)
                                && (string.IsNullOrEmpty(filter.Nombre) || x.Nombre == filter.Nombre)
                                && (!filter.Ciudad.HasValue || (int)x.Ciudad == filter.Ciudad)
                                && (!filter.TipoDeHabitacion.HasValue || (int)x.TipoDeHabitacion == filter.TipoDeHabitacion)
                                && (!filter.Calificacion.HasValue || (int)x.Calificacion == filter.Calificacion));
        }

        public static Hoteles? GetHotelByID(int id)
        {
            return hoteles.Where(x => x.Id == id).SingleOrDefault();
        }

        public static IEnumerable<Hoteles> GetHotelesElegidos()
        {
            return hotelesElegidos;
        }

        public static IEnumerable<Guid> GetIdsHotelesElegidos()
        {
            return hotelesElegidos.Select(x => x.Id);
        }

        public static void ClearHotelesElegidos()
        {
            hotelesElegidos.Clear();
        }

        public static void AddHotelElegido(int id)
        {
            var producto = hoteles.Where(x => x.Id == id).SingleOrDefault();

            hotelesElegidos.Add(producto);
        }

        public static void RemoveHotelElegido(int id)
        {
            var index = hotelesElegidos.FindIndex(x => x.Id == id);

            if (index != -1)
            {
                hotelesElegidos.RemoveAt(index);
            }
        }

        public static void ActualizarCantidadesDeHoteles()
        {
            var hotelesToUpdate = new List<Hoteles>(hoteles.Intersect(hotelesElegidos));

            foreach (var hotel in hotelesToUpdate)
            {
                var indexHotel = hoteles.FindIndex(x => x.Id == hotel.Id);

                var cantidadSeleccionada = hotelesElegidos.Where(x => x.Id == hotel.Id).Count();

                hotel.Cantidad = hotel.Cantidad - cantidadSeleccionada;

                if (indexHotel != -1)
                {
                    hoteles[indexHotel] = hotel;
                }
            }

            hotelesElegidos.Clear();
        }
    }
}
