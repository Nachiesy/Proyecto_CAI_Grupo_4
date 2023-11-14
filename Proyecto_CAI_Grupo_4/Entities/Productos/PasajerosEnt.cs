namespace Proyecto_CAI_Grupo_4.Entities;

public class PasajerosEnt
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int DNI { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public int IdPresupuesto { get; set; }

    public List<AereoSeleccionado> AereosAsignados { get; set; } = new List<AereoSeleccionado>();
    public List<HotelSeleccionado> HotelesAsignados { get; set; } = new List<HotelSeleccionado>();

    public PasajerosEnt(int idPresupuesto, string nombre, string apellido, int dni, DateTime fechaNacimiento)
    {
        IdPresupuesto = idPresupuesto;
        Nombre = nombre;
        Apellido = apellido;
        DNI = dni;
        FechaNacimiento = fechaNacimiento;
    }

    public int GetEdad()
    {
        return DateTime.Now.Year - FechaNacimiento.Year;
    }

    public string GetTipoDePasajero()
    {
        var edad = GetEdad();

        if (edad <= 2)
        {
            return "Infante";
        }
        
        if (edad < 18)
        {
            return "Menor";
        }

        return "Adulto";
    }

    public int TotalAsignados()
    {
        return AereosAsignados.Count + HotelesAsignados.Count;
    }

    public PasajerosEnt AsignarAereo(AereoSeleccionado productoSeleccionado)
    {
        AereosAsignados.Add(productoSeleccionado);
        return this;
    }

    public PasajerosEnt AsignarHotel(HotelSeleccionado productoSeleccionado)
    {
        HotelesAsignados.Add(productoSeleccionado);
        return this;
    }
}