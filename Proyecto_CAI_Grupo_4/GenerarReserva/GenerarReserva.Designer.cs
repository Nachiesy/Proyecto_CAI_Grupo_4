namespace Proyecto_CAI_Grupo_4
{
    partial class GenerarReserva
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
            gbxPasajeros = new GroupBox();
            lblcodigp = new Label();
            btn_Quitar = new Common.Components.BotonEstilizado();
            lblcantpasajeros = new Label();
            btn_Agregar = new Common.Components.BotonEstilizado();
            listPasajeros = new ListView();
            nombre = new ColumnHeader();
            apellido = new ColumnHeader();
            fechadenac = new ColumnHeader();
            edad = new ColumnHeader();
            tipopasajero = new ColumnHeader();
            nacionalidad = new ColumnHeader();
            tipodoc = new ColumnHeader();
            documento = new ColumnHeader();
            fechavencimiento = new ColumnHeader();
            paisemisor = new ColumnHeader();
            email = new ColumnHeader();
            telcontacto = new ColumnHeader();
            gpProsupuesto = new GroupBox();
            btn_Buscar = new Common.Components.BotonEstilizado();
            listPresupuestos = new ListView();
            nropresup = new ColumnHeader();
            doccliente = new ColumnHeader();
            cantpasajeros = new ColumnHeader();
            cantAdultos = new ColumnHeader();
            cantMenores = new ColumnHeader();
            precio = new ColumnHeader();
            estado = new ColumnHeader();
            fechadesde = new ColumnHeader();
            fechahasta = new ColumnHeader();
            fecha = new ColumnHeader();
            txbDocumento = new TextBox();
            nroPresupuestotxt = new TextBox();
            cbxTipodoc = new ComboBox();
            btn_SeleccionarPresupuesto = new Common.Components.BotonEstilizado();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_GenerarReserva = new Common.Components.BotonEstilizado();
            btn_Cancelar = new Common.Components.BotonEstilizado();
            gbxPasajeros.SuspendLayout();
            gpProsupuesto.SuspendLayout();
            SuspendLayout();
            // 
            // gbxPasajeros
            // 
            gbxPasajeros.Controls.Add(lblcodigp);
            gbxPasajeros.Controls.Add(btn_Quitar);
            gbxPasajeros.Controls.Add(lblcantpasajeros);
            gbxPasajeros.Controls.Add(btn_Agregar);
            gbxPasajeros.Controls.Add(listPasajeros);
            gbxPasajeros.Enabled = false;
            gbxPasajeros.Location = new Point(22, 762);
            gbxPasajeros.Margin = new Padding(4, 2, 4, 2);
            gbxPasajeros.Name = "gbxPasajeros";
            gbxPasajeros.Padding = new Padding(4, 2, 4, 2);
            gbxPasajeros.Size = new Size(2009, 418);
            gbxPasajeros.TabIndex = 6;
            gbxPasajeros.TabStop = false;
            gbxPasajeros.Text = "Pasajeros";
            // 
            // lblcodigp
            // 
            lblcodigp.AutoSize = true;
            lblcodigp.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblcodigp.Location = new Point(524, 64);
            lblcodigp.Margin = new Padding(4, 0, 4, 0);
            lblcodigp.Name = "lblcodigp";
            lblcodigp.Size = new Size(336, 48);
            lblcodigp.TabIndex = 5;
            lblcodigp.Text = "ID Presupuesto:  -";
            // 
            // btn_Quitar
            // 
            btn_Quitar.BackColor = Color.Transparent;
            btn_Quitar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_Quitar.FlatStyle = FlatStyle.Flat;
            btn_Quitar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Quitar.ForeColor = Color.Black;
            btn_Quitar.Location = new Point(1814, 47);
            btn_Quitar.Margin = new Padding(6);
            btn_Quitar.Name = "btn_Quitar";
            btn_Quitar.Size = new Size(186, 85);
            btn_Quitar.TabIndex = 13;
            btn_Quitar.Text = "Quitar";
            btn_Quitar.UseVisualStyleBackColor = false;
            // 
            // lblcantpasajeros
            // 
            lblcantpasajeros.AutoSize = true;
            lblcantpasajeros.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblcantpasajeros.Location = new Point(32, 64);
            lblcantpasajeros.Margin = new Padding(4, 0, 4, 0);
            lblcantpasajeros.Name = "lblcantpasajeros";
            lblcantpasajeros.Size = new Size(452, 48);
            lblcantpasajeros.TabIndex = 4;
            lblcantpasajeros.Text = "Pasajeros Disponibles:  -";
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.Transparent;
            btn_Agregar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_Agregar.FlatStyle = FlatStyle.Flat;
            btn_Agregar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Agregar.ForeColor = Color.Black;
            btn_Agregar.Location = new Point(1618, 47);
            btn_Agregar.Margin = new Padding(6);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(186, 85);
            btn_Agregar.TabIndex = 12;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btnAddpasajero_Click;
            // 
            // listPasajeros
            // 
            listPasajeros.Columns.AddRange(new ColumnHeader[] { nombre, apellido, fechadenac, edad, tipopasajero, nacionalidad, tipodoc, documento, fechavencimiento, paisemisor, email, telcontacto });
            listPasajeros.Location = new Point(32, 147);
            listPasajeros.Margin = new Padding(4, 2, 4, 2);
            listPasajeros.Name = "listPasajeros";
            listPasajeros.Size = new Size(1965, 234);
            listPasajeros.TabIndex = 3;
            listPasajeros.UseCompatibleStateImageBehavior = false;
            listPasajeros.View = View.Details;
            listPasajeros.SelectedIndexChanged += listPasajeros_SelectedIndexChanged;
            // 
            // nombre
            // 
            nombre.Text = "Nombre";
            nombre.Width = 160;
            // 
            // apellido
            // 
            apellido.Text = "Apellido";
            apellido.Width = 160;
            // 
            // fechadenac
            // 
            fechadenac.Text = "Fecha de Nacimiento";
            fechadenac.Width = 250;
            // 
            // edad
            // 
            edad.Text = "Edad";
            edad.Width = 80;
            // 
            // tipopasajero
            // 
            tipopasajero.Text = "Tipo";
            tipopasajero.Width = 100;
            // 
            // nacionalidad
            // 
            nacionalidad.Text = "Nacionalidad";
            nacionalidad.Width = 160;
            // 
            // tipodoc
            // 
            tipodoc.Text = "Tipo de Doc.";
            tipodoc.Width = 160;
            // 
            // documento
            // 
            documento.Text = "Documento";
            documento.Width = 160;
            // 
            // fechavencimiento
            // 
            fechavencimiento.Text = "Fecha de Vencimiento";
            fechavencimiento.Width = 250;
            // 
            // paisemisor
            // 
            paisemisor.Text = "Pais Emisor";
            paisemisor.Width = 160;
            // 
            // email
            // 
            email.Text = "E-mail";
            email.Width = 200;
            // 
            // telcontacto
            // 
            telcontacto.Text = "Tel. de Contacto";
            telcontacto.Width = 180;
            // 
            // gpProsupuesto
            // 
            gpProsupuesto.Controls.Add(btn_Buscar);
            gpProsupuesto.Controls.Add(listPresupuestos);
            gpProsupuesto.Controls.Add(txbDocumento);
            gpProsupuesto.Controls.Add(nroPresupuestotxt);
            gpProsupuesto.Controls.Add(cbxTipodoc);
            gpProsupuesto.Controls.Add(btn_SeleccionarPresupuesto);
            gpProsupuesto.Controls.Add(label3);
            gpProsupuesto.Controls.Add(label2);
            gpProsupuesto.Controls.Add(label1);
            gpProsupuesto.Location = new Point(20, 222);
            gpProsupuesto.Margin = new Padding(4, 2, 4, 2);
            gpProsupuesto.Name = "gpProsupuesto";
            gpProsupuesto.Padding = new Padding(4, 2, 4, 2);
            gpProsupuesto.Size = new Size(2011, 535);
            gpProsupuesto.TabIndex = 7;
            gpProsupuesto.TabStop = false;
            gpProsupuesto.Text = "Presupuestos";
            gpProsupuesto.Enter += gpProsupuesto_Enter;
            // 
            // btn_Buscar
            // 
            btn_Buscar.BackColor = Color.Transparent;
            btn_Buscar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_Buscar.FlatStyle = FlatStyle.Flat;
            btn_Buscar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Buscar.ForeColor = Color.Black;
            btn_Buscar.Location = new Point(1692, 32);
            btn_Buscar.Margin = new Padding(6);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(310, 85);
            btn_Buscar.TabIndex = 14;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = false;
            btn_Buscar.Click += btnBuscar_Click;
            // 
            // listPresupuestos
            // 
            listPresupuestos.Columns.AddRange(new ColumnHeader[] { nropresup, doccliente, cantpasajeros, cantAdultos, cantMenores, precio, estado, fechadesde, fechahasta, fecha });
            listPresupuestos.FullRowSelect = true;
            listPresupuestos.Location = new Point(19, 126);
            listPresupuestos.Margin = new Padding(4, 2, 4, 2);
            listPresupuestos.MultiSelect = false;
            listPresupuestos.Name = "listPresupuestos";
            listPresupuestos.ShowItemToolTips = true;
            listPresupuestos.Size = new Size(1980, 279);
            listPresupuestos.TabIndex = 9;
            listPresupuestos.UseCompatibleStateImageBehavior = false;
            listPresupuestos.View = View.Details;
            listPresupuestos.SelectedIndexChanged += listPresupuestos_SelectedIndexChanged;
            // 
            // nropresup
            // 
            nropresup.Text = "ID Presupuesto";
            nropresup.Width = 200;
            // 
            // doccliente
            // 
            doccliente.Text = "Documento";
            doccliente.Width = 160;
            // 
            // cantpasajeros
            // 
            cantpasajeros.Text = "Cant. de Pasajeros";
            cantpasajeros.Width = 220;
            // 
            // cantAdultos
            // 
            cantAdultos.Text = "Cant. Adultos";
            cantAdultos.Width = 200;
            // 
            // cantMenores
            // 
            cantMenores.Text = "Cant. Menores";
            cantMenores.Width = 200;
            // 
            // precio
            // 
            precio.Text = "Precio";
            precio.Width = 180;
            // 
            // estado
            // 
            estado.Text = "Estado";
            estado.Width = 180;
            // 
            // fechadesde
            // 
            fechadesde.Text = "Fecha Desde";
            fechadesde.Width = 200;
            // 
            // fechahasta
            // 
            fechahasta.Text = "Fecha Hasta";
            fechahasta.Width = 200;
            // 
            // fecha
            // 
            fecha.Text = "Fecha";
            fecha.Width = 180;
            // 
            // txbDocumento
            // 
            txbDocumento.Location = new Point(1356, 53);
            txbDocumento.Margin = new Padding(4, 2, 4, 2);
            txbDocumento.Name = "txbDocumento";
            txbDocumento.Size = new Size(305, 39);
            txbDocumento.TabIndex = 7;
            // 
            // nroPresupuestotxt
            // 
            nroPresupuestotxt.Location = new Point(271, 53);
            nroPresupuestotxt.Margin = new Padding(4, 2, 4, 2);
            nroPresupuestotxt.Name = "nroPresupuestotxt";
            nroPresupuestotxt.Size = new Size(201, 39);
            nroPresupuestotxt.TabIndex = 6;
            // 
            // cbxTipodoc
            // 
            cbxTipodoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipodoc.FormattingEnabled = true;
            cbxTipodoc.Location = new Point(806, 53);
            cbxTipodoc.Margin = new Padding(4, 2, 4, 2);
            cbxTipodoc.Name = "cbxTipodoc";
            cbxTipodoc.Size = new Size(242, 40);
            cbxTipodoc.TabIndex = 5;
            // 
            // btn_SeleccionarPresupuesto
            // 
            btn_SeleccionarPresupuesto.BackColor = Color.Transparent;
            btn_SeleccionarPresupuesto.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_SeleccionarPresupuesto.FlatStyle = FlatStyle.Flat;
            btn_SeleccionarPresupuesto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SeleccionarPresupuesto.ForeColor = Color.Black;
            btn_SeleccionarPresupuesto.Location = new Point(19, 442);
            btn_SeleccionarPresupuesto.Margin = new Padding(6);
            btn_SeleccionarPresupuesto.Name = "btn_SeleccionarPresupuesto";
            btn_SeleccionarPresupuesto.Size = new Size(1983, 85);
            btn_SeleccionarPresupuesto.TabIndex = 11;
            btn_SeleccionarPresupuesto.Text = "Seleccionar";
            btn_SeleccionarPresupuesto.UseVisualStyleBackColor = false;
            btn_SeleccionarPresupuesto.Click += btnSelect_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1059, 53);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(305, 38);
            label3.TabIndex = 4;
            label3.Text = "Nro. de Documento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(503, 53);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(307, 38);
            label2.TabIndex = 3;
            label2.Text = "Tipo de Documento:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(269, 38);
            label1.TabIndex = 2;
            label1.Text = "Nro. Presupuesto:";
            // 
            // btn_GenerarReserva
            // 
            btn_GenerarReserva.BackColor = Color.Transparent;
            btn_GenerarReserva.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_GenerarReserva.FlatStyle = FlatStyle.Flat;
            btn_GenerarReserva.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_GenerarReserva.ForeColor = Color.Black;
            btn_GenerarReserva.Location = new Point(1007, 1188);
            btn_GenerarReserva.Margin = new Padding(6);
            btn_GenerarReserva.Name = "btn_GenerarReserva";
            btn_GenerarReserva.Size = new Size(1023, 85);
            btn_GenerarReserva.TabIndex = 4;
            btn_GenerarReserva.Text = "Generar Reserva";
            btn_GenerarReserva.UseVisualStyleBackColor = false;
            btn_GenerarReserva.Click += btnGenreserva_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.Transparent;
            btn_Cancelar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Cancelar.ForeColor = Color.Black;
            btn_Cancelar.Location = new Point(22, 1188);
            btn_Cancelar.Margin = new Padding(6);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(973, 85);
            btn_Cancelar.TabIndex = 10;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btnCancelar_Click;
            // 
            // GenerarReserva
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(2052, 1299);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_GenerarReserva);
            Controls.Add(gpProsupuesto);
            Controls.Add(gbxPasajeros);
            Margin = new Padding(2);
            Name = "GenerarReserva";
            Text = "Generar Reserva";
            Load += GenerarReserva_Load;
            Controls.SetChildIndex(gbxPasajeros, 0);
            Controls.SetChildIndex(gpProsupuesto, 0);
            Controls.SetChildIndex(btn_GenerarReserva, 0);
            Controls.SetChildIndex(btn_Cancelar, 0);
            gbxPasajeros.ResumeLayout(false);
            gbxPasajeros.PerformLayout();
            gpProsupuesto.ResumeLayout(false);
            gpProsupuesto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbxPasajeros;
        private GroupBox gpProsupuesto;
        private TextBox txbDocumento;
        private TextBox nroPresupuestotxt;
        private ComboBox cbxTipodoc;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView listPasajeros;
        private ColumnHeader nombre;
        private ColumnHeader apellido;
        private ColumnHeader fechadenac;
        private ColumnHeader tipodoc;
        private ColumnHeader documento;
        private ColumnHeader paisemisor;
        private ColumnHeader fechavencimiento;
        private ColumnHeader nacionalidad;
        private ColumnHeader email;
        private ColumnHeader telcontacto;
        private ListView listPresupuestos;
        private ColumnHeader nropresup;
        private ColumnHeader doccliente;
        private ColumnHeader cantpasajeros;
        private ColumnHeader precio;
        private ColumnHeader estado;
        private ColumnHeader fechadesde;
        private ColumnHeader fechahasta;
        private ColumnHeader fecha;
        private Label lblcantpasajeros;
        private Label lblcodigp;
        private Common.Components.BotonEstilizado btn_GenerarReserva;
        private Common.Components.BotonEstilizado btn_Cancelar;
        private Common.Components.BotonEstilizado btn_SeleccionarPresupuesto;
        private Common.Components.BotonEstilizado btn_Agregar;
        private Common.Components.BotonEstilizado btn_Quitar;
        private Common.Components.BotonEstilizado btn_Buscar;
        private ColumnHeader edad;
        private ColumnHeader tipopasajero;
        private ColumnHeader cantAdultos;
        private ColumnHeader cantMenores;
    }
}