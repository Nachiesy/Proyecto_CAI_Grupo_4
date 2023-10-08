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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarPresupuestoMenu));
            label1 = new Label();
            presupuestoTotal = new Label();
            productosElegidos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            TipoDeServicio = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnMenuAereos = new Common.Components.BotonEstilizado();
            btnMenuPaquetes = new Common.Components.BotonEstilizado();
            btnMenuHoteles = new Common.Components.BotonEstilizado();
            btnMenuCruceros = new Common.Components.BotonEstilizado();
            btnFinalizarPresupuesto = new Common.Components.BotonEstilizado();
            grp_Estimacion = new GroupBox();
            grp_Filtros = new GroupBox();
            textBoxClienteDNI = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)productosElegidos).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grp_Estimacion.SuspendLayout();
            grp_Filtros.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 233);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 6;
            // 
            // presupuestoTotal
            // 
            presupuestoTotal.AutoSize = true;
            presupuestoTotal.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            presupuestoTotal.Location = new Point(15, 30);
            presupuestoTotal.Name = "presupuestoTotal";
            presupuestoTotal.Size = new Size(108, 31);
            presupuestoTotal.TabIndex = 34;
            presupuestoTotal.Text = "Total: $-";
            // 
            // productosElegidos
            // 
            productosElegidos.AllowUserToAddRows = false;
            productosElegidos.AllowUserToDeleteRows = false;
            productosElegidos.AllowUserToOrderColumns = true;
            productosElegidos.BackgroundColor = SystemColors.ControlLight;
            productosElegidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productosElegidos.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, TipoDeServicio, PrecioUnitario, Cantidad, SubTotal });
            productosElegidos.Location = new Point(303, 126);
            productosElegidos.Name = "productosElegidos";
            productosElegidos.RowHeadersWidth = 82;
            productosElegidos.RowTemplate.Height = 25;
            productosElegidos.Size = new Size(893, 443);
            productosElegidos.TabIndex = 36;
            productosElegidos.CellValueChanged += productosElegidos_CellValueChanged;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 250;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 10;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 200;
            // 
            // TipoDeServicio
            // 
            TipoDeServicio.HeaderText = "Tipo de Servicio";
            TipoDeServicio.MinimumWidth = 10;
            TipoDeServicio.Name = "TipoDeServicio";
            TipoDeServicio.ReadOnly = true;
            TipoDeServicio.Width = 200;
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.HeaderText = "Precio Unitario";
            PrecioUnitario.MinimumWidth = 10;
            PrecioUnitario.Name = "PrecioUnitario";
            PrecioUnitario.ReadOnly = true;
            PrecioUnitario.Width = 200;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 10;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 200;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.MinimumWidth = 10;
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.Width = 200;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnMenuAereos);
            groupBox1.Controls.Add(btnMenuPaquetes);
            groupBox1.Controls.Add(btnMenuHoteles);
            groupBox1.Controls.Add(btnMenuCruceros);
            groupBox1.Location = new Point(12, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 237);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar productos";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(15, 184);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 48);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(14, 131);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 48);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 76);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnMenuAereos
            // 
            btnMenuAereos.BackColor = Color.Transparent;
            btnMenuAereos.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnMenuAereos.FlatStyle = FlatStyle.Flat;
            btnMenuAereos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuAereos.ForeColor = Color.Black;
            btnMenuAereos.Location = new Point(68, 23);
            btnMenuAereos.Name = "btnMenuAereos";
            btnMenuAereos.Size = new Size(172, 40);
            btnMenuAereos.TabIndex = 4;
            btnMenuAereos.Text = "Aéreos";
            btnMenuAereos.UseVisualStyleBackColor = false;
            btnMenuAereos.Click += btnMenuAereos_Click;
            // 
            // btnMenuPaquetes
            // 
            btnMenuPaquetes.BackColor = Color.Transparent;
            btnMenuPaquetes.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnMenuPaquetes.FlatStyle = FlatStyle.Flat;
            btnMenuPaquetes.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuPaquetes.ForeColor = Color.Black;
            btnMenuPaquetes.Location = new Point(68, 187);
            btnMenuPaquetes.Name = "btnMenuPaquetes";
            btnMenuPaquetes.Size = new Size(172, 40);
            btnMenuPaquetes.TabIndex = 4;
            btnMenuPaquetes.Text = "Paquetes";
            btnMenuPaquetes.UseVisualStyleBackColor = false;
            btnMenuPaquetes.Click += btnMenuPaquetes_Click;
            // 
            // btnMenuHoteles
            // 
            btnMenuHoteles.BackColor = Color.Transparent;
            btnMenuHoteles.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnMenuHoteles.FlatStyle = FlatStyle.Flat;
            btnMenuHoteles.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuHoteles.ForeColor = Color.Black;
            btnMenuHoteles.Location = new Point(68, 79);
            btnMenuHoteles.Name = "btnMenuHoteles";
            btnMenuHoteles.Size = new Size(172, 40);
            btnMenuHoteles.TabIndex = 4;
            btnMenuHoteles.Text = "Hoteles";
            btnMenuHoteles.UseVisualStyleBackColor = false;
            btnMenuHoteles.Click += btnMenuHoteles_Click;
            // 
            // btnMenuCruceros
            // 
            btnMenuCruceros.BackColor = Color.Transparent;
            btnMenuCruceros.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnMenuCruceros.FlatStyle = FlatStyle.Flat;
            btnMenuCruceros.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuCruceros.ForeColor = Color.Black;
            btnMenuCruceros.Location = new Point(68, 133);
            btnMenuCruceros.Name = "btnMenuCruceros";
            btnMenuCruceros.Size = new Size(172, 40);
            btnMenuCruceros.TabIndex = 4;
            btnMenuCruceros.Text = "Cruceros";
            btnMenuCruceros.UseVisualStyleBackColor = false;
            btnMenuCruceros.Click += btnMenuCruceros_Click;
            // 
            // btnFinalizarPresupuesto
            // 
            btnFinalizarPresupuesto.BackColor = Color.Transparent;
            btnFinalizarPresupuesto.Enabled = false;
            btnFinalizarPresupuesto.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnFinalizarPresupuesto.FlatStyle = FlatStyle.Flat;
            btnFinalizarPresupuesto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinalizarPresupuesto.ForeColor = Color.Black;
            btnFinalizarPresupuesto.Location = new Point(12, 529);
            btnFinalizarPresupuesto.Name = "btnFinalizarPresupuesto";
            btnFinalizarPresupuesto.Size = new Size(246, 40);
            btnFinalizarPresupuesto.TabIndex = 4;
            btnFinalizarPresupuesto.Text = "Guardar";
            btnFinalizarPresupuesto.UseVisualStyleBackColor = false;
            btnFinalizarPresupuesto.Click += btnFinalizarPresupuesto_Click;
            // 
            // grp_Estimacion
            // 
            grp_Estimacion.Controls.Add(presupuestoTotal);
            grp_Estimacion.Location = new Point(12, 448);
            grp_Estimacion.Name = "grp_Estimacion";
            grp_Estimacion.Size = new Size(246, 75);
            grp_Estimacion.TabIndex = 38;
            grp_Estimacion.TabStop = false;
            grp_Estimacion.Text = "Estimacion";
            // 
            // grp_Filtros
            // 
            grp_Filtros.Controls.Add(textBoxClienteDNI);
            grp_Filtros.Controls.Add(label2);
            grp_Filtros.Location = new Point(12, 349);
            grp_Filtros.Name = "grp_Filtros";
            grp_Filtros.Size = new Size(246, 87);
            grp_Filtros.TabIndex = 39;
            grp_Filtros.TabStop = false;
            grp_Filtros.Text = "Agregar Cliente";
            // 
            // textBoxClienteDNI
            // 
            textBoxClienteDNI.Location = new Point(14, 50);
            textBoxClienteDNI.Name = "textBoxClienteDNI";
            textBoxClienteDNI.Size = new Size(226, 23);
            textBoxClienteDNI.TabIndex = 2;
            textBoxClienteDNI.TextChanged += textBoxClienteDNI_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 28);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 3;
            label2.Text = "DNI";
            // 
            // GenerarPresupuestoMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1210, 611);
            Controls.Add(grp_Filtros);
            Controls.Add(grp_Estimacion);
            Controls.Add(btnFinalizarPresupuesto);
            Controls.Add(groupBox1);
            Controls.Add(productosElegidos);
            Controls.Add(label1);
            Margin = new Padding(6);
            Name = "GenerarPresupuestoMenu";
            Text = "Generar Presupuesto";
            Load += GenerarPresupuestoMenu_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(productosElegidos, 0);
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(btnFinalizarPresupuesto, 0);
            Controls.SetChildIndex(grp_Estimacion, 0);
            Controls.SetChildIndex(grp_Filtros, 0);
            ((System.ComponentModel.ISupportInitialize)productosElegidos).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grp_Estimacion.ResumeLayout(false);
            grp_Estimacion.PerformLayout();
            grp_Filtros.ResumeLayout(false);
            grp_Filtros.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label presupuestoTotal;
        private DataGridView productosElegidos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn TipoDeServicio;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private GroupBox groupBox1;
        private Common.Components.BotonEstilizado btnMenuAereos;
        private Common.Components.BotonEstilizado btnMenuHoteles;
        private Common.Components.BotonEstilizado btnMenuCruceros;
        private Common.Components.BotonEstilizado btnMenuPaquetes;
        private Common.Components.BotonEstilizado btnFinalizarPresupuesto;
        private GroupBox grp_Estimacion;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private GroupBox grp_Filtros;
        private TextBox textBoxClienteDNI;
        private Label label2;
    }
}