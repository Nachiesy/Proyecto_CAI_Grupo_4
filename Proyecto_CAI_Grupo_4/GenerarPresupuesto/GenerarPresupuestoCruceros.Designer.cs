namespace Proyecto_CAI_Grupo_4
{
    partial class GenerarPresupuestoCruceros
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
            btnLimpiarFiltro = new Button();
            lstViewProductos = new ListView();
            ID = new ColumnHeader();
            btnAgregarProductos = new Button();
            btnBuscarProducto = new Button();
            label7 = new Label();
            txtBoxPrecioDesde = new TextBox();
            label6 = new Label();
            txtBoxPrecioHasta = new TextBox();
            label5 = new Label();
            datePickerFechaLlegada = new DateTimePicker();
            label4 = new Label();
            datePickerFechaSalida = new DateTimePicker();
            btnVolverMenuGenerarPresupuestos = new Button();
            btnFinalizarPresupuesto = new Button();
            btnRemoverProductos = new Button();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            lstViewProductosElegidos = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            SuspendLayout();
            // 
            // btnLimpiarFiltro
            // 
            btnLimpiarFiltro.Location = new Point(211, 97);
            btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            btnLimpiarFiltro.Size = new Size(126, 30);
            btnLimpiarFiltro.TabIndex = 76;
            btnLimpiarFiltro.Text = "Limpiar Filtros";
            btnLimpiarFiltro.UseVisualStyleBackColor = true;
            btnLimpiarFiltro.Click += btnLimpiarFiltro_Click;
            // 
            // lstViewProductos
            // 
            lstViewProductos.Columns.AddRange(new ColumnHeader[] { ID, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lstViewProductos.FullRowSelect = true;
            lstViewProductos.Location = new Point(45, 152);
            lstViewProductos.Name = "lstViewProductos";
            lstViewProductos.Size = new Size(1159, 195);
            lstViewProductos.TabIndex = 75;
            lstViewProductos.UseCompatibleStateImageBehavior = false;
            lstViewProductos.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 250;
            // 
            // btnAgregarProductos
            // 
            btnAgregarProductos.Location = new Point(1098, 363);
            btnAgregarProductos.Name = "btnAgregarProductos";
            btnAgregarProductos.Size = new Size(106, 28);
            btnAgregarProductos.TabIndex = 74;
            btnAgregarProductos.Text = "Agregar";
            btnAgregarProductos.UseVisualStyleBackColor = true;
            btnAgregarProductos.Click += btnAgregarProductos_Click;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(45, 97);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(128, 30);
            btnBuscarProducto.TabIndex = 73;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 21);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 72;
            label7.Text = "Precio Desde";
            // 
            // txtBoxPrecioDesde
            // 
            txtBoxPrecioDesde.Location = new Point(47, 48);
            txtBoxPrecioDesde.Name = "txtBoxPrecioDesde";
            txtBoxPrecioDesde.Size = new Size(126, 23);
            txtBoxPrecioDesde.TabIndex = 71;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(211, 21);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 70;
            label6.Text = "Precio Hasta";
            // 
            // txtBoxPrecioHasta
            // 
            txtBoxPrecioHasta.Location = new Point(211, 48);
            txtBoxPrecioHasta.Name = "txtBoxPrecioHasta";
            txtBoxPrecioHasta.Size = new Size(126, 23);
            txtBoxPrecioHasta.TabIndex = 69;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(615, 21);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 68;
            label5.Text = "Fecha Llegada";
            // 
            // datePickerFechaLlegada
            // 
            datePickerFechaLlegada.Location = new Point(615, 48);
            datePickerFechaLlegada.MinDate = new DateTime(2023, 10, 7, 0, 0, 0, 0);
            datePickerFechaLlegada.Name = "datePickerFechaLlegada";
            datePickerFechaLlegada.Size = new Size(200, 23);
            datePickerFechaLlegada.TabIndex = 67;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(371, 21);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 66;
            label4.Text = "Fecha Salida";
            // 
            // datePickerFechaSalida
            // 
            datePickerFechaSalida.Location = new Point(371, 48);
            datePickerFechaSalida.MinDate = new DateTime(2023, 10, 7, 0, 0, 0, 0);
            datePickerFechaSalida.Name = "datePickerFechaSalida";
            datePickerFechaSalida.Size = new Size(200, 23);
            datePickerFechaSalida.TabIndex = 65;
            // 
            // btnVolverMenuGenerarPresupuestos
            // 
            btnVolverMenuGenerarPresupuestos.Location = new Point(45, 641);
            btnVolverMenuGenerarPresupuestos.Name = "btnVolverMenuGenerarPresupuestos";
            btnVolverMenuGenerarPresupuestos.Size = new Size(126, 23);
            btnVolverMenuGenerarPresupuestos.TabIndex = 79;
            btnVolverMenuGenerarPresupuestos.Text = "Volver";
            btnVolverMenuGenerarPresupuestos.UseVisualStyleBackColor = true;
            btnVolverMenuGenerarPresupuestos.Click += btnVolverMenuGenerarPresupuestos_Click;
            // 
            // btnFinalizarPresupuesto
            // 
            btnFinalizarPresupuesto.Location = new Point(1066, 639);
            btnFinalizarPresupuesto.Name = "btnFinalizarPresupuesto";
            btnFinalizarPresupuesto.Size = new Size(138, 25);
            btnFinalizarPresupuesto.TabIndex = 78;
            btnFinalizarPresupuesto.Text = "Confirmar";
            btnFinalizarPresupuesto.UseVisualStyleBackColor = true;
            btnFinalizarPresupuesto.Click += btnFinalizarPresupuesto_Click;
            // 
            // btnRemoverProductos
            // 
            btnRemoverProductos.Location = new Point(932, 639);
            btnRemoverProductos.Name = "btnRemoverProductos";
            btnRemoverProductos.Size = new Size(107, 25);
            btnRemoverProductos.TabIndex = 77;
            btnRemoverProductos.Text = "Quitar";
            btnRemoverProductos.UseVisualStyleBackColor = true;
            btnRemoverProductos.Click += btnRemoverProductos_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ciudad de Partida";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ciudad de Llegada";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Precio";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Fecha Desde";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Fecha Hasta";
            columnHeader6.Width = 100;
            // 
            // lstViewProductosElegidos
            // 
            lstViewProductosElegidos.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13 });
            lstViewProductosElegidos.FullRowSelect = true;
            lstViewProductosElegidos.Location = new Point(45, 424);
            lstViewProductosElegidos.Name = "lstViewProductosElegidos";
            lstViewProductosElegidos.Size = new Size(1159, 195);
            lstViewProductosElegidos.TabIndex = 80;
            lstViewProductosElegidos.UseCompatibleStateImageBehavior = false;
            lstViewProductosElegidos.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "ID";
            columnHeader7.Width = 250;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Nombre";
            columnHeader8.Width = 200;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Ciudad de Partida";
            columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Ciudad de Llegada";
            columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Precio";
            columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Fecha Desde";
            columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Fecha Hasta";
            columnHeader13.Width = 100;
            // 
            // GenerarPresupuestoCruceros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 734);
            Controls.Add(lstViewProductosElegidos);
            Controls.Add(btnVolverMenuGenerarPresupuestos);
            Controls.Add(btnFinalizarPresupuesto);
            Controls.Add(btnRemoverProductos);
            Controls.Add(btnLimpiarFiltro);
            Controls.Add(lstViewProductos);
            Controls.Add(btnAgregarProductos);
            Controls.Add(btnBuscarProducto);
            Controls.Add(label7);
            Controls.Add(txtBoxPrecioDesde);
            Controls.Add(label6);
            Controls.Add(txtBoxPrecioHasta);
            Controls.Add(label5);
            Controls.Add(datePickerFechaLlegada);
            Controls.Add(label4);
            Controls.Add(datePickerFechaSalida);
            Name = "GenerarPresupuestoCruceros";
            Text = "Generar Presupuesto - Cruceros";
            Load += GenerarPresupuestoCruceros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiarFiltro;
        private ListView lstViewProductos;
        private ColumnHeader ID;
        private Button btnAgregarProductos;
        private Button btnBuscarProducto;
        private Label label7;
        private TextBox txtBoxPrecioDesde;
        private Label label6;
        private TextBox txtBoxPrecioHasta;
        private Label label5;
        private DateTimePicker datePickerFechaLlegada;
        private Label label4;
        private DateTimePicker datePickerFechaSalida;
        private Button btnVolverMenuGenerarPresupuestos;
        private Button btnFinalizarPresupuesto;
        private Button btnRemoverProductos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ListView lstViewProductosElegidos;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
    }
}