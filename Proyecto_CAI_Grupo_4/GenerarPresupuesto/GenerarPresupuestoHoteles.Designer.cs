namespace Proyecto_CAI_Grupo_4
{
    partial class GenerarPresupuestoHoteles
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
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
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
            lstViewProductosElegidos = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            SuspendLayout();
            // 
            // btnLimpiarFiltro
            // 
            btnLimpiarFiltro.Location = new Point(189, 102);
            btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            btnLimpiarFiltro.Size = new Size(126, 30);
            btnLimpiarFiltro.TabIndex = 64;
            btnLimpiarFiltro.Text = "Limpiar Filtros";
            btnLimpiarFiltro.UseVisualStyleBackColor = true;
            btnLimpiarFiltro.Click += btnLimpiarFiltro_Click;
            // 
            // lstViewProductos
            // 
            lstViewProductos.Columns.AddRange(new ColumnHeader[] { ID, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lstViewProductos.FullRowSelect = true;
            lstViewProductos.Location = new Point(23, 157);
            lstViewProductos.Name = "lstViewProductos";
            lstViewProductos.Size = new Size(1159, 195);
            lstViewProductos.TabIndex = 63;
            lstViewProductos.UseCompatibleStateImageBehavior = false;
            lstViewProductos.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 250;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ciudad";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Precio";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Fecha Desde";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Fecha Hasta";
            columnHeader5.Width = 100;
            // 
            // btnAgregarProductos
            // 
            btnAgregarProductos.Location = new Point(1076, 368);
            btnAgregarProductos.Name = "btnAgregarProductos";
            btnAgregarProductos.Size = new Size(106, 28);
            btnAgregarProductos.TabIndex = 62;
            btnAgregarProductos.Text = "Agregar";
            btnAgregarProductos.UseVisualStyleBackColor = true;
            btnAgregarProductos.Click += btnAgregarProductos_Click;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(23, 102);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(128, 30);
            btnBuscarProducto.TabIndex = 61;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 26);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 60;
            label7.Text = "Precio Desde";
            // 
            // txtBoxPrecioDesde
            // 
            txtBoxPrecioDesde.Location = new Point(25, 53);
            txtBoxPrecioDesde.Name = "txtBoxPrecioDesde";
            txtBoxPrecioDesde.Size = new Size(126, 23);
            txtBoxPrecioDesde.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(189, 26);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 58;
            label6.Text = "Precio Hasta";
            // 
            // txtBoxPrecioHasta
            // 
            txtBoxPrecioHasta.Location = new Point(189, 53);
            txtBoxPrecioHasta.Name = "txtBoxPrecioHasta";
            txtBoxPrecioHasta.Size = new Size(126, 23);
            txtBoxPrecioHasta.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(593, 26);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 56;
            label5.Text = "Fecha Llegada";
            // 
            // datePickerFechaLlegada
            // 
            datePickerFechaLlegada.Location = new Point(593, 53);
            datePickerFechaLlegada.MinDate = new DateTime(2023, 10, 7, 0, 0, 0, 0);
            datePickerFechaLlegada.Name = "datePickerFechaLlegada";
            datePickerFechaLlegada.Size = new Size(200, 23);
            datePickerFechaLlegada.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(349, 26);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 54;
            label4.Text = "Fecha Salida";
            // 
            // datePickerFechaSalida
            // 
            datePickerFechaSalida.Location = new Point(349, 53);
            datePickerFechaSalida.MinDate = new DateTime(2023, 10, 7, 0, 0, 0, 0);
            datePickerFechaSalida.Name = "datePickerFechaSalida";
            datePickerFechaSalida.Size = new Size(200, 23);
            datePickerFechaSalida.TabIndex = 53;
            // 
            // btnVolverMenuGenerarPresupuestos
            // 
            btnVolverMenuGenerarPresupuestos.Location = new Point(23, 643);
            btnVolverMenuGenerarPresupuestos.Name = "btnVolverMenuGenerarPresupuestos";
            btnVolverMenuGenerarPresupuestos.Size = new Size(126, 23);
            btnVolverMenuGenerarPresupuestos.TabIndex = 67;
            btnVolverMenuGenerarPresupuestos.Text = "Volver";
            btnVolverMenuGenerarPresupuestos.UseVisualStyleBackColor = true;
            btnVolverMenuGenerarPresupuestos.Click += btnVolverMenuGenerarPresupuestos_Click;
            // 
            // btnFinalizarPresupuesto
            // 
            btnFinalizarPresupuesto.Location = new Point(1044, 641);
            btnFinalizarPresupuesto.Name = "btnFinalizarPresupuesto";
            btnFinalizarPresupuesto.Size = new Size(138, 25);
            btnFinalizarPresupuesto.TabIndex = 66;
            btnFinalizarPresupuesto.Text = "Confirmar";
            btnFinalizarPresupuesto.UseVisualStyleBackColor = true;
            btnFinalizarPresupuesto.Click += btnFinalizarPresupuesto_Click;
            // 
            // btnRemoverProductos
            // 
            btnRemoverProductos.Location = new Point(910, 641);
            btnRemoverProductos.Name = "btnRemoverProductos";
            btnRemoverProductos.Size = new Size(107, 25);
            btnRemoverProductos.TabIndex = 65;
            btnRemoverProductos.Text = "Quitar";
            btnRemoverProductos.UseVisualStyleBackColor = true;
            btnRemoverProductos.Click += btnRemoverProductos_Click;
            // 
            // lstViewProductosElegidos
            // 
            lstViewProductosElegidos.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            lstViewProductosElegidos.FullRowSelect = true;
            lstViewProductosElegidos.Location = new Point(23, 430);
            lstViewProductosElegidos.Name = "lstViewProductosElegidos";
            lstViewProductosElegidos.Size = new Size(1159, 195);
            lstViewProductosElegidos.TabIndex = 68;
            lstViewProductosElegidos.UseCompatibleStateImageBehavior = false;
            lstViewProductosElegidos.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "ID";
            columnHeader6.Width = 250;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Nombre";
            columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Ciudad";
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Precio";
            columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Fecha Desde";
            columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Fecha Hasta";
            columnHeader11.Width = 100;
            // 
            // GenerarPresupuestoHoteles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 711);
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
            Name = "GenerarPresupuestoHoteles";
            Text = "Generar Presupuesto - Hoteles";
            Load += GenerarPresupuestoHoteles_Load;
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
        private ListView lstViewProductosElegidos;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
    }
}