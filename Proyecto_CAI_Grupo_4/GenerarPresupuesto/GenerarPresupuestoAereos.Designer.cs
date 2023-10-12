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
            btnAgregarProductos = new Common.Components.BotonEstilizado();
            btnRemoverProductos = new Common.Components.BotonEstilizado();
            btnConfirmarProductosSeleccionados = new Common.Components.BotonEstilizado();
            grp_VuelosDisponibles = new GroupBox();
            dataGridViewProductos = new DataGridView();
            grp_VuelosSeleccionados = new GroupBox();
            dataGridViewProductosSeleccionados = new DataGridView();
            btnVolverAlMenuGenerarPresupuestos = new Common.Components.BotonEstilizado();
            grp_Filtros = new GroupBox();
            btnDisableDatePickerFilterFechaDesde = new Button();
            btnDisableDatePickerFilterFechaHasta = new Button();
            labelDestino = new Label();
            comboBoxDestino = new ComboBox();
            labelOrigen = new Label();
            comboBoxOrigen = new ComboBox();
            btnLimpiarFiltro = new Common.Components.BotonEstilizado();
            labelFiltroPrecioDesde = new Label();
            btnBuscarProductos = new Common.Components.BotonEstilizado();
            datePickerFilterFechaDesde = new DateTimePicker();
            labelFiltroFechaDesde = new Label();
            datePickerFilterFechaHasta = new DateTimePicker();
            labelFiltroFechaHasta = new Label();
            txtBoxFiltroPrecioHasta = new TextBox();
            labelFiltroPrecioHasta = new Label();
            txtBoxFiltroPrecioDesde = new TextBox();
            ID = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            PrecioUnitarioAdulto = new DataGridViewTextBoxColumn();
            PrecioUnitarioMenor = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            FechaDesde = new DataGridViewTextBoxColumn();
            FechaHasta = new DataGridViewTextBoxColumn();
            Aerolinea = new DataGridViewTextBoxColumn();
            Origen = new DataGridViewTextBoxColumn();
            Destino = new DataGridViewTextBoxColumn();
            Clase = new DataGridViewTextBoxColumn();
            Paradas = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            PrecioUnitarioMenores = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            CantidadSeleccionadaAdulto = new DataGridViewTextBoxColumn();
            CantidadSeleccionadaMenores = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            grp_VuelosDisponibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            grp_VuelosSeleccionados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductosSeleccionados).BeginInit();
            grp_Filtros.SuspendLayout();
            SuspendLayout();
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
            dataGridViewProductos.Columns.AddRange(new DataGridViewColumn[] { ID, Codigo, Nombre, PrecioUnitarioAdulto, PrecioUnitarioMenor, Cantidad, FechaDesde, FechaHasta, Aerolinea, Origen, Destino, Clase, Paradas });
            dataGridViewProductos.Location = new Point(6, 22);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersWidth = 82;
            dataGridViewProductos.RowTemplate.Height = 25;
            dataGridViewProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProductos.Size = new Size(964, 194);
            dataGridViewProductos.TabIndex = 38;
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
            dataGridViewProductosSeleccionados.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Column1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, PrecioUnitarioMenores, dataGridViewTextBoxColumn4, CantidadSeleccionadaAdulto, CantidadSeleccionadaMenores, SubTotal, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, Column3, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, Column2 });
            dataGridViewProductosSeleccionados.Location = new Point(6, 22);
            dataGridViewProductosSeleccionados.Name = "dataGridViewProductosSeleccionados";
            dataGridViewProductosSeleccionados.RowHeadersWidth = 82;
            dataGridViewProductosSeleccionados.RowTemplate.Height = 25;
            dataGridViewProductosSeleccionados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProductosSeleccionados.Size = new Size(964, 194);
            dataGridViewProductosSeleccionados.TabIndex = 39;
            dataGridViewProductosSeleccionados.CellValueChanged += dataGridViewProductosSeleccionados_CellValueChanged;
            // 
            // btnVolverAlMenuGenerarPresupuestos
            // 
            btnVolverAlMenuGenerarPresupuestos.BackColor = Color.Transparent;
            btnVolverAlMenuGenerarPresupuestos.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnVolverAlMenuGenerarPresupuestos.FlatStyle = FlatStyle.Flat;
            btnVolverAlMenuGenerarPresupuestos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolverAlMenuGenerarPresupuestos.ForeColor = Color.Black;
            btnVolverAlMenuGenerarPresupuestos.Location = new Point(24, 648);
            btnVolverAlMenuGenerarPresupuestos.Name = "btnVolverAlMenuGenerarPresupuestos";
            btnVolverAlMenuGenerarPresupuestos.Size = new Size(322, 47);
            btnVolverAlMenuGenerarPresupuestos.TabIndex = 43;
            btnVolverAlMenuGenerarPresupuestos.Text = "Volver";
            btnVolverAlMenuGenerarPresupuestos.UseVisualStyleBackColor = false;
            btnVolverAlMenuGenerarPresupuestos.Click += btnVolverAlMenuGenerarPresupuestos_Click;
            // 
            // grp_Filtros
            // 
            grp_Filtros.Controls.Add(btnDisableDatePickerFilterFechaDesde);
            grp_Filtros.Controls.Add(btnDisableDatePickerFilterFechaHasta);
            grp_Filtros.Controls.Add(labelDestino);
            grp_Filtros.Controls.Add(comboBoxDestino);
            grp_Filtros.Controls.Add(labelOrigen);
            grp_Filtros.Controls.Add(comboBoxOrigen);
            grp_Filtros.Controls.Add(btnLimpiarFiltro);
            grp_Filtros.Controls.Add(labelFiltroPrecioDesde);
            grp_Filtros.Controls.Add(btnBuscarProductos);
            grp_Filtros.Controls.Add(datePickerFilterFechaDesde);
            grp_Filtros.Controls.Add(labelFiltroFechaDesde);
            grp_Filtros.Controls.Add(datePickerFilterFechaHasta);
            grp_Filtros.Controls.Add(labelFiltroFechaHasta);
            grp_Filtros.Controls.Add(txtBoxFiltroPrecioHasta);
            grp_Filtros.Controls.Add(labelFiltroPrecioHasta);
            grp_Filtros.Controls.Add(txtBoxFiltroPrecioDesde);
            grp_Filtros.Location = new Point(27, 138);
            grp_Filtros.Name = "grp_Filtros";
            grp_Filtros.Size = new Size(319, 500);
            grp_Filtros.TabIndex = 44;
            grp_Filtros.TabStop = false;
            grp_Filtros.Text = "Filtros";
            // 
            // btnDisableDatePickerFilterFechaDesde
            // 
            btnDisableDatePickerFilterFechaDesde.Location = new Point(18, 145);
            btnDisableDatePickerFilterFechaDesde.Name = "btnDisableDatePickerFilterFechaDesde";
            btnDisableDatePickerFilterFechaDesde.Size = new Size(80, 23);
            btnDisableDatePickerFilterFechaDesde.TabIndex = 25;
            btnDisableDatePickerFilterFechaDesde.Text = "Deshabilitar";
            btnDisableDatePickerFilterFechaDesde.UseVisualStyleBackColor = true;
            btnDisableDatePickerFilterFechaDesde.Click += btnDisableDatePickerFilterFechaDesde_Click;
            // 
            // btnDisableDatePickerFilterFechaHasta
            // 
            btnDisableDatePickerFilterFechaHasta.Location = new Point(18, 235);
            btnDisableDatePickerFilterFechaHasta.Name = "btnDisableDatePickerFilterFechaHasta";
            btnDisableDatePickerFilterFechaHasta.Size = new Size(80, 23);
            btnDisableDatePickerFilterFechaHasta.TabIndex = 24;
            btnDisableDatePickerFilterFechaHasta.Text = "Deshabilitar";
            btnDisableDatePickerFilterFechaHasta.UseVisualStyleBackColor = true;
            btnDisableDatePickerFilterFechaHasta.Click += btnDisableDatePickerFilterFechaHasta_Click;
            // 
            // labelDestino
            // 
            labelDestino.AutoSize = true;
            labelDestino.Location = new Point(163, 273);
            labelDestino.Name = "labelDestino";
            labelDestino.Size = new Size(47, 15);
            labelDestino.TabIndex = 23;
            labelDestino.Text = "Destino";
            // 
            // comboBoxDestino
            // 
            comboBoxDestino.FormattingEnabled = true;
            comboBoxDestino.Location = new Point(163, 291);
            comboBoxDestino.Name = "comboBoxDestino";
            comboBoxDestino.Size = new Size(126, 23);
            comboBoxDestino.TabIndex = 22;
            // 
            // labelOrigen
            // 
            labelOrigen.AutoSize = true;
            labelOrigen.Location = new Point(18, 273);
            labelOrigen.Name = "labelOrigen";
            labelOrigen.Size = new Size(43, 15);
            labelOrigen.TabIndex = 21;
            labelOrigen.Text = "Origen";
            // 
            // comboBoxOrigen
            // 
            comboBoxOrigen.FormattingEnabled = true;
            comboBoxOrigen.Location = new Point(18, 291);
            comboBoxOrigen.Name = "comboBoxOrigen";
            comboBoxOrigen.Size = new Size(126, 23);
            comboBoxOrigen.TabIndex = 20;
            // 
            // btnLimpiarFiltro
            // 
            btnLimpiarFiltro.BackColor = Color.Transparent;
            btnLimpiarFiltro.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnLimpiarFiltro.FlatStyle = FlatStyle.Flat;
            btnLimpiarFiltro.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiarFiltro.ForeColor = Color.Black;
            btnLimpiarFiltro.Location = new Point(163, 364);
            btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            btnLimpiarFiltro.Size = new Size(139, 40);
            btnLimpiarFiltro.TabIndex = 4;
            btnLimpiarFiltro.Text = "Limpiar";
            btnLimpiarFiltro.UseVisualStyleBackColor = false;
            btnLimpiarFiltro.Click += btnLimpiarFiltro_Click;
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
            // btnBuscarProductos
            // 
            btnBuscarProductos.BackColor = Color.Transparent;
            btnBuscarProductos.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnBuscarProductos.FlatStyle = FlatStyle.Flat;
            btnBuscarProductos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarProductos.ForeColor = Color.Black;
            btnBuscarProductos.Location = new Point(18, 364);
            btnBuscarProductos.Name = "btnBuscarProductos";
            btnBuscarProductos.Size = new Size(139, 40);
            btnBuscarProductos.TabIndex = 4;
            btnBuscarProductos.Text = "Buscar";
            btnBuscarProductos.UseVisualStyleBackColor = false;
            btnBuscarProductos.Click += btnBuscarProductos_Click;
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
            labelFiltroFechaDesde.Size = new Size(73, 15);
            labelFiltroFechaDesde.TabIndex = 13;
            labelFiltroFechaDesde.Text = "Fecha Desde";
            // 
            // datePickerFilterFechaHasta
            // 
            datePickerFilterFechaHasta.Location = new Point(18, 206);
            datePickerFilterFechaHasta.MinDate = new DateTime(2023, 10, 7, 0, 0, 0, 0);
            datePickerFilterFechaHasta.Name = "datePickerFilterFechaHasta";
            datePickerFilterFechaHasta.Size = new Size(271, 23);
            datePickerFilterFechaHasta.TabIndex = 14;
            // 
            // labelFiltroFechaHasta
            // 
            labelFiltroFechaHasta.AutoSize = true;
            labelFiltroFechaHasta.Location = new Point(18, 188);
            labelFiltroFechaHasta.Name = "labelFiltroFechaHasta";
            labelFiltroFechaHasta.Size = new Size(71, 15);
            labelFiltroFechaHasta.TabIndex = 15;
            labelFiltroFechaHasta.Text = "Fecha Hasta";
            // 
            // txtBoxFiltroPrecioHasta
            // 
            txtBoxFiltroPrecioHasta.Location = new Point(163, 56);
            txtBoxFiltroPrecioHasta.Name = "txtBoxFiltroPrecioHasta";
            txtBoxFiltroPrecioHasta.Size = new Size(126, 23);
            txtBoxFiltroPrecioHasta.TabIndex = 16;
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
            // txtBoxFiltroPrecioDesde
            // 
            txtBoxFiltroPrecioDesde.Location = new Point(18, 56);
            txtBoxFiltroPrecioDesde.Name = "txtBoxFiltroPrecioDesde";
            txtBoxFiltroPrecioDesde.Size = new Size(126, 23);
            txtBoxFiltroPrecioDesde.TabIndex = 18;
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
            // PrecioUnitarioAdulto
            // 
            PrecioUnitarioAdulto.HeaderText = "Precio Unitario Adultos";
            PrecioUnitarioAdulto.MinimumWidth = 10;
            PrecioUnitarioAdulto.Name = "PrecioUnitarioAdulto";
            PrecioUnitarioAdulto.ReadOnly = true;
            PrecioUnitarioAdulto.Width = 200;
            // 
            // PrecioUnitarioMenor
            // 
            PrecioUnitarioMenor.HeaderText = "Precio Unitario Menores";
            PrecioUnitarioMenor.Name = "PrecioUnitarioMenor";
            PrecioUnitarioMenor.ReadOnly = true;
            PrecioUnitarioMenor.Width = 200;
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
            // Aerolinea
            // 
            Aerolinea.HeaderText = "Aerolínea";
            Aerolinea.Name = "Aerolinea";
            Aerolinea.ReadOnly = true;
            Aerolinea.Width = 200;
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
            // Paradas
            // 
            Paradas.HeaderText = "Paradas";
            Paradas.Name = "Paradas";
            Paradas.ReadOnly = true;
            Paradas.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 10;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 250;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
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
            dataGridViewTextBoxColumn3.HeaderText = "Precio Unitario Adultos";
            dataGridViewTextBoxColumn3.MinimumWidth = 10;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 200;
            // 
            // PrecioUnitarioMenores
            // 
            PrecioUnitarioMenores.HeaderText = "Precio Unitario Menores";
            PrecioUnitarioMenores.Name = "PrecioUnitarioMenores";
            PrecioUnitarioMenores.ReadOnly = true;
            PrecioUnitarioMenores.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Cantidad Disponible";
            dataGridViewTextBoxColumn4.MinimumWidth = 10;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 200;
            // 
            // CantidadSeleccionadaAdulto
            // 
            CantidadSeleccionadaAdulto.HeaderText = "Cantidad Seleccionada Adultos";
            CantidadSeleccionadaAdulto.Name = "CantidadSeleccionadaAdulto";
            CantidadSeleccionadaAdulto.Width = 200;
            // 
            // CantidadSeleccionadaMenores
            // 
            CantidadSeleccionadaMenores.HeaderText = "Cantidad Seleccionada Menores";
            CantidadSeleccionadaMenores.Name = "CantidadSeleccionadaMenores";
            CantidadSeleccionadaMenores.Width = 200;
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
            // Column3
            // 
            Column3.HeaderText = "Aerolínea";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 200;
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
            // Column2
            // 
            Column2.HeaderText = "Paradas";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 200;
            // 
            // GenerarPresupuestoAereos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1364, 721);
            Controls.Add(grp_Filtros);
            Controls.Add(btnVolverAlMenuGenerarPresupuestos);
            Controls.Add(grp_VuelosSeleccionados);
            Controls.Add(grp_VuelosDisponibles);
            Name = "GenerarPresupuestoAereos";
            Text = "Generar Presupuesto - Aéreos";
            Load += GenerarPresupuestoAereos_Load;
            Controls.SetChildIndex(grp_VuelosDisponibles, 0);
            Controls.SetChildIndex(grp_VuelosSeleccionados, 0);
            Controls.SetChildIndex(btnVolverAlMenuGenerarPresupuestos, 0);
            Controls.SetChildIndex(grp_Filtros, 0);
            grp_VuelosDisponibles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            grp_VuelosSeleccionados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductosSeleccionados).EndInit();
            grp_Filtros.ResumeLayout(false);
            grp_Filtros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Common.Components.BotonEstilizado btnAgregarProductos;
        private Common.Components.BotonEstilizado btnRemoverProductos;
        private Common.Components.BotonEstilizado btnConfirmarProductosSeleccionados;
        private GroupBox grp_VuelosDisponibles;
        private GroupBox grp_VuelosSeleccionados;
        private DataGridView dataGridViewProductos;
        private DataGridView dataGridViewProductosSeleccionados;
        private Common.Components.BotonEstilizado btnVolverAlMenuGenerarPresupuestos;
        private GroupBox grp_Filtros;
        private Button btnDisableDatePickerFilterFechaDesde;
        private Button btnDisableDatePickerFilterFechaHasta;
        private Label labelDestino;
        private ComboBox comboBoxDestino;
        private Label labelOrigen;
        private ComboBox comboBoxOrigen;
        private Common.Components.BotonEstilizado btnLimpiarFiltro;
        private Label labelFiltroPrecioDesde;
        private Common.Components.BotonEstilizado btnBuscarProductos;
        private DateTimePicker datePickerFilterFechaDesde;
        private Label labelFiltroFechaDesde;
        private DateTimePicker datePickerFilterFechaHasta;
        private Label labelFiltroFechaHasta;
        private TextBox txtBoxFiltroPrecioHasta;
        private Label labelFiltroPrecioHasta;
        private TextBox txtBoxFiltroPrecioDesde;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrecioUnitarioAdulto;
        private DataGridViewTextBoxColumn PrecioUnitarioMenor;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn FechaDesde;
        private DataGridViewTextBoxColumn FechaHasta;
        private DataGridViewTextBoxColumn Aerolinea;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Destino;
        private DataGridViewTextBoxColumn Clase;
        private DataGridViewTextBoxColumn Paradas;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn PrecioUnitarioMenores;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn CantidadSeleccionadaAdulto;
        private DataGridViewTextBoxColumn CantidadSeleccionadaMenores;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn Column2;
    }
}