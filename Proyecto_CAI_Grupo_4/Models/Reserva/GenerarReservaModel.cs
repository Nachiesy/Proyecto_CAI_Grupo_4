using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modelos;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class GenerarReservaModel
    {
        public IEnumerable<PresupuestoEnt> GetPreReservasAbonadas()
        {
            return PresupuestosModule
                .GetPresupuestosPrereservadosAbonados()
                .AsQueryable();
        }

        public int GetTotalDePasajeros(int idItinerario)
        {
            return PasajerosModule.GetTotalPasajerosByIdPresupuesto(idItinerario);
        }

        public PresupuestoEnt? GetPresupuestoById(int idItinerario)
        {
            return PresupuestosModule.GetPresupuestoById(idItinerario);
        }

        public PresupuestoEnt GetPreReservaAbonadaById(int id)
        {
            return ReservaModule.GetPreReservasAbonadasById(id);
        }

        public ReservaEnt GenerarReserva(PresupuestoEnt preReserva)
        {
            PresupuestosModule.ActualizarEstadoAReservado(preReserva.IdPresupuesto);

            return ReservaModule.GenerarNuevaReserva(preReserva.IdPresupuesto, preReserva.Cliente);
        }

        public IEnumerable<PresupuestoEnt> GetPreReservasAbonadasByDNI(string dni)
        {
            return GetPreReservasAbonadas().Where(x => x.Cliente.DNI == dni);
        }

        public IEnumerable<PresupuestoEnt> GetPreReservasAbonadasById(string codigo)
        {
            return GetPreReservasAbonadas().Where(x => x.IdPresupuesto == int.Parse(codigo));
        }

        public string? ValidarFiltros(string codigo, string dni)
        {
            if (!string.IsNullOrEmpty(codigo) && !int.TryParse(codigo, out int presupuestoId))
            {
                return "Debes ingresar un Id de Pre-reserva correcto. El mismo tiene que ser un número entero. Recordar que el id de Pre-reserva es el mismo id del presupuesto.";
            }

            if (!string.IsNullOrEmpty(dni) && !dni.EsDNI())
            {
                return "Debes ingresar un DNI correcto. El mismo debe ser numérico y tener entre 7 y 8 cifras.";
            }

            return null;
        }

        public IEnumerable<PresupuestoEnt> GetPreReservasAbonadasFiltradas(string inputCodigo, string dni)
        {
            var prereservas = GetPreReservasAbonadas();

            if (!string.IsNullOrEmpty(inputCodigo))
            {
                var codigo = int.Parse(inputCodigo);

                prereservas = prereservas.Where(x => x.IdPresupuesto == codigo);
            }

            if (!string.IsNullOrEmpty(dni))
            {
                prereservas = prereservas.Where(x => x.Cliente.DNI == dni);
            }

            return prereservas;
        }
    }
}
