﻿using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modelos;

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
    }
}
