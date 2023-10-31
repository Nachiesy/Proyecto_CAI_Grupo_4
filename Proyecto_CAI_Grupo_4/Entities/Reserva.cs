﻿using Proyecto_CAI_Grupo_4.Enums;

namespace Proyecto_CAI_Grupo_4.Entities
{
    public class Reserva
    {
        public int Codigo { get; set; }
        public int IdItinerario { get; set; }
        public Cliente Cliente { get; set; }
        public ReservaEstadoEnum Estado { get; set; }
        public DateTime FechaReserva { get; set; }

        public Reserva(int codigo, int idItinerario, ReservaEstadoEnum estado, Cliente cliente)
        {
            Codigo = codigo;
            IdItinerario = idItinerario;
            Cliente = cliente;
            Estado = estado;
            FechaReserva = DateTime.Now;
        }

        public Reserva() { }
    }
}
