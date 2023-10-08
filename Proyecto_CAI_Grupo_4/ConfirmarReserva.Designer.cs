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
            btnSelect = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbxTipodoc = new ComboBox();
            nroPresupuestotxt = new TextBox();
            txbDocumento = new TextBox();
            btnBuscar = new Button();
            listPresupuestos = new ListView();
            nropresup = new ColumnHeader();
            doccliente = new ColumnHeader();
            cantpasajeros = new ColumnHeader();
            precio = new ColumnHeader();
            estado = new ColumnHeader();
            fechadesde = new ColumnHeader();
            fechahasta = new ColumnHeader();
            fecha = new ColumnHeader();
            gpProsupuesto = new GroupBox();
            btVolver = new Button();
            gpProsupuesto.SuspendLayout();
            SuspendLayout();
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(1347, 422);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(283, 46);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Confirmar Reserva";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(451, 79);
            label2.Name = "label2";
            label2.Size = new Size(233, 32);
            label2.TabIndex = 3;
            label2.Text = "Tipo de Documento:";
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
            // cbxTipodoc
            // 
            cbxTipodoc.FormattingEnabled = true;
            cbxTipodoc.Location = new Point(690, 75);
            cbxTipodoc.Name = "cbxTipodoc";
            cbxTipodoc.Size = new Size(242, 40);
            cbxTipodoc.TabIndex = 5;
            // 
            // nroPresupuestotxt
            // 
            nroPresupuestotxt.Location = new Point(218, 76);
            nroPresupuestotxt.Name = "nroPresupuestotxt";
            nroPresupuestotxt.Size = new Size(200, 39);
            nroPresupuestotxt.TabIndex = 6;
            // 
            // txbDocumento
            // 
            txbDocumento.Location = new Point(1188, 80);
            txbDocumento.Name = "txbDocumento";
            txbDocumento.Size = new Size(200, 39);
            txbDocumento.TabIndex = 7;
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
            // gpProsupuesto
            // 
            gpProsupuesto.Controls.Add(btVolver);
            gpProsupuesto.Controls.Add(listPresupuestos);
            gpProsupuesto.Controls.Add(btnBuscar);
            gpProsupuesto.Controls.Add(txbDocumento);
            gpProsupuesto.Controls.Add(nroPresupuestotxt);
            gpProsupuesto.Controls.Add(cbxTipodoc);
            gpProsupuesto.Controls.Add(label3);
            gpProsupuesto.Controls.Add(label2);
            gpProsupuesto.Controls.Add(label1);
            gpProsupuesto.Controls.Add(btnSelect);
            gpProsupuesto.Location = new Point(21, 24);
            gpProsupuesto.Name = "gpProsupuesto";
            gpProsupuesto.Size = new Size(1967, 488);
            gpProsupuesto.TabIndex = 8;
            gpProsupuesto.TabStop = false;
            gpProsupuesto.Text = "Presupuestos";
            // 
            // btVolver
            // 
            btVolver.Location = new Point(1650, 422);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(283, 46);
            btVolver.TabIndex = 10;
            btVolver.Text = "Volver";
            btVolver.TextImageRelation = TextImageRelation.TextAboveImage;
            btVolver.UseVisualStyleBackColor = true;
            btVolver.Click += button1_Click;
            // 
            // ConfirmarReserva
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2037, 615);
            Controls.Add(gpProsupuesto);
            Name = "ConfirmarReserva";
            Text = "ConfirmarReserva";
            gpProsupuesto.ResumeLayout(false);
            gpProsupuesto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelect;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbxTipodoc;
        private TextBox nroPresupuestotxt;
        private TextBox txbDocumento;
        private Button btnBuscar;
        private ListView listPresupuestos;
        private ColumnHeader nropresup;
        private ColumnHeader doccliente;
        private ColumnHeader cantpasajeros;
        private ColumnHeader precio;
        private ColumnHeader estado;
        private ColumnHeader fechadesde;
        private ColumnHeader fechahasta;
        private ColumnHeader fecha;
        private GroupBox gpProsupuesto;
        private Button btVolver;
    }
}