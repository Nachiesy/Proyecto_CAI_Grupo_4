﻿using Proyecto_CAI_Grupo_4.Common.Views;
using Proyecto_CAI_Grupo_4.Models;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4.GenerarPresupuesto;

public partial class BuscarPresupuesto : VistaBase
{
    private BuscarPresupuestoModel Model;

    public BuscarPresupuesto()
    {
        InitializeComponent();
    }

    private void BuscarPresupuesto_Load(object sender, EventArgs e)
    {
        Model = new BuscarPresupuestoModel();
    }

    private void btn_BuscarPresupuesto_Click(object sender, EventArgs e)
    {
        var validacion = Model.ValidarBuscarPresupuesto(txt_NumeroPresupuesto.Text.Trim());

        if (!string.IsNullOrEmpty(validacion))
        {
            MessageBox.Show(validacion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return;
        }

        Close();

        Model.SetGenerarPresupuestoParams(new GenerarPresupuestoParams()
        {
            PresupuestoId = Model.PresupuestoId,
            EsNuevo = false,
            InitBuscarPresupuesto = true,
        });

        var thread = new Thread(OpenGenerarPresupuestoMenu);
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
    }

    private void OpenGenerarPresupuestoMenu()
    {
        Application.Run(new GenerarPresupuestoMenu());
    }

    private void btn_Volver_Click(object sender, EventArgs e)
    {
        Close();

        var thread = new Thread(OpenMenuPrincipal);
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
    }
}
