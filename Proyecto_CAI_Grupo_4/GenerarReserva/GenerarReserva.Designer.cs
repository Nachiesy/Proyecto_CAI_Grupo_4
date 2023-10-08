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
            lblcantpasajeros = new Label();
            listPasajeros = new ListView();
            nombre = new ColumnHeader();
            apellido = new ColumnHeader();
            fechadenac = new ColumnHeader();
            nacionalidad = new ColumnHeader();
            tipodoc = new ColumnHeader();
            documento = new ColumnHeader();
            fechavencimiento = new ColumnHeader();
            paisemisor = new ColumnHeader();
            email = new ColumnHeader();
            telcontacto = new ColumnHeader();
            btnQuitpasajero = new Button();
            btnAddpasajero = new Button();
            gpProsupuesto = new GroupBox();
            listPresupuestos = new ListView();
            nropresup = new ColumnHeader();
            doccliente = new ColumnHeader();
            cantpasajeros = new ColumnHeader();
            precio = new ColumnHeader();
            estado = new ColumnHeader();
            fechadesde = new ColumnHeader();
            fechahasta = new ColumnHeader();
            fecha = new ColumnHeader();
            btnBuscar = new Button();
            txbDocumento = new TextBox();
            nroPresupuestotxt = new TextBox();
            cbxTipodoc = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSelect = new Button();
            btnGenreserva = new Button();
            btnCancelar = new Button();
            lblcodigp = new Label();
            gbxPasajeros.SuspendLayout();
            gpProsupuesto.SuspendLayout();
            SuspendLayout();
            // 
            // gbxPasajeros
            // 
            gbxPasajeros.Controls.Add(lblcodigp);
            gbxPasajeros.Controls.Add(lblcantpasajeros);
            gbxPasajeros.Controls.Add(listPasajeros);
            gbxPasajeros.Controls.Add(btnQuitpasajero);
            gbxPasajeros.Controls.Add(btnAddpasajero);
            gbxPasajeros.Enabled = false;
            gbxPasajeros.Location = new Point(16, 528);
            gbxPasajeros.Name = "gbxPasajeros";
            gbxPasajeros.Size = new Size(1958, 419);
            gbxPasajeros.TabIndex = 6;
            gbxPasajeros.TabStop = false;
            gbxPasajeros.Text = "Pasajeros";
            // 
            // lblcantpasajeros
            // 
            lblcantpasajeros.AutoSize = true;
            lblcantpasajeros.Location = new Point(38, 83);
            lblcantpasajeros.Name = "lblcantpasajeros";
            lblcantpasajeros.Size = new Size(249, 32);
            lblcantpasajeros.TabIndex = 4;
            lblcantpasajeros.Text = "Pasajeros Disponibles ";
            // 
            // listPasajeros
            // 
            listPasajeros.Columns.AddRange(new ColumnHeader[] { nombre, apellido, fechadenac, nacionalidad, tipodoc, documento, fechavencimiento, paisemisor, email, telcontacto });
            listPasajeros.Location = new Point(32, 147);
            listPasajeros.Name = "listPasajeros";
            listPasajeros.Size = new Size(1920, 234);
            listPasajeros.TabIndex = 3;
            listPasajeros.UseCompatibleStateImageBehavior = false;
            listPasajeros.View = View.Details;
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
            fechavencimiento.DisplayIndex = 7;
            fechavencimiento.Text = "Fecha de Vencimiento";
            fechavencimiento.Width = 250;
            // 
            // paisemisor
            // 
            paisemisor.DisplayIndex = 6;
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
            // btnQuitpasajero
            // 
            btnQuitpasajero.Location = new Point(1802, 76);
            btnQuitpasajero.Name = "btnQuitpasajero";
            btnQuitpasajero.Size = new Size(150, 46);
            btnQuitpasajero.TabIndex = 1;
            btnQuitpasajero.Text = "Quitar";
            btnQuitpasajero.UseVisualStyleBackColor = true;
            // 
            // btnAddpasajero
            // 
            btnAddpasajero.Location = new Point(1605, 76);
            btnAddpasajero.Name = "btnAddpasajero";
            btnAddpasajero.Size = new Size(150, 46);
            btnAddpasajero.TabIndex = 0;
            btnAddpasajero.Text = "Agregar";
            btnAddpasajero.UseVisualStyleBackColor = true;
            btnAddpasajero.Click += btnAddpasajero_Click;
            // 
            // gpProsupuesto
            // 
            gpProsupuesto.Controls.Add(listPresupuestos);
            gpProsupuesto.Controls.Add(btnBuscar);
            gpProsupuesto.Controls.Add(txbDocumento);
            gpProsupuesto.Controls.Add(nroPresupuestotxt);
            gpProsupuesto.Controls.Add(cbxTipodoc);
            gpProsupuesto.Controls.Add(label3);
            gpProsupuesto.Controls.Add(label2);
            gpProsupuesto.Controls.Add(label1);
            gpProsupuesto.Controls.Add(btnSelect);
            gpProsupuesto.Location = new Point(35, 34);
            gpProsupuesto.Name = "gpProsupuesto";
            gpProsupuesto.Size = new Size(1939, 456);
            gpProsupuesto.TabIndex = 7;
            gpProsupuesto.TabStop = false;
            gpProsupuesto.Text = "Presupuestos";
            // 
            // listPresupuestos
            // 
            listPresupuestos.Columns.AddRange(new ColumnHeader[] { nropresup, doccliente, cantpasajeros, precio, estado, fechadesde, fechahasta, fecha });
            listPresupuestos.FullRowSelect = true;
            listPresupuestos.Location = new Point(19, 147);
            listPresupuestos.MultiSelect = false;
            listPresupuestos.Name = "listPresupuestos";
            listPresupuestos.ShowItemToolTips = true;
            listPresupuestos.Size = new Size(1914, 257);
            listPresupuestos.TabIndex = 9;
            listPresupuestos.UseCompatibleStateImageBehavior = false;
            listPresupuestos.View = View.Details;
            listPresupuestos.SelectedIndexChanged += listPresupuestos_SelectedIndexChanged;
            // 
            // nropresup
            // 
            nropresup.Text = "Nro. Presupuesto";
            nropresup.Width = 300;
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
            fechadesde.DisplayIndex = 6;
            fechadesde.Text = "Fecha Desde";
            fechadesde.Width = 200;
            // 
            // fechahasta
            // 
            fechahasta.DisplayIndex = 7;
            fechahasta.Text = "Fecha Hasta";
            fechahasta.Width = 200;
            // 
            // fecha
            // 
            fecha.DisplayIndex = 5;
            fecha.Text = "Fecha";
            fecha.Width = 180;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1783, 73);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(150, 46);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txbDocumento
            // 
            txbDocumento.Location = new Point(1188, 80);
            txbDocumento.Name = "txbDocumento";
            txbDocumento.Size = new Size(200, 39);
            txbDocumento.TabIndex = 7;
            // 
            // nroPresupuestotxt
            // 
            nroPresupuestotxt.Location = new Point(218, 76);
            nroPresupuestotxt.Name = "nroPresupuestotxt";
            nroPresupuestotxt.Size = new Size(200, 39);
            nroPresupuestotxt.TabIndex = 6;
            // 
            // cbxTipodoc
            // 
            cbxTipodoc.FormattingEnabled = true;
            cbxTipodoc.Location = new Point(690, 75);
            cbxTipodoc.Name = "cbxTipodoc";
            cbxTipodoc.Size = new Size(242, 40);
            cbxTipodoc.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(951, 83);
            label3.Name = "label3";
            label3.Size = new Size(231, 32);
            label3.TabIndex = 4;
            label3.Text = "Nro. de Documento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(451, 79);
            label2.Name = "label2";
            label2.Size = new Size(233, 32);
            label2.TabIndex = 3;
            label2.Text = "Tipo de Documento:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 82);
            label1.Name = "label1";
            label1.Size = new Size(202, 32);
            label1.TabIndex = 2;
            label1.Text = "Nro. Presupuesto:";
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(1783, 410);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(150, 46);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Seleccionar";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnGenreserva
            // 
            btnGenreserva.Location = new Point(1483, 995);
            btnGenreserva.Name = "btnGenreserva";
            btnGenreserva.Size = new Size(233, 46);
            btnGenreserva.TabIndex = 8;
            btnGenreserva.Text = "Generar Reserva";
            btnGenreserva.UseVisualStyleBackColor = true;
            btnGenreserva.Click += btnGenreserva_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1735, 995);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(233, 46);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblcodigp
            // 
            lblcodigp.AutoSize = true;
            lblcodigp.Location = new Point(359, 83);
            lblcodigp.Name = "lblcodigp";
            lblcodigp.Size = new Size(241, 32);
            lblcodigp.TabIndex = 5;
            lblcodigp.Text = "Codigo Presupuesto: ";
            lblcodigp.Click += label4_Click;
            // 
            // GenerarReserva
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2003, 1096);
            Controls.Add(btnCancelar);
            Controls.Add(btnGenreserva);
            Controls.Add(gpProsupuesto);
            Controls.Add(gbxPasajeros);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "GenerarReserva";
            Text = "Generar Reserva";
            Load += GenerarReserva_Load;
            gbxPasajeros.ResumeLayout(false);
            gbxPasajeros.PerformLayout();
            gpProsupuesto.ResumeLayout(false);
            gpProsupuesto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbxPasajeros;
        private Button btnQuitpasajero;
        private Button btnAddpasajero;
        private GroupBox gpProsupuesto;
        private Button btnBuscar;
        private TextBox txbDocumento;
        private TextBox nroPresupuestotxt;
        private ComboBox cbxTipodoc;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSelect;
        private Button btnGenreserva;
        private Button btnCancelar;
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
    }
}