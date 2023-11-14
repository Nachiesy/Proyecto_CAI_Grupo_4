namespace Proyecto_CAI_Grupo_4.Entities
{
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
