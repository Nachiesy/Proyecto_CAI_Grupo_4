namespace Proyecto_CAI_Grupo_4.Entities;

public class Pasajeros
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int DNI { get; set; }
    public DateTime FechaNacimiento { get; set; }

    public Pasajeros(string nombre, string apellido, int dni, DateTime fechaNacimiento)
    {
        Nombre = nombre;
        Apellido = apellido;
        DNI = dni;
        FechaNacimiento = fechaNacimiento;
    }
}