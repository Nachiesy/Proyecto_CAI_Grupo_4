namespace Proyecto_CAI_Grupo_4
{
    partial class GenerarPreReserva
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
            btn_GenerarReserva = new Common.Components.BotonEstilizado();
            gbxPasajeros.SuspendLayout();
            SuspendLayout();
            // 
            // gbxPasajeros
            // 
            gbxPasajeros.Controls.Add(lblcodigp);
            gbxPasajeros.Controls.Add(btn_Quitar);
            gbxPasajeros.Controls.Add(lblcantpasajeros);
            gbxPasajeros.Controls.Add(btn_Agregar);
            gbxPasajeros.Controls.Add(listPasajeros);
            gbxPasajeros.Location = new Point(12, 114);
            gbxPasajeros.Margin = new Padding(2, 1, 2, 1);
            gbxPasajeros.Name = "gbxPasajeros";
            gbxPasajeros.Padding = new Padding(2, 1, 2, 1);
            gbxPasajeros.Size = new Size(1082, 439);
            gbxPasajeros.TabIndex = 6;
            gbxPasajeros.TabStop = false;
            gbxPasajeros.Text = "Pasajeros";
            // 
            // lblcodigp
            // 
            lblcodigp.AutoSize = true;
            lblcodigp.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblcodigp.Location = new Point(282, 30);
            lblcodigp.Margin = new Padding(2, 0, 2, 0);
            lblcodigp.Name = "lblcodigp";
            lblcodigp.Size = new Size(169, 24);
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
            btn_Quitar.Location = new Point(977, 22);
            btn_Quitar.Name = "btn_Quitar";
            btn_Quitar.Size = new Size(100, 40);
            btn_Quitar.TabIndex = 13;
            btn_Quitar.Text = "Quitar";
            btn_Quitar.UseVisualStyleBackColor = false;
            btn_Quitar.Click += btn_Quitar_Click;
            // 
            // lblcantpasajeros
            // 
            lblcantpasajeros.AutoSize = true;
            lblcantpasajeros.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblcantpasajeros.Location = new Point(17, 30);
            lblcantpasajeros.Margin = new Padding(2, 0, 2, 0);
            lblcantpasajeros.Name = "lblcantpasajeros";
            lblcantpasajeros.Size = new Size(227, 24);
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
            btn_Agregar.Location = new Point(871, 22);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(100, 40);
            btn_Agregar.TabIndex = 12;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btnAddpasajero_Click;
            // 
            // listPasajeros
            // 
            listPasajeros.Columns.AddRange(new ColumnHeader[] { nombre, apellido, fechadenac, edad, tipopasajero, nacionalidad, tipodoc, documento, fechavencimiento, paisemisor, email, telcontacto });
            listPasajeros.FullRowSelect = true;
            listPasajeros.Location = new Point(17, 69);
            listPasajeros.Margin = new Padding(2, 1, 2, 1);
            listPasajeros.Name = "listPasajeros";
            listPasajeros.Size = new Size(1060, 353);
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
            // btn_GenerarReserva
            // 
            btn_GenerarReserva.BackColor = Color.Transparent;
            btn_GenerarReserva.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_GenerarReserva.FlatStyle = FlatStyle.Flat;
            btn_GenerarReserva.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_GenerarReserva.ForeColor = Color.Black;
            btn_GenerarReserva.Location = new Point(12, 557);
            btn_GenerarReserva.Name = "btn_GenerarReserva";
            btn_GenerarReserva.Size = new Size(1081, 40);
            btn_GenerarReserva.TabIndex = 4;
            btn_GenerarReserva.Text = "Generar Pre Reserva";
            btn_GenerarReserva.UseVisualStyleBackColor = false;
            btn_GenerarReserva.Click += btnGenreserva_Click;
            // 
            // GenerarPreReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1105, 612);
            Controls.Add(btn_GenerarReserva);
            Controls.Add(gbxPasajeros);
            Margin = new Padding(1);
            Name = "GenerarPreReserva";
            Text = "Generar Reserva";
            Load += GenerarPreReserva_Load;
            Controls.SetChildIndex(gbxPasajeros, 0);
            Controls.SetChildIndex(btn_GenerarReserva, 0);
            gbxPasajeros.ResumeLayout(false);
            gbxPasajeros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbxPasajeros;
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
        private Label lblcantpasajeros;
        private Label lblcodigp;
        private Common.Components.BotonEstilizado btn_GenerarReserva;
        private Common.Components.BotonEstilizado btn_Agregar;
        private Common.Components.BotonEstilizado btn_Quitar;
        private ColumnHeader edad;
        private ColumnHeader tipopasajero;
    }
}