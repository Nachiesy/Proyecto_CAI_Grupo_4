using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modelos;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class GenerarReservaModel
    {
        public IEnumerable<Itinerario> GetPreReservasAbonadas()
        {
            return PresupuestosModule
                .GetPresupuestosPrereservadosAbonados()
                .AsQueryable();
        }

        public int GetTotalDePasajeros(int idItinerario)
        {
            return PasajerosModule.GetTotalPasajerosByIdPresupuesto(idItinerario);
        }

        public Itinerario? GetPresupuestoById(int idItinerario)
        {
            return PresupuestosModule.GetPresupuestoById(idItinerario);
        }

        public Itinerario GetPreReservaAbonadaById(int id)
        {
            return ReservaModule.GetPreReservasAbonadasById(id);
        }

        public Reserva GenerarReserva(Itinerario preReserva)
        {
            PresupuestosModule.ActualizarEstadoAReservado(preReserva.IdItinerario);

            return ReservaModule.GenerarNuevaReserva(preReserva.IdItinerario, preReserva.Cliente);
        }

        public IEnumerable<Itinerario> GetPreReservasAbonadasByDNI(string dni)
        {
            return GetPreReservasAbonadas().Where(x => x.Cliente.DNI == dni);
        }

        public IEnumerable<Itinerario> GetPreReservasAbonadasById(string codigo)
        {
            return GetPreReservasAbonadas().Where(x => x.IdItinerario == int.Parse(codigo));
        }

        public string? ValidarFiltros(string codigo, string dni)
        {
            if (!string.IsNullOrEmpty(codigo) && !int.TryParse(codigo, out int presupuestoId))
            {
                return "El codigo de presupuesto debe ser numérico.";
            }

            if (!string.IsNullOrEmpty(dni) && !dni.EsDNI())
            {
                return "Ingrese un DNI valido por favor.";
            }

            return null;
        }

        public IEnumerable<Itinerario> GetPreReservasAbonadasFiltradas(string inputCodigo, string dni)
        {
            var prereservas = GetPreReservasAbonadas();

            if (!string.IsNullOrEmpty(inputCodigo))
            {
                var codigo = int.Parse(inputCodigo);

                prereservas = prereservas.Where(x => x.IdItinerario == codigo);
            }

            if (!string.IsNullOrEmpty(dni))
            {
                prereservas = prereservas.Where(x => x.Cliente.DNI == dni);
            }

            return prereservas;
        }
    }
}
