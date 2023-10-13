namespace Proyecto_CAI_Grupo_4
{
    partial class ConsultarAereos
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
            labelClase = new Label();
            labelDestino = new Label();
            comboBoxClase = new ComboBox();
            labelOrigen = new Label();
            labelItinerario = new Label();
            comboBoxDestino = new ComboBox();
            comboBoxItinerario = new ComboBox();
            labelTipoDePasajero = new Label();
            comboBoxOrigen = new ComboBox();
            comboBoxTipoDePasajero = new ComboBox();
            btnDisableDatePickerFilterFechaHasta = new Button();
            btnDisableDatePickerFilterFechaDesde = new Button();
            btnLimpiarFiltro = new Common.Components.BotonEstilizado();
            buscarPresupuesto = new Common.Components.BotonEstilizado();
            btnVolverMenuGenerarPresupuestos = new Button();
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
            grp_Filtros.SuspendLayout();
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
            label4.Size = new Size(72, 15);
            label4.TabIndex = 13;
            label4.Text = "Fecha Salida";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(576, 38);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 15;
            label5.Text = "Fecha Llegada";
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
            grp_Filtros.Controls.Add(labelClase);
            grp_Filtros.Controls.Add(labelDestino);
            grp_Filtros.Controls.Add(comboBoxClase);
            grp_Filtros.Controls.Add(labelOrigen);
            grp_Filtros.Controls.Add(labelItinerario);
            grp_Filtros.Controls.Add(comboBoxDestino);
            grp_Filtros.Controls.Add(comboBoxItinerario);
            grp_Filtros.Controls.Add(labelTipoDePasajero);
            grp_Filtros.Controls.Add(comboBoxOrigen);
            grp_Filtros.Controls.Add(comboBoxTipoDePasajero);
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
            grp_Filtros.Size = new Size(830, 231);
            grp_Filtros.TabIndex = 35;
            grp_Filtros.TabStop = false;
            grp_Filtros.Text = "Filtros";
            // 
            // labelClase
            // 
            labelClase.AutoSize = true;
            labelClase.Location = new Point(626, 125);
            labelClase.Name = "labelClase";
            labelClase.Size = new Size(35, 15);
            labelClase.TabIndex = 45;
            labelClase.Text = "Clase";
            // 
            // labelDestino
            // 
            labelDestino.AutoSize = true;
            labelDestino.Location = new Point(163, 125);
            labelDestino.Name = "labelDestino";
            labelDestino.Size = new Size(47, 15);
            labelDestino.TabIndex = 37;
            labelDestino.Text = "Destino";
            // 
            // comboBoxClase
            // 
            comboBoxClase.FormattingEnabled = true;
            comboBoxClase.Location = new Point(626, 143);
            comboBoxClase.Name = "comboBoxClase";
            comboBoxClase.Size = new Size(126, 23);
            comboBoxClase.TabIndex = 44;
            // 
            // labelOrigen
            // 
            labelOrigen.AutoSize = true;
            labelOrigen.Location = new Point(18, 125);
            labelOrigen.Name = "labelOrigen";
            labelOrigen.Size = new Size(43, 15);
            labelOrigen.TabIndex = 36;
            labelOrigen.Text = "Origen";
            // 
            // labelItinerario
            // 
            labelItinerario.AutoSize = true;
            labelItinerario.Location = new Point(470, 125);
            labelItinerario.Name = "labelItinerario";
            labelItinerario.Size = new Size(54, 15);
            labelItinerario.TabIndex = 43;
            labelItinerario.Text = "Itinerario";
            // 
            // comboBoxDestino
            // 
            comboBoxDestino.FormattingEnabled = true;
            comboBoxDestino.Location = new Point(163, 143);
            comboBoxDestino.Name = "comboBoxDestino";
            comboBoxDestino.Size = new Size(126, 23);
            comboBoxDestino.TabIndex = 35;
            // 
            // comboBoxItinerario
            // 
            comboBoxItinerario.FormattingEnabled = true;
            comboBoxItinerario.Location = new Point(470, 143);
            comboBoxItinerario.Name = "comboBoxItinerario";
            comboBoxItinerario.Size = new Size(126, 23);
            comboBoxItinerario.TabIndex = 42;
            // 
            // labelTipoDePasajero
            // 
            labelTipoDePasajero.AutoSize = true;
            labelTipoDePasajero.Location = new Point(316, 125);
            labelTipoDePasajero.Name = "labelTipoDePasajero";
            labelTipoDePasajero.Size = new Size(93, 15);
            labelTipoDePasajero.TabIndex = 41;
            labelTipoDePasajero.Text = "Tipo de Pasajero";
            // 
            // comboBoxOrigen
            // 
            comboBoxOrigen.FormattingEnabled = true;
            comboBoxOrigen.Location = new Point(18, 143);
            comboBoxOrigen.Name = "comboBoxOrigen";
            comboBoxOrigen.Size = new Size(126, 23);
            comboBoxOrigen.TabIndex = 34;
            // 
            // comboBoxTipoDePasajero
            // 
            comboBoxTipoDePasajero.FormattingEnabled = true;
            comboBoxTipoDePasajero.Location = new Point(316, 143);
            comboBoxTipoDePasajero.Name = "comboBoxTipoDePasajero";
            comboBoxTipoDePasajero.Size = new Size(126, 23);
            comboBoxTipoDePasajero.TabIndex = 40;
            // 
            // btnDisableDatePickerFilterFechaHasta
            // 
            btnDisableDatePickerFilterFechaHasta.Location = new Point(576, 85);
            btnDisableDatePickerFilterFechaHasta.Name = "btnDisableDatePickerFilterFechaHasta";
            btnDisableDatePickerFilterFechaHasta.Size = new Size(80, 23);
            btnDisableDatePickerFilterFechaHasta.TabIndex = 33;
            btnDisableDatePickerFilterFechaHasta.Text = "Deshabilitar";
            btnDisableDatePickerFilterFechaHasta.UseVisualStyleBackColor = true;
            btnDisableDatePickerFilterFechaHasta.Click += btnDisableDatePickerFilterFechaHasta_Click;
            // 
            // btnDisableDatePickerFilterFechaDesde
            // 
            btnDisableDatePickerFilterFechaDesde.Location = new Point(316, 85);
            btnDisableDatePickerFilterFechaDesde.Name = "btnDisableDatePickerFilterFechaDesde";
            btnDisableDatePickerFilterFechaDesde.Size = new Size(80, 23);
            btnDisableDatePickerFilterFechaDesde.TabIndex = 32;
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
            btnVolverMenuGenerarPresupuestos.Location = new Point(27, 618);
            btnVolverMenuGenerarPresupuestos.Name = "btnVolverMenuGenerarPresupuestos";
            btnVolverMenuGenerarPresupuestos.Size = new Size(289, 47);
            btnVolverMenuGenerarPresupuestos.TabIndex = 37;
            btnVolverMenuGenerarPresupuestos.Text = "Volver";
            btnVolverMenuGenerarPresupuestos.UseVisualStyleBackColor = true;
            btnVolverMenuGenerarPresupuestos.Click += btnVolverMenuGenerarPresupuestos_Click;
            // 
            // listViewProductos
            // 
            listViewProductos.Columns.AddRange(new ColumnHeader[] { ID, Codigo, Origen, Destino, Clase, Itinerario, Cantidad, TipoDePasajero, Precio, Aerolinea, Paradas, FechaSalida, FechaLlegada });
            listViewProductos.FullRowSelect = true;
            listViewProductos.Location = new Point(27, 360);
            listViewProductos.Name = "listViewProductos";
            listViewProductos.Size = new Size(1064, 252);
            listViewProductos.TabIndex = 38;
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
            // ConsultarAereos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1106, 686);
            Controls.Add(listViewProductos);
            Controls.Add(btnVolverMenuGenerarPresupuestos);
            Controls.Add(btnLimpiarFiltro);
            Controls.Add(grp_Filtros);
            Controls.Add(buscarPresupuesto);
            Name = "ConsultarAereos";
            Text = "Generar Presupuesto - Aéreos";
            Load += GenerarPresupuestoAereos_Load;
            Controls.SetChildIndex(buscarPresupuesto, 0);
            Controls.SetChildIndex(grp_Filtros, 0);
            Controls.SetChildIndex(btnLimpiarFiltro, 0);
            Controls.SetChildIndex(btnVolverMenuGenerarPresupuestos, 0);
            Controls.SetChildIndex(listViewProductos, 0);
            grp_Filtros.ResumeLayout(false);
            grp_Filtros.PerformLayout();
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
        private Label labelDestino;
        private Label labelOrigen;
        private ComboBox comboBoxDestino;
        private ComboBox comboBoxOrigen;
        private Button btnDisableDatePickerFilterFechaHasta;
        private Button btnDisableDatePickerFilterFechaDesde;
        private Label labelClase;
        private ComboBox comboBoxClase;
        private Label labelItinerario;
        private ComboBox comboBoxItinerario;
        private Label labelTipoDePasajero;
        private ComboBox comboBoxTipoDePasajero;
        private ListView listViewProductos;
        private ColumnHeader ID;
        private ColumnHeader Codigo;
        private ColumnHeader Origen;
        private ColumnHeader Destino;
        private ColumnHeader Clase;
        private ColumnHeader Itinerario;
        private ColumnHeader Cantidad;
        private ColumnHeader TipoDePasajero;
        private ColumnHeader Precio;
        private ColumnHeader Aerolinea;
        private ColumnHeader Paradas;
        private ColumnHeader FechaSalida;
        private ColumnHeader FechaLlegada;
    }
}