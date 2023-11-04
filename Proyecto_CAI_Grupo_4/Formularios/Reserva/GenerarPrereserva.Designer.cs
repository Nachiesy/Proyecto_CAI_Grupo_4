namespace Proyecto_CAI_Grupo_4
{
    partial class GenerarPrereserva
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
            label1 = new Label();
            label3 = new Label();
            nroPresupuestotxt = new TextBox();
            txbDocumento = new TextBox();
            lv_Prereservas = new ListView();
            nropresup = new ColumnHeader();
            cantidadPasajeros = new ColumnHeader();
            doccliente = new ColumnHeader();
            precio = new ColumnHeader();
            gpProsupuesto = new GroupBox();
            btn_Volver = new Common.Components.BotonEstilizado();
            btn_ConfirmarReserva = new Common.Components.BotonEstilizado();
            grupoFiltros = new GroupBox();
            btn_LimpiarFiltros = new Common.Components.BotonEstilizado();
            btn_FiltrarPresupuestos = new Common.Components.BotonEstilizado();
            gpProsupuesto.SuspendLayout();
            grupoFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 2;
            label1.Text = "ID Presupuesto:";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 26);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(30, 15);
            label3.TabIndex = 4;
            label3.Text = "DNI:";
            // 
            // nroPresupuestotxt
            // 
            nroPresupuestotxt.Location = new Point(103, 23);
            nroPresupuestotxt.Margin = new Padding(2, 1, 2, 1);
            nroPresupuestotxt.Name = "nroPresupuestotxt";
            nroPresupuestotxt.Size = new Size(110, 23);
            nroPresupuestotxt.TabIndex = 6;
            // 
            // txbDocumento
            // 
            txbDocumento.Location = new Point(251, 23);
            txbDocumento.Margin = new Padding(2, 1, 2, 1);
            txbDocumento.Name = "txbDocumento";
            txbDocumento.Size = new Size(124, 23);
            txbDocumento.TabIndex = 7;
            // 
            // lv_Prereservas
            // 
            lv_Prereservas.Columns.AddRange(new ColumnHeader[] { nropresup, cantidadPasajeros, doccliente, precio });
            lv_Prereservas.FullRowSelect = true;
            lv_Prereservas.Location = new Point(9, 18);
            lv_Prereservas.Margin = new Padding(2, 1, 2, 1);
            lv_Prereservas.MultiSelect = false;
            lv_Prereservas.Name = "lv_Prereservas";
            lv_Prereservas.ShowItemToolTips = true;
            lv_Prereservas.Size = new Size(1060, 276);
            lv_Prereservas.TabIndex = 9;
            lv_Prereservas.UseCompatibleStateImageBehavior = false;
            lv_Prereservas.View = View.Details;
            // 
            // nropresup
            // 
            nropresup.Text = "ID Presupuesto";
            nropresup.Width = 150;
            // 
            // cantidadPasajeros
            // 
            cantidadPasajeros.Text = "Cantidad Pasajeros";
            cantidadPasajeros.Width = 180;
            // 
            // doccliente
            // 
            doccliente.Text = "DNI Cliente";
            doccliente.Width = 160;
            // 
            // precio
            // 
            precio.Text = "Precio";
            precio.Width = 180;
            // 
            // gpProsupuesto
            // 
            gpProsupuesto.Controls.Add(btn_Volver);
            gpProsupuesto.Controls.Add(btn_ConfirmarReserva);
            gpProsupuesto.Controls.Add(lv_Prereservas);
            gpProsupuesto.Location = new Point(12, 190);
            gpProsupuesto.Margin = new Padding(2, 1, 2, 1);
            gpProsupuesto.Name = "gpProsupuesto";
            gpProsupuesto.Padding = new Padding(2, 1, 2, 1);
            gpProsupuesto.Size = new Size(1073, 342);
            gpProsupuesto.TabIndex = 8;
            gpProsupuesto.TabStop = false;
            gpProsupuesto.Text = "Presupuestos";
            // 
            // btn_Volver
            // 
            btn_Volver.BackColor = Color.Transparent;
            btn_Volver.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_Volver.FlatStyle = FlatStyle.Flat;
            btn_Volver.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Volver.ForeColor = Color.Black;
            btn_Volver.Location = new Point(5, 298);
            btn_Volver.Name = "btn_Volver";
            btn_Volver.Size = new Size(527, 40);
            btn_Volver.TabIndex = 4;
            btn_Volver.Text = "Volver";
            btn_Volver.UseVisualStyleBackColor = false;
            btn_Volver.Click += btn_Volver_Click;
            // 
            // btn_ConfirmarReserva
            // 
            btn_ConfirmarReserva.BackColor = Color.Transparent;
            btn_ConfirmarReserva.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_ConfirmarReserva.FlatStyle = FlatStyle.Flat;
            btn_ConfirmarReserva.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ConfirmarReserva.ForeColor = Color.Black;
            btn_ConfirmarReserva.Location = new Point(538, 298);
            btn_ConfirmarReserva.Name = "btn_ConfirmarReserva";
            btn_ConfirmarReserva.Size = new Size(530, 40);
            btn_ConfirmarReserva.TabIndex = 4;
            btn_ConfirmarReserva.Text = "Generar Pre-reserva";
            btn_ConfirmarReserva.UseVisualStyleBackColor = false;
            btn_ConfirmarReserva.Click += btn_GenerarPreReserva_Click;
            // 
            // grupoFiltros
            // 
            grupoFiltros.Controls.Add(btn_LimpiarFiltros);
            grupoFiltros.Controls.Add(btn_FiltrarPresupuestos);
            grupoFiltros.Controls.Add(label1);
            grupoFiltros.Controls.Add(nroPresupuestotxt);
            grupoFiltros.Controls.Add(txbDocumento);
            grupoFiltros.Controls.Add(label3);
            grupoFiltros.Location = new Point(12, 116);
            grupoFiltros.Name = "grupoFiltros";
            grupoFiltros.Size = new Size(1073, 60);
            grupoFiltros.TabIndex = 9;
            grupoFiltros.TabStop = false;
            grupoFiltros.Text = "Filtros";
            // 
            // btn_LimpiarFiltros
            // 
            btn_LimpiarFiltros.BackColor = Color.Transparent;
            btn_LimpiarFiltros.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_LimpiarFiltros.FlatStyle = FlatStyle.Flat;
            btn_LimpiarFiltros.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_LimpiarFiltros.ForeColor = Color.Black;
            btn_LimpiarFiltros.Location = new Point(929, 13);
            btn_LimpiarFiltros.Name = "btn_LimpiarFiltros";
            btn_LimpiarFiltros.Size = new Size(138, 40);
            btn_LimpiarFiltros.TabIndex = 4;
            btn_LimpiarFiltros.Text = "Limpiar";
            btn_LimpiarFiltros.UseVisualStyleBackColor = false;
            btn_LimpiarFiltros.Click += btn_LimpiarFiltros_Click;
            // 
            // btn_FiltrarPresupuestos
            // 
            btn_FiltrarPresupuestos.BackColor = Color.Transparent;
            btn_FiltrarPresupuestos.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_FiltrarPresupuestos.FlatStyle = FlatStyle.Flat;
            btn_FiltrarPresupuestos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_FiltrarPresupuestos.ForeColor = Color.Black;
            btn_FiltrarPresupuestos.Location = new Point(780, 13);
            btn_FiltrarPresupuestos.Name = "btn_FiltrarPresupuestos";
            btn_FiltrarPresupuestos.Size = new Size(143, 40);
            btn_FiltrarPresupuestos.TabIndex = 4;
            btn_FiltrarPresupuestos.Text = "Buscar";
            btn_FiltrarPresupuestos.UseVisualStyleBackColor = false;
            btn_FiltrarPresupuestos.Click += btnBuscar_Click;
            // 
            // GenerarPrereserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1098, 564);
            Controls.Add(grupoFiltros);
            Controls.Add(gpProsupuesto);
            Margin = new Padding(2, 1, 2, 1);
            Name = "GenerarPrereserva";
            Text = "ConfirmarReserva";
            Load += ConfirmarReserva_Load;
            Controls.SetChildIndex(gpProsupuesto, 0);
            Controls.SetChildIndex(grupoFiltros, 0);
            gpProsupuesto.ResumeLayout(false);
            grupoFiltros.ResumeLayout(false);
            grupoFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label3;
        private TextBox nroPresupuestotxt;
        private TextBox txbDocumento;
        private ListView lv_Prereservas;
        private ColumnHeader nropresup;
        private ColumnHeader doccliente;
        private ColumnHeader precio;
        private ColumnHeader cantidadPasajeros;
        private GroupBox gpProsupuesto;
        private GroupBox grupoFiltros;
        private Common.Components.BotonEstilizado btn_LimpiarFiltros;
        private Common.Components.BotonEstilizado btn_FiltrarPresupuestos;
        private Common.Components.BotonEstilizado btn_Volver;
        private Common.Components.BotonEstilizado btn_ConfirmarReserva;
    }
}