﻿namespace Proyecto_CAI_Grupo_4
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
            datePickerFilterFechaDesde = new DateTimePicker();
            labelFiltroFechaDesde = new Label();
            labelFiltroFechaHasta = new Label();
            datePickerFilterFechaHasta = new DateTimePicker();
            labelFiltroPrecioHasta = new Label();
            txtBoxFiltroPrecioHasta = new TextBox();
            labelFiltroPrecioDesde = new Label();
            txtBoxFiltroPrecioDesde = new TextBox();
            grp_Filtros = new GroupBox();
            btnLimpiarFiltros = new Common.Components.BotonEstilizado();
            btnBuscarPresupuestos = new Common.Components.BotonEstilizado();
            btnAgregarProductos = new Common.Components.BotonEstilizado();
            btnRemoverProductos = new Common.Components.BotonEstilizado();
            btnConfirmarProductosSeleccionados = new Common.Components.BotonEstilizado();
            grp_VuelosDisponibles = new GroupBox();
            dataGridViewProductos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            FechaDesde = new DataGridViewTextBoxColumn();
            FechaHasta = new DataGridViewTextBoxColumn();
            Origen = new DataGridViewTextBoxColumn();
            Destino = new DataGridViewTextBoxColumn();
            Clase = new DataGridViewTextBoxColumn();
            grp_VuelosSeleccionados = new GroupBox();
            dataGridViewProductosSeleccionados = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            CantidadSeleccionada = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            btnVolverAlMenuGenerarPresupuestos = new Common.Components.BotonEstilizado();
            grp_Filtros.SuspendLayout();
            grp_VuelosDisponibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            grp_VuelosSeleccionados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductosSeleccionados).BeginInit();
            SuspendLayout();
            // 
            // datePickerFilterFechaDesde
            // 
            datePickerFilterFechaDesde.Location = new Point(18, 116);
            datePickerFilterFechaDesde.MinDate = new DateTime(2023, 10, 7, 0, 0, 0, 0);
            datePickerFilterFechaDesde.Name = "datePickerFilterFechaDesde";
            datePickerFilterFechaDesde.Size = new Size(271, 23);
            datePickerFilterFechaDesde.TabIndex = 12;
            // 
            // labelFiltroFechaDesde
            // 
            labelFiltroFechaDesde.AutoSize = true;
            labelFiltroFechaDesde.Location = new Point(18, 98);
            labelFiltroFechaDesde.Name = "labelFiltroFechaDesde";
            labelFiltroFechaDesde.Size = new Size(72, 15);
            labelFiltroFechaDesde.TabIndex = 13;
            labelFiltroFechaDesde.Text = "Fecha Salida";
            // 
            // labelFiltroFechaHasta
            // 
            labelFiltroFechaHasta.AutoSize = true;
            labelFiltroFechaHasta.Location = new Point(18, 161);
            labelFiltroFechaHasta.Name = "labelFiltroFechaHasta";
            labelFiltroFechaHasta.Size = new Size(82, 15);
            labelFiltroFechaHasta.TabIndex = 15;
            labelFiltroFechaHasta.Text = "Fecha Llegada";
            // 
            // datePickerFilterFechaHasta
            // 
            datePickerFilterFechaHasta.Location = new Point(18, 179);
            datePickerFilterFechaHasta.MinDate = new DateTime(2023, 10, 7, 0, 0, 0, 0);
            datePickerFilterFechaHasta.Name = "datePickerFilterFechaHasta";
            datePickerFilterFechaHasta.Size = new Size(271, 23);
            datePickerFilterFechaHasta.TabIndex = 14;
            // 
            // labelFiltroPrecioHasta
            // 
            labelFiltroPrecioHasta.AutoSize = true;
            labelFiltroPrecioHasta.Location = new Point(163, 38);
            labelFiltroPrecioHasta.Name = "labelFiltroPrecioHasta";
            labelFiltroPrecioHasta.Size = new Size(73, 15);
            labelFiltroPrecioHasta.TabIndex = 17;
            labelFiltroPrecioHasta.Text = "Precio Hasta";
            // 
            // txtBoxFiltroPrecioHasta
            // 
            txtBoxFiltroPrecioHasta.Location = new Point(163, 56);
            txtBoxFiltroPrecioHasta.Name = "txtBoxFiltroPrecioHasta";
            txtBoxFiltroPrecioHasta.Size = new Size(126, 23);
            txtBoxFiltroPrecioHasta.TabIndex = 16;
            // 
            // labelFiltroPrecioDesde
            // 
            labelFiltroPrecioDesde.AutoSize = true;
            labelFiltroPrecioDesde.Location = new Point(18, 38);
            labelFiltroPrecioDesde.Name = "labelFiltroPrecioDesde";
            labelFiltroPrecioDesde.Size = new Size(75, 15);
            labelFiltroPrecioDesde.TabIndex = 19;
            labelFiltroPrecioDesde.Text = "Precio Desde";
            // 
            // txtBoxFiltroPrecioDesde
            // 
            txtBoxFiltroPrecioDesde.Location = new Point(18, 56);
            txtBoxFiltroPrecioDesde.Name = "txtBoxFiltroPrecioDesde";
            txtBoxFiltroPrecioDesde.Size = new Size(126, 23);
            txtBoxFiltroPrecioDesde.TabIndex = 18;
            // 
            // grp_Filtros
            // 
            grp_Filtros.Controls.Add(btnLimpiarFiltros);
            grp_Filtros.Controls.Add(labelFiltroPrecioDesde);
            grp_Filtros.Controls.Add(btnBuscarPresupuestos);
            grp_Filtros.Controls.Add(datePickerFilterFechaDesde);
            grp_Filtros.Controls.Add(labelFiltroFechaDesde);
            grp_Filtros.Controls.Add(datePickerFilterFechaHasta);
            grp_Filtros.Controls.Add(labelFiltroFechaHasta);
            grp_Filtros.Controls.Add(txtBoxFiltroPrecioHasta);
            grp_Filtros.Controls.Add(labelFiltroPrecioHasta);
            grp_Filtros.Controls.Add(txtBoxFiltroPrecioDesde);
            grp_Filtros.Location = new Point(27, 131);
            grp_Filtros.Name = "grp_Filtros";
            grp_Filtros.Size = new Size(322, 278);
            grp_Filtros.TabIndex = 35;
            grp_Filtros.TabStop = false;
            grp_Filtros.Text = "Filtros";
            // 
            // btnLimpiarFiltros
            // 
            btnLimpiarFiltros.BackColor = Color.Transparent;
            btnLimpiarFiltros.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnLimpiarFiltros.FlatStyle = FlatStyle.Flat;
            btnLimpiarFiltros.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiarFiltros.ForeColor = Color.Black;
            btnLimpiarFiltros.Location = new Point(163, 220);
            btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            btnLimpiarFiltros.Size = new Size(139, 40);
            btnLimpiarFiltros.TabIndex = 4;
            btnLimpiarFiltros.Text = "Limpiar";
            btnLimpiarFiltros.UseVisualStyleBackColor = false;
            btnLimpiarFiltros.Click += btnLimpiarFiltro_Click;
            // 
            // btnBuscarPresupuestos
            // 
            btnBuscarPresupuestos.BackColor = Color.Transparent;
            btnBuscarPresupuestos.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnBuscarPresupuestos.FlatStyle = FlatStyle.Flat;
            btnBuscarPresupuestos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarPresupuestos.ForeColor = Color.Black;
            btnBuscarPresupuestos.Location = new Point(18, 220);
            btnBuscarPresupuestos.Name = "btnBuscarPresupuestos";
            btnBuscarPresupuestos.Size = new Size(139, 40);
            btnBuscarPresupuestos.TabIndex = 4;
            btnBuscarPresupuestos.Text = "Buscar";
            btnBuscarPresupuestos.UseVisualStyleBackColor = false;
            btnBuscarPresupuestos.Click += btnBuscarProductos_Click;
            // 
            // btnAgregarProductos
            // 
            btnAgregarProductos.BackColor = Color.Transparent;
            btnAgregarProductos.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnAgregarProductos.FlatStyle = FlatStyle.Flat;
            btnAgregarProductos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarProductos.ForeColor = Color.Black;
            btnAgregarProductos.Location = new Point(6, 222);
            btnAgregarProductos.Name = "btnAgregarProductos";
            btnAgregarProductos.Size = new Size(964, 40);
            btnAgregarProductos.TabIndex = 4;
            btnAgregarProductos.Text = "Agregar";
            btnAgregarProductos.UseVisualStyleBackColor = false;
            btnAgregarProductos.Click += btnAgregarProductos_Click;
            // 
            // btnRemoverProductos
            // 
            btnRemoverProductos.BackColor = Color.Transparent;
            btnRemoverProductos.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnRemoverProductos.FlatStyle = FlatStyle.Flat;
            btnRemoverProductos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoverProductos.ForeColor = Color.Black;
            btnRemoverProductos.Location = new Point(6, 222);
            btnRemoverProductos.Name = "btnRemoverProductos";
            btnRemoverProductos.Size = new Size(479, 40);
            btnRemoverProductos.TabIndex = 4;
            btnRemoverProductos.Text = "Quitar";
            btnRemoverProductos.UseVisualStyleBackColor = false;
            btnRemoverProductos.Click += btnRemoverProductos_Click;
            // 
            // btnConfirmarProductosSeleccionados
            // 
            btnConfirmarProductosSeleccionados.BackColor = Color.Transparent;
            btnConfirmarProductosSeleccionados.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnConfirmarProductosSeleccionados.FlatStyle = FlatStyle.Flat;
            btnConfirmarProductosSeleccionados.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmarProductosSeleccionados.ForeColor = Color.Black;
            btnConfirmarProductosSeleccionados.Location = new Point(491, 222);
            btnConfirmarProductosSeleccionados.Name = "btnConfirmarProductosSeleccionados";
            btnConfirmarProductosSeleccionados.Size = new Size(479, 40);
            btnConfirmarProductosSeleccionados.TabIndex = 4;
            btnConfirmarProductosSeleccionados.Text = "Confirmar";
            btnConfirmarProductosSeleccionados.UseVisualStyleBackColor = false;
            btnConfirmarProductosSeleccionados.Click += btnConfirmarProductosSeleccionados_Click;
            // 
            // grp_VuelosDisponibles
            // 
            grp_VuelosDisponibles.Controls.Add(dataGridViewProductos);
            grp_VuelosDisponibles.Controls.Add(btnAgregarProductos);
            grp_VuelosDisponibles.Location = new Point(376, 131);
            grp_VuelosDisponibles.Name = "grp_VuelosDisponibles";
            grp_VuelosDisponibles.Size = new Size(976, 278);
            grp_VuelosDisponibles.TabIndex = 36;
            grp_VuelosDisponibles.TabStop = false;
            grp_VuelosDisponibles.Text = "Vuelos Disponibles";
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AllowUserToAddRows = false;
            dataGridViewProductos.AllowUserToDeleteRows = false;
            dataGridViewProductos.AllowUserToOrderColumns = true;
            dataGridViewProductos.BackgroundColor = SystemColors.ControlLight;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, PrecioUnitario, Cantidad, FechaDesde, FechaHasta, Origen, Destino, Clase });
            dataGridViewProductos.Location = new Point(6, 22);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersWidth = 82;
            dataGridViewProductos.RowTemplate.Height = 25;
            dataGridViewProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProductos.Size = new Size(964, 194);
            dataGridViewProductos.TabIndex = 38;
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
            FechaDesde.HeaderText = "Fecha Salida";
            FechaDesde.Name = "FechaDesde";
            FechaDesde.ReadOnly = true;
            // 
            // FechaHasta
            // 
            FechaHasta.HeaderText = "Fecha Llegada";
            FechaHasta.Name = "FechaHasta";
            FechaHasta.ReadOnly = true;
            FechaHasta.Width = 200;
            // 
            // Origen
            // 
            Origen.HeaderText = "Origen";
            Origen.Name = "Origen";
            Origen.ReadOnly = true;
            // 
            // Destino
            // 
            Destino.HeaderText = "Destino";
            Destino.Name = "Destino";
            Destino.ReadOnly = true;
            // 
            // Clase
            // 
            Clase.HeaderText = "Clase";
            Clase.Name = "Clase";
            Clase.ReadOnly = true;
            // 
            // grp_VuelosSeleccionados
            // 
            grp_VuelosSeleccionados.Controls.Add(dataGridViewProductosSeleccionados);
            grp_VuelosSeleccionados.Controls.Add(btnRemoverProductos);
            grp_VuelosSeleccionados.Controls.Add(btnConfirmarProductosSeleccionados);
            grp_VuelosSeleccionados.Location = new Point(376, 422);
            grp_VuelosSeleccionados.Name = "grp_VuelosSeleccionados";
            grp_VuelosSeleccionados.Size = new Size(976, 269);
            grp_VuelosSeleccionados.TabIndex = 37;
            grp_VuelosSeleccionados.TabStop = false;
            grp_VuelosSeleccionados.Text = "Vuelos Seleccionados";
            // 
            // dataGridViewProductosSeleccionados
            // 
            dataGridViewProductosSeleccionados.AllowUserToAddRows = false;
            dataGridViewProductosSeleccionados.AllowUserToDeleteRows = false;
            dataGridViewProductosSeleccionados.AllowUserToOrderColumns = true;
            dataGridViewProductosSeleccionados.BackgroundColor = SystemColors.ControlLight;
            dataGridViewProductosSeleccionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductosSeleccionados.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, CantidadSeleccionada, SubTotal, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
            dataGridViewProductosSeleccionados.Location = new Point(6, 22);
            dataGridViewProductosSeleccionados.Name = "dataGridViewProductosSeleccionados";
            dataGridViewProductosSeleccionados.RowHeadersWidth = 82;
            dataGridViewProductosSeleccionados.RowTemplate.Height = 25;
            dataGridViewProductosSeleccionados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProductosSeleccionados.Size = new Size(964, 194);
            dataGridViewProductosSeleccionados.TabIndex = 39;
            dataGridViewProductosSeleccionados.CellValueChanged += dataGridViewProductosSeleccionados_CellValueChanged;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 10;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            dataGridViewTextBoxColumn2.MinimumWidth = 10;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Precio Unitario";
            dataGridViewTextBoxColumn3.MinimumWidth = 10;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Cantidad Disponible";
            dataGridViewTextBoxColumn4.MinimumWidth = 10;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 200;
            // 
            // CantidadSeleccionada
            // 
            CantidadSeleccionada.HeaderText = "Cantidad Seleccionada";
            CantidadSeleccionada.Name = "CantidadSeleccionada";
            CantidadSeleccionada.Width = 200;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Sub Total";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Fecha Salida";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Fecha Llegada";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Origen";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Destino";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Clase";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // btnVolverAlMenuGenerarPresupuestos
            // 
            btnVolverAlMenuGenerarPresupuestos.BackColor = Color.Transparent;
            btnVolverAlMenuGenerarPresupuestos.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnVolverAlMenuGenerarPresupuestos.FlatStyle = FlatStyle.Flat;
            btnVolverAlMenuGenerarPresupuestos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolverAlMenuGenerarPresupuestos.ForeColor = Color.Black;
            btnVolverAlMenuGenerarPresupuestos.Location = new Point(27, 422);
            btnVolverAlMenuGenerarPresupuestos.Name = "btnVolverAlMenuGenerarPresupuestos";
            btnVolverAlMenuGenerarPresupuestos.Size = new Size(322, 47);
            btnVolverAlMenuGenerarPresupuestos.TabIndex = 43;
            btnVolverAlMenuGenerarPresupuestos.Text = "Volver";
            btnVolverAlMenuGenerarPresupuestos.UseVisualStyleBackColor = false;
            btnVolverAlMenuGenerarPresupuestos.Click += btnVolverAlMenuGenerarPresupuestos_Click;
            // 
            // GenerarPresupuestoAereos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1364, 721);
            Controls.Add(btnVolverAlMenuGenerarPresupuestos);
            Controls.Add(grp_VuelosSeleccionados);
            Controls.Add(grp_VuelosDisponibles);
            Controls.Add(grp_Filtros);
            Name = "GenerarPresupuestoAereos";
            Text = "Generar Presupuesto - Aéreos";
            Load += GenerarPresupuestoAereos_Load;
            Controls.SetChildIndex(grp_Filtros, 0);
            Controls.SetChildIndex(grp_VuelosDisponibles, 0);
            Controls.SetChildIndex(grp_VuelosSeleccionados, 0);
            Controls.SetChildIndex(btnVolverAlMenuGenerarPresupuestos, 0);
            grp_Filtros.ResumeLayout(false);
            grp_Filtros.PerformLayout();
            grp_VuelosDisponibles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            grp_VuelosSeleccionados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductosSeleccionados).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker datePickerFilterFechaDesde;
        private Label labelFiltroFechaDesde;
        private Label labelFiltroFechaHasta;
        private DateTimePicker datePickerFilterFechaHasta;
        private Label labelFiltroPrecioHasta;
        private TextBox txtBoxFiltroPrecioHasta;
        private Label labelFiltroPrecioDesde;
        private TextBox txtBoxFiltroPrecioDesde;
        private GroupBox grp_Filtros;
        private Common.Components.BotonEstilizado btnLimpiarFiltros;
        private Common.Components.BotonEstilizado btnBuscarPresupuestos;
        private Common.Components.BotonEstilizado btnAgregarProductos;
        private Common.Components.BotonEstilizado btnRemoverProductos;
        private Common.Components.BotonEstilizado btnConfirmarProductosSeleccionados;
        private GroupBox grp_VuelosDisponibles;
        private GroupBox grp_VuelosSeleccionados;
        private DataGridView dataGridViewProductos;
        private DataGridView dataGridViewProductosSeleccionados;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn FechaDesde;
        private DataGridViewTextBoxColumn FechaHasta;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Destino;
        private DataGridViewTextBoxColumn Clase;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn CantidadSeleccionada;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private Common.Components.BotonEstilizado btnVolverAlMenuGenerarPresupuestos;
    }
}