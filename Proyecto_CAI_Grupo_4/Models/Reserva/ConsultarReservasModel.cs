using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modelos;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class ConsultarReservasModel
    {
        public IEnumerable<ReservaEnt> GetReservas()
        {
            return ReservaModule.GetReservas();
        }

        public PresupuestoEnt GetPresupuestoById(int id)
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
                return "Debes ingresar un DNI correcto. El mismo debe ser numérico y tener entre 7 y 8 cifras.";
            }

            if (!string.IsNullOrEmpty(codigo) && !int.TryParse(codigo, out _))
            {
                return "Debes ingresar un código de reserva correcto. El mismo tiene que ser un número entero.";
            }

            return null;
        }

        public IEnumerable<ReservaEnt> GetReservasFiltradas(string inputCodigo, string inputDni, string estado)
        {
            var reservas = GetReservas();

            if (!string.IsNullOrEmpty(inputCodigo))
            {
                var codigo = int.Parse(inputCodigo);

                reservas = reservas.Where(x => x.Codigo == codigo);
            }

            if (!string.IsNullOrEmpty(inputDni))
            {
                reservas = reservas.Where(x => x.Cliente.DNI == inputDni);
            }

            if(!string.IsNullOrEmpty(estado) && estado != "Todas")
            {
                if(estado == "Reserva pendiente de confirmación")
                {
                    reservas = reservas.Where(x => x.Estado == ReservaEstadoEnum.PendienteDeConfirmacion);
                }
                else if(estado == "Reserva confirmada")
                {
                    reservas = reservas.Where(x => x.Estado == ReservaEstadoEnum.Confirmada);
                }
            }

            return reservas;
        }
    }
}
