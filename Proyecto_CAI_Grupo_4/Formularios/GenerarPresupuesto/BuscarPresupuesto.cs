using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Modelos;
using Proyecto_CAI_Grupo_4.Models;

namespace Proyecto_CAI_Grupo_4.GenerarPresupuesto;

public partial class BuscarPresupuesto : VistaBase
{
    private BuscarPresupuestoModel Model = new BuscarPresupuestoModel();

    public BuscarPresupuesto()
    {
        InitializeComponent();
    }

    private void BuscarPresupuesto_Load(object sender, EventArgs e)
    {

    }

    private void btn_BuscarPresupuesto_Click(object sender, EventArgs e)
    {
        var nroPresupuestoValido = int.TryParse(txt_NumeroPresupuesto.Text.Trim(), out int nroPresupuesto);

        if (!nroPresupuestoValido)
        {
            MessageBox.Show("El número de presupuesto ingresado no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return;
        }

        var presupuesto = PresupuestosModel.GetPresupuestoById(nroPresupuesto);

        if (presupuesto is null)
        {
            MessageBox.Show("El número de presupuesto ingresado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return;
        }

        var preReserva = PrereservaModel.GetPrereservaByItinerario(presupuesto.IdItinerario);

        if (preReserva.Count > 0)
        {
            MessageBox.Show("El número de presupuesto ingresado ya fue abonado en la pre-reserva " + preReserva.First().IdItinerario + " y no se puede editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            return;
        }

        Model.PresupuestoId = nroPresupuesto;

        Close();

        Model.GoToGenerarPresupuestoMenu();
    }

    private void btn_Volver_Click(object sender, EventArgs e)
    {
        Close();

        Model.GoToMenuPrincipal();
    }
}
