namespace Proyecto_CAI_Grupo_4.Entities;

public class AereoEnt
{
    public int Id { get; set; }

    public string Codigo { get; set; }

    public string Nombre { get; set; }

    public string Origen { get; set; }

    public string Destino { get; set; }

    public DateTime FechaDeSalida { get; set; }

    public DateTime FechaDeLlegada { get; set; }

    public string Aerolinea { get; set; }

    public TarifaAereo Tarifa { get; set; }

    public int CantidadDeParadas { get; set; }
}