namespace Proyecto_CAI_Grupo_4
{
    partial class ConsultarCruceros
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
            grp_Filtros = new GroupBox();
            labelTipoDeCamarote = new Label();
            comboBoxTipoDeCamarote = new ComboBox();
            labelDestino = new Label();
            labelOrigen = new Label();
            comboBoxDestino = new ComboBox();
            comboBoxOrigen = new ComboBox();
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
            Origen = new DataGridViewTextBoxColumn();
            Destino = new DataGridViewTextBoxColumn();
            TipoDeCamarote = new DataGridViewTextBoxColumn();
            Paradas = new DataGridViewTextBoxColumn();
            grp_Filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // datePickerFechaSalida
            // 
            datePickerFechaSalida.Location = new Point(316, 56);
            datePickerFechaSalida.MinDate = new DateTime(2023, 10, 7, 0, 0, 0, 0);
            datePickerFechaSalida.Name = "datePickerFechaSalida";
            datePickerFechaSalida.Size = new Size(235, 23);
            datePickerFechaSalida.TabIndex = 12;
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
            // datePickerFechaLlegada
            // 
            datePickerFechaLlegada.Location = new Point(576, 56);
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
            // grp_Filtros
            // 
            grp_Filtros.Controls.Add(labelTipoDeCamarote);
            grp_Filtros.Controls.Add(comboBoxTipoDeCamarote);
            grp_Filtros.Controls.Add(labelDestino);
            grp_Filtros.Controls.Add(labelOrigen);
            grp_Filtros.Controls.Add(comboBoxDestino);
            grp_Filtros.Controls.Add(comboBoxOrigen);
            grp_Filtros.Controls.Add(btnDisableDatePickerFilterFechaHasta);
            grp_Filtros.Controls.Add(btnDisableDatePickerFilterFechaDesde);
            grp_Filtros.Controls.Add(label7);
            grp_Filtros.Controls.Add(datePickerFechaSalida);
            grp_Filtros.Controls.Add(label4);
            grp_Filtros.Controls.Add(datePickerFechaLlegada);
            grp_Filtros.Controls.Add(label5);
            grp_Filtros.Controls.Add(txtBoxPrecioHasta);
            grp_Filtros.Controls.Add(label6);
            grp_Filtros.Controls.Add(txtBoxPrecioDesde);
            grp_Filtros.Location = new Point(27, 123);
            grp_Filtros.Name = "grp_Filtros";
            grp_Filtros.Size = new Size(830, 199);
            grp_Filtros.TabIndex = 35;
            grp_Filtros.TabStop = false;
            grp_Filtros.Text = "Filtros";
            // 
            // labelTipoDeCamarote
            // 
            labelTipoDeCamarote.AutoSize = true;
            labelTipoDeCamarote.Location = new Point(316, 125);
            labelTipoDeCamarote.Name = "labelTipoDeCamarote";
            labelTipoDeCamarote.Size = new Size(101, 15);
            labelTipoDeCamarote.TabIndex = 39;
            labelTipoDeCamarote.Text = "Tipo de Camarote";
            // 
            // comboBoxTipoDeCamarote
            // 
            comboBoxTipoDeCamarote.FormattingEnabled = true;
            comboBoxTipoDeCamarote.Location = new Point(316, 143);
            comboBoxTipoDeCamarote.Name = "comboBoxTipoDeCamarote";
            comboBoxTipoDeCamarote.Size = new Size(126, 23);
            comboBoxTipoDeCamarote.TabIndex = 38;
            // 
            // labelDestino
            // 
            labelDestino.AutoSize = true;
            labelDestino.Location = new Point(163, 125);
            labelDestino.Name = "labelDestino";
            labelDestino.Size = new Size(105, 15);
            labelDestino.TabIndex = 31;
            labelDestino.Text = "Ciudad de Llegada";
            // 
            // labelOrigen
            // 
            labelOrigen.AutoSize = true;
            labelOrigen.Location = new Point(18, 125);
            labelOrigen.Name = "labelOrigen";
            labelOrigen.Size = new Size(101, 15);
            labelOrigen.TabIndex = 30;
            labelOrigen.Text = "Ciudad de Partida";
            // 
            // comboBoxDestino
            // 
            comboBoxDestino.FormattingEnabled = true;
            comboBoxDestino.Location = new Point(163, 143);
            comboBoxDestino.Name = "comboBoxDestino";
            comboBoxDestino.Size = new Size(126, 23);
            comboBoxDestino.TabIndex = 29;
            // 
            // comboBoxOrigen
            // 
            comboBoxOrigen.FormattingEnabled = true;
            comboBoxOrigen.Location = new Point(18, 143);
            comboBoxOrigen.Name = "comboBoxOrigen";
            comboBoxOrigen.Size = new Size(126, 23);
            comboBoxOrigen.TabIndex = 28;
            // 
            // btnDisableDatePickerFilterFechaHasta
            // 
            btnDisableDatePickerFilterFechaHasta.Location = new Point(576, 85);
            btnDisableDatePickerFilterFechaHasta.Name = "btnDisableDatePickerFilterFechaHasta";
            btnDisableDatePickerFilterFechaHasta.Size = new Size(80, 23);
            btnDisableDatePickerFilterFechaHasta.TabIndex = 27;
            btnDisableDatePickerFilterFechaHasta.Text = "Deshabilitar";
            btnDisableDatePickerFilterFechaHasta.UseVisualStyleBackColor = true;
            btnDisableDatePickerFilterFechaHasta.Click += btnDisableDatePickerFilterFechaHasta_Click;
            // 
            // btnDisableDatePickerFilterFechaDesde
            // 
            btnDisableDatePickerFilterFechaDesde.Location = new Point(316, 85);
            btnDisableDatePickerFilterFechaDesde.Name = "btnDisableDatePickerFilterFechaDesde";
            btnDisableDatePickerFilterFechaDesde.Size = new Size(80, 23);
            btnDisableDatePickerFilterFechaDesde.TabIndex = 26;
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
            btnVolverMenuGenerarPresupuestos.Location = new Point(27, 610);
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
            dataGridViewProductos.Columns.AddRange(new DataGridViewColumn[] { ID, Codigo, Nombre, PrecioUnitario, Cantidad, FechaDesde, FechaHasta, Origen, Destino, TipoDeCamarote, Paradas });
            dataGridViewProductos.Location = new Point(27, 337);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersWidth = 82;
            dataGridViewProductos.RowTemplate.Height = 25;
            dataGridViewProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProductos.Size = new Size(1064, 254);
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
            // Origen
            // 
            Origen.HeaderText = "Ciudad de Partida";
            Origen.Name = "Origen";
            Origen.ReadOnly = true;
            Origen.Width = 200;
            // 
            // Destino
            // 
            Destino.HeaderText = "Ciudad de Llegada";
            Destino.Name = "Destino";
            Destino.ReadOnly = true;
            Destino.Width = 200;
            // 
            // TipoDeCamarote
            // 
            TipoDeCamarote.HeaderText = "Tipo de Camarote";
            TipoDeCamarote.Name = "TipoDeCamarote";
            TipoDeCamarote.ReadOnly = true;
            TipoDeCamarote.Width = 200;
            // 
            // Paradas
            // 
            Paradas.HeaderText = "Paradas";
            Paradas.Name = "Paradas";
            Paradas.ReadOnly = true;
            Paradas.Width = 200;
            // 
            // ConsultarCruceros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1106, 669);
            Controls.Add(dataGridViewProductos);
            Controls.Add(btnVolverMenuGenerarPresupuestos);
            Controls.Add(btnLimpiarFiltro);
            Controls.Add(grp_Filtros);
            Controls.Add(buscarPresupuesto);
            Name = "ConsultarCruceros";
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
        private DateTimePicker datePickerFechaSalida;
        private Label label4;
        private Label label5;
        private DateTimePicker datePickerFechaLlegada;
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
        private ComboBox comboBoxOrigen;
        private ComboBox comboBoxDestino;
        private Label labelOrigen;
        private Label labelDestino;
        private Label labelTipoDeCamarote;
        private ComboBox comboBoxTipoDeCamarote;
        private DataGridView dataGridViewProductos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn FechaDesde;
        private DataGridViewTextBoxColumn FechaHasta;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Destino;
        private DataGridViewTextBoxColumn TipoDeCamarote;
        private DataGridViewTextBoxColumn Paradas;
    }
}