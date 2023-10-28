using System.ComponentModel;

namespace Proyecto_CAI_Grupo_4.Entities.Productos
{
    public class PaquetesTuristicos : Productos
    {
        public PaquetesTuristicos()
        {
            Actividades = new List<PaquetesTuristicosActividades>();
        }

        public PaquetesTuristicosOrigenEnum Origen { get; set; }

        public PaquetesTuristicosDestinoEnum Destino { get; set; }

        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }

        public IEnumerable<PaquetesTuristicosActividades> Actividades { get; set; }

        public int CapacidadMaximaAdultos { get; set; }

        public int CapacidadMaximaMenores { get; set; }

        public string GetActividades()
        {
            var actividades = string.Empty;

            var delimitter = ";";

            foreach (var actividad in Actividades)
            {
                if (actividades == string.Empty)
                {
                    actividades += $"{actividad.Nombre}";
                }
                else
                {
                    actividades += $"{delimitter}{actividad.Nombre}";
                }
            }

            actividades = actividades.Replace(delimitter, ", ");

            return actividades;
        }
    }

    public enum PaquetesTuristicosOrigenEnum
    {
        [Description("Buenos Aires")]
        buenosAires,

        [Description("Sao Pablo")]
        saoPablo,

        [Description("Filadelfia")]
        filadelfia,

        [Description("Sidney")]
        sidney,
    }

    public enum PaquetesTuristicosDestinoEnum
    {
        [Description("Mar del Plata")]
        marDelPlata,

        [Description("Pretoria")]
        pretoria,

        [Description("Napoles")]
        napoles,

        [Description("Tokio")]
        tokio,
    }

    public class PaquetesTuristicosActividades
    {
        public string Nombre { get; set; }
    }
}
