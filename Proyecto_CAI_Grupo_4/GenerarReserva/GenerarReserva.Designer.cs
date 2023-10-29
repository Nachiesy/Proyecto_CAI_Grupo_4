﻿namespace Proyecto_CAI_Grupo_4
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
            gbxPresupuesto = new GroupBox();
            btn_Buscar = new Common.Components.BotonEstilizado();
            listPresupuestos = new ListView();
            nropresup = new ColumnHeader();
            doccliente = new ColumnHeader();
            cantpasajeros = new ColumnHeader();
            cantAdultos = new ColumnHeader();
            cantMenores = new ColumnHeader();
            precio = new ColumnHeader();
            estado = new ColumnHeader();
            fecha = new ColumnHeader();
            prereserva = new ColumnHeader();
            txbDocumento = new TextBox();
            nroPresupuestotxt = new TextBox();
            btn_SeleccionarPresupuesto = new Common.Components.BotonEstilizado();
            label3 = new Label();
            label1 = new Label();
            btn_GenerarReserva = new Common.Components.BotonEstilizado();
            btn_Cancelar = new Common.Components.BotonEstilizado();
            codigoproducto = new ColumnHeader();
            nombreproducto = new ColumnHeader();
            gbxPasajeros.SuspendLayout();
            gbxPresupuesto.SuspendLayout();
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
            gbxPasajeros.Location = new Point(12, 357);
            gbxPasajeros.Margin = new Padding(2, 1, 2, 1);
            gbxPasajeros.Name = "gbxPasajeros";
            gbxPasajeros.Padding = new Padding(2, 1, 2, 1);
            gbxPasajeros.Size = new Size(1082, 196);
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
            listPasajeros.Columns.AddRange(new ColumnHeader[] { codigoproducto, nombreproducto, nombre, apellido, fechadenac, edad });
            listPasajeros.FullRowSelect = true;
            listPasajeros.Location = new Point(17, 69);
            listPasajeros.Margin = new Padding(2, 1, 2, 1);
            listPasajeros.Name = "listPasajeros";
            listPasajeros.Size = new Size(1060, 112);
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
            // gbxPresupuesto
            // 
            gbxPresupuesto.Controls.Add(btn_Buscar);
            gbxPresupuesto.Controls.Add(listPresupuestos);
            gbxPresupuesto.Controls.Add(txbDocumento);
            gbxPresupuesto.Controls.Add(nroPresupuestotxt);
            gbxPresupuesto.Controls.Add(btn_SeleccionarPresupuesto);
            gbxPresupuesto.Controls.Add(label3);
            gbxPresupuesto.Controls.Add(label1);
            gbxPresupuesto.Location = new Point(11, 104);
            gbxPresupuesto.Margin = new Padding(2, 1, 2, 1);
            gbxPresupuesto.Name = "gbxPresupuesto";
            gbxPresupuesto.Padding = new Padding(2, 1, 2, 1);
            gbxPresupuesto.Size = new Size(1083, 251);
            gbxPresupuesto.TabIndex = 7;
            gbxPresupuesto.TabStop = false;
            gbxPresupuesto.Text = "Presupuestos";
            gbxPresupuesto.Enter += gpProsupuesto_Enter;
            // 
            // btn_Buscar
            // 
            btn_Buscar.BackColor = Color.Transparent;
            btn_Buscar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_Buscar.FlatStyle = FlatStyle.Flat;
            btn_Buscar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Buscar.ForeColor = Color.Black;
            btn_Buscar.Location = new Point(911, 15);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(167, 40);
            btn_Buscar.TabIndex = 14;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = false;
            btn_Buscar.Click += btnBuscar_Click;
            // 
            // listPresupuestos
            // 
            listPresupuestos.Columns.AddRange(new ColumnHeader[] { nropresup, doccliente, cantpasajeros, cantAdultos, cantMenores, precio, estado, fecha, prereserva });
            listPresupuestos.FullRowSelect = true;
            listPresupuestos.Location = new Point(10, 59);
            listPresupuestos.Margin = new Padding(2, 1, 2, 1);
            listPresupuestos.MultiSelect = false;
            listPresupuestos.Name = "listPresupuestos";
            listPresupuestos.ShowItemToolTips = true;
            listPresupuestos.Size = new Size(1068, 133);
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
            // fecha
            // 
            fecha.Text = "Fecha";
            fecha.Width = 180;
            // 
            // prereserva
            // 
            prereserva.Text = "Prereserva";
            prereserva.TextAlign = HorizontalAlignment.Right;
            // 
            // txbDocumento
            // 
            txbDocumento.Location = new Point(312, 25);
            txbDocumento.Margin = new Padding(2, 1, 2, 1);
            txbDocumento.Name = "txbDocumento";
            txbDocumento.Size = new Size(166, 23);
            txbDocumento.TabIndex = 7;
            // 
            // nroPresupuestotxt
            // 
            nroPresupuestotxt.Location = new Point(146, 25);
            nroPresupuestotxt.Margin = new Padding(2, 1, 2, 1);
            nroPresupuestotxt.Name = "nroPresupuestotxt";
            nroPresupuestotxt.Size = new Size(110, 23);
            nroPresupuestotxt.TabIndex = 6;
            // 
            // btn_SeleccionarPresupuesto
            // 
            btn_SeleccionarPresupuesto.BackColor = Color.Transparent;
            btn_SeleccionarPresupuesto.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_SeleccionarPresupuesto.FlatStyle = FlatStyle.Flat;
            btn_SeleccionarPresupuesto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SeleccionarPresupuesto.ForeColor = Color.Black;
            btn_SeleccionarPresupuesto.Location = new Point(10, 207);
            btn_SeleccionarPresupuesto.Name = "btn_SeleccionarPresupuesto";
            btn_SeleccionarPresupuesto.Size = new Size(1068, 40);
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
            label3.Location = new Point(269, 25);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 19);
            label3.TabIndex = 4;
            label3.Text = "DNI:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 19);
            label1.TabIndex = 2;
            label1.Text = "ID Presupuesto:";
            // 
            // btn_GenerarReserva
            // 
            btn_GenerarReserva.BackColor = Color.Transparent;
            btn_GenerarReserva.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_GenerarReserva.FlatStyle = FlatStyle.Flat;
            btn_GenerarReserva.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_GenerarReserva.ForeColor = Color.Black;
            btn_GenerarReserva.Location = new Point(542, 557);
            btn_GenerarReserva.Name = "btn_GenerarReserva";
            btn_GenerarReserva.Size = new Size(551, 40);
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
            btn_Cancelar.Location = new Point(12, 557);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(524, 40);
            btn_Cancelar.TabIndex = 10;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btnCancelar_Click;
            // 
            // codigoproducto
            // 
            codigoproducto.Text = "Codigo de Producto";
            codigoproducto.Width = 180;
            // 
            // nombreproducto
            // 
            nombreproducto.Text = "Nombre del Producto";
            nombreproducto.Width = 200;
            // 
            // GenerarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1105, 612);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_GenerarReserva);
            Controls.Add(gbxPresupuesto);
            Controls.Add(gbxPasajeros);
            Margin = new Padding(1);
            Name = "GenerarReserva";
            Text = "Generar Reserva";
            Load += GenerarReserva_Load;
            Controls.SetChildIndex(gbxPasajeros, 0);
            Controls.SetChildIndex(gbxPresupuesto, 0);
            Controls.SetChildIndex(btn_GenerarReserva, 0);
            Controls.SetChildIndex(btn_Cancelar, 0);
            gbxPasajeros.ResumeLayout(false);
            gbxPasajeros.PerformLayout();
            gbxPresupuesto.ResumeLayout(false);
            gbxPresupuesto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbxPasajeros;
        private GroupBox gbxPresupuesto;
        private TextBox txbDocumento;
        private TextBox nroPresupuestotxt;
        private Label label3;
        private Label label1;
        private ListView listPasajeros;
        private ColumnHeader nombre;
        private ColumnHeader apellido;
        private ColumnHeader fechadenac;
        private ListView listPresupuestos;
        private ColumnHeader nropresup;
        private ColumnHeader doccliente;
        private ColumnHeader cantpasajeros;
        private ColumnHeader precio;
        private ColumnHeader estado;
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
        private ColumnHeader cantAdultos;
        private ColumnHeader cantMenores;
        private ColumnHeader prereserva;
        private ColumnHeader codigoproducto;
        private ColumnHeader nombreproducto;
    }
}