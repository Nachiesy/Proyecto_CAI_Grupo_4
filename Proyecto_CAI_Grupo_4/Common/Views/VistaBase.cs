using Proyecto_CAI_Grupo_4.Models;
using Proyecto_CAI_Grupo_4.Modules;
using System.Runtime.InteropServices;

namespace Proyecto_CAI_Grupo_4.Common.Views;

public partial class VistaBase : Form
{
    VistaBaseModel Model = new VistaBaseModel();

    public VistaBase()
    {
        InitializeComponent();
    }

    public VistaBase(string tituloModulo, bool deshabilitarBotones = false)
    {
        InitializeComponent();

        lbl_TituloModulo.Text = tituloModulo;

        if (tituloModulo == "Menu Principal")
        {
            btn_VolverAlMenu.Visible = false;
        }

        if (deshabilitarBotones)
        {
            btn_VolverAlMenu.Visible = false;
            btn_Salir.Visible = false;
        }
    }

    [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
    private static extern void ReleaseCapture();

    [DllImport("user32.dll", EntryPoint = "SendMessage")]
    private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    private void pnl_BarraFijaSuperior_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    private void btn_Salir_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    public void btn_Volver_Menu(object sender, EventArgs e)
    {
        Close();

        GoToMenuPrincipal();
    }

    private void VistaBase_Load(object sender, EventArgs e)
    {

    }

    protected void GoToMenuPrincipal()
    {
        AereosModule.ClearAereosElegidos();
        HotelesModule.ClearHotelesElegidos();

        var thread = new Thread(OpenMenuPrincipal);
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
    }

    private void OpenMenuPrincipal()
    {
        Application.Run(new MenuPrincipal());
    }
}