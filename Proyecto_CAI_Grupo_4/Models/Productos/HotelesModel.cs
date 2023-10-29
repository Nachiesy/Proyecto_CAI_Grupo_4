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
                Id = Guid.Parse("55be2c9a-987a-4bfe-a7de-23025f7dc2fe"),
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
                Id = Guid.Parse("f3b64800-5eb6-40fc-8ee9-2d2d0eb661ae"),
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
                Id = Guid.Parse("d0eb7781-145e-4f42-8c87-a11bee28636a"),
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
                Id = Guid.Parse("7a13d7cb-10bf-4300-a620-25b21e95e4c6"),
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
                Id = Guid.Parse("6459cbc3-6757-4aea-b4ca-7befeea696e5"),
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
                Id = Guid.Parse("cd320b6d-093b-4131-98c9-77a31bafa353"),
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
                Id = Guid.Parse("88325af2-7a0d-4819-907a-c2358a130211"),
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
                Id = Guid.Parse("da20f950-9b8c-4d68-9376-357ada524df1"),
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

        public static Hoteles? GetHotelByID(Guid id)
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

        public static void AddHotelElegido(Guid id)
        {
            var producto = hoteles.Where(x => x.Id == id).SingleOrDefault();

            hotelesElegidos.Add(producto);
        }

        public static void RemoveHotelElegido(Guid id)
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
