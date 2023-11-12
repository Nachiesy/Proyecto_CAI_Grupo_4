using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modelos;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class ConsultarReservasModel
    {
        public IEnumerable<Reserva> GetReservas()
        {
            return ReservaModule.GetReservas();
        }

        public Itinerario GetPresupuestoById(int id)
        {
            return PresupuestosModule.GetPresupuestoById(id);
        }

        public List<string> GetListadoEstadosReservas()
        {
            var estados = new List<string>()
            {
                "Todas"
            };

            estados.AddRange(
                Enum.GetValues(typeof(ReservaEstadoEnum))
                .Cast<ReservaEstadoEnum>()
                .Select(v => v.GetDescription())
                .Skip(1));

            return estados;
        }

        public string? ValidarCamposBusqueda(string codigo, string dni)
        {
            if (!string.IsNullOrEmpty(dni) && !dni.EsDNI())
            {
                return "Ingrese un DNI valido por favor.";
            }

            if (!string.IsNullOrEmpty(codigo) && !int.TryParse(codigo, out _))
            {
                return "Ingrese un codigo valido por favor.";
            }

            return null;
        }

        public IEnumerable<Reserva> GetReservasFiltradas(string inputCodigo, string inputDni, string estado)
        {
            var reservas = GetReservas();

            if (!string.IsNullOrEmpty(inputCodigo))
            {
                var codigo = int.Parse(inputCodigo);

                reservas = reservas.Where(x => x.IdItinerario == codigo);
            }

            if (!string.IsNullOrEmpty(inputDni))
            {
                var dni = int.Parse(inputDni);

                reservas = reservas.Where(x => x.Cliente.DNI == dni.ToString());
            }

            if(!string.IsNullOrEmpty(estado) && estado != "Todas")
            {
                Enum.TryParse<ReservaEstadoEnum>(estado, out var estadoEnum);

                reservas = reservas.Where(x => x.Estado == estadoEnum);
            }

            return reservas;
        }
    }
}
