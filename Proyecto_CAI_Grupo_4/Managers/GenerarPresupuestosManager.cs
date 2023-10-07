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
    }
}
