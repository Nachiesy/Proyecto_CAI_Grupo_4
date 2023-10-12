namespace Proyecto_CAI_Grupo_4
{
    partial class ConfirmarReserva
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
            label2 = new Label();
            label3 = new Label();
            cbxTipodoc = new ComboBox();
            nroPresupuestotxt = new TextBox();
            txbDocumento = new TextBox();
            listPresupuestos = new ListView();
            nropresup = new ColumnHeader();
            doccliente = new ColumnHeader();
            cantpasajeros = new ColumnHeader();
            precio = new ColumnHeader();
            estado = new ColumnHeader();
            fecha = new ColumnHeader();
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
            label1.Location = new Point(19, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 32);
            label1.TabIndex = 2;
            label1.Text = "Nro. Presupuesto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(442, 55);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(233, 32);
            label2.TabIndex = 3;
            label2.Text = "Tipo de Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(936, 55);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(231, 32);
            label3.TabIndex = 4;
            label3.Text = "Nro. de Documento:";
            // 
            // cbxTipodoc
            // 
            cbxTipodoc.FormattingEnabled = true;
            cbxTipodoc.Location = new Point(663, 49);
            cbxTipodoc.Margin = new Padding(4, 2, 4, 2);
            cbxTipodoc.Name = "cbxTipodoc";
            cbxTipodoc.Size = new Size(242, 40);
            cbxTipodoc.TabIndex = 5;
            // 
            // nroPresupuestotxt
            // 
            nroPresupuestotxt.Location = new Point(214, 49);
            nroPresupuestotxt.Margin = new Padding(4, 2, 4, 2);
            nroPresupuestotxt.Name = "nroPresupuestotxt";
            nroPresupuestotxt.Size = new Size(201, 39);
            nroPresupuestotxt.TabIndex = 6;
            // 
            // txbDocumento
            // 
            txbDocumento.Location = new Point(1157, 49);
            txbDocumento.Margin = new Padding(4, 2, 4, 2);
            txbDocumento.Name = "txbDocumento";
            txbDocumento.Size = new Size(227, 39);
            txbDocumento.TabIndex = 7;
            // 
            // listPresupuestos
            // 
            listPresupuestos.Columns.AddRange(new ColumnHeader[] { nropresup, doccliente, cantpasajeros, precio, estado, fecha });
            listPresupuestos.FullRowSelect = true;
            listPresupuestos.Location = new Point(17, 38);
            listPresupuestos.Margin = new Padding(4, 2, 4, 2);
            listPresupuestos.MultiSelect = false;
            listPresupuestos.Name = "listPresupuestos";
            listPresupuestos.ShowItemToolTips = true;
            listPresupuestos.Size = new Size(1965, 584);
            listPresupuestos.TabIndex = 9;
            listPresupuestos.UseCompatibleStateImageBehavior = false;
            listPresupuestos.View = View.Details;
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
            // fecha
            // 
            fecha.Text = "Fecha";
            fecha.Width = 180;
            // 
            // gpProsupuesto
            // 
            gpProsupuesto.Controls.Add(btn_Volver);
            gpProsupuesto.Controls.Add(btn_ConfirmarReserva);
            gpProsupuesto.Controls.Add(listPresupuestos);
            gpProsupuesto.Location = new Point(22, 405);
            gpProsupuesto.Margin = new Padding(4, 2, 4, 2);
            gpProsupuesto.Name = "gpProsupuesto";
            gpProsupuesto.Padding = new Padding(4, 2, 4, 2);
            gpProsupuesto.Size = new Size(1993, 730);
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
            btn_Volver.Location = new Point(9, 636);
            btn_Volver.Margin = new Padding(6, 6, 6, 6);
            btn_Volver.Name = "btn_Volver";
            btn_Volver.Size = new Size(979, 85);
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
            btn_ConfirmarReserva.Location = new Point(999, 636);
            btn_ConfirmarReserva.Margin = new Padding(6, 6, 6, 6);
            btn_ConfirmarReserva.Name = "btn_ConfirmarReserva";
            btn_ConfirmarReserva.Size = new Size(984, 85);
            btn_ConfirmarReserva.TabIndex = 4;
            btn_ConfirmarReserva.Text = "Confirmar Reserva";
            btn_ConfirmarReserva.UseVisualStyleBackColor = false;
            btn_ConfirmarReserva.Click += btn_ConfirmarReserva_Click;
            // 
            // grupoFiltros
            // 
            grupoFiltros.Controls.Add(btn_LimpiarFiltros);
            grupoFiltros.Controls.Add(btn_FiltrarPresupuestos);
            grupoFiltros.Controls.Add(label1);
            grupoFiltros.Controls.Add(nroPresupuestotxt);
            grupoFiltros.Controls.Add(label2);
            grupoFiltros.Controls.Add(txbDocumento);
            grupoFiltros.Controls.Add(label3);
            grupoFiltros.Controls.Add(cbxTipodoc);
            grupoFiltros.Location = new Point(22, 247);
            grupoFiltros.Margin = new Padding(6, 6, 6, 6);
            grupoFiltros.Name = "grupoFiltros";
            grupoFiltros.Padding = new Padding(6, 6, 6, 6);
            grupoFiltros.Size = new Size(1993, 128);
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
            btn_LimpiarFiltros.Location = new Point(1725, 28);
            btn_LimpiarFiltros.Margin = new Padding(6, 6, 6, 6);
            btn_LimpiarFiltros.Name = "btn_LimpiarFiltros";
            btn_LimpiarFiltros.Size = new Size(256, 85);
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
            btn_FiltrarPresupuestos.Location = new Point(1449, 28);
            btn_FiltrarPresupuestos.Margin = new Padding(6, 6, 6, 6);
            btn_FiltrarPresupuestos.Name = "btn_FiltrarPresupuestos";
            btn_FiltrarPresupuestos.Size = new Size(266, 85);
            btn_FiltrarPresupuestos.TabIndex = 4;
            btn_FiltrarPresupuestos.Text = "Buscar";
            btn_FiltrarPresupuestos.UseVisualStyleBackColor = false;
            btn_FiltrarPresupuestos.Click += btnBuscar_Click;
            // 
            // ConfirmarReserva
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(2037, 1178);
            Controls.Add(grupoFiltros);
            Controls.Add(gpProsupuesto);
            Margin = new Padding(4, 2, 4, 2);
            Name = "ConfirmarReserva";
            Text = "ConfirmarReserva";
            Controls.SetChildIndex(gpProsupuesto, 0);
            Controls.SetChildIndex(grupoFiltros, 0);
            gpProsupuesto.ResumeLayout(false);
            grupoFiltros.ResumeLayout(false);
            grupoFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbxTipodoc;
        private TextBox nroPresupuestotxt;
        private TextBox txbDocumento;
        private ListView listPresupuestos;
        private ColumnHeader nropresup;
        private ColumnHeader doccliente;
        private ColumnHeader cantpasajeros;
        private ColumnHeader precio;
        private ColumnHeader estado;
        private ColumnHeader fecha;
        private GroupBox gpProsupuesto;
        private GroupBox grupoFiltros;
        private Common.Components.BotonEstilizado btn_LimpiarFiltros;
        private Common.Components.BotonEstilizado btn_FiltrarPresupuestos;
        private Common.Components.BotonEstilizado btn_Volver;
        private Common.Components.BotonEstilizado btn_ConfirmarReserva;
    }
}