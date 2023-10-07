using Proyecto_CAI_Grupo_4.Managers;
using Proyecto_CAI_Grupo_4.Models.Productos;
using Proyecto_CAI_Grupo_4.Utils;

namespace Proyecto_CAI_Grupo_4
{
    public partial class GenerarPresupuestoMenu : Form
    {
        public GenerarPresupuestoMenu()
        {
            InitializeComponent();
        }

        private void GenerarPresupuestoMenu_Load(object sender, EventArgs e)
        {
            AddProductosToListView(GenerarPresupuestosManager.productosAereosElegidos, productosElegidos);

            AddProductosToListView(GenerarPresupuestosManager.productosHotelesElegidos, productosElegidos);
        }

        private void AddProductosToListView(IEnumerable<Productos> listToAdd, ListView listView)
        {
            foreach (var item in listToAdd)
            {
                var row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Nombre);
                row.SubItems.Add(item.Precio.ToString());
                row.SubItems.Add(item.TipoDeServicio.GetDescription());

                listView.Items.Add(row);
            }
        }

        private void btnMenuAereos_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(OpenGenerarPresupuestoAereos);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenGenerarPresupuestoAereos()
        {
            Application.Run(new GenerarPresupuestoAereos());
        }

        private void btnMenuHoteles_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(OpenGenerarPresupuestoHoteles);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenGenerarPresupuestoHoteles()
        {
            Application.Run(new GenerarPresupuestoHoteles());
        }

        private void btnMenuCruceros_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(OpenGenerarPresupuestoCruceros);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenGenerarPresupuestoCruceros()
        {
            Application.Run(new GenerarPresupuestoCruceros());
        }

        private void btnFinalizarPresupuesto_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread thread = new Thread(OpenMenuPrincipal);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenMenuPrincipal()
        {
            Application.Run(new MenuPrincipal());
        }
    }
}
