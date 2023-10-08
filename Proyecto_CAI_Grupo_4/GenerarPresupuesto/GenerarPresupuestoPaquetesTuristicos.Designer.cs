namespace Proyecto_CAI_Grupo_4
{
    partial class GenerarPresupuestoPaquetesTuristicos
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
            btnVolverMenuGenerarPresupuestos = new Button();
            lstViewProductos = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            lstViewProductosElegidos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            grp_Filtros = new GroupBox();
            btnLimpiarFiltro = new Common.Components.BotonEstilizado();
            buscarPresupuesto = new Common.Components.BotonEstilizado();
            agregarPresupuesto = new Common.Components.BotonEstilizado();
            removerPresupuesto = new Common.Components.BotonEstilizado();
            finalizarPresupuesto = new Common.Components.BotonEstilizado();
            grp_VuelosDisponibles = new GroupBox();
            grp_VuelosSeleccionados = new GroupBox();
            grp_Filtros.SuspendLayout();
            grp_VuelosDisponibles.SuspendLayout();
            grp_VuelosSeleccionados.SuspendLayout();
            SuspendLayout();
            // 
            // datePickerFechaSalida
            // 
            datePickerFechaSalida.Location = new Point(18, 116);
            datePickerFechaSalida.MinDate = new DateTime(2023, 10, 7, 0, 0, 0, 0);
            datePickerFechaSalida.Name = "datePickerFechaSalida";
            datePickerFechaSalida.Size = new Size(235, 23);
            datePickerFechaSalida.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 98);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 13;
            label4.Text = "Fecha Salida";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 161);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 15;
            label5.Text = "Fecha Llegada";
            // 
            // datePickerFechaLlegada
            // 
            datePickerFechaLlegada.Location = new Point(18, 179);
            datePickerFechaLlegada.MinDate = new DateTime(2023, 10, 7, 0, 0, 0, 0);
            datePickerFechaLlegada.Name = "datePickerFechaLlegada";
            datePickerFechaLlegada.Size = new Size(232, 23);
            datePickerFechaLlegada.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(163, 38);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 17;
            label6.Text = "Precio Hasta";
            // 
            // txtBoxPrecioHasta
            // 
            txtBoxPrecioHasta.Location = new Point(163, 56);
            txtBoxPrecioHasta.Name = "txtBoxPrecioHasta";
            txtBoxPrecioHasta.Size = new Size(126, 23);
            txtBoxPrecioHasta.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 38);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 19;
            label7.Text = "Precio Desde";
            // 
            // txtBoxPrecioDesde
            // 
            txtBoxPrecioDesde.Location = new Point(18, 56);
            txtBoxPrecioDesde.Name = "txtBoxPrecioDesde";
            txtBoxPrecioDesde.Size = new Size(126, 23);
            txtBoxPrecioDesde.TabIndex = 18;
            // 
            // btnVolverMenuGenerarPresupuestos
            // 
            btnVolverMenuGenerarPresupuestos.Location = new Point(27, 422);
            btnVolverMenuGenerarPresupuestos.Name = "btnVolverMenuGenerarPresupuestos";
            btnVolverMenuGenerarPresupuestos.Size = new Size(322, 47);
            btnVolverMenuGenerarPresupuestos.TabIndex = 30;
            btnVolverMenuGenerarPresupuestos.Text = "Volver";
            btnVolverMenuGenerarPresupuestos.UseVisualStyleBackColor = true;
            btnVolverMenuGenerarPresupuestos.Click += btnVolverMenuGenerarPresupuestos_Click;
            // 
            // lstViewProductos
            // 
            lstViewProductos.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader13, columnHeader14, columnHeader15 });
            lstViewProductos.FullRowSelect = true;
            lstViewProductos.Location = new Point(6, 22);
            lstViewProductos.Name = "lstViewProductos";
            lstViewProductos.Size = new Size(964, 194);
            lstViewProductos.TabIndex = 33;
            lstViewProductos.UseCompatibleStateImageBehavior = false;
            lstViewProductos.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "ID";
            columnHeader8.Width = 250;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Nombre";
            columnHeader9.Width = 200;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Origen";
            columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Destino";
            columnHeader11.Width = 100;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Precio";
            columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Fecha Salida";
            columnHeader14.Width = 100;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Fecha Llegada";
            columnHeader15.Width = 100;
            // 
            // lstViewProductosElegidos
            // 
            lstViewProductosElegidos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader6, columnHeader7, columnHeader16 });
            lstViewProductosElegidos.FullRowSelect = true;
            lstViewProductosElegidos.Location = new Point(6, 22);
            lstViewProductosElegidos.Name = "lstViewProductosElegidos";
            lstViewProductosElegidos.Size = new Size(964, 194);
            lstViewProductosElegidos.TabIndex = 34;
            lstViewProductosElegidos.UseCompatibleStateImageBehavior = false;
            lstViewProductosElegidos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Origen";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Destino";
            columnHeader4.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Precio";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Fecha Salida";
            columnHeader7.Width = 100;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Fecha Llegada";
            columnHeader16.Width = 100;
            // 
            // grp_Filtros
            // 
            grp_Filtros.Controls.Add(btnLimpiarFiltro);
            grp_Filtros.Controls.Add(label7);
            grp_Filtros.Controls.Add(buscarPresupuesto);
            grp_Filtros.Controls.Add(datePickerFechaSalida);
            grp_Filtros.Controls.Add(label4);
            grp_Filtros.Controls.Add(datePickerFechaLlegada);
            grp_Filtros.Controls.Add(label5);
            grp_Filtros.Controls.Add(txtBoxPrecioHasta);
            grp_Filtros.Controls.Add(label6);
            grp_Filtros.Controls.Add(txtBoxPrecioDesde);
            grp_Filtros.Location = new Point(27, 131);
            grp_Filtros.Name = "grp_Filtros";
            grp_Filtros.Size = new Size(322, 278);
            grp_Filtros.TabIndex = 35;
            grp_Filtros.TabStop = false;
            grp_Filtros.Text = "Filtros";
            // 
            // btnLimpiarFiltro
            // 
            btnLimpiarFiltro.BackColor = Color.Transparent;
            btnLimpiarFiltro.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnLimpiarFiltro.FlatStyle = FlatStyle.Flat;
            btnLimpiarFiltro.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiarFiltro.ForeColor = Color.Black;
            btnLimpiarFiltro.Location = new Point(163, 220);
            btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            btnLimpiarFiltro.Size = new Size(139, 40);
            btnLimpiarFiltro.TabIndex = 4;
            btnLimpiarFiltro.Text = "Limpiar";
            btnLimpiarFiltro.UseVisualStyleBackColor = false;
            btnLimpiarFiltro.Click += btnLimpiarFiltro_Click;
            // 
            // buscarPresupuesto
            // 
            buscarPresupuesto.BackColor = Color.Transparent;
            buscarPresupuesto.FlatAppearance.MouseOverBackColor = Color.LightGray;
            buscarPresupuesto.FlatStyle = FlatStyle.Flat;
            buscarPresupuesto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buscarPresupuesto.ForeColor = Color.Black;
            buscarPresupuesto.Location = new Point(18, 220);
            buscarPresupuesto.Name = "buscarPresupuesto";
            buscarPresupuesto.Size = new Size(139, 40);
            buscarPresupuesto.TabIndex = 4;
            buscarPresupuesto.Text = "Buscar";
            buscarPresupuesto.UseVisualStyleBackColor = false;
            buscarPresupuesto.Click += btnBuscarProducto_Click;
            // 
            // agregarPresupuesto
            // 
            agregarPresupuesto.BackColor = Color.Transparent;
            agregarPresupuesto.FlatAppearance.MouseOverBackColor = Color.LightGray;
            agregarPresupuesto.FlatStyle = FlatStyle.Flat;
            agregarPresupuesto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            agregarPresupuesto.ForeColor = Color.Black;
            agregarPresupuesto.Location = new Point(6, 222);
            agregarPresupuesto.Name = "agregarPresupuesto";
            agregarPresupuesto.Size = new Size(964, 40);
            agregarPresupuesto.TabIndex = 4;
            agregarPresupuesto.Text = "Agregar";
            agregarPresupuesto.UseVisualStyleBackColor = false;
            agregarPresupuesto.Click += btnAgregarProductos_Click;
            // 
            // removerPresupuesto
            // 
            removerPresupuesto.BackColor = Color.Transparent;
            removerPresupuesto.FlatAppearance.MouseOverBackColor = Color.LightGray;
            removerPresupuesto.FlatStyle = FlatStyle.Flat;
            removerPresupuesto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            removerPresupuesto.ForeColor = Color.Black;
            removerPresupuesto.Location = new Point(6, 222);
            removerPresupuesto.Name = "removerPresupuesto";
            removerPresupuesto.Size = new Size(479, 40);
            removerPresupuesto.TabIndex = 4;
            removerPresupuesto.Text = "Quitar";
            removerPresupuesto.UseVisualStyleBackColor = false;
            removerPresupuesto.Click += btnRemoverProductos_Click;
            // 
            // finalizarPresupuesto
            // 
            finalizarPresupuesto.BackColor = Color.Transparent;
            finalizarPresupuesto.FlatAppearance.MouseOverBackColor = Color.LightGray;
            finalizarPresupuesto.FlatStyle = FlatStyle.Flat;
            finalizarPresupuesto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            finalizarPresupuesto.ForeColor = Color.Black;
            finalizarPresupuesto.Location = new Point(491, 222);
            finalizarPresupuesto.Name = "finalizarPresupuesto";
            finalizarPresupuesto.Size = new Size(479, 40);
            finalizarPresupuesto.TabIndex = 4;
            finalizarPresupuesto.Text = "Confirmar";
            finalizarPresupuesto.UseVisualStyleBackColor = false;
            finalizarPresupuesto.Click += btnFinalizarPresupuesto_Click;
            // 
            // grp_VuelosDisponibles
            // 
            grp_VuelosDisponibles.Controls.Add(lstViewProductos);
            grp_VuelosDisponibles.Controls.Add(agregarPresupuesto);
            grp_VuelosDisponibles.Location = new Point(376, 131);
            grp_VuelosDisponibles.Name = "grp_VuelosDisponibles";
            grp_VuelosDisponibles.Size = new Size(976, 278);
            grp_VuelosDisponibles.TabIndex = 36;
            grp_VuelosDisponibles.TabStop = false;
            grp_VuelosDisponibles.Text = "Paquetes Disponibles";
            // 
            // grp_VuelosSeleccionados
            // 
            grp_VuelosSeleccionados.Controls.Add(lstViewProductosElegidos);
            grp_VuelosSeleccionados.Controls.Add(removerPresupuesto);
            grp_VuelosSeleccionados.Controls.Add(finalizarPresupuesto);
            grp_VuelosSeleccionados.Location = new Point(376, 422);
            grp_VuelosSeleccionados.Name = "grp_VuelosSeleccionados";
            grp_VuelosSeleccionados.Size = new Size(976, 269);
            grp_VuelosSeleccionados.TabIndex = 37;
            grp_VuelosSeleccionados.TabStop = false;
            grp_VuelosSeleccionados.Text = "Paquetes Seleccionados";
            // 
            // GenerarPresupuestoPaquetesTuristicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1364, 721);
            Controls.Add(grp_VuelosSeleccionados);
            Controls.Add(grp_VuelosDisponibles);
            Controls.Add(grp_Filtros);
            Controls.Add(btnVolverMenuGenerarPresupuestos);
            Name = "GenerarPresupuestoPaquetesTuristicos";
            Text = "Generar Presupuesto - Aéreos";
            Load += GenerarPresupuestoPaquetesTuristicos_Load;
            Controls.SetChildIndex(btnVolverMenuGenerarPresupuestos, 0);
            Controls.SetChildIndex(grp_Filtros, 0);
            Controls.SetChildIndex(grp_VuelosDisponibles, 0);
            Controls.SetChildIndex(grp_VuelosSeleccionados, 0);
            grp_Filtros.ResumeLayout(false);
            grp_Filtros.PerformLayout();
            grp_VuelosDisponibles.ResumeLayout(false);
            grp_VuelosSeleccionados.ResumeLayout(false);
            ResumeLayout(false);
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
        private Button btnVolverMenuGenerarPresupuestos;
        private ListView lstViewProductos;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ListView lstViewProductosElegidos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader16;
        private GroupBox grp_Filtros;
        private Common.Components.BotonEstilizado btnLimpiarFiltro;
        private Common.Components.BotonEstilizado buscarPresupuesto;
        private Common.Components.BotonEstilizado agregarPresupuesto;
        private Common.Components.BotonEstilizado removerPresupuesto;
        private Common.Components.BotonEstilizado finalizarPresupuesto;
        private GroupBox grp_VuelosDisponibles;
        private GroupBox grp_VuelosSeleccionados;
    }
}