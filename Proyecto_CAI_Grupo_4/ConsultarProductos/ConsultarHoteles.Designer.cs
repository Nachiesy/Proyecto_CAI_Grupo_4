namespace Proyecto_CAI_Grupo_4
{
    partial class ConsultarHoteles
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
            datePickerFilterFechaDesde = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            datePickerFilterFechaHasta = new DateTimePicker();
            label6 = new Label();
            txtBoxPrecioHasta = new TextBox();
            label7 = new Label();
            txtBoxPrecioDesde = new TextBox();
            grp_Filtros = new GroupBox();
            labelCalificacion = new Label();
            comboBoxCalificacion = new ComboBox();
            labelTipoDeHabitacion = new Label();
            comboBoxTipoDeHabitacion = new ComboBox();
            labelCiudad = new Label();
            comboBoxCiudad = new ComboBox();
            btnDisableDatePickerFilterFechaHasta = new Button();
            btnDisableDatePickerFilterFechaDesde = new Button();
            btnLimpiarFiltro = new Common.Components.BotonEstilizado();
            buscarPresupuesto = new Common.Components.BotonEstilizado();
            btnVolverMenuGenerarPresupuestos = new Button();
            dataGridViewProductos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            FechaDesde = new DataGridViewTextBoxColumn();
            FechaHasta = new DataGridViewTextBoxColumn();
            Ciudad = new DataGridViewTextBoxColumn();
            TipoDeHabitación = new DataGridViewTextBoxColumn();
            Calificacion = new DataGridViewTextBoxColumn();
            CantidadDePersonas = new DataGridViewTextBoxColumn();
            grp_Filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // datePickerFilterFechaDesde
            // 
            datePickerFilterFechaDesde.Location = new Point(316, 56);
            datePickerFilterFechaDesde.MinDate = new DateTime(2023, 10, 7, 0, 0, 0, 0);
            datePickerFilterFechaDesde.Name = "datePickerFilterFechaDesde";
            datePickerFilterFechaDesde.Size = new Size(235, 23);
            datePickerFilterFechaDesde.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(316, 38);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 13;
            label4.Text = "Fecha Desde";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(576, 38);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 15;
            label5.Text = "Fecha Hasta";
            // 
            // datePickerFilterFechaHasta
            // 
            datePickerFilterFechaHasta.Location = new Point(576, 56);
            datePickerFilterFechaHasta.MinDate = new DateTime(2023, 10, 7, 0, 0, 0, 0);
            datePickerFilterFechaHasta.Name = "datePickerFilterFechaHasta";
            datePickerFilterFechaHasta.Size = new Size(232, 23);
            datePickerFilterFechaHasta.TabIndex = 14;
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
            // grp_Filtros
            // 
            grp_Filtros.Controls.Add(labelCalificacion);
            grp_Filtros.Controls.Add(comboBoxCalificacion);
            grp_Filtros.Controls.Add(labelTipoDeHabitacion);
            grp_Filtros.Controls.Add(comboBoxTipoDeHabitacion);
            grp_Filtros.Controls.Add(labelCiudad);
            grp_Filtros.Controls.Add(comboBoxCiudad);
            grp_Filtros.Controls.Add(btnDisableDatePickerFilterFechaHasta);
            grp_Filtros.Controls.Add(btnDisableDatePickerFilterFechaDesde);
            grp_Filtros.Controls.Add(label7);
            grp_Filtros.Controls.Add(datePickerFilterFechaDesde);
            grp_Filtros.Controls.Add(label4);
            grp_Filtros.Controls.Add(datePickerFilterFechaHasta);
            grp_Filtros.Controls.Add(label5);
            grp_Filtros.Controls.Add(txtBoxPrecioHasta);
            grp_Filtros.Controls.Add(label6);
            grp_Filtros.Controls.Add(txtBoxPrecioDesde);
            grp_Filtros.Location = new Point(27, 123);
            grp_Filtros.Name = "grp_Filtros";
            grp_Filtros.Size = new Size(830, 216);
            grp_Filtros.TabIndex = 35;
            grp_Filtros.TabStop = false;
            grp_Filtros.Text = "Filtros";
            // 
            // labelCalificacion
            // 
            labelCalificacion.AutoSize = true;
            labelCalificacion.Location = new Point(316, 140);
            labelCalificacion.Name = "labelCalificacion";
            labelCalificacion.Size = new Size(69, 15);
            labelCalificacion.TabIndex = 49;
            labelCalificacion.Text = "Calificación";
            // 
            // comboBoxCalificacion
            // 
            comboBoxCalificacion.FormattingEnabled = true;
            comboBoxCalificacion.Location = new Point(316, 158);
            comboBoxCalificacion.Name = "comboBoxCalificacion";
            comboBoxCalificacion.Size = new Size(126, 23);
            comboBoxCalificacion.TabIndex = 48;
            // 
            // labelTipoDeHabitacion
            // 
            labelTipoDeHabitacion.AutoSize = true;
            labelTipoDeHabitacion.Location = new Point(163, 140);
            labelTipoDeHabitacion.Name = "labelTipoDeHabitacion";
            labelTipoDeHabitacion.Size = new Size(107, 15);
            labelTipoDeHabitacion.TabIndex = 47;
            labelTipoDeHabitacion.Text = "Tipo de Habitación";
            // 
            // comboBoxTipoDeHabitacion
            // 
            comboBoxTipoDeHabitacion.FormattingEnabled = true;
            comboBoxTipoDeHabitacion.Location = new Point(163, 158);
            comboBoxTipoDeHabitacion.Name = "comboBoxTipoDeHabitacion";
            comboBoxTipoDeHabitacion.Size = new Size(126, 23);
            comboBoxTipoDeHabitacion.TabIndex = 46;
            // 
            // labelCiudad
            // 
            labelCiudad.AutoSize = true;
            labelCiudad.Location = new Point(18, 140);
            labelCiudad.Name = "labelCiudad";
            labelCiudad.Size = new Size(45, 15);
            labelCiudad.TabIndex = 45;
            labelCiudad.Text = "Ciudad";
            // 
            // comboBoxCiudad
            // 
            comboBoxCiudad.FormattingEnabled = true;
            comboBoxCiudad.Location = new Point(18, 158);
            comboBoxCiudad.Name = "comboBoxCiudad";
            comboBoxCiudad.Size = new Size(126, 23);
            comboBoxCiudad.TabIndex = 44;
            // 
            // btnDisableDatePickerFilterFechaHasta
            // 
            btnDisableDatePickerFilterFechaHasta.Location = new Point(576, 85);
            btnDisableDatePickerFilterFechaHasta.Name = "btnDisableDatePickerFilterFechaHasta";
            btnDisableDatePickerFilterFechaHasta.Size = new Size(80, 23);
            btnDisableDatePickerFilterFechaHasta.TabIndex = 39;
            btnDisableDatePickerFilterFechaHasta.Text = "Deshabilitar";
            btnDisableDatePickerFilterFechaHasta.UseVisualStyleBackColor = true;
            btnDisableDatePickerFilterFechaHasta.Click += btnDisableDatePickerFilterFechaHasta_Click;
            // 
            // btnDisableDatePickerFilterFechaDesde
            // 
            btnDisableDatePickerFilterFechaDesde.Location = new Point(316, 85);
            btnDisableDatePickerFilterFechaDesde.Name = "btnDisableDatePickerFilterFechaDesde";
            btnDisableDatePickerFilterFechaDesde.Size = new Size(80, 23);
            btnDisableDatePickerFilterFechaDesde.TabIndex = 38;
            btnDisableDatePickerFilterFechaDesde.Text = "Deshabilitar";
            btnDisableDatePickerFilterFechaDesde.UseVisualStyleBackColor = true;
            btnDisableDatePickerFilterFechaDesde.Click += btnDisableDatePickerFilterFechaDesde_Click;
            // 
            // btnLimpiarFiltro
            // 
            btnLimpiarFiltro.BackColor = Color.Transparent;
            btnLimpiarFiltro.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnLimpiarFiltro.FlatStyle = FlatStyle.Flat;
            btnLimpiarFiltro.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiarFiltro.ForeColor = Color.Black;
            btnLimpiarFiltro.Location = new Point(952, 201);
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
            buscarPresupuesto.Location = new Point(952, 131);
            buscarPresupuesto.Name = "buscarPresupuesto";
            buscarPresupuesto.Size = new Size(139, 40);
            buscarPresupuesto.TabIndex = 4;
            buscarPresupuesto.Text = "Buscar";
            buscarPresupuesto.UseVisualStyleBackColor = false;
            buscarPresupuesto.Click += btnBuscarProductos_Click;
            // 
            // btnVolverMenuGenerarPresupuestos
            // 
            btnVolverMenuGenerarPresupuestos.Location = new Point(27, 601);
            btnVolverMenuGenerarPresupuestos.Name = "btnVolverMenuGenerarPresupuestos";
            btnVolverMenuGenerarPresupuestos.Size = new Size(289, 47);
            btnVolverMenuGenerarPresupuestos.TabIndex = 37;
            btnVolverMenuGenerarPresupuestos.Text = "Volver";
            btnVolverMenuGenerarPresupuestos.UseVisualStyleBackColor = true;
            btnVolverMenuGenerarPresupuestos.Click += btnVolverMenuGenerarPresupuestos_Click;
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AllowUserToAddRows = false;
            dataGridViewProductos.AllowUserToDeleteRows = false;
            dataGridViewProductos.AllowUserToOrderColumns = true;
            dataGridViewProductos.BackgroundColor = SystemColors.ControlLight;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Columns.AddRange(new DataGridViewColumn[] { ID, Codigo, Nombre, PrecioUnitario, Cantidad, FechaDesde, FechaHasta, Ciudad, TipoDeHabitación, Calificacion, CantidadDePersonas });
            dataGridViewProductos.Location = new Point(27, 355);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersWidth = 82;
            dataGridViewProductos.RowTemplate.Height = 25;
            dataGridViewProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProductos.Size = new Size(1064, 229);
            dataGridViewProductos.TabIndex = 39;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 250;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 10;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 200;
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
            Cantidad.HeaderText = "Cantidad Disponible";
            Cantidad.MinimumWidth = 10;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 200;
            // 
            // FechaDesde
            // 
            FechaDesde.HeaderText = "Fecha Desde";
            FechaDesde.Name = "FechaDesde";
            FechaDesde.ReadOnly = true;
            // 
            // FechaHasta
            // 
            FechaHasta.HeaderText = "Fecha Hasta";
            FechaHasta.Name = "FechaHasta";
            FechaHasta.ReadOnly = true;
            // 
            // Ciudad
            // 
            Ciudad.HeaderText = "Ciudad";
            Ciudad.Name = "Ciudad";
            Ciudad.ReadOnly = true;
            // 
            // TipoDeHabitación
            // 
            TipoDeHabitación.HeaderText = "Tipo de Habitacion";
            TipoDeHabitación.Name = "TipoDeHabitación";
            TipoDeHabitación.ReadOnly = true;
            TipoDeHabitación.Width = 200;
            // 
            // Calificacion
            // 
            Calificacion.HeaderText = "Calificación";
            Calificacion.Name = "Calificacion";
            Calificacion.ReadOnly = true;
            // 
            // CantidadDePersonas
            // 
            CantidadDePersonas.HeaderText = "Cantidad de Personas";
            CantidadDePersonas.Name = "CantidadDePersonas";
            CantidadDePersonas.ReadOnly = true;
            CantidadDePersonas.Width = 200;
            // 
            // ConsultarHoteles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1106, 675);
            Controls.Add(dataGridViewProductos);
            Controls.Add(btnVolverMenuGenerarPresupuestos);
            Controls.Add(btnLimpiarFiltro);
            Controls.Add(grp_Filtros);
            Controls.Add(buscarPresupuesto);
            Name = "ConsultarHoteles";
            Text = "Generar Presupuesto - Aéreos";
            Load += GenerarPresupuestoAereos_Load;
            Controls.SetChildIndex(buscarPresupuesto, 0);
            Controls.SetChildIndex(grp_Filtros, 0);
            Controls.SetChildIndex(btnLimpiarFiltro, 0);
            Controls.SetChildIndex(btnVolverMenuGenerarPresupuestos, 0);
            Controls.SetChildIndex(dataGridViewProductos, 0);
            grp_Filtros.ResumeLayout(false);
            grp_Filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker datePickerFilterFechaDesde;
        private Label label4;
        private Label label5;
        private DateTimePicker datePickerFilterFechaHasta;
        private Label label6;
        private TextBox txtBoxPrecioHasta;
        private Label label7;
        private TextBox txtBoxPrecioDesde;
        private GroupBox grp_Filtros;
        private Common.Components.BotonEstilizado btnLimpiarFiltro;
        private Common.Components.BotonEstilizado buscarPresupuesto;
        private Button btnVolverMenuGenerarPresupuestos;
        private Button btnDisableDatePickerFilterFechaDesde;
        private Button btnDisableDatePickerFilterFechaHasta;
        private Label labelCiudad;
        private ComboBox comboBoxCiudad;
        private Label labelTipoDeHabitacion;
        private ComboBox comboBoxTipoDeHabitacion;
        private Label labelCalificacion;
        private ComboBox comboBoxCalificacion;
        private DataGridView dataGridViewProductos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn FechaDesde;
        private DataGridViewTextBoxColumn FechaHasta;
        private DataGridViewTextBoxColumn Ciudad;
        private DataGridViewTextBoxColumn TipoDeHabitación;
        private DataGridViewTextBoxColumn Calificacion;
        private DataGridViewTextBoxColumn CantidadDePersonas;
    }
}