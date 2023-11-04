using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Enums;
using Proyecto_CAI_Grupo_4.Modelos;
using Proyecto_CAI_Grupo_4.Models;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.GenerarPresupuesto;

public partial class BuscarPresupuesto : VistaBase
{
    private int PresupuestoId;

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

        var prereserva = PrereservaModel.GetPrereservaByItinerario(presupuesto.IdItinerario);

        if (prereserva.Count > 0)
        {
            MessageBox.Show("El número de presupuesto ingresado ya fue abonado en la pre-reserva " + prereserva.First().IdItinerario + " y no se puede editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        PresupuestoId = nroPresupuesto;

        GoToGenerarPresupuestoMenu();
    }

    private void GoToGenerarPresupuestoMenu()
    {
        Close();

        Thread thread = new Thread(OpenGenerarPresupuestoMenu);
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
    }

    private void OpenGenerarPresupuestoMenu()
    {
        Application.Run(new GenerarPresupuestoMenu(new GenerarPresupuestoMenuParams()
        {
            PresupuestoId = PresupuestoId,
            EsNuevo = false,
            InitBuscarPresupuesto = true,
        }));
    }

    private void btn_Volver_Click(object sender, EventArgs e)
    {
        GoToMenuPrincipal();
    }

    private void GoToMenuPrincipal()
    {
        Close();

        Thread thread = new Thread(OpenMenuPrincipal);
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
    }

    private void OpenMenuPrincipal()
    {
        Application.Run(new MenuPrincipal());
    }
}