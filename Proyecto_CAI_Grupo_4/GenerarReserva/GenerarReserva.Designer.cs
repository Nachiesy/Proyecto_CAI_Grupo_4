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
            listPasajeros = new ListBox();
            btnQuitpasajero = new Button();
            btnAddpasajero = new Button();
            gpProsupuesto = new GroupBox();
            btnBuscar = new Button();
            txbDocumento = new TextBox();
            textBox1 = new TextBox();
            cbxTipodoc = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSelect = new Button();
            listPresupuestos = new ListBox();
            btnGenreserva = new Button();
            btnCancelar = new Button();
            gbxPasajeros.SuspendLayout();
            gpProsupuesto.SuspendLayout();
            SuspendLayout();
            // 
            // gbxPasajeros
            // 
            gbxPasajeros.Controls.Add(listPasajeros);
            gbxPasajeros.Controls.Add(btnQuitpasajero);
            gbxPasajeros.Controls.Add(btnAddpasajero);
            gbxPasajeros.Location = new Point(22, 532);
            gbxPasajeros.Name = "gbxPasajeros";
            gbxPasajeros.Size = new Size(1645, 419);
            gbxPasajeros.TabIndex = 6;
            gbxPasajeros.TabStop = false;
            gbxPasajeros.Text = "Pasajeros";
            // 
            // listPasajeros
            // 
            listPasajeros.FormattingEnabled = true;
            listPasajeros.ItemHeight = 32;
            listPasajeros.Location = new Point(32, 173);
            listPasajeros.Name = "listPasajeros";
            listPasajeros.Size = new Size(1571, 164);
            listPasajeros.TabIndex = 2;
            // 
            // btnQuitpasajero
            // 
            btnQuitpasajero.Location = new Point(220, 76);
            btnQuitpasajero.Name = "btnQuitpasajero";
            btnQuitpasajero.Size = new Size(150, 46);
            btnQuitpasajero.TabIndex = 1;
            btnQuitpasajero.Text = "Quitar";
            btnQuitpasajero.UseVisualStyleBackColor = true;
            // 
            // btnAddpasajero
            // 
            btnAddpasajero.Location = new Point(32, 76);
            btnAddpasajero.Name = "btnAddpasajero";
            btnAddpasajero.Size = new Size(150, 46);
            btnAddpasajero.TabIndex = 0;
            btnAddpasajero.Text = "Agregar";
            btnAddpasajero.UseVisualStyleBackColor = true;
            btnAddpasajero.Click += btnAddpasajero_Click;
            // 
            // gpProsupuesto
            // 
            gpProsupuesto.Controls.Add(btnBuscar);
            gpProsupuesto.Controls.Add(txbDocumento);
            gpProsupuesto.Controls.Add(textBox1);
            gpProsupuesto.Controls.Add(cbxTipodoc);
            gpProsupuesto.Controls.Add(label3);
            gpProsupuesto.Controls.Add(label2);
            gpProsupuesto.Controls.Add(label1);
            gpProsupuesto.Controls.Add(btnSelect);
            gpProsupuesto.Controls.Add(listPresupuestos);
            gpProsupuesto.Location = new Point(35, 34);
            gpProsupuesto.Name = "gpProsupuesto";
            gpProsupuesto.Size = new Size(1632, 456);
            gpProsupuesto.TabIndex = 7;
            gpProsupuesto.TabStop = false;
            gpProsupuesto.Text = "Presupuestos";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1440, 75);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(150, 46);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txbDocumento
            // 
            txbDocumento.Location = new Point(1188, 80);
            txbDocumento.Name = "txbDocumento";
            txbDocumento.Size = new Size(200, 39);
            txbDocumento.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(218, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 6;
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
            btnSelect.Location = new Point(1440, 404);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(150, 46);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Seleccionar";
            btnSelect.UseVisualStyleBackColor = true;
            // 
            // listPresupuestos
            // 
            listPresupuestos.FormattingEnabled = true;
            listPresupuestos.ItemHeight = 32;
            listPresupuestos.Location = new Point(19, 162);
            listPresupuestos.Name = "listPresupuestos";
            listPresupuestos.Size = new Size(1571, 228);
            listPresupuestos.TabIndex = 0;
            // 
            // btnGenreserva
            // 
            btnGenreserva.Location = new Point(1142, 995);
            btnGenreserva.Name = "btnGenreserva";
            btnGenreserva.Size = new Size(233, 46);
            btnGenreserva.TabIndex = 8;
            btnGenreserva.Text = "Generar Reserva";
            btnGenreserva.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1434, 995);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(233, 46);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // GenerarReserva
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1692, 1096);
            Controls.Add(btnCancelar);
            Controls.Add(btnGenreserva);
            Controls.Add(gpProsupuesto);
            Controls.Add(gbxPasajeros);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "GenerarReserva";
            Text = "Generar Reserva";
            gbxPasajeros.ResumeLayout(false);
            gpProsupuesto.ResumeLayout(false);
            gpProsupuesto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbxPasajeros;
        private ListBox listPasajeros;
        private Button btnQuitpasajero;
        private Button btnAddpasajero;
        private GroupBox gpProsupuesto;
        private Button btnBuscar;
        private TextBox txbDocumento;
        private TextBox textBox1;
        private ComboBox cbxTipodoc;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSelect;
        private ListBox listPresupuestos;
        private Button btnGenreserva;
        private Button btnCancelar;
    }
}