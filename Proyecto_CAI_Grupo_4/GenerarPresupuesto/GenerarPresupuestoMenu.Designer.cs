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
            Codigo = new ColumnHeader();
            Nombre = new ColumnHeader();
            TipoServicio = new ColumnHeader();
            Precios = new ColumnHeader();
            label2 = new Label();
            textBoxClienteDNI = new TextBox();
            grp_Filtros = new GroupBox();
            textBoxClienteApellido = new TextBox();
            label4 = new Label();
            textBoxClienteNombre = new TextBox();
            label3 = new Label();
            btnPreReservar = new Common.Components.BotonEstilizado();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnEliminarTodo = new Common.Components.BotonEstilizado();
            btnEliminarSeleccion = new Common.Components.BotonEstilizado();
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
            btnFinalizarPresupuesto.Size = new Size(380, 47);
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
            grp_Estimacion.Size = new Size(246, 95);
            grp_Estimacion.TabIndex = 38;
            grp_Estimacion.TabStop = false;
            grp_Estimacion.Text = "Presupuesto";
            // 
            // productosElegidos
            // 
            productosElegidos.Columns.AddRange(new ColumnHeader[] { Codigo, Nombre, TipoServicio, Precios });
            productosElegidos.FullRowSelect = true;
            productosElegidos.Location = new Point(8, 22);
            productosElegidos.Name = "productosElegidos";
            productosElegidos.Size = new Size(841, 306);
            productosElegidos.TabIndex = 41;
            productosElegidos.UseCompatibleStateImageBehavior = false;
            productosElegidos.View = View.Details;
            productosElegidos.SelectedIndexChanged += productosElegidos_SelectedIndexChanged;
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
            grp_Filtros.Controls.Add(textBoxClienteApellido);
            grp_Filtros.Controls.Add(label4);
            grp_Filtros.Controls.Add(textBoxClienteNombre);
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
            // textBoxClienteApellido
            // 
            textBoxClienteApellido.Location = new Point(10, 116);
            textBoxClienteApellido.Name = "textBoxClienteApellido";
            textBoxClienteApellido.Size = new Size(226, 23);
            textBoxClienteApellido.TabIndex = 6;
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
            // textBoxClienteNombre
            // 
            textBoxClienteNombre.Location = new Point(10, 53);
            textBoxClienteNombre.Name = "textBoxClienteNombre";
            textBoxClienteNombre.Size = new Size(226, 23);
            textBoxClienteNombre.TabIndex = 4;
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
            // btnPreReservar
            // 
            btnPreReservar.BackColor = Color.Transparent;
            btnPreReservar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnPreReservar.FlatStyle = FlatStyle.Flat;
            btnPreReservar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnPreReservar.ForeColor = Color.Black;
            btnPreReservar.Location = new Point(451, 22);
            btnPreReservar.Name = "btnPreReservar";
            btnPreReservar.Size = new Size(382, 47);
            btnPreReservar.TabIndex = 42;
            btnPreReservar.Text = "Pre-reservar";
            btnPreReservar.UseVisualStyleBackColor = false;
            btnPreReservar.Click += btnPreReservar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(btnEliminarTodo);
            groupBox2.Controls.Add(btnEliminarSeleccion);
            groupBox2.Controls.Add(productosElegidos);
            groupBox2.Location = new Point(279, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(853, 509);
            groupBox2.TabIndex = 43;
            groupBox2.TabStop = false;
            groupBox2.Text = "Productos Asignados";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnPreReservar);
            groupBox3.Controls.Add(btnFinalizarPresupuesto);
            groupBox3.Location = new Point(8, 414);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(841, 84);
            groupBox3.TabIndex = 44;
            groupBox3.TabStop = false;
            groupBox3.Text = "Acciones";
            // 
            // btnEliminarTodo
            // 
            btnEliminarTodo.BackColor = Color.Transparent;
            btnEliminarTodo.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnEliminarTodo.FlatStyle = FlatStyle.Flat;
            btnEliminarTodo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarTodo.ForeColor = Color.Black;
            btnEliminarTodo.Location = new Point(459, 354);
            btnEliminarTodo.Name = "btnEliminarTodo";
            btnEliminarTodo.Size = new Size(382, 40);
            btnEliminarTodo.TabIndex = 46;
            btnEliminarTodo.Text = "Eliminar todo";
            btnEliminarTodo.UseVisualStyleBackColor = false;
            btnEliminarTodo.Click += btnEliminarTodo_Click;
            // 
            // btnEliminarSeleccion
            // 
            btnEliminarSeleccion.BackColor = Color.Transparent;
            btnEliminarSeleccion.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnEliminarSeleccion.FlatStyle = FlatStyle.Flat;
            btnEliminarSeleccion.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarSeleccion.ForeColor = Color.Black;
            btnEliminarSeleccion.Location = new Point(12, 354);
            btnEliminarSeleccion.Name = "btnEliminarSeleccion";
            btnEliminarSeleccion.Size = new Size(382, 40);
            btnEliminarSeleccion.TabIndex = 45;
            btnEliminarSeleccion.Text = "Eliminar selección";
            btnEliminarSeleccion.UseVisualStyleBackColor = false;
            btnEliminarSeleccion.Click += btnEliminarSeleccion_Click;
            // 
            // GenerarPresupuestoMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1140, 622);
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
        private ColumnHeader Codigo;
        private ColumnHeader Nombre;
        private ColumnHeader TipoServicio;
        private ColumnHeader Precios;
        private Label label2;
        private TextBox textBoxClienteDNI;
        private GroupBox grp_Filtros;
        private TextBox textBoxClienteApellido;
        private Label label4;
        private TextBox textBoxClienteNombre;
        private Label label3;
        private Common.Components.BotonEstilizado btnPreReservar;
        private GroupBox groupBox2;
        private Common.Components.BotonEstilizado btnEliminarSeleccion;
        private Common.Components.BotonEstilizado btnEliminarTodo;
        private GroupBox groupBox3;
    }
}