using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modelos;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class ConfirmarReservaModel
    {
        public IEnumerable<Reserva> GetReservasPendientesDeConfirmacion()
        {
            return ReservaModule
                .GetReservasPendientesDeConfirmacion()
                .AsQueryable();
        }

        public Itinerario GetPresupuestoById(int id) 
        {
            return PresupuestosModule.GetPresupuestoById(id);
        }

        public void ConfirmarReserva(int id)
        {
            ReservaModule.ConfirmarReserva(id);
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

        public IEnumerable<Reserva> GetReservasPendientesDeConfirmacionFiltradas(string codigo, string dni)
        {
            var reservas = GetReservasPendientesDeConfirmacion();

            if (!string.IsNullOrEmpty(codigo))
            {
                var codigoInt = int.Parse(codigo);

                reservas = reservas.Where(x => x.Codigo == codigoInt);
            }

            if (!string.IsNullOrEmpty(dni))
            {
                reservas = reservas.Where(x => x.Cliente.DNI == dni);
            }

            return reservas;
        }
    }
}
