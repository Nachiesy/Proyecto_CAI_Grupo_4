namespace Proyecto_CAI_Grupo_4.Entities;

public class AereoSeleccionado
{
    public AereoSeleccionado(string idUnico, int idAereo)
    {
        Id = idUnico;
        IdAereo = idAereo;
    }

    public string Id { get; set; }
    public int IdAereo { get; set; }
}