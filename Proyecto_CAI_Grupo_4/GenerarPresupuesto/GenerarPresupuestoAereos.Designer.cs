namespace Proyecto_CAI_Grupo_4
{
    partial class GenerarPresupuestoAereos
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
            datePickerFechaSalida = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            datePickerFechaLlegada = new DateTimePicker();
            label6 = new Label();
            txtBoxPrecioHasta = new TextBox();
            label7 = new Label();
            txtBoxPrecioDesde = new TextBox();
            buscarPresupuesto = new Button();
            finalizarPresupuesto = new Button();
            removerPresupuesto = new Button();
            agregarPresupuesto = new Button();
            lstViewProductosAereos = new ListView();
            ID = new ColumnHeader();
            Origen = new ColumnHeader();
            Destino = new ColumnHeader();
            TipoDeClaseAerea = new ColumnHeader();
            Precio = new ColumnHeader();
            FechaSalida = new ColumnHeader();
            FechaLLegada = new ColumnHeader();
            btnVolverMenuGenerarPresupuestos = new Button();
            lstViewProductosAereosElegidos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            btnLimpiarFiltro = new Button();
            SuspendLayout();
            // 
            // datePickerFechaSalida
            // 
            datePickerFechaSalida.Location = new Point(356, 52);
            datePickerFechaSalida.MinDate = new DateTime(2023, 10, 7, 0, 0, 0, 0);
            datePickerFechaSalida.Name = "datePickerFechaSalida";
            datePickerFechaSalida.Size = new Size(200, 23);
            datePickerFechaSalida.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(356, 25);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 13;
            label4.Text = "Fecha Salida";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(600, 25);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 15;
            label5.Text = "Fecha Llegada";
            // 
            // datePickerFechaLlegada
            // 
            datePickerFechaLlegada.Location = new Point(600, 52);
            datePickerFechaLlegada.MinDate = new DateTime(2023, 10, 7, 0, 0, 0, 0);
            datePickerFechaLlegada.Name = "datePickerFechaLlegada";
            datePickerFechaLlegada.Size = new Size(200, 23);
            datePickerFechaLlegada.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(196, 25);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 17;
            label6.Text = "Precio Hasta";
            // 
            // txtBoxPrecioHasta
            // 
            txtBoxPrecioHasta.Location = new Point(196, 52);
            txtBoxPrecioHasta.Name = "txtBoxPrecioHasta";
            txtBoxPrecioHasta.Size = new Size(126, 23);
            txtBoxPrecioHasta.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 25);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 19;
            label7.Text = "Precio Desde";
            // 
            // txtBoxPrecioDesde
            // 
            txtBoxPrecioDesde.Location = new Point(32, 52);
            txtBoxPrecioDesde.Name = "txtBoxPrecioDesde";
            txtBoxPrecioDesde.Size = new Size(126, 23);
            txtBoxPrecioDesde.TabIndex = 18;
            // 
            // buscarPresupuesto
            // 
            buscarPresupuesto.Location = new Point(30, 101);
            buscarPresupuesto.Name = "buscarPresupuesto";
            buscarPresupuesto.Size = new Size(128, 30);
            buscarPresupuesto.TabIndex = 22;
            buscarPresupuesto.Text = "Buscar";
            buscarPresupuesto.UseVisualStyleBackColor = true;
            buscarPresupuesto.Click += buscarProductosAereos_Click;
            // 
            // finalizarPresupuesto
            // 
            finalizarPresupuesto.Location = new Point(1051, 641);
            finalizarPresupuesto.Name = "finalizarPresupuesto";
            finalizarPresupuesto.Size = new Size(138, 25);
            finalizarPresupuesto.TabIndex = 27;
            finalizarPresupuesto.Text = "Confirmar";
            finalizarPresupuesto.UseVisualStyleBackColor = true;
            finalizarPresupuesto.Click += finalizarPresupuestoAereo_Click;
            // 
            // removerPresupuesto
            // 
            removerPresupuesto.Location = new Point(917, 641);
            removerPresupuesto.Name = "removerPresupuesto";
            removerPresupuesto.Size = new Size(107, 25);
            removerPresupuesto.TabIndex = 26;
            removerPresupuesto.Text = "Quitar";
            removerPresupuesto.UseVisualStyleBackColor = true;
            removerPresupuesto.Click += removerProductosAereosDeLosElegidos_Click;
            // 
            // agregarPresupuesto
            // 
            agregarPresupuesto.Location = new Point(1083, 367);
            agregarPresupuesto.Name = "agregarPresupuesto";
            agregarPresupuesto.Size = new Size(106, 28);
            agregarPresupuesto.TabIndex = 25;
            agregarPresupuesto.Text = "Agregar";
            agregarPresupuesto.UseVisualStyleBackColor = true;
            agregarPresupuesto.Click += agregarProductosAereosElegidos_Click;
            // 
            // lstViewProductosAereos
            // 
            lstViewProductosAereos.Columns.AddRange(new ColumnHeader[] { ID, Origen, Destino, TipoDeClaseAerea, Precio, FechaSalida, FechaLLegada });
            lstViewProductosAereos.FullRowSelect = true;
            lstViewProductosAereos.Location = new Point(30, 156);
            lstViewProductosAereos.Name = "lstViewProductosAereos";
            lstViewProductosAereos.Size = new Size(1159, 195);
            lstViewProductosAereos.TabIndex = 28;
            lstViewProductosAereos.UseCompatibleStateImageBehavior = false;
            lstViewProductosAereos.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 250;
            // 
            // Origen
            // 
            Origen.Text = "Origen";
            Origen.Width = 100;
            // 
            // Destino
            // 
            Destino.Text = "Destino";
            Destino.Width = 100;
            // 
            // TipoDeClaseAerea
            // 
            TipoDeClaseAerea.Text = "Clase";
            TipoDeClaseAerea.Width = 100;
            // 
            // Precio
            // 
            Precio.Text = "Precio";
            Precio.Width = 100;
            // 
            // FechaSalida
            // 
            FechaSalida.Text = "Fecha Salida";
            FechaSalida.Width = 100;
            // 
            // FechaLLegada
            // 
            FechaLLegada.Text = "Fecha Llegada";
            FechaLLegada.Width = 100;
            // 
            // btnVolverMenuGenerarPresupuestos
            // 
            btnVolverMenuGenerarPresupuestos.Location = new Point(30, 643);
            btnVolverMenuGenerarPresupuestos.Name = "btnVolverMenuGenerarPresupuestos";
            btnVolverMenuGenerarPresupuestos.Size = new Size(126, 23);
            btnVolverMenuGenerarPresupuestos.TabIndex = 30;
            btnVolverMenuGenerarPresupuestos.Text = "Volver";
            btnVolverMenuGenerarPresupuestos.UseVisualStyleBackColor = true;
            btnVolverMenuGenerarPresupuestos.Click += btnVolverMenuGenerarPresupuestos_Click;
            // 
            // lstViewProductosAereosElegidos
            // 
            lstViewProductosAereosElegidos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lstViewProductosAereosElegidos.FullRowSelect = true;
            lstViewProductosAereosElegidos.Location = new Point(30, 428);
            lstViewProductosAereosElegidos.Name = "lstViewProductosAereosElegidos";
            lstViewProductosAereosElegidos.Size = new Size(1159, 195);
            lstViewProductosAereosElegidos.TabIndex = 31;
            lstViewProductosAereosElegidos.UseCompatibleStateImageBehavior = false;
            lstViewProductosAereosElegidos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Origen";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Destino";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Clase";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Precio";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Fecha Salida";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Fecha Llegada";
            columnHeader7.Width = 100;
            // 
            // btnLimpiarFiltro
            // 
            btnLimpiarFiltro.Location = new Point(196, 101);
            btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            btnLimpiarFiltro.Size = new Size(126, 30);
            btnLimpiarFiltro.TabIndex = 32;
            btnLimpiarFiltro.Text = "Limpiar Filtros";
            btnLimpiarFiltro.UseVisualStyleBackColor = true;
            btnLimpiarFiltro.Click += btnLimpiarFiltro_Click;
            // 
            // GenerarPresupuestoAereos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 703);
            Controls.Add(btnLimpiarFiltro);
            Controls.Add(lstViewProductosAereosElegidos);
            Controls.Add(btnVolverMenuGenerarPresupuestos);
            Controls.Add(lstViewProductosAereos);
            Controls.Add(finalizarPresupuesto);
            Controls.Add(removerPresupuesto);
            Controls.Add(agregarPresupuesto);
            Controls.Add(buscarPresupuesto);
            Controls.Add(label7);
            Controls.Add(txtBoxPrecioDesde);
            Controls.Add(label6);
            Controls.Add(txtBoxPrecioHasta);
            Controls.Add(label5);
            Controls.Add(datePickerFechaLlegada);
            Controls.Add(label4);
            Controls.Add(datePickerFechaSalida);
            Name = "GenerarPresupuestoAereos";
            Text = "Form2";
            Load += GenerarPresupuestoAereos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker datePickerFechaSalida;
        private Label label4;
        private Label label5;
        private DateTimePicker datePickerFechaLlegada;
        private Label label6;
        private TextBox txtBoxPrecioHasta;
        private Label label7;
        private TextBox txtBoxPrecioDesde;
        private Button buscarPresupuesto;
        private Button finalizarPresupuesto;
        private Button removerPresupuesto;
        private Button agregarPresupuesto;
        private ListView lstViewProductosAereos;
        private ColumnHeader ID;
        private ColumnHeader Origen;
        private ColumnHeader Destino;
        private ColumnHeader TipoDeClaseAerea;
        private ColumnHeader Precio;
        private ColumnHeader FechaSalida;
        private ColumnHeader FechaLLegada;
        private Button btnVolverMenuGenerarPresupuestos;
        private ListView lstViewProductosAereosElegidos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button btnLimpiarFiltro;
    }
}