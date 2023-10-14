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
            grp_HotelesDisponibles = new GroupBox();
            listViewProductos = new ListView();
            ID = new ColumnHeader();
            Codigo = new ColumnHeader();
            Nombre = new ColumnHeader();
            Ciudad = new ColumnHeader();
            Direccion = new ColumnHeader();
            Calificacion = new ColumnHeader();
            CantidadHabitaciones = new ColumnHeader();
            TipoHabitacion = new ColumnHeader();
            Precio = new ColumnHeader();
            CapacidadPersonas = new ColumnHeader();
            CapacidadAdultos = new ColumnHeader();
            CapacidadMenores = new ColumnHeader();
            CapacidadInfantes = new ColumnHeader();
            FechaDesde = new ColumnHeader();
            FechaHasta = new ColumnHeader();
            btnAgregarProductos = new Common.Components.BotonEstilizado();
            grp_Filtros = new GroupBox();
            labelNombre = new Label();
            textBoxNombre = new TextBox();
            labelCalificacion = new Label();
            comboBoxCalificacion = new ComboBox();
            labelTipoDeHabitacion = new Label();
            comboBoxTipoDeHabitacion = new ComboBox();
            labelCiudad = new Label();
            btnDisableDatePickerFilterFechaHasta = new Button();
            comboBoxCiudad = new ComboBox();
            btnDisableDatePickerFilterFechaDesde = new Button();
            btnLimpiarFiltros = new Common.Components.BotonEstilizado();
            labelFiltroPrecioDesde = new Label();
            btnBuscarPresupuestos = new Common.Components.BotonEstilizado();
            datePickerFilterFechaDesde = new DateTimePicker();
            labelFiltroFechaDesde = new Label();
            datePickerFilterFechaHasta = new DateTimePicker();
            labelFiltroFechaHasta = new Label();
            txtBoxFiltroPrecioHasta = new TextBox();
            labelFiltroPrecioHasta = new Label();
            txtBoxFiltroPrecioDesde = new TextBox();
            grp_CrucerosSeleccionados = new GroupBox();
            listViewProductosSeleccionados = new ListView();
            SelectID = new ColumnHeader();
            SelectCodigo = new ColumnHeader();
            SelectNombre = new ColumnHeader();
            SelectCiudad = new ColumnHeader();
            SelectDireccion = new ColumnHeader();
            SelectCalificacion = new ColumnHeader();
            SelectTipoHabitacion = new ColumnHeader();
            SelectPrecio = new ColumnHeader();
            SelectCapacidadPersonas = new ColumnHeader();
            SelectCapacidadAdultos = new ColumnHeader();
            SelectCapacidadMenores = new ColumnHeader();
            SelectCapacidadInfantes = new ColumnHeader();
            SelectFechaDesde = new ColumnHeader();
            SelectFechaHasta = new ColumnHeader();
            btnRemoverProductos = new Common.Components.BotonEstilizado();
            btnConfirmarProductosSeleccionados = new Common.Components.BotonEstilizado();
            btnVolverAlMenuGenerarPresupuestos = new Common.Components.BotonEstilizado();
            grp_HotelesDisponibles.SuspendLayout();
            grp_Filtros.SuspendLayout();
            grp_CrucerosSeleccionados.SuspendLayout();
            SuspendLayout();
            // 
            // grp_HotelesDisponibles
            // 
            grp_HotelesDisponibles.Controls.Add(listViewProductos);
            grp_HotelesDisponibles.Controls.Add(btnAgregarProductos);
            grp_HotelesDisponibles.Location = new Point(362, 127);
            grp_HotelesDisponibles.Name = "grp_HotelesDisponibles";
            grp_HotelesDisponibles.Size = new Size(976, 278);
            grp_HotelesDisponibles.TabIndex = 38;
            grp_HotelesDisponibles.TabStop = false;
            grp_HotelesDisponibles.Text = "Hoteles Disponibles";
            // 
            // listViewProductos
            // 
            listViewProductos.Columns.AddRange(new ColumnHeader[] { ID, Codigo, Nombre, Ciudad, Direccion, Calificacion, CantidadHabitaciones, TipoHabitacion, Precio, CapacidadPersonas, CapacidadAdultos, CapacidadMenores, CapacidadInfantes, FechaDesde, FechaHasta });
            listViewProductos.FullRowSelect = true;
            listViewProductos.Location = new Point(6, 22);
            listViewProductos.Name = "listViewProductos";
            listViewProductos.Size = new Size(964, 194);
            listViewProductos.TabIndex = 5;
            listViewProductos.UseCompatibleStateImageBehavior = false;
            listViewProductos.View = View.Details;
            listViewProductos.ColumnWidthChanging += listViewProductos_ColumnWidthChanging;
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
            Nombre.Width = 100;
            // 
            // Ciudad
            // 
            Ciudad.Text = "Ciudad";
            Ciudad.Width = 100;
            // 
            // Direccion
            // 
            Direccion.Text = "Dirección";
            Direccion.Width = 200;
            // 
            // Calificacion
            // 
            Calificacion.Text = "Calificación";
            Calificacion.Width = 100;
            // 
            // CantidadHabitaciones
            // 
            CantidadHabitaciones.Text = "Cantidad de Habitaciones";
            CantidadHabitaciones.Width = 200;
            // 
            // TipoHabitacion
            // 
            TipoHabitacion.Text = "Tipo de Habitación";
            TipoHabitacion.Width = 200;
            // 
            // Precio
            // 
            Precio.Text = "Precio";
            Precio.Width = 100;
            // 
            // CapacidadPersonas
            // 
            CapacidadPersonas.Text = "Capacidad de Personas";
            CapacidadPersonas.Width = 200;
            // 
            // CapacidadAdultos
            // 
            CapacidadAdultos.Text = "Capacidad de Adultos";
            CapacidadAdultos.Width = 200;
            // 
            // CapacidadMenores
            // 
            CapacidadMenores.Text = "Capacidad de Menores";
            CapacidadMenores.Width = 200;
            // 
            // CapacidadInfantes
            // 
            CapacidadInfantes.Text = "Capacidad de Infantes";
            CapacidadInfantes.Width = 200;
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
            // grp_Filtros
            // 
            grp_Filtros.Controls.Add(labelNombre);
            grp_Filtros.Controls.Add(textBoxNombre);
            grp_Filtros.Controls.Add(labelCalificacion);
            grp_Filtros.Controls.Add(comboBoxCalificacion);
            grp_Filtros.Controls.Add(labelTipoDeHabitacion);
            grp_Filtros.Controls.Add(comboBoxTipoDeHabitacion);
            grp_Filtros.Controls.Add(labelCiudad);
            grp_Filtros.Controls.Add(btnDisableDatePickerFilterFechaHasta);
            grp_Filtros.Controls.Add(comboBoxCiudad);
            grp_Filtros.Controls.Add(btnDisableDatePickerFilterFechaDesde);
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
            grp_Filtros.Location = new Point(13, 127);
            grp_Filtros.Name = "grp_Filtros";
            grp_Filtros.Size = new Size(322, 450);
            grp_Filtros.TabIndex = 37;
            grp_Filtros.TabStop = false;
            grp_Filtros.Text = "Filtros";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(18, 278);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 49;
            labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(18, 296);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(126, 23);
            textBoxNombre.TabIndex = 48;
            // 
            // labelCalificacion
            // 
            labelCalificacion.AutoSize = true;
            labelCalificacion.Location = new Point(18, 333);
            labelCalificacion.Name = "labelCalificacion";
            labelCalificacion.Size = new Size(69, 15);
            labelCalificacion.TabIndex = 47;
            labelCalificacion.Text = "Calificación";
            // 
            // comboBoxCalificacion
            // 
            comboBoxCalificacion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCalificacion.FormattingEnabled = true;
            comboBoxCalificacion.Location = new Point(18, 351);
            comboBoxCalificacion.Name = "comboBoxCalificacion";
            comboBoxCalificacion.Size = new Size(126, 23);
            comboBoxCalificacion.TabIndex = 46;
            // 
            // labelTipoDeHabitacion
            // 
            labelTipoDeHabitacion.AutoSize = true;
            labelTipoDeHabitacion.Location = new Point(163, 333);
            labelTipoDeHabitacion.Name = "labelTipoDeHabitacion";
            labelTipoDeHabitacion.Size = new Size(107, 15);
            labelTipoDeHabitacion.TabIndex = 45;
            labelTipoDeHabitacion.Text = "Tipo de Habitación";
            // 
            // comboBoxTipoDeHabitacion
            // 
            comboBoxTipoDeHabitacion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoDeHabitacion.FormattingEnabled = true;
            comboBoxTipoDeHabitacion.Location = new Point(163, 351);
            comboBoxTipoDeHabitacion.Name = "comboBoxTipoDeHabitacion";
            comboBoxTipoDeHabitacion.Size = new Size(126, 23);
            comboBoxTipoDeHabitacion.TabIndex = 44;
            // 
            // labelCiudad
            // 
            labelCiudad.AutoSize = true;
            labelCiudad.Location = new Point(163, 278);
            labelCiudad.Name = "labelCiudad";
            labelCiudad.Size = new Size(45, 15);
            labelCiudad.TabIndex = 43;
            labelCiudad.Text = "Ciudad";
            // 
            // btnDisableDatePickerFilterFechaHasta
            // 
            btnDisableDatePickerFilterFechaHasta.Location = new Point(18, 235);
            btnDisableDatePickerFilterFechaHasta.Name = "btnDisableDatePickerFilterFechaHasta";
            btnDisableDatePickerFilterFechaHasta.Size = new Size(80, 23);
            btnDisableDatePickerFilterFechaHasta.TabIndex = 27;
            btnDisableDatePickerFilterFechaHasta.Text = "Deshabilitar";
            btnDisableDatePickerFilterFechaHasta.UseVisualStyleBackColor = true;
            btnDisableDatePickerFilterFechaHasta.Click += btnDisableDatePickerFilterFechaHasta_Click;
            // 
            // comboBoxCiudad
            // 
            comboBoxCiudad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCiudad.FormattingEnabled = true;
            comboBoxCiudad.Location = new Point(163, 296);
            comboBoxCiudad.Name = "comboBoxCiudad";
            comboBoxCiudad.Size = new Size(126, 23);
            comboBoxCiudad.TabIndex = 42;
            // 
            // btnDisableDatePickerFilterFechaDesde
            // 
            btnDisableDatePickerFilterFechaDesde.Location = new Point(18, 145);
            btnDisableDatePickerFilterFechaDesde.Name = "btnDisableDatePickerFilterFechaDesde";
            btnDisableDatePickerFilterFechaDesde.Size = new Size(80, 23);
            btnDisableDatePickerFilterFechaDesde.TabIndex = 26;
            btnDisableDatePickerFilterFechaDesde.Text = "Deshabilitar";
            btnDisableDatePickerFilterFechaDesde.UseVisualStyleBackColor = true;
            btnDisableDatePickerFilterFechaDesde.Click += btnDisableDatePickerFilterFechaDesde_Click;
            // 
            // btnLimpiarFiltros
            // 
            btnLimpiarFiltros.BackColor = Color.Transparent;
            btnLimpiarFiltros.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnLimpiarFiltros.FlatStyle = FlatStyle.Flat;
            btnLimpiarFiltros.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiarFiltros.ForeColor = Color.Black;
            btnLimpiarFiltros.Location = new Point(163, 389);
            btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            btnLimpiarFiltros.Size = new Size(139, 40);
            btnLimpiarFiltros.TabIndex = 4;
            btnLimpiarFiltros.Text = "Limpiar";
            btnLimpiarFiltros.UseVisualStyleBackColor = false;
            btnLimpiarFiltros.Click += btnLimpiarFiltro_Click;
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
            // btnBuscarPresupuestos
            // 
            btnBuscarPresupuestos.BackColor = Color.Transparent;
            btnBuscarPresupuestos.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnBuscarPresupuestos.FlatStyle = FlatStyle.Flat;
            btnBuscarPresupuestos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarPresupuestos.ForeColor = Color.Black;
            btnBuscarPresupuestos.Location = new Point(18, 389);
            btnBuscarPresupuestos.Name = "btnBuscarPresupuestos";
            btnBuscarPresupuestos.Size = new Size(139, 40);
            btnBuscarPresupuestos.TabIndex = 4;
            btnBuscarPresupuestos.Text = "Buscar";
            btnBuscarPresupuestos.UseVisualStyleBackColor = false;
            btnBuscarPresupuestos.Click += btnBuscarProductos_Click;
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
            // grp_CrucerosSeleccionados
            // 
            grp_CrucerosSeleccionados.Controls.Add(listViewProductosSeleccionados);
            grp_CrucerosSeleccionados.Controls.Add(btnRemoverProductos);
            grp_CrucerosSeleccionados.Controls.Add(btnConfirmarProductosSeleccionados);
            grp_CrucerosSeleccionados.Location = new Point(362, 423);
            grp_CrucerosSeleccionados.Name = "grp_CrucerosSeleccionados";
            grp_CrucerosSeleccionados.Size = new Size(976, 269);
            grp_CrucerosSeleccionados.TabIndex = 40;
            grp_CrucerosSeleccionados.TabStop = false;
            grp_CrucerosSeleccionados.Text = "Hoteles Seleccionados";
            // 
            // listViewProductosSeleccionados
            // 
            listViewProductosSeleccionados.Columns.AddRange(new ColumnHeader[] { SelectID, SelectCodigo, SelectNombre, SelectCiudad, SelectDireccion, SelectCalificacion, SelectTipoHabitacion, SelectPrecio, SelectCapacidadPersonas, SelectCapacidadAdultos, SelectCapacidadMenores, SelectCapacidadInfantes, SelectFechaDesde, SelectFechaHasta });
            listViewProductosSeleccionados.FullRowSelect = true;
            listViewProductosSeleccionados.Location = new Point(6, 22);
            listViewProductosSeleccionados.Name = "listViewProductosSeleccionados";
            listViewProductosSeleccionados.Size = new Size(964, 194);
            listViewProductosSeleccionados.TabIndex = 6;
            listViewProductosSeleccionados.UseCompatibleStateImageBehavior = false;
            listViewProductosSeleccionados.View = View.Details;
            listViewProductosSeleccionados.ColumnWidthChanging += listViewProductosSeleccionados_ColumnWidthChanging;
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
            SelectNombre.Width = 100;
            // 
            // SelectCiudad
            // 
            SelectCiudad.Text = "Ciudad";
            SelectCiudad.Width = 100;
            // 
            // SelectDireccion
            // 
            SelectDireccion.Text = "Dirección";
            SelectDireccion.Width = 200;
            // 
            // SelectCalificacion
            // 
            SelectCalificacion.Text = "Calificación";
            SelectCalificacion.Width = 100;
            // 
            // SelectTipoHabitacion
            // 
            SelectTipoHabitacion.Text = "Tipo de Habitación";
            SelectTipoHabitacion.Width = 200;
            // 
            // SelectPrecio
            // 
            SelectPrecio.Text = "Precio";
            SelectPrecio.Width = 100;
            // 
            // SelectCapacidadPersonas
            // 
            SelectCapacidadPersonas.Text = "Capacidad de Personas";
            SelectCapacidadPersonas.Width = 200;
            // 
            // SelectCapacidadAdultos
            // 
            SelectCapacidadAdultos.Text = "Capacidad de Adultos";
            SelectCapacidadAdultos.Width = 200;
            // 
            // SelectCapacidadMenores
            // 
            SelectCapacidadMenores.Text = "Capacidad de Menores";
            SelectCapacidadMenores.Width = 200;
            // 
            // SelectCapacidadInfantes
            // 
            SelectCapacidadInfantes.Text = "Capacidad de Infantes";
            SelectCapacidadInfantes.Width = 200;
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
            // btnVolverAlMenuGenerarPresupuestos
            // 
            btnVolverAlMenuGenerarPresupuestos.BackColor = Color.Transparent;
            btnVolverAlMenuGenerarPresupuestos.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnVolverAlMenuGenerarPresupuestos.FlatStyle = FlatStyle.Flat;
            btnVolverAlMenuGenerarPresupuestos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolverAlMenuGenerarPresupuestos.ForeColor = Color.Black;
            btnVolverAlMenuGenerarPresupuestos.Location = new Point(13, 592);
            btnVolverAlMenuGenerarPresupuestos.Name = "btnVolverAlMenuGenerarPresupuestos";
            btnVolverAlMenuGenerarPresupuestos.Size = new Size(322, 47);
            btnVolverAlMenuGenerarPresupuestos.TabIndex = 41;
            btnVolverAlMenuGenerarPresupuestos.Text = "Volver";
            btnVolverAlMenuGenerarPresupuestos.UseVisualStyleBackColor = false;
            btnVolverAlMenuGenerarPresupuestos.Click += btnVolverAlMenuGenerarPresupuestos_Click;
            // 
            // GenerarPresupuestoHoteles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1364, 721);
            Controls.Add(btnVolverAlMenuGenerarPresupuestos);
            Controls.Add(grp_CrucerosSeleccionados);
            Controls.Add(grp_HotelesDisponibles);
            Controls.Add(grp_Filtros);
            Name = "GenerarPresupuestoHoteles";
            Text = "Generar Presupuesto - Aéreos";
            Load += GenerarPresupuestoHoteles_Load;
            Controls.SetChildIndex(grp_Filtros, 0);
            Controls.SetChildIndex(grp_HotelesDisponibles, 0);
            Controls.SetChildIndex(grp_CrucerosSeleccionados, 0);
            Controls.SetChildIndex(btnVolverAlMenuGenerarPresupuestos, 0);
            grp_HotelesDisponibles.ResumeLayout(false);
            grp_Filtros.ResumeLayout(false);
            grp_Filtros.PerformLayout();
            grp_CrucerosSeleccionados.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp_HotelesDisponibles;
        private Common.Components.BotonEstilizado btnAgregarProductos;
        private GroupBox grp_Filtros;
        private Common.Components.BotonEstilizado btnLimpiarFiltros;
        private Label labelFiltroPrecioDesde;
        private Common.Components.BotonEstilizado btnBuscarPresupuestos;
        private DateTimePicker datePickerFilterFechaDesde;
        private Label labelFiltroFechaDesde;
        private DateTimePicker datePickerFilterFechaHasta;
        private Label labelFiltroFechaHasta;
        private TextBox txtBoxFiltroPrecioHasta;
        private Label labelFiltroPrecioHasta;
        private TextBox txtBoxFiltroPrecioDesde;
        private GroupBox grp_CrucerosSeleccionados;
        private Common.Components.BotonEstilizado btnRemoverProductos;
        private Common.Components.BotonEstilizado btnConfirmarProductosSeleccionados;
        private Common.Components.BotonEstilizado btnVolverAlMenuGenerarPresupuestos;
        private Button btnDisableDatePickerFilterFechaDesde;
        private Button btnDisableDatePickerFilterFechaHasta;
        private Label labelCiudad;
        private ComboBox comboBoxCiudad;
        private Label labelCalificacion;
        private ComboBox comboBoxCalificacion;
        private Label labelTipoDeHabitacion;
        private ComboBox comboBoxTipoDeHabitacion;
        private Label labelNombre;
        private TextBox textBoxNombre;
        private ListView listViewProductos;
        private ColumnHeader ID;
        private ColumnHeader Codigo;
        private ColumnHeader Nombre;
        private ColumnHeader Ciudad;
        private ColumnHeader Direccion;
        private ColumnHeader Calificacion;
        private ColumnHeader CantidadHabitaciones;
        private ColumnHeader TipoHabitacion;
        private ColumnHeader CapacidadPersonas;
        private ColumnHeader CapacidadAdultos;
        private ColumnHeader CapacidadMenores;
        private ColumnHeader CapacidadInfantes;
        private ColumnHeader Precio;
        private ListView listViewProductosSeleccionados;
        private ColumnHeader SelectID;
        private ColumnHeader SelectCodigo;
        private ColumnHeader SelectNombre;
        private ColumnHeader SelectCiudad;
        private ColumnHeader SelectDireccion;
        private ColumnHeader SelectCalificacion;
        private ColumnHeader SelectTipoHabitacion;
        private ColumnHeader SelectPrecio;
        private ColumnHeader SelectCapacidadPersonas;
        private ColumnHeader SelectCapacidadAdultos;
        private ColumnHeader SelectCapacidadMenores;
        private ColumnHeader SelectCapacidadInfantes;
        private ColumnHeader FechaDesde;
        private ColumnHeader FechaHasta;
        private ColumnHeader SelectFechaDesde;
        private ColumnHeader SelectFechaHasta;
    }
}