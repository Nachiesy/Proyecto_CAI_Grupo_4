namespace Proyecto_CAI_Grupo_4
{
    partial class GenerarPresupuestoMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnMenuHoteles = new Button();
            btnMenuCruceros = new Button();
            btnMenuAereos = new Button();
            label2 = new Label();
            btnFinalizarPresupuesto = new Button();
            btnVolverMenuPrincipal = new Button();
            presupuestoTotal = new TextBox();
            label3 = new Label();
            btnMenuPaquetes = new Button();
            productosElegidos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            TipoDeServicio = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)productosElegidos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(553, 23);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 6;
            // 
            // btnMenuHoteles
            // 
            btnMenuHoteles.Location = new Point(502, 115);
            btnMenuHoteles.Name = "btnMenuHoteles";
            btnMenuHoteles.Size = new Size(206, 23);
            btnMenuHoteles.TabIndex = 11;
            btnMenuHoteles.Text = "Hoteles";
            btnMenuHoteles.UseVisualStyleBackColor = true;
            btnMenuHoteles.Click += btnMenuHoteles_Click;
            // 
            // btnMenuCruceros
            // 
            btnMenuCruceros.Location = new Point(502, 160);
            btnMenuCruceros.Name = "btnMenuCruceros";
            btnMenuCruceros.Size = new Size(206, 23);
            btnMenuCruceros.TabIndex = 8;
            btnMenuCruceros.Text = "Cruceros";
            btnMenuCruceros.UseVisualStyleBackColor = true;
            btnMenuCruceros.Click += btnMenuCruceros_Click;
            // 
            // btnMenuAereos
            // 
            btnMenuAereos.Location = new Point(502, 72);
            btnMenuAereos.Name = "btnMenuAereos";
            btnMenuAereos.Size = new Size(206, 23);
            btnMenuAereos.TabIndex = 7;
            btnMenuAereos.Text = "Aéreos";
            btnMenuAereos.UseVisualStyleBackColor = true;
            btnMenuAereos.Click += btnMenuAereos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(502, 23);
            label2.Name = "label2";
            label2.Size = new Size(206, 30);
            label2.TabIndex = 12;
            label2.Text = "Generar Presupuesto";
            // 
            // btnFinalizarPresupuesto
            // 
            btnFinalizarPresupuesto.Location = new Point(502, 568);
            btnFinalizarPresupuesto.Name = "btnFinalizarPresupuesto";
            btnFinalizarPresupuesto.Size = new Size(206, 23);
            btnFinalizarPresupuesto.TabIndex = 14;
            btnFinalizarPresupuesto.Text = "Finalizar Presupuesto";
            btnFinalizarPresupuesto.UseVisualStyleBackColor = true;
            btnFinalizarPresupuesto.Click += btnFinalizarPresupuesto_Click;
            // 
            // btnVolverMenuPrincipal
            // 
            btnVolverMenuPrincipal.Location = new Point(502, 609);
            btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            btnVolverMenuPrincipal.Size = new Size(206, 23);
            btnVolverMenuPrincipal.TabIndex = 15;
            btnVolverMenuPrincipal.Text = "Volver al Menu Principal";
            btnVolverMenuPrincipal.UseVisualStyleBackColor = true;
            btnVolverMenuPrincipal.Click += btnVolverMenuPrincipal_Click;
            // 
            // presupuestoTotal
            // 
            presupuestoTotal.Enabled = false;
            presupuestoTotal.Location = new Point(184, 527);
            presupuestoTotal.Name = "presupuestoTotal";
            presupuestoTotal.Size = new Size(101, 23);
            presupuestoTotal.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 508);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 34;
            label3.Text = "Total";
            // 
            // btnMenuPaquetes
            // 
            btnMenuPaquetes.Location = new Point(502, 204);
            btnMenuPaquetes.Name = "btnMenuPaquetes";
            btnMenuPaquetes.Size = new Size(206, 23);
            btnMenuPaquetes.TabIndex = 35;
            btnMenuPaquetes.Text = "Paquetes";
            btnMenuPaquetes.UseVisualStyleBackColor = true;
            btnMenuPaquetes.Click += btnMenuPaquetes_Click;
            // 
            // productosElegidos
            // 
            productosElegidos.AllowUserToAddRows = false;
            productosElegidos.AllowUserToDeleteRows = false;
            productosElegidos.AllowUserToOrderColumns = true;
            productosElegidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productosElegidos.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, TipoDeServicio, PrecioUnitario, Cantidad, SubTotal });
            productosElegidos.Location = new Point(184, 251);
            productosElegidos.Name = "productosElegidos";
            productosElegidos.RowTemplate.Height = 25;
            productosElegidos.Size = new Size(893, 245);
            productosElegidos.TabIndex = 36;
            productosElegidos.CellValueChanged += productosElegidos_CellValueChanged;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 250;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 200;
            // 
            // TipoDeServicio
            // 
            TipoDeServicio.HeaderText = "Tipo de Servicio";
            TipoDeServicio.Name = "TipoDeServicio";
            TipoDeServicio.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.HeaderText = "Precio Unitario";
            PrecioUnitario.Name = "PrecioUnitario";
            PrecioUnitario.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            // 
            // GenerarPresupuestoMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 644);
            Controls.Add(productosElegidos);
            Controls.Add(btnMenuPaquetes);
            Controls.Add(label3);
            Controls.Add(presupuestoTotal);
            Controls.Add(btnVolverMenuPrincipal);
            Controls.Add(btnFinalizarPresupuesto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMenuHoteles);
            Controls.Add(btnMenuCruceros);
            Controls.Add(btnMenuAereos);
            Name = "GenerarPresupuestoMenu";
            Text = "Generar Presupuesto";
            Load += GenerarPresupuestoMenu_Load;
            ((System.ComponentModel.ISupportInitialize)productosElegidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnMenuHoteles;
        private Button btnMenuCruceros;
        private Button btnMenuAereos;
        private Label label2;
        private Button btnFinalizarPresupuesto;
        private Button btnVolverMenuPrincipal;
        private TextBox presupuestoTotal;
        private Label label3;
        private Button btnMenuPaquetes;
        private DataGridView productosElegidos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn TipoDeServicio;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
    }
}