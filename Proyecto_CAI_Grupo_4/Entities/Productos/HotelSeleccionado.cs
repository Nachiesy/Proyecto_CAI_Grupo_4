namespace Proyecto_CAI_Grupo_4.Entities;

public class HotelSeleccionado
{
    public HotelSeleccionado(string idUnico, int idHotel)
    {
        Id = idUnico;
        IdHotel = idHotel;
    }

    public string Id { get; set; }
    public int IdHotel { get; set; }
}