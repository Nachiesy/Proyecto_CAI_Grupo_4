using Proyecto_CAI_Grupo_4.Models.Productos;

namespace Proyecto_CAI_Grupo_4.Managers
{
    public class GenerarPresupuestosManager
    {
        public static List<ProductosAereos> productosAereos = new List<ProductosAereos>()
        {
            new ProductosAereos()
            {
                Id = Guid.NewGuid(),
                Nombre = "Vuelo 113",
                Precio = 10,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = "Buenos Aires",
                Destino = "Montevideo",
                FechaDeSalida = DateTime.Now.AddDays(10).Date,
                FechaDeLlegada = DateTime.Now.AddDays(20).Date,
                TipoDeClaseAerea = TipoDeClaseAereaEnum.turista,
            },
            new ProductosAereos()
            {
                Id = Guid.NewGuid(),
                Nombre = "Vuelo 201",
                Precio = 10,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = "Madrid",
                Destino = "Paris",
                FechaDeSalida = DateTime.Now.AddDays(10).Date,
                FechaDeLlegada = DateTime.Now.AddDays(20).Date,
                TipoDeClaseAerea = TipoDeClaseAereaEnum.ejecutivo,
            },
            new ProductosAereos()
            {
                Id = Guid.NewGuid(),
                Nombre = "Vuelo 369",
                Precio = 10,
                TipoDeServicio = TipoDeServicioEnum.aereo,
                Origen = "Londres",
                Destino = "San Francisco",
                FechaDeSalida = DateTime.Now.AddDays(10).Date,
                FechaDeLlegada = DateTime.Now.AddDays(20).Date,
                TipoDeClaseAerea = TipoDeClaseAereaEnum.primeraClase,
            },
        };

        public static List<ProductosAereos> productosAereosElegidos = new List<ProductosAereos>();

        public static List<ProductosHoteles> productosHoteles = new List<ProductosHoteles>()
        {
            new ProductosHoteles()
            {
                Id = Guid.NewGuid(),
                Nombre = "Hilton",
                Precio = 10,
                TipoDeServicio = TipoDeServicioEnum.hotel,
                Ciudad = "Buenos Aires",
                Habitacion = "Nro. 200",
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
            },
            new ProductosHoteles()
            {
                Id = Guid.NewGuid(),
                Nombre = "Sheraton",
                Precio = 10,
                TipoDeServicio = TipoDeServicioEnum.hotel,
                Ciudad = "Montevideo",
                Habitacion = "Nro. 100",
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
            },
            new ProductosHoteles()
            {
                Id = Guid.NewGuid(),
                Nombre = "Intercontinental",
                Precio = 10,
                TipoDeServicio = TipoDeServicioEnum.hotel,
                Ciudad = "Madrid",
                Habitacion = "Nro. 300",
                FechaDesde = DateTime.Now.AddDays(10).Date,
                FechaHasta = DateTime.Now.AddDays(20).Date,
            },
        };

        public static List<ProductosHoteles> productosHotelesElegidos = new List<ProductosHoteles>();
    }
}
