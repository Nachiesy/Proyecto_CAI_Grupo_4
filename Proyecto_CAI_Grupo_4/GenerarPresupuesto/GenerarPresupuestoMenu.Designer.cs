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
            grp_Filtros = new GroupBox();
            textBoxClienteDNI = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            textBoxPasajerosInfantes = new TextBox();
            labelPasajerosInfantes = new Label();
            textBoxPasajerosMenores = new TextBox();
            labelPasajerosMenores = new Label();
            textBoxPasajerosAdultos = new TextBox();
            labelPasajerosAdultos = new Label();
            productosElegidos = new ListView();
            ID = new ColumnHeader();
            Codigo = new ColumnHeader();
            Nombre = new ColumnHeader();
            TipoServicio = new ColumnHeader();
            Precios = new ColumnHeader();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grp_Estimacion.SuspendLayout();
            grp_Filtros.SuspendLayout();
            groupBox2.SuspendLayout();
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
            groupBox1.Size = new Size(246, 237);
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
            btnFinalizarPresupuesto.Location = new Point(12, 670);
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
            grp_Estimacion.Location = new Point(12, 589);
            grp_Estimacion.Name = "grp_Estimacion";
            grp_Estimacion.Size = new Size(246, 75);
            grp_Estimacion.TabIndex = 38;
            grp_Estimacion.TabStop = false;
            grp_Estimacion.Text = "Presupuesto";
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
            grp_Filtros.Text = "Cliente";
            // 
            // textBoxClienteDNI
            // 
            textBoxClienteDNI.Location = new Point(14, 50);
            textBoxClienteDNI.Name = "textBoxClienteDNI";
            textBoxClienteDNI.Size = new Size(226, 23);
            textBoxClienteDNI.TabIndex = 2;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxPasajerosInfantes);
            groupBox2.Controls.Add(labelPasajerosInfantes);
            groupBox2.Controls.Add(textBoxPasajerosMenores);
            groupBox2.Controls.Add(labelPasajerosMenores);
            groupBox2.Controls.Add(textBoxPasajerosAdultos);
            groupBox2.Controls.Add(labelPasajerosAdultos);
            groupBox2.Location = new Point(12, 442);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(246, 141);
            groupBox2.TabIndex = 40;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pasajeros";
            // 
            // textBoxPasajerosInfantes
            // 
            textBoxPasajerosInfantes.Location = new Point(7, 102);
            textBoxPasajerosInfantes.Name = "textBoxPasajerosInfantes";
            textBoxPasajerosInfantes.Size = new Size(233, 23);
            textBoxPasajerosInfantes.TabIndex = 6;
            // 
            // labelPasajerosInfantes
            // 
            labelPasajerosInfantes.AutoSize = true;
            labelPasajerosInfantes.Location = new Point(8, 80);
            labelPasajerosInfantes.Name = "labelPasajerosInfantes";
            labelPasajerosInfantes.Size = new Size(49, 15);
            labelPasajerosInfantes.TabIndex = 7;
            labelPasajerosInfantes.Text = "Infantes";
            // 
            // textBoxPasajerosMenores
            // 
            textBoxPasajerosMenores.Location = new Point(134, 50);
            textBoxPasajerosMenores.Name = "textBoxPasajerosMenores";
            textBoxPasajerosMenores.Size = new Size(106, 23);
            textBoxPasajerosMenores.TabIndex = 4;
            // 
            // labelPasajerosMenores
            // 
            labelPasajerosMenores.AutoSize = true;
            labelPasajerosMenores.Location = new Point(135, 28);
            labelPasajerosMenores.Name = "labelPasajerosMenores";
            labelPasajerosMenores.Size = new Size(53, 15);
            labelPasajerosMenores.TabIndex = 5;
            labelPasajerosMenores.Text = "Menores";
            // 
            // textBoxPasajerosAdultos
            // 
            textBoxPasajerosAdultos.Location = new Point(6, 50);
            textBoxPasajerosAdultos.Name = "textBoxPasajerosAdultos";
            textBoxPasajerosAdultos.Size = new Size(106, 23);
            textBoxPasajerosAdultos.TabIndex = 2;
            // 
            // labelPasajerosAdultos
            // 
            labelPasajerosAdultos.AutoSize = true;
            labelPasajerosAdultos.Location = new Point(7, 28);
            labelPasajerosAdultos.Name = "labelPasajerosAdultos";
            labelPasajerosAdultos.Size = new Size(48, 15);
            labelPasajerosAdultos.TabIndex = 3;
            labelPasajerosAdultos.Text = "Adultos";
            // 
            // productosElegidos
            // 
            productosElegidos.Columns.AddRange(new ColumnHeader[] { ID, Codigo, Nombre, TipoServicio, Precios });
            productosElegidos.Enabled = false;
            productosElegidos.FullRowSelect = true;
            productosElegidos.Location = new Point(273, 116);
            productosElegidos.Name = "productosElegidos";
            productosElegidos.Size = new Size(853, 594);
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
            // GenerarPresupuestoMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1208, 720);
            Controls.Add(productosElegidos);
            Controls.Add(groupBox2);
            Controls.Add(grp_Filtros);
            Controls.Add(grp_Estimacion);
            Controls.Add(btnFinalizarPresupuesto);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(6);
            Name = "GenerarPresupuestoMenu";
            Text = "Generar Presupuesto";
            Load += GenerarPresupuestoMenu_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(btnFinalizarPresupuesto, 0);
            Controls.SetChildIndex(grp_Estimacion, 0);
            Controls.SetChildIndex(grp_Filtros, 0);
            Controls.SetChildIndex(groupBox2, 0);
            Controls.SetChildIndex(productosElegidos, 0);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grp_Estimacion.ResumeLayout(false);
            grp_Estimacion.PerformLayout();
            grp_Filtros.ResumeLayout(false);
            grp_Filtros.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private GroupBox grp_Filtros;
        private TextBox textBoxClienteDNI;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox textBoxPasajerosMenores;
        private Label labelPasajerosMenores;
        private TextBox textBoxPasajerosAdultos;
        private Label labelPasajerosAdultos;
        private TextBox textBoxPasajerosInfantes;
        private Label labelPasajerosInfantes;
        private ListView productosElegidos;
        private ColumnHeader ID;
        private ColumnHeader Codigo;
        private ColumnHeader Nombre;
        private ColumnHeader TipoServicio;
        private ColumnHeader Precios;
    }
}