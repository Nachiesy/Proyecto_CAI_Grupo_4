namespace Proyecto_CAI_Grupo_4
{
    partial class GenerarPresupuestoCruceros
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
            grp_CrucerosDisponibles = new GroupBox();
            listViewProductos = new ListView();
            ID = new ColumnHeader();
            Codigo = new ColumnHeader();
            Nombre = new ColumnHeader();
            Origen = new ColumnHeader();
            Destino = new ColumnHeader();
            Cantidad = new ColumnHeader();
            TipoCamarote = new ColumnHeader();
            Precio = new ColumnHeader();
            FechaDesde = new ColumnHeader();
            FechaHasta = new ColumnHeader();
            btnAgregarProductos = new Common.Components.BotonEstilizado();
            grp_CrucerosSeleccionados = new GroupBox();
            listViewProductosSeleccionados = new ListView();
            SelectID = new ColumnHeader();
            SelectCodigo = new ColumnHeader();
            SelectNombre = new ColumnHeader();
            SelectOrigen = new ColumnHeader();
            SelectDestino = new ColumnHeader();
            SelectTipoCamarote = new ColumnHeader();
            SelectPrecio = new ColumnHeader();
            SelectFechaDesde = new ColumnHeader();
            SelectFechaHasta = new ColumnHeader();
            btnRemoverProductos = new Common.Components.BotonEstilizado();
            btnConfirmarProductosSeleccionados = new Common.Components.BotonEstilizado();
            btnVolverAlMenuGenerarPresupuestos = new Common.Components.BotonEstilizado();
            grp_Filtros = new GroupBox();
            labelTipoDeCamarote = new Label();
            comboBoxTipoDeCamarote = new ComboBox();
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
            grp_CrucerosDisponibles.SuspendLayout();
            grp_CrucerosSeleccionados.SuspendLayout();
            grp_Filtros.SuspendLayout();
            SuspendLayout();
            // 
            // grp_CrucerosDisponibles
            // 
            grp_CrucerosDisponibles.Controls.Add(listViewProductos);
            grp_CrucerosDisponibles.Controls.Add(btnAgregarProductos);
            grp_CrucerosDisponibles.Location = new Point(362, 127);
            grp_CrucerosDisponibles.Name = "grp_CrucerosDisponibles";
            grp_CrucerosDisponibles.Size = new Size(976, 278);
            grp_CrucerosDisponibles.TabIndex = 38;
            grp_CrucerosDisponibles.TabStop = false;
            grp_CrucerosDisponibles.Text = "Cruceros Disponibles";
            // 
            // listViewProductos
            // 
            listViewProductos.Columns.AddRange(new ColumnHeader[] { ID, Codigo, Nombre, Origen, Destino, Cantidad, TipoCamarote, Precio, FechaDesde, FechaHasta });
            listViewProductos.FullRowSelect = true;
            listViewProductos.Location = new Point(6, 22);
            listViewProductos.Name = "listViewProductos";
            listViewProductos.Size = new Size(964, 194);
            listViewProductos.TabIndex = 7;
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
            // TipoCamarote
            // 
            TipoCamarote.Text = "Tipo de Camarote";
            TipoCamarote.Width = 150;
            // 
            // Precio
            // 
            Precio.Text = "Precio";
            Precio.Width = 100;
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
            grp_CrucerosSeleccionados.Text = "Cruceros Seleccionados";
            // 
            // listViewProductosSeleccionados
            // 
            listViewProductosSeleccionados.Columns.AddRange(new ColumnHeader[] { SelectID, SelectCodigo, SelectNombre, SelectOrigen, SelectDestino, SelectTipoCamarote, SelectPrecio, SelectFechaDesde, SelectFechaHasta });
            listViewProductosSeleccionados.FullRowSelect = true;
            listViewProductosSeleccionados.Location = new Point(6, 22);
            listViewProductosSeleccionados.Name = "listViewProductosSeleccionados";
            listViewProductosSeleccionados.Size = new Size(964, 194);
            listViewProductosSeleccionados.TabIndex = 8;
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
            // SelectTipoCamarote
            // 
            SelectTipoCamarote.Text = "Tipo de Camarote";
            SelectTipoCamarote.Width = 150;
            // 
            // SelectPrecio
            // 
            SelectPrecio.Text = "Precio";
            SelectPrecio.Width = 100;
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
            btnVolverAlMenuGenerarPresupuestos.Location = new Point(12, 642);
            btnVolverAlMenuGenerarPresupuestos.Name = "btnVolverAlMenuGenerarPresupuestos";
            btnVolverAlMenuGenerarPresupuestos.Size = new Size(319, 47);
            btnVolverAlMenuGenerarPresupuestos.TabIndex = 42;
            btnVolverAlMenuGenerarPresupuestos.Text = "Volver";
            btnVolverAlMenuGenerarPresupuestos.UseVisualStyleBackColor = false;
            btnVolverAlMenuGenerarPresupuestos.Click += btnVolverAlMenuGenerarPresupuestos_Click;
            // 
            // grp_Filtros
            // 
            grp_Filtros.Controls.Add(labelTipoDeCamarote);
            grp_Filtros.Controls.Add(comboBoxTipoDeCamarote);
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
            grp_Filtros.Location = new Point(12, 127);
            grp_Filtros.Name = "grp_Filtros";
            grp_Filtros.Size = new Size(319, 500);
            grp_Filtros.TabIndex = 43;
            grp_Filtros.TabStop = false;
            grp_Filtros.Text = "Filtros";
            // 
            // labelTipoDeCamarote
            // 
            labelTipoDeCamarote.AutoSize = true;
            labelTipoDeCamarote.Location = new Point(18, 329);
            labelTipoDeCamarote.Name = "labelTipoDeCamarote";
            labelTipoDeCamarote.Size = new Size(101, 15);
            labelTipoDeCamarote.TabIndex = 27;
            labelTipoDeCamarote.Text = "Tipo de Camarote";
            // 
            // comboBoxTipoDeCamarote
            // 
            comboBoxTipoDeCamarote.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoDeCamarote.FormattingEnabled = true;
            comboBoxTipoDeCamarote.Location = new Point(18, 347);
            comboBoxTipoDeCamarote.Name = "comboBoxTipoDeCamarote";
            comboBoxTipoDeCamarote.Size = new Size(126, 23);
            comboBoxTipoDeCamarote.TabIndex = 26;
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
            // btnLimpiarFiltro
            // 
            btnLimpiarFiltro.BackColor = Color.Transparent;
            btnLimpiarFiltro.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnLimpiarFiltro.FlatStyle = FlatStyle.Flat;
            btnLimpiarFiltro.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiarFiltro.ForeColor = Color.Black;
            btnLimpiarFiltro.Location = new Point(163, 404);
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
            btnBuscarProductos.Location = new Point(18, 404);
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
            // GenerarPresupuestoCruceros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1364, 721);
            Controls.Add(grp_Filtros);
            Controls.Add(btnVolverAlMenuGenerarPresupuestos);
            Controls.Add(grp_CrucerosSeleccionados);
            Controls.Add(grp_CrucerosDisponibles);
            Name = "GenerarPresupuestoCruceros";
            Text = "Generar Presupuesto - Aéreos";
            Load += GenerarPresupuestoCruceros_Load;
            Controls.SetChildIndex(grp_CrucerosDisponibles, 0);
            Controls.SetChildIndex(grp_CrucerosSeleccionados, 0);
            Controls.SetChildIndex(btnVolverAlMenuGenerarPresupuestos, 0);
            Controls.SetChildIndex(grp_Filtros, 0);
            grp_CrucerosDisponibles.ResumeLayout(false);
            grp_CrucerosSeleccionados.ResumeLayout(false);
            grp_Filtros.ResumeLayout(false);
            grp_Filtros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp_CrucerosDisponibles;
        private Common.Components.BotonEstilizado btnAgregarProductos;
        private GroupBox grp_CrucerosSeleccionados;
        private Common.Components.BotonEstilizado btnRemoverProductos;
        private Common.Components.BotonEstilizado btnConfirmarProductosSeleccionados;
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
        private Label labelTipoDeCamarote;
        private ComboBox comboBoxTipoDeCamarote;
        private ListView listViewProductos;
        private ColumnHeader ID;
        private ColumnHeader Codigo;
        private ColumnHeader Origen;
        private ColumnHeader Destino;
        private ColumnHeader Cantidad;
        private ColumnHeader TipoCamarote;
        private ColumnHeader Precio;
        private ColumnHeader FechaDesde;
        private ColumnHeader FechaHasta;
        private ListView listViewProductosSeleccionados;
        private ColumnHeader SelectID;
        private ColumnHeader SelectCodigo;
        private ColumnHeader SelectOrigen;
        private ColumnHeader SelectDestino;
        private ColumnHeader SelectTipoCamarote;
        private ColumnHeader SelectPrecio;
        private ColumnHeader SelectFechaDesde;
        private ColumnHeader SelectFechaHasta;
        private ColumnHeader Nombre;
        private ColumnHeader SelectNombre;
    }
}