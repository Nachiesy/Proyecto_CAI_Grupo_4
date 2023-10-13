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
            datePickerFilterFechaDesde = new DateTimePicker();
            labelFiltroFechaDesde = new Label();
            labelFiltroFechaHasta = new Label();
            datePickerFilterFechaHasta = new DateTimePicker();
            labelFiltroPrecioHasta = new Label();
            txtBoxFiltroPrecioHasta = new TextBox();
            labelFiltroPrecioDesde = new Label();
            txtBoxFiltroPrecioDesde = new TextBox();
            grp_Filtros = new GroupBox();
            btnDisableDatePickerFilterFechaDesde = new Button();
            btnDisableDatePickerFilterFechaHasta = new Button();
            labelDestino = new Label();
            comboBoxDestino = new ComboBox();
            labelOrigen = new Label();
            comboBoxOrigen = new ComboBox();
            btnLimpiarFiltros = new Common.Components.BotonEstilizado();
            btnBuscarPresupuestos = new Common.Components.BotonEstilizado();
            btnAgregarProductos = new Common.Components.BotonEstilizado();
            btnRemoverProductos = new Common.Components.BotonEstilizado();
            btnConfirmarProductosSeleccionados = new Common.Components.BotonEstilizado();
            grp_VuelosDisponibles = new GroupBox();
            listViewProductos = new ListView();
            ID = new ColumnHeader();
            Codigo = new ColumnHeader();
            Nombre = new ColumnHeader();
            Origen = new ColumnHeader();
            Destino = new ColumnHeader();
            Cantidad = new ColumnHeader();
            Precio = new ColumnHeader();
            CapacidadAdultos = new ColumnHeader();
            CapacidadMenores = new ColumnHeader();
            FechaDesde = new ColumnHeader();
            FechaHasta = new ColumnHeader();
            grp_VuelosSeleccionados = new GroupBox();
            listViewProductosSeleccionados = new ListView();
            SelectID = new ColumnHeader();
            SelectCodigo = new ColumnHeader();
            SelectNombre = new ColumnHeader();
            SelectOrigen = new ColumnHeader();
            SelectDestino = new ColumnHeader();
            SelectPrecio = new ColumnHeader();
            SelectCapacidadAdultos = new ColumnHeader();
            SelectCapacidadMenores = new ColumnHeader();
            SelectFechaDesde = new ColumnHeader();
            SelectFechaHasta = new ColumnHeader();
            btnVolverAlMenuGenerarPresupuestos = new Common.Components.BotonEstilizado();
            grp_Filtros.SuspendLayout();
            grp_VuelosDisponibles.SuspendLayout();
            grp_VuelosSeleccionados.SuspendLayout();
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
            labelFiltroFechaDesde.Size = new Size(73, 15);
            labelFiltroFechaDesde.TabIndex = 13;
            labelFiltroFechaDesde.Text = "Fecha Desde";
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
            // datePickerFilterFechaHasta
            // 
            datePickerFilterFechaHasta.Location = new Point(18, 206);
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
            grp_Filtros.Controls.Add(btnDisableDatePickerFilterFechaDesde);
            grp_Filtros.Controls.Add(btnDisableDatePickerFilterFechaHasta);
            grp_Filtros.Controls.Add(labelDestino);
            grp_Filtros.Controls.Add(comboBoxDestino);
            grp_Filtros.Controls.Add(labelOrigen);
            grp_Filtros.Controls.Add(comboBoxOrigen);
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
            grp_Filtros.Size = new Size(322, 500);
            grp_Filtros.TabIndex = 35;
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
            comboBoxDestino.DropDownStyle = ComboBoxStyle.DropDownList;
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
            comboBoxOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrigen.FormattingEnabled = true;
            comboBoxOrigen.Location = new Point(18, 291);
            comboBoxOrigen.Name = "comboBoxOrigen";
            comboBoxOrigen.Size = new Size(126, 23);
            comboBoxOrigen.TabIndex = 20;
            // 
            // btnLimpiarFiltros
            // 
            btnLimpiarFiltros.BackColor = Color.Transparent;
            btnLimpiarFiltros.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnLimpiarFiltros.FlatStyle = FlatStyle.Flat;
            btnLimpiarFiltros.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiarFiltros.ForeColor = Color.Black;
            btnLimpiarFiltros.Location = new Point(163, 364);
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
            btnBuscarPresupuestos.Location = new Point(18, 364);
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
            grp_VuelosDisponibles.Controls.Add(listViewProductos);
            grp_VuelosDisponibles.Controls.Add(btnAgregarProductos);
            grp_VuelosDisponibles.Location = new Point(376, 131);
            grp_VuelosDisponibles.Name = "grp_VuelosDisponibles";
            grp_VuelosDisponibles.Size = new Size(976, 278);
            grp_VuelosDisponibles.TabIndex = 36;
            grp_VuelosDisponibles.TabStop = false;
            grp_VuelosDisponibles.Text = "Paquetes Disponibles";
            // 
            // listViewProductos
            // 
            listViewProductos.Columns.AddRange(new ColumnHeader[] { ID, Codigo, Nombre, Origen, Destino, Cantidad, Precio, CapacidadAdultos, CapacidadMenores, FechaDesde, FechaHasta });
            listViewProductos.FullRowSelect = true;
            listViewProductos.Location = new Point(6, 22);
            listViewProductos.Name = "listViewProductos";
            listViewProductos.Size = new Size(964, 194);
            listViewProductos.TabIndex = 8;
            listViewProductos.UseCompatibleStateImageBehavior = false;
            listViewProductos.View = View.Details;
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
            Nombre.Width = 150;
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
            // Cantidad
            // 
            Cantidad.Text = "Cantidad Disponible";
            Cantidad.Width = 150;
            // 
            // Precio
            // 
            Precio.Text = "Precio";
            Precio.Width = 100;
            // 
            // CapacidadAdultos
            // 
            CapacidadAdultos.Text = "Capacidad de Adultos";
            CapacidadAdultos.Width = 150;
            // 
            // CapacidadMenores
            // 
            CapacidadMenores.Text = "Capacidad de Menores";
            CapacidadMenores.Width = 150;
            // 
            // FechaDesde
            // 
            FechaDesde.Text = "Fecha Desde";
            FechaDesde.Width = 100;
            // 
            // FechaHasta
            // 
            FechaHasta.Text = "Fecha Hasta";
            FechaHasta.Width = 100;
            // 
            // grp_VuelosSeleccionados
            // 
            grp_VuelosSeleccionados.Controls.Add(listViewProductosSeleccionados);
            grp_VuelosSeleccionados.Controls.Add(btnRemoverProductos);
            grp_VuelosSeleccionados.Controls.Add(btnConfirmarProductosSeleccionados);
            grp_VuelosSeleccionados.Location = new Point(376, 422);
            grp_VuelosSeleccionados.Name = "grp_VuelosSeleccionados";
            grp_VuelosSeleccionados.Size = new Size(976, 269);
            grp_VuelosSeleccionados.TabIndex = 37;
            grp_VuelosSeleccionados.TabStop = false;
            grp_VuelosSeleccionados.Text = "Paquetes Seleccionados";
            // 
            // listViewProductosSeleccionados
            // 
            listViewProductosSeleccionados.Columns.AddRange(new ColumnHeader[] { SelectID, SelectCodigo, SelectNombre, SelectOrigen, SelectDestino, SelectPrecio, SelectCapacidadAdultos, SelectCapacidadMenores, SelectFechaDesde, SelectFechaHasta });
            listViewProductosSeleccionados.FullRowSelect = true;
            listViewProductosSeleccionados.Location = new Point(6, 22);
            listViewProductosSeleccionados.Name = "listViewProductosSeleccionados";
            listViewProductosSeleccionados.Size = new Size(964, 194);
            listViewProductosSeleccionados.TabIndex = 9;
            listViewProductosSeleccionados.UseCompatibleStateImageBehavior = false;
            listViewProductosSeleccionados.View = View.Details;
            // 
            // SelectID
            // 
            SelectID.Text = "ID";
            SelectID.Width = 0;
            // 
            // SelectCodigo
            // 
            SelectCodigo.Text = "Código";
            SelectCodigo.Width = 100;
            // 
            // SelectNombre
            // 
            SelectNombre.Text = "Nombre";
            SelectNombre.Width = 150;
            // 
            // SelectOrigen
            // 
            SelectOrigen.Text = "Origen";
            SelectOrigen.Width = 100;
            // 
            // SelectDestino
            // 
            SelectDestino.Text = "Destino";
            SelectDestino.Width = 100;
            // 
            // SelectPrecio
            // 
            SelectPrecio.Text = "Precio";
            SelectPrecio.Width = 100;
            // 
            // SelectCapacidadAdultos
            // 
            SelectCapacidadAdultos.Text = "Capacidad de Adultos";
            SelectCapacidadAdultos.Width = 150;
            // 
            // SelectCapacidadMenores
            // 
            SelectCapacidadMenores.Text = "Capacidad de Menores";
            SelectCapacidadMenores.Width = 150;
            // 
            // SelectFechaDesde
            // 
            SelectFechaDesde.Text = "Fecha Desde";
            SelectFechaDesde.Width = 100;
            // 
            // SelectFechaHasta
            // 
            SelectFechaHasta.Text = "Fecha Hasta";
            SelectFechaHasta.Width = 100;
            // 
            // btnVolverAlMenuGenerarPresupuestos
            // 
            btnVolverAlMenuGenerarPresupuestos.BackColor = Color.Transparent;
            btnVolverAlMenuGenerarPresupuestos.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnVolverAlMenuGenerarPresupuestos.FlatStyle = FlatStyle.Flat;
            btnVolverAlMenuGenerarPresupuestos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolverAlMenuGenerarPresupuestos.ForeColor = Color.Black;
            btnVolverAlMenuGenerarPresupuestos.Location = new Point(27, 637);
            btnVolverAlMenuGenerarPresupuestos.Name = "btnVolverAlMenuGenerarPresupuestos";
            btnVolverAlMenuGenerarPresupuestos.Size = new Size(322, 47);
            btnVolverAlMenuGenerarPresupuestos.TabIndex = 4;
            btnVolverAlMenuGenerarPresupuestos.Text = "Volver";
            btnVolverAlMenuGenerarPresupuestos.UseVisualStyleBackColor = false;
            btnVolverAlMenuGenerarPresupuestos.Click += btnVolverAlMenuGenerarPresupuestos_Click;
            // 
            // GenerarPresupuestoPaquetesTuristicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1364, 721);
            Controls.Add(btnVolverAlMenuGenerarPresupuestos);
            Controls.Add(grp_VuelosSeleccionados);
            Controls.Add(grp_VuelosDisponibles);
            Controls.Add(grp_Filtros);
            Name = "GenerarPresupuestoPaquetesTuristicos";
            Text = "Generar Presupuesto - Aéreos";
            Load += GenerarPresupuestoPaquetesTuristicos_Load;
            Controls.SetChildIndex(grp_Filtros, 0);
            Controls.SetChildIndex(grp_VuelosDisponibles, 0);
            Controls.SetChildIndex(grp_VuelosSeleccionados, 0);
            Controls.SetChildIndex(btnVolverAlMenuGenerarPresupuestos, 0);
            grp_Filtros.ResumeLayout(false);
            grp_Filtros.PerformLayout();
            grp_VuelosDisponibles.ResumeLayout(false);
            grp_VuelosSeleccionados.ResumeLayout(false);
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
        private Common.Components.BotonEstilizado btnVolverAlMenuGenerarPresupuestos;
        private Label labelDestino;
        private ComboBox comboBoxDestino;
        private Label labelOrigen;
        private ComboBox comboBoxOrigen;
        private Button btnDisableDatePickerFilterFechaDesde;
        private Button btnDisableDatePickerFilterFechaHasta;
        private ListView listViewProductos;
        private ColumnHeader ID;
        private ColumnHeader Codigo;
        private ColumnHeader Nombre;
        private ColumnHeader Origen;
        private ColumnHeader Destino;
        private ColumnHeader Cantidad;
        private ColumnHeader Precio;
        private ColumnHeader FechaDesde;
        private ColumnHeader FechaHasta;
        private ColumnHeader CapacidadAdultos;
        private ColumnHeader CapacidadMenores;
        private ListView listViewProductosSeleccionados;
        private ColumnHeader SelectID;
        private ColumnHeader SelectCodigo;
        private ColumnHeader SelectNombre;
        private ColumnHeader SelectOrigen;
        private ColumnHeader SelectDestino;
        private ColumnHeader SelectPrecio;
        private ColumnHeader SelectFechaDesde;
        private ColumnHeader SelectFechaHasta;
        private ColumnHeader SelectCapacidadAdultos;
        private ColumnHeader SelectCapacidadMenores;
    }
}