namespace Proyecto_CAI_Grupo_4.Entities
{
    public class HotelEnt
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Ciudad { get; set; }

        public string Calificacion { get; set; }

        public DireccionHotel Direccion { get; set; }

        public DisponibilidadHotel Disponibilidad { get; set; }
    }

    public class DireccionHotel
    {
        public string Calle { get; set; }

        public int Numero { get; set; }

        public int CP { get; set; }

        public string Latitud { get; set; }

        public string Longitud { get; set; }
    }

    public class DisponibilidadHotel
    {
        public string NombreHabitacion { get; set; }

        public decimal TarifaPorDia { get; set; }

        public int CapacidadTotal { get; set; }

        public int CantidadMaximaAdultos { get; set; }

        public int CantidadMaximaMenores { get; set; }

        public int CantidadMaximaInfantes { get; set; }

        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }

        public int Disponibilidad { get; set; }
    }
}
