using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Models;

namespace Proyecto_CAI_Grupo_4.GenerarPresupuesto;

public partial class BuscarPresupuesto : VistaBase
{
    private int idPresupuesto;
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

        var presupuesto = PresupuestosModel.ObtenerPresupuesto(nroPresupuesto);

        if (presupuesto is null)
        {
            MessageBox.Show("El número de presupuesto ingresado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        idPresupuesto = nroPresupuesto;

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
        Application.Run(new GenerarPresupuestoMenu(idPresupuesto));
    }

    private void btn_Volver_Click(object sender, EventArgs e) => btn_Volver_Menu(sender, e);
}