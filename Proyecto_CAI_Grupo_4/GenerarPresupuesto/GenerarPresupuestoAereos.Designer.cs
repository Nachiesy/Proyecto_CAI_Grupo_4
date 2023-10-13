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
            listViewProductos = new ListView();
            ID = new ColumnHeader();
            Codigo = new ColumnHeader();
            Origen = new ColumnHeader();
            Destino = new ColumnHeader();
            Clase = new ColumnHeader();
            Itinerario = new ColumnHeader();
            Cantidad = new ColumnHeader();
            TipoDePasajero = new ColumnHeader();
            Precio = new ColumnHeader();
            Aerolinea = new ColumnHeader();
            Paradas = new ColumnHeader();
            FechaSalida = new ColumnHeader();
            FechaLlegada = new ColumnHeader();
            grp_VuelosSeleccionados = new GroupBox();
            listViewProductosSeleccionados = new ListView();
            SelectID = new ColumnHeader();
            SelectCodigo = new ColumnHeader();
            SelectOrigen = new ColumnHeader();
            SelectDestino = new ColumnHeader();
            SelectClase = new ColumnHeader();
            SelectItinerario = new ColumnHeader();
            SelectTipoDePasajero = new ColumnHeader();
            SelectPrecio = new ColumnHeader();
            SelectAerolinea = new ColumnHeader();
            SelectParadas = new ColumnHeader();
            SelectFechaSalida = new ColumnHeader();
            SelectFechaLlegada = new ColumnHeader();
            btnVolverAlMenuGenerarPresupuestos = new Common.Components.BotonEstilizado();
            grp_Filtros = new GroupBox();
            labelClase = new Label();
            comboBoxClase = new ComboBox();
            labelItinerario = new Label();
            comboBoxItinerario = new ComboBox();
            labelTipoDePasajero = new Label();
            comboBoxTipoDePasajero = new ComboBox();
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
            grp_VuelosDisponibles.SuspendLayout();
            grp_VuelosSeleccionados.SuspendLayout();
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
            grp_VuelosDisponibles.Controls.Add(listViewProductos);
            grp_VuelosDisponibles.Controls.Add(btnAgregarProductos);
            grp_VuelosDisponibles.Location = new Point(376, 131);
            grp_VuelosDisponibles.Name = "grp_VuelosDisponibles";
            grp_VuelosDisponibles.Size = new Size(976, 278);
            grp_VuelosDisponibles.TabIndex = 36;
            grp_VuelosDisponibles.TabStop = false;
            grp_VuelosDisponibles.Text = "Vuelos Disponibles";
            // 
            // listViewProductos
            // 
            listViewProductos.Columns.AddRange(new ColumnHeader[] { ID, Codigo, Origen, Destino, Clase, Itinerario, Cantidad, TipoDePasajero, Precio, Aerolinea, Paradas, FechaSalida, FechaLlegada });
            listViewProductos.FullRowSelect = true;
            listViewProductos.Location = new Point(6, 22);
            listViewProductos.Name = "listViewProductos";
            listViewProductos.Size = new Size(964, 194);
            listViewProductos.TabIndex = 6;
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
            // Clase
            // 
            Clase.Text = "Clase";
            Clase.Width = 100;
            // 
            // Itinerario
            // 
            Itinerario.Text = "Itinerario";
            Itinerario.Width = 100;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Asientos Disponibles";
            Cantidad.Width = 150;
            // 
            // TipoDePasajero
            // 
            TipoDePasajero.Text = "Tarifa";
            TipoDePasajero.Width = 100;
            // 
            // Precio
            // 
            Precio.Text = "Precio";
            Precio.Width = 100;
            // 
            // Aerolinea
            // 
            Aerolinea.Text = "Aerolinea";
            Aerolinea.Width = 150;
            // 
            // Paradas
            // 
            Paradas.Text = "Cantidad de Paradas";
            Paradas.Width = 150;
            // 
            // FechaSalida
            // 
            FechaSalida.Text = "Fecha de Salida";
            FechaSalida.Width = 150;
            // 
            // FechaLlegada
            // 
            FechaLlegada.Text = "Fecha de Llegada";
            FechaLlegada.Width = 150;
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
            grp_VuelosSeleccionados.Text = "Vuelos Seleccionados";
            // 
            // listViewProductosSeleccionados
            // 
            listViewProductosSeleccionados.Columns.AddRange(new ColumnHeader[] { SelectID, SelectCodigo, SelectOrigen, SelectDestino, SelectClase, SelectItinerario, SelectTipoDePasajero, SelectPrecio, SelectAerolinea, SelectParadas, SelectFechaSalida, SelectFechaLlegada });
            listViewProductosSeleccionados.FullRowSelect = true;
            listViewProductosSeleccionados.Location = new Point(6, 22);
            listViewProductosSeleccionados.Name = "listViewProductosSeleccionados";
            listViewProductosSeleccionados.Size = new Size(964, 194);
            listViewProductosSeleccionados.TabIndex = 7;
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
            // SelectClase
            // 
            SelectClase.Text = "Clase";
            SelectClase.Width = 100;
            // 
            // SelectItinerario
            // 
            SelectItinerario.Text = "Itinerario";
            SelectItinerario.Width = 100;
            // 
            // SelectTipoDePasajero
            // 
            SelectTipoDePasajero.Text = "Tarifa";
            SelectTipoDePasajero.Width = 100;
            // 
            // SelectPrecio
            // 
            SelectPrecio.Text = "Precio";
            SelectPrecio.Width = 100;
            // 
            // SelectAerolinea
            // 
            SelectAerolinea.Text = "Aerolinea";
            SelectAerolinea.Width = 150;
            // 
            // SelectParadas
            // 
            SelectParadas.Text = "Cantidad de Paradas";
            SelectParadas.Width = 150;
            // 
            // SelectFechaSalida
            // 
            SelectFechaSalida.Text = "Fecha de Salida";
            SelectFechaSalida.Width = 150;
            // 
            // SelectFechaLlegada
            // 
            SelectFechaLlegada.Text = "Fecha de Llegada";
            SelectFechaLlegada.Width = 150;
            // 
            // btnVolverAlMenuGenerarPresupuestos
            // 
            btnVolverAlMenuGenerarPresupuestos.BackColor = Color.Transparent;
            btnVolverAlMenuGenerarPresupuestos.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnVolverAlMenuGenerarPresupuestos.FlatStyle = FlatStyle.Flat;
            btnVolverAlMenuGenerarPresupuestos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolverAlMenuGenerarPresupuestos.ForeColor = Color.Black;
            btnVolverAlMenuGenerarPresupuestos.Location = new Point(27, 644);
            btnVolverAlMenuGenerarPresupuestos.Name = "btnVolverAlMenuGenerarPresupuestos";
            btnVolverAlMenuGenerarPresupuestos.Size = new Size(322, 47);
            btnVolverAlMenuGenerarPresupuestos.TabIndex = 43;
            btnVolverAlMenuGenerarPresupuestos.Text = "Volver";
            btnVolverAlMenuGenerarPresupuestos.UseVisualStyleBackColor = false;
            btnVolverAlMenuGenerarPresupuestos.Click += btnVolverAlMenuGenerarPresupuestos_Click;
            // 
            // grp_Filtros
            // 
            grp_Filtros.Controls.Add(labelClase);
            grp_Filtros.Controls.Add(comboBoxClase);
            grp_Filtros.Controls.Add(labelItinerario);
            grp_Filtros.Controls.Add(comboBoxItinerario);
            grp_Filtros.Controls.Add(labelTipoDePasajero);
            grp_Filtros.Controls.Add(comboBoxTipoDePasajero);
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
            grp_Filtros.Location = new Point(27, 133);
            grp_Filtros.Name = "grp_Filtros";
            grp_Filtros.Size = new Size(319, 500);
            grp_Filtros.TabIndex = 44;
            grp_Filtros.TabStop = false;
            grp_Filtros.Text = "Filtros";
            // 
            // labelClase
            // 
            labelClase.AutoSize = true;
            labelClase.Location = new Point(18, 382);
            labelClase.Name = "labelClase";
            labelClase.Size = new Size(35, 15);
            labelClase.TabIndex = 31;
            labelClase.Text = "Clase";
            // 
            // comboBoxClase
            // 
            comboBoxClase.FormattingEnabled = true;
            comboBoxClase.Location = new Point(18, 400);
            comboBoxClase.Name = "comboBoxClase";
            comboBoxClase.Size = new Size(126, 23);
            comboBoxClase.TabIndex = 30;
            // 
            // labelItinerario
            // 
            labelItinerario.AutoSize = true;
            labelItinerario.Location = new Point(163, 328);
            labelItinerario.Name = "labelItinerario";
            labelItinerario.Size = new Size(54, 15);
            labelItinerario.TabIndex = 29;
            labelItinerario.Text = "Itinerario";
            // 
            // comboBoxItinerario
            // 
            comboBoxItinerario.FormattingEnabled = true;
            comboBoxItinerario.Location = new Point(163, 346);
            comboBoxItinerario.Name = "comboBoxItinerario";
            comboBoxItinerario.Size = new Size(126, 23);
            comboBoxItinerario.TabIndex = 28;
            // 
            // labelTipoDePasajero
            // 
            labelTipoDePasajero.AutoSize = true;
            labelTipoDePasajero.Location = new Point(18, 328);
            labelTipoDePasajero.Name = "labelTipoDePasajero";
            labelTipoDePasajero.Size = new Size(93, 15);
            labelTipoDePasajero.TabIndex = 27;
            labelTipoDePasajero.Text = "Tipo de Pasajero";
            // 
            // comboBoxTipoDePasajero
            // 
            comboBoxTipoDePasajero.FormattingEnabled = true;
            comboBoxTipoDePasajero.Location = new Point(18, 346);
            comboBoxTipoDePasajero.Name = "comboBoxTipoDePasajero";
            comboBoxTipoDePasajero.Size = new Size(126, 23);
            comboBoxTipoDePasajero.TabIndex = 26;
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
            btnLimpiarFiltro.Location = new Point(163, 436);
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
            btnBuscarProductos.Location = new Point(18, 436);
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
            grp_VuelosSeleccionados.ResumeLayout(false);
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
        private Label labelItinerario;
        private ComboBox comboBoxItinerario;
        private Label labelTipoDePasajero;
        private ComboBox comboBoxTipoDePasajero;
        private Label labelClase;
        private ComboBox comboBoxClase;
        private ListView listViewProductos;
        private ColumnHeader ID;
        private ColumnHeader Codigo;
        private ColumnHeader Origen;
        private ColumnHeader Destino;
        private ColumnHeader Clase;
        private ColumnHeader Itinerario;
        private ColumnHeader TipoDePasajero;
        private ColumnHeader Cantidad;
        private ColumnHeader Precio;
        private ColumnHeader Aerolinea;
        private ColumnHeader Paradas;
        private ColumnHeader FechaSalida;
        private ColumnHeader FechaLlegada;
        private ListView listViewProductosSeleccionados;
        private ColumnHeader SelectID;
        private ColumnHeader SelectCodigo;
        private ColumnHeader SelectOrigen;
        private ColumnHeader SelectDestino;
        private ColumnHeader SelectClase;
        private ColumnHeader SelectItinerario;
        private ColumnHeader SelectTipoDePasajero;
        private ColumnHeader SelectPrecio;
        private ColumnHeader SelectAerolinea;
        private ColumnHeader SelectParadas;
        private ColumnHeader SelectFechaSalida;
        private ColumnHeader SelectFechaLlegada;
    }
}