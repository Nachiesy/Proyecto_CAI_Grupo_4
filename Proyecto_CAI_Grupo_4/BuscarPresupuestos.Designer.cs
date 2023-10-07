namespace Proyecto_CAI_Grupo_4
{
    partial class BuscarPresupuestos
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
            pasajerosAdultos = new TextBox();
            lbl = new Label();
            label2 = new Label();
            pasajerosMenores = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tipoDeServicio = new ComboBox();
            label3 = new Label();
            fechaDesde = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            fechaHasta = new DateTimePicker();
            label6 = new Label();
            precioHasta = new TextBox();
            label7 = new Label();
            precioDesde = new TextBox();
            label8 = new Label();
            nombreDelServicio = new TextBox();
            buscarPresupuesto = new Button();
            SuspendLayout();
            // 
            // pasajerosAdultos
            // 
            pasajerosAdultos.Location = new Point(470, 141);
            pasajerosAdultos.Name = "pasajerosAdultos";
            pasajerosAdultos.Size = new Size(126, 23);
            pasajerosAdultos.TabIndex = 0;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(470, 114);
            lbl.Name = "lbl";
            lbl.Size = new Size(100, 15);
            lbl.TabIndex = 1;
            lbl.Text = "Pasajeros Adultos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(634, 114);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 3;
            label2.Text = "Pasajeros Menores";
            // 
            // pasajerosMenores
            // 
            pasajerosMenores.Location = new Point(634, 141);
            pasajerosMenores.Name = "pasajerosMenores";
            pasajerosMenores.Size = new Size(126, 23);
            pasajerosMenores.TabIndex = 2;
            // 
            // tipoDeServicio
            // 
            tipoDeServicio.FormattingEnabled = true;
            tipoDeServicio.Items.AddRange(new object[] { "Aéreo", "Hotel", "Crucero" });
            tipoDeServicio.Location = new Point(299, 141);
            tipoDeServicio.Name = "tipoDeServicio";
            tipoDeServicio.Size = new Size(126, 23);
            tipoDeServicio.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(299, 114);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 11;
            label3.Text = "Tipo de Servicio";
            // 
            // fechaDesde
            // 
            fechaDesde.Location = new Point(807, 141);
            fechaDesde.Name = "fechaDesde";
            fechaDesde.Size = new Size(200, 23);
            fechaDesde.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(807, 114);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 13;
            label4.Text = "Fecha Desde";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(807, 193);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 15;
            label5.Text = "Fecha Hasta";
            // 
            // fechaHasta
            // 
            fechaHasta.Location = new Point(807, 220);
            fechaHasta.Name = "fechaHasta";
            fechaHasta.Size = new Size(200, 23);
            fechaHasta.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(634, 193);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 17;
            label6.Text = "Precio Hasta";
            // 
            // precioHasta
            // 
            precioHasta.Location = new Point(634, 220);
            precioHasta.Name = "precioHasta";
            precioHasta.Size = new Size(126, 23);
            precioHasta.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(470, 193);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 19;
            label7.Text = "Precio Desde";
            // 
            // precioDesde
            // 
            precioDesde.Location = new Point(470, 220);
            precioDesde.Name = "precioDesde";
            precioDesde.Size = new Size(126, 23);
            precioDesde.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(299, 193);
            label8.Name = "label8";
            label8.Size = new Size(114, 15);
            label8.TabIndex = 21;
            label8.Text = "Nombre del Servicio";
            // 
            // nombreDelServicio
            // 
            nombreDelServicio.Location = new Point(299, 220);
            nombreDelServicio.Name = "nombreDelServicio";
            nombreDelServicio.Size = new Size(126, 23);
            nombreDelServicio.TabIndex = 20;
            // 
            // buscarPresupuesto
            // 
            buscarPresupuesto.Location = new Point(299, 284);
            buscarPresupuesto.Name = "buscarPresupuesto";
            buscarPresupuesto.Size = new Size(119, 30);
            buscarPresupuesto.TabIndex = 22;
            buscarPresupuesto.Text = "Buscar";
            buscarPresupuesto.UseVisualStyleBackColor = true;
            buscarPresupuesto.Click += buscarPresupuesto_Click;
            // 
            // Presupuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 501);
            Controls.Add(buscarPresupuesto);
            Controls.Add(label8);
            Controls.Add(nombreDelServicio);
            Controls.Add(label7);
            Controls.Add(precioDesde);
            Controls.Add(label6);
            Controls.Add(precioHasta);
            Controls.Add(label5);
            Controls.Add(fechaHasta);
            Controls.Add(label4);
            Controls.Add(fechaDesde);
            Controls.Add(label3);
            Controls.Add(tipoDeServicio);
            Controls.Add(label2);
            Controls.Add(pasajerosMenores);
            Controls.Add(lbl);
            Controls.Add(pasajerosAdultos);
            Name = "Presupuestos";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox pasajerosAdultos;
        private Label lbl;
        private Label label2;
        private TextBox pasajerosMenores;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox tipoDeServicio;
        private Label label3;
        private DateTimePicker fechaDesde;
        private Label label4;
        private Label label5;
        private DateTimePicker fechaHasta;
        private Label label6;
        private TextBox precioHasta;
        private Label label7;
        private TextBox precioDesde;
        private Label label8;
        private TextBox nombreDelServicio;
        private Button buscarPresupuesto;
    }
}