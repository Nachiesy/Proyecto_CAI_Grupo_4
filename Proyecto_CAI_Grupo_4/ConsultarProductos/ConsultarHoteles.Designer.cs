﻿namespace Proyecto_CAI_Grupo_4
{
    partial class ConsultarHoteles
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
            btnLimpiarFiltro = new Common.Components.BotonEstilizado();
            buscarPresupuesto = new Common.Components.BotonEstilizado();
            lstViewProductos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            btnVolverMenuGenerarPresupuestos = new Button();
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
            label4.Size = new Size(73, 15);
            label4.TabIndex = 13;
            label4.Text = "Fecha Desde";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(576, 38);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 15;
            label5.Text = "Fecha Hasta";
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
            grp_Filtros.Size = new Size(830, 118);
            grp_Filtros.TabIndex = 35;
            grp_Filtros.TabStop = false;
            grp_Filtros.Text = "Filtros";
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
            // lstViewProductos
            // 
            lstViewProductos.BackColor = SystemColors.ControlLight;
            lstViewProductos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader6, columnHeader7, columnHeader8 });
            lstViewProductos.Location = new Point(27, 291);
            lstViewProductos.Name = "lstViewProductos";
            lstViewProductos.Size = new Size(1064, 228);
            lstViewProductos.TabIndex = 36;
            lstViewProductos.UseCompatibleStateImageBehavior = false;
            lstViewProductos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ciudad";
            columnHeader3.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Precio";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Fecha Desde";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Fecha Hasta";
            columnHeader8.Width = 100;
            // 
            // btnVolverMenuGenerarPresupuestos
            // 
            btnVolverMenuGenerarPresupuestos.Location = new Point(27, 541);
            btnVolverMenuGenerarPresupuestos.Name = "btnVolverMenuGenerarPresupuestos";
            btnVolverMenuGenerarPresupuestos.Size = new Size(289, 47);
            btnVolverMenuGenerarPresupuestos.TabIndex = 37;
            btnVolverMenuGenerarPresupuestos.Text = "Volver";
            btnVolverMenuGenerarPresupuestos.UseVisualStyleBackColor = true;
            btnVolverMenuGenerarPresupuestos.Click += btnVolverMenuGenerarPresupuestos_Click;
            // 
            // ConsultarHoteles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1106, 600);
            Controls.Add(btnVolverMenuGenerarPresupuestos);
            Controls.Add(lstViewProductos);
            Controls.Add(btnLimpiarFiltro);
            Controls.Add(grp_Filtros);
            Controls.Add(buscarPresupuesto);
            Name = "ConsultarHoteles";
            Text = "Generar Presupuesto - Aéreos";
            Load += GenerarPresupuestoAereos_Load;
            Controls.SetChildIndex(buscarPresupuesto, 0);
            Controls.SetChildIndex(grp_Filtros, 0);
            Controls.SetChildIndex(btnLimpiarFiltro, 0);
            Controls.SetChildIndex(lstViewProductos, 0);
            Controls.SetChildIndex(btnVolverMenuGenerarPresupuestos, 0);
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
        private ListView lstViewProductos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Button btnVolverMenuGenerarPresupuestos;
    }
}