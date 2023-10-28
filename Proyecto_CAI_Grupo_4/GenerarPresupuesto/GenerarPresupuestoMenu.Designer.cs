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
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnMenuAereos = new Common.Components.BotonEstilizado();
            btnMenuHoteles = new Common.Components.BotonEstilizado();
            btnFinalizarPresupuesto = new Common.Components.BotonEstilizado();
            grp_Estimacion = new GroupBox();
            productosElegidos = new ListView();
            ID = new ColumnHeader();
            Codigo = new ColumnHeader();
            Nombre = new ColumnHeader();
            TipoServicio = new ColumnHeader();
            Precios = new ColumnHeader();
            label2 = new Label();
            textBoxClienteDNI = new TextBox();
            grp_Filtros = new GroupBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            botonEstilizado1 = new Common.Components.BotonEstilizado();
            groupBox2 = new GroupBox();
            botonEstilizado4 = new Common.Components.BotonEstilizado();
            botonEstilizado2 = new Common.Components.BotonEstilizado();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grp_Estimacion.SuspendLayout();
            grp_Filtros.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
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
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnMenuAereos);
            groupBox1.Controls.Add(btnMenuHoteles);
            groupBox1.Location = new Point(12, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 142);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Productos";
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
            // btnFinalizarPresupuesto
            // 
            btnFinalizarPresupuesto.BackColor = Color.Transparent;
            btnFinalizarPresupuesto.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnFinalizarPresupuesto.FlatStyle = FlatStyle.Flat;
            btnFinalizarPresupuesto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinalizarPresupuesto.ForeColor = Color.Black;
            btnFinalizarPresupuesto.Location = new Point(6, 22);
            btnFinalizarPresupuesto.Name = "btnFinalizarPresupuesto";
            btnFinalizarPresupuesto.Size = new Size(230, 61);
            btnFinalizarPresupuesto.TabIndex = 4;
            btnFinalizarPresupuesto.Text = "Guardar Presupuesto";
            btnFinalizarPresupuesto.UseVisualStyleBackColor = false;
            btnFinalizarPresupuesto.Click += btnFinalizarPresupuesto_Click;
            // 
            // grp_Estimacion
            // 
            grp_Estimacion.Controls.Add(presupuestoTotal);
            grp_Estimacion.Location = new Point(12, 520);
            grp_Estimacion.Name = "grp_Estimacion";
            grp_Estimacion.Size = new Size(246, 75);
            grp_Estimacion.TabIndex = 38;
            grp_Estimacion.TabStop = false;
            grp_Estimacion.Text = "Presupuesto";
            // 
            // productosElegidos
            // 
            productosElegidos.Columns.AddRange(new ColumnHeader[] { ID, Codigo, Nombre, TipoServicio, Precios });
            productosElegidos.Enabled = false;
            productosElegidos.FullRowSelect = true;
            productosElegidos.Location = new Point(6, 22);
            productosElegidos.Name = "productosElegidos";
            productosElegidos.Size = new Size(841, 601);
            productosElegidos.TabIndex = 41;
            productosElegidos.UseCompatibleStateImageBehavior = false;
            productosElegidos.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 0;
            // 
            // Codigo
            // 
            Codigo.Text = "Código";
            Codigo.Width = 100;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre";
            Nombre.Width = 200;
            // 
            // TipoServicio
            // 
            TipoServicio.Text = "Tipo de Servicio";
            TipoServicio.Width = 200;
            // 
            // Precios
            // 
            Precios.Text = "Precio";
            Precios.Width = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 153);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 3;
            label2.Text = "DNI";
            // 
            // textBoxClienteDNI
            // 
            textBoxClienteDNI.Location = new Point(14, 175);
            textBoxClienteDNI.Name = "textBoxClienteDNI";
            textBoxClienteDNI.Size = new Size(226, 23);
            textBoxClienteDNI.TabIndex = 2;
            // 
            // grp_Filtros
            // 
            grp_Filtros.Controls.Add(textBox2);
            grp_Filtros.Controls.Add(label4);
            grp_Filtros.Controls.Add(textBox1);
            grp_Filtros.Controls.Add(label3);
            grp_Filtros.Controls.Add(textBoxClienteDNI);
            grp_Filtros.Controls.Add(label2);
            grp_Filtros.Location = new Point(12, 266);
            grp_Filtros.Name = "grp_Filtros";
            grp_Filtros.Size = new Size(246, 234);
            grp_Filtros.TabIndex = 39;
            grp_Filtros.TabStop = false;
            grp_Filtros.Text = "Cliente";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(10, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 23);
            textBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 94);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "Apellido";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 23);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 31);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Nombre";
            // 
            // botonEstilizado1
            // 
            botonEstilizado1.BackColor = Color.Transparent;
            botonEstilizado1.FlatAppearance.MouseOverBackColor = Color.LightGray;
            botonEstilizado1.FlatStyle = FlatStyle.Flat;
            botonEstilizado1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            botonEstilizado1.ForeColor = Color.Black;
            botonEstilizado1.Location = new Point(6, 89);
            botonEstilizado1.Name = "botonEstilizado1";
            botonEstilizado1.Size = new Size(230, 56);
            botonEstilizado1.TabIndex = 42;
            botonEstilizado1.Text = "Pre-reservar";
            botonEstilizado1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(botonEstilizado2);
            groupBox2.Controls.Add(botonEstilizado4);
            groupBox2.Controls.Add(productosElegidos);
            groupBox2.Location = new Point(279, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(853, 675);
            groupBox2.TabIndex = 43;
            groupBox2.TabStop = false;
            groupBox2.Text = "Productos Asignados";
            // 
            // botonEstilizado4
            // 
            botonEstilizado4.BackColor = Color.Transparent;
            botonEstilizado4.FlatAppearance.MouseOverBackColor = Color.LightGray;
            botonEstilizado4.FlatStyle = FlatStyle.Flat;
            botonEstilizado4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            botonEstilizado4.ForeColor = Color.Black;
            botonEstilizado4.Location = new Point(419, 629);
            botonEstilizado4.Name = "botonEstilizado4";
            botonEstilizado4.Size = new Size(428, 40);
            botonEstilizado4.TabIndex = 45;
            botonEstilizado4.Text = "Eliminar selección";
            botonEstilizado4.UseVisualStyleBackColor = false;
            // 
            // botonEstilizado2
            // 
            botonEstilizado2.BackColor = Color.Transparent;
            botonEstilizado2.FlatAppearance.MouseOverBackColor = Color.LightGray;
            botonEstilizado2.FlatStyle = FlatStyle.Flat;
            botonEstilizado2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            botonEstilizado2.ForeColor = Color.Black;
            botonEstilizado2.Location = new Point(6, 629);
            botonEstilizado2.Name = "botonEstilizado2";
            botonEstilizado2.Size = new Size(388, 40);
            botonEstilizado2.TabIndex = 46;
            botonEstilizado2.Text = "Eliminar todo";
            botonEstilizado2.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(botonEstilizado1);
            groupBox3.Controls.Add(btnFinalizarPresupuesto);
            groupBox3.Location = new Point(12, 616);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(246, 159);
            groupBox3.TabIndex = 44;
            groupBox3.TabStop = false;
            groupBox3.Text = "Acciones";
            // 
            // GenerarPresupuestoMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1144, 793);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(grp_Filtros);
            Controls.Add(grp_Estimacion);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(6);
            Name = "GenerarPresupuestoMenu";
            Text = "Generar Presupuesto";
            Load += GenerarPresupuestoMenu_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(grp_Estimacion, 0);
            Controls.SetChildIndex(grp_Filtros, 0);
            Controls.SetChildIndex(groupBox2, 0);
            Controls.SetChildIndex(groupBox3, 0);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grp_Estimacion.ResumeLayout(false);
            grp_Estimacion.PerformLayout();
            grp_Filtros.ResumeLayout(false);
            grp_Filtros.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label presupuestoTotal;
        private GroupBox groupBox1;
        private Common.Components.BotonEstilizado btnMenuAereos;
        private Common.Components.BotonEstilizado btnMenuHoteles;
        private Common.Components.BotonEstilizado btnFinalizarPresupuesto;
        private GroupBox grp_Estimacion;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ListView productosElegidos;
        private ColumnHeader ID;
        private ColumnHeader Codigo;
        private ColumnHeader Nombre;
        private ColumnHeader TipoServicio;
        private ColumnHeader Precios;
        private Label label2;
        private TextBox textBoxClienteDNI;
        private GroupBox grp_Filtros;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private Common.Components.BotonEstilizado botonEstilizado1;
        private GroupBox groupBox2;
        private Common.Components.BotonEstilizado botonEstilizado4;
        private Common.Components.BotonEstilizado botonEstilizado2;
        private GroupBox groupBox3;
    }
}