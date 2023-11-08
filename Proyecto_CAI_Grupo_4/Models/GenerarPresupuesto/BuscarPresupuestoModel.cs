﻿using Proyecto_CAI_Grupo_4.GenerarPresupuesto;
using Proyecto_CAI_Grupo_4.Modelos;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class BuscarPresupuestoModel
    {
        public int PresupuestoId;

        public string ValidarBuscarPresupuesto(string numeroDePresupuesto)
        {
            var nroPresupuestoValido = int.TryParse(numeroDePresupuesto, out int nroPresupuesto);

            if (!nroPresupuestoValido)
            {
                return "El número de presupuesto ingresado no es válido";
            }

            var presupuesto = PresupuestosModule.GetPresupuestoById(nroPresupuesto);

            if (presupuesto is null)
            {
                return "El número de presupuesto ingresado no existe";
            }

            var esModificable = PresupuestosModule.EsPresupuestoModificable(presupuesto.IdItinerario);

            if (!esModificable)
            {
                return $"El número de presupuesto #{presupuesto.IdItinerario} coincide con un presupuesto que" +
                       $" no puede ser modificado ya que esta en estado {presupuesto.Estado}";
            }

            PresupuestoId = nroPresupuesto;

            return string.Empty;
        }

        public void GoToGenerarPresupuestoMenu()
        {
            GenerarPresupuestoMenuModel.PresupuestoId = PresupuestoId;
            GenerarPresupuestoMenuModel.EsNuevo = false;
            GenerarPresupuestoMenuModel.InitBuscarPresupuesto = true;

            Thread thread = new Thread(GenerarPresupuestoMenuModel.OpenGenerarPresupuestoMenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
