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
}
