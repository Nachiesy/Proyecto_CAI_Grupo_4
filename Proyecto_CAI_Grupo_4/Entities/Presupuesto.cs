namespace Proyecto_CAI_Grupo_4.Entities
{
    public class Presupuesto
    {
        public string DNI { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public IEnumerable<Productos> Productos { get; set; }
    }
}
