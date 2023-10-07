﻿namespace Proyecto_CAI_Grupo_4.Filters
{
    public class ProductosAereosFilterDto : ProductosFilterDto
    {
        public string Origen { get; set; }

        public string Destino { get; set; }

        public DateTime FechaDeSalida { get; set; }

        public DateTime FechaDeLlegada { get; set; }

        public int TipoDeClaseAerea { get; set; }
    }

    public class ProductosAereosFilter : ProductosFilter
    {
        public ProductosAereosFilter(ProductosAereosFilterDto dto) : base(dto)
        {
            Origen = dto.Origen;

            Destino = dto.Destino;

            FechaDeSalida = dto.FechaDeSalida.Date;

            FechaDeLlegada = dto.FechaDeLlegada.Date;

            TipoDeClaseAerea = dto.TipoDeClaseAerea;
        }

        public string Origen { get; set; }

        public string Destino { get; set; }

        public DateTime FechaDeSalida { get; set; }

        public DateTime FechaDeLlegada { get; set; }

        public int TipoDeClaseAerea { get; set; }
    }
}
