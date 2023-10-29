namespace Proyecto_CAI_Grupo_4.Entities;

public class Pasajeros
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int DNI { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public int IdReserva { get; set; }

    public List<Guid> IdsAereosAsignados { get; set; } = new List<Guid>();
    public List<Guid> IdsHotelesAsignados { get; set; } = new List<Guid>();

    public Pasajeros(int idReserva, string nombre, string apellido, int dni, DateTime fechaNacimiento)
    {
        IdReserva = idReserva;
        Nombre = nombre;
        Apellido = apellido;
        DNI = dni;
        FechaNacimiento = fechaNacimiento;
    }

    public int GetEdad()
    {
        return DateTime.Now.Year - FechaNacimiento.Year;
    }

    public TipoDePasajeroEnum GetTipoDePasajero()
    {
        var edad = GetEdad();

        if (edad <= 11)
        {
            return TipoDePasajeroEnum.infante;
        }
        
        if (edad < 18)
        {
            return TipoDePasajeroEnum.menor;
        }

        return TipoDePasajeroEnum.adulto;
    }

    public int TotalAsignados()
    {
        return IdsAereosAsignados.Count + IdsHotelesAsignados.Count;
    }

    public Pasajeros AsignarAereo(Guid idProducto)
    {
        IdsAereosAsignados.Add(idProducto);
        return this;
    }

    public Pasajeros AsignarHotel(Guid idProducto)
    {
        IdsHotelesAsignados.Add(idProducto);
        return this;
    }
}