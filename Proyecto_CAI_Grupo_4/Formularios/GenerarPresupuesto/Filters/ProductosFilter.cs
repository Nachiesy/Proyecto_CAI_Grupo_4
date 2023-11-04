namespace Proyecto_CAI_Grupo_4.Filters
{
    public class ProductosFilter
    {
        public int? CantidadMin { get; set; }

        public decimal? PrecioDesde { get; private set; }

        private string precioDesdeInput;

        public string PrecioDesdeInput
        {
            get
            {
                return precioDesdeInput;
            }
            set
            {
                precioDesdeInput = value;

                if (decimal.TryParse(precioDesdeInput, out decimal precioDesde))
                {
                    PrecioDesde = precioDesde;
                }
            }
        }

        public decimal? PrecioHasta { get; private set; }

        private string precioHastaInput;

        public string PrecioHastaInput
        {
            get
            {
                return precioHastaInput;
            }
            set
            {
                precioHastaInput = value;

                if (decimal.TryParse(precioHastaInput, out decimal precioHasta))
                {
                    PrecioHasta = precioHasta;
                }
            }
        }

        public DateTime? FechaDesde { get; set; }

        public DateTime? FechaHasta { get; set; }
    }
}
