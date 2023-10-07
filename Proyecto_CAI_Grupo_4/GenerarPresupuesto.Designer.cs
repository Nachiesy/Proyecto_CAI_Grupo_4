namespace Proyecto_CAI_Grupo_4
{
    partial class GenerarPresupuesto
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
            finalizarPresupuesto = new Button();
            removerPresupuesto = new Button();
            agregarPresupuesto = new Button();
            presupuestosBuscados = new ListView();
            ID = new ColumnHeader();
            Tipo = new ColumnHeader();
            Nombre = new ColumnHeader();
            Adultos = new ColumnHeader();
            Menores = new ColumnHeader();
            PrecioD = new ColumnHeader();
            PrecioH = new ColumnHeader();
            FechaD = new ColumnHeader();
            FechaH = new ColumnHeader();
            presupuestosElegidos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            SuspendLayout();
            // 
            // pasajerosAdultos
            // 
            pasajerosAdultos.Location = new Point(201, 49);
            pasajerosAdultos.Name = "pasajerosAdultos";
            pasajerosAdultos.Size = new Size(126, 23);
            pasajerosAdultos.TabIndex = 0;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(201, 22);
            lbl.Name = "lbl";
            lbl.Size = new Size(100, 15);
            lbl.TabIndex = 1;
            lbl.Text = "Pasajeros Adultos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(365, 22);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 3;
            label2.Text = "Pasajeros Menores";
            // 
            // pasajerosMenores
            // 
            pasajerosMenores.Location = new Point(365, 49);
            pasajerosMenores.Name = "pasajerosMenores";
            pasajerosMenores.Size = new Size(126, 23);
            pasajerosMenores.TabIndex = 2;
            // 
            // tipoDeServicio
            // 
            tipoDeServicio.FormattingEnabled = true;
            tipoDeServicio.Items.AddRange(new object[] { "Aéreo", "Hotel", "Crucero" });
            tipoDeServicio.Location = new Point(30, 49);
            tipoDeServicio.Name = "tipoDeServicio";
            tipoDeServicio.Size = new Size(126, 23);
            tipoDeServicio.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 22);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 11;
            label3.Text = "Tipo de Servicio";
            // 
            // fechaDesde
            // 
            fechaDesde.Location = new Point(538, 49);
            fechaDesde.Name = "fechaDesde";
            fechaDesde.Size = new Size(200, 23);
            fechaDesde.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(538, 22);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 13;
            label4.Text = "Fecha Desde";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(538, 101);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 15;
            label5.Text = "Fecha Hasta";
            // 
            // fechaHasta
            // 
            fechaHasta.Location = new Point(538, 128);
            fechaHasta.Name = "fechaHasta";
            fechaHasta.Size = new Size(200, 23);
            fechaHasta.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(365, 101);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 17;
            label6.Text = "Precio Hasta";
            // 
            // precioHasta
            // 
            precioHasta.Location = new Point(365, 128);
            precioHasta.Name = "precioHasta";
            precioHasta.Size = new Size(126, 23);
            precioHasta.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(201, 101);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 19;
            label7.Text = "Precio Desde";
            // 
            // precioDesde
            // 
            precioDesde.Location = new Point(201, 128);
            precioDesde.Name = "precioDesde";
            precioDesde.Size = new Size(126, 23);
            precioDesde.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 101);
            label8.Name = "label8";
            label8.Size = new Size(114, 15);
            label8.TabIndex = 21;
            label8.Text = "Nombre del Servicio";
            // 
            // nombreDelServicio
            // 
            nombreDelServicio.Location = new Point(30, 128);
            nombreDelServicio.Name = "nombreDelServicio";
            nombreDelServicio.Size = new Size(126, 23);
            nombreDelServicio.TabIndex = 20;
            // 
            // buscarPresupuesto
            // 
            buscarPresupuesto.Location = new Point(782, 121);
            buscarPresupuesto.Name = "buscarPresupuesto";
            buscarPresupuesto.Size = new Size(119, 30);
            buscarPresupuesto.TabIndex = 22;
            buscarPresupuesto.Text = "Buscar";
            buscarPresupuesto.UseVisualStyleBackColor = true;
            buscarPresupuesto.Click += buscarPresupuesto_Click;
            // 
            // finalizarPresupuesto
            // 
            finalizarPresupuesto.Location = new Point(1051, 616);
            finalizarPresupuesto.Name = "finalizarPresupuesto";
            finalizarPresupuesto.Size = new Size(138, 25);
            finalizarPresupuesto.TabIndex = 27;
            finalizarPresupuesto.Text = "Finalizar Presupuesto";
            finalizarPresupuesto.UseVisualStyleBackColor = true;
            finalizarPresupuesto.Click += finalizarPresupuesto_Click;
            // 
            // removerPresupuesto
            // 
            removerPresupuesto.Location = new Point(917, 616);
            removerPresupuesto.Name = "removerPresupuesto";
            removerPresupuesto.Size = new Size(107, 25);
            removerPresupuesto.TabIndex = 26;
            removerPresupuesto.Text = "Remover";
            removerPresupuesto.UseVisualStyleBackColor = true;
            removerPresupuesto.Click += removerPresupuesto_Click;
            // 
            // agregarPresupuesto
            // 
            agregarPresupuesto.Location = new Point(1083, 369);
            agregarPresupuesto.Name = "agregarPresupuesto";
            agregarPresupuesto.Size = new Size(106, 28);
            agregarPresupuesto.TabIndex = 25;
            agregarPresupuesto.Text = "Agregar";
            agregarPresupuesto.UseVisualStyleBackColor = true;
            agregarPresupuesto.Click += agregarPresupuesto_Click;
            // 
            // presupuestosBuscados
            // 
            presupuestosBuscados.Columns.AddRange(new ColumnHeader[] { ID, Tipo, Nombre, Adultos, Menores, PrecioD, PrecioH, FechaD, FechaH });
            presupuestosBuscados.FullRowSelect = true;
            presupuestosBuscados.Location = new Point(30, 168);
            presupuestosBuscados.Name = "presupuestosBuscados";
            presupuestosBuscados.Size = new Size(1159, 195);
            presupuestosBuscados.TabIndex = 28;
            presupuestosBuscados.UseCompatibleStateImageBehavior = false;
            presupuestosBuscados.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 100;
            // 
            // Tipo
            // 
            Tipo.Text = "Tipo de Servicio";
            Tipo.Width = 100;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre del Servicio";
            Nombre.Width = 150;
            // 
            // Adultos
            // 
            Adultos.Text = "Adultos";
            Adultos.Width = 100;
            // 
            // Menores
            // 
            Menores.Text = "Menores";
            Menores.Width = 100;
            // 
            // PrecioD
            // 
            PrecioD.Text = "Precio";
            PrecioD.Width = 100;
            // 
            // PrecioH
            // 
            PrecioH.Text = "Precio Hasta";
            PrecioH.Width = 100;
            // 
            // FechaD
            // 
            FechaD.Text = "Fecha Desde";
            FechaD.Width = 100;
            // 
            // FechaH
            // 
            FechaH.Text = "Fecha Hasta";
            FechaH.Width = 100;
            // 
            // presupuestosElegidos
            // 
            presupuestosElegidos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            presupuestosElegidos.FullRowSelect = true;
            presupuestosElegidos.Location = new Point(30, 415);
            presupuestosElegidos.Name = "presupuestosElegidos";
            presupuestosElegidos.Size = new Size(1159, 195);
            presupuestosElegidos.TabIndex = 29;
            presupuestosElegidos.UseCompatibleStateImageBehavior = false;
            presupuestosElegidos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tipo de Servicio";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Nombre del Servicio";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Adultos";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Menores";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Precio";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Precio Hasta";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Fecha Desde";
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Fecha Hasta";
            columnHeader9.Width = 100;
            // 
            // GenerarPresupuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 703);
            Controls.Add(presupuestosElegidos);
            Controls.Add(presupuestosBuscados);
            Controls.Add(finalizarPresupuesto);
            Controls.Add(removerPresupuesto);
            Controls.Add(agregarPresupuesto);
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
            Name = "GenerarPresupuesto";
            Text = "Form2";
            Load += GenerarPresupuesto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox pasajerosAdultos;
        private Label lbl;
        private Label label2;
        private TextBox pasajerosMenores;
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
        private Button finalizarPresupuesto;
        private Button removerPresupuesto;
        private Button agregarPresupuesto;
        private ListView presupuestosBuscados;
        private ColumnHeader ID;
        private ColumnHeader Tipo;
        private ColumnHeader Nombre;
        private ColumnHeader Adultos;
        private ColumnHeader Menores;
        private ColumnHeader PrecioD;
        private ColumnHeader PrecioH;
        private ColumnHeader FechaD;
        private ColumnHeader FechaH;
        private ListView presupuestosElegidos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
    }
}