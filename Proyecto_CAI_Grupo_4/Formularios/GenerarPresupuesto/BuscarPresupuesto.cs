using Proyecto_CAI_Grupo_4.Common.Views;
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
        var validacion = Model.ValidarBuscarPresupuesto(txt_NumeroPresupuesto.Text.Trim());

        if (!validacion)
        {
            return;
        }

        Close();

        Model.GoToGenerarPresupuestoMenu();
    }

    private void btn_Volver_Click(object sender, EventArgs e)
    {
        Close();

        Model.GoToMenuPrincipal();
    }
}
