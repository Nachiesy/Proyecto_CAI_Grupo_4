namespace Proyecto_CAI_Grupo_4
{
    partial class GenerarPresupuestoCruceros
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
            agregarPresupuesto = new Button();
            buscarPresupuesto = new Button();
            label8 = new Label();
            nombreDelServicio = new TextBox();
            label7 = new Label();
            precioDesde = new TextBox();
            label6 = new Label();
            precioHasta = new TextBox();
            label5 = new Label();
            fechaHasta = new DateTimePicker();
            label4 = new Label();
            fechaDesde = new DateTimePicker();
            label3 = new Label();
            tipoDeServicio = new ComboBox();
            label2 = new Label();
            pasajerosMenores = new TextBox();
            lbl = new Label();
            pasajerosAdultos = new TextBox();
            btnVolverMenuGenerarPresupuestos = new Button();
            finalizarPresupuesto = new Button();
            removerPresupuesto = new Button();
            SuspendLayout();
            // 
            // presupuestosElegidos
            // 
            presupuestosElegidos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            presupuestosElegidos.FullRowSelect = true;
            presupuestosElegidos.Location = new Point(31, 437);
            presupuestosElegidos.Name = "presupuestosElegidos";
            presupuestosElegidos.Size = new Size(1159, 195);
            presupuestosElegidos.TabIndex = 49;
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
            // presupuestosBuscados
            // 
            presupuestosBuscados.Columns.AddRange(new ColumnHeader[] { ID, Tipo, Nombre, Adultos, Menores, PrecioD, PrecioH, FechaD, FechaH });
            presupuestosBuscados.FullRowSelect = true;
            presupuestosBuscados.Location = new Point(31, 183);
            presupuestosBuscados.Name = "presupuestosBuscados";
            presupuestosBuscados.Size = new Size(1159, 195);
            presupuestosBuscados.TabIndex = 48;
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
            // agregarPresupuesto
            // 
            agregarPresupuesto.Location = new Point(1084, 388);
            agregarPresupuesto.Name = "agregarPresupuesto";
            agregarPresupuesto.Size = new Size(106, 28);
            agregarPresupuesto.TabIndex = 47;
            agregarPresupuesto.Text = "Agregar";
            agregarPresupuesto.UseVisualStyleBackColor = true;
            // 
            // buscarPresupuesto
            // 
            buscarPresupuesto.Location = new Point(783, 126);
            buscarPresupuesto.Name = "buscarPresupuesto";
            buscarPresupuesto.Size = new Size(119, 30);
            buscarPresupuesto.TabIndex = 46;
            buscarPresupuesto.Text = "Buscar";
            buscarPresupuesto.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 106);
            label8.Name = "label8";
            label8.Size = new Size(114, 15);
            label8.TabIndex = 45;
            label8.Text = "Nombre del Servicio";
            // 
            // nombreDelServicio
            // 
            nombreDelServicio.Location = new Point(31, 133);
            nombreDelServicio.Name = "nombreDelServicio";
            nombreDelServicio.Size = new Size(126, 23);
            nombreDelServicio.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(202, 106);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 43;
            label7.Text = "Precio Desde";
            // 
            // precioDesde
            // 
            precioDesde.Location = new Point(202, 133);
            precioDesde.Name = "precioDesde";
            precioDesde.Size = new Size(126, 23);
            precioDesde.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(366, 106);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 41;
            label6.Text = "Precio Hasta";
            // 
            // precioHasta
            // 
            precioHasta.Location = new Point(366, 133);
            precioHasta.Name = "precioHasta";
            precioHasta.Size = new Size(126, 23);
            precioHasta.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(539, 106);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 39;
            label5.Text = "Fecha Hasta";
            // 
            // fechaHasta
            // 
            fechaHasta.Location = new Point(539, 133);
            fechaHasta.Name = "fechaHasta";
            fechaHasta.Size = new Size(200, 23);
            fechaHasta.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(539, 27);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 37;
            label4.Text = "Fecha Desde";
            // 
            // fechaDesde
            // 
            fechaDesde.Location = new Point(539, 54);
            fechaDesde.Name = "fechaDesde";
            fechaDesde.Size = new Size(200, 23);
            fechaDesde.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 27);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 35;
            label3.Text = "Tipo de Servicio";
            // 
            // tipoDeServicio
            // 
            tipoDeServicio.FormattingEnabled = true;
            tipoDeServicio.Items.AddRange(new object[] { "Aéreo", "Hotel", "Crucero" });
            tipoDeServicio.Location = new Point(31, 54);
            tipoDeServicio.Name = "tipoDeServicio";
            tipoDeServicio.Size = new Size(126, 23);
            tipoDeServicio.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 27);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 33;
            label2.Text = "Pasajeros Menores";
            // 
            // pasajerosMenores
            // 
            pasajerosMenores.Location = new Point(366, 54);
            pasajerosMenores.Name = "pasajerosMenores";
            pasajerosMenores.Size = new Size(126, 23);
            pasajerosMenores.TabIndex = 32;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(202, 27);
            lbl.Name = "lbl";
            lbl.Size = new Size(100, 15);
            lbl.TabIndex = 31;
            lbl.Text = "Pasajeros Adultos";
            // 
            // pasajerosAdultos
            // 
            pasajerosAdultos.Location = new Point(202, 54);
            pasajerosAdultos.Name = "pasajerosAdultos";
            pasajerosAdultos.Size = new Size(126, 23);
            pasajerosAdultos.TabIndex = 30;
            // 
            // btnVolverMenuGenerarPresupuestos
            // 
            btnVolverMenuGenerarPresupuestos.Location = new Point(30, 653);
            btnVolverMenuGenerarPresupuestos.Name = "btnVolverMenuGenerarPresupuestos";
            btnVolverMenuGenerarPresupuestos.Size = new Size(246, 23);
            btnVolverMenuGenerarPresupuestos.TabIndex = 52;
            btnVolverMenuGenerarPresupuestos.Text = "Volver al Menu de Generar Presupuestos";
            btnVolverMenuGenerarPresupuestos.UseVisualStyleBackColor = true;
            // 
            // finalizarPresupuesto
            // 
            finalizarPresupuesto.Location = new Point(1051, 651);
            finalizarPresupuesto.Name = "finalizarPresupuesto";
            finalizarPresupuesto.Size = new Size(138, 25);
            finalizarPresupuesto.TabIndex = 51;
            finalizarPresupuesto.Text = "Finalizar Presupuesto";
            finalizarPresupuesto.UseVisualStyleBackColor = true;
            // 
            // removerPresupuesto
            // 
            removerPresupuesto.Location = new Point(917, 651);
            removerPresupuesto.Name = "removerPresupuesto";
            removerPresupuesto.Size = new Size(107, 25);
            removerPresupuesto.TabIndex = 50;
            removerPresupuesto.Text = "Remover";
            removerPresupuesto.UseVisualStyleBackColor = true;
            // 
            // GenerarPresupuestoCruceros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 734);
            Controls.Add(btnVolverMenuGenerarPresupuestos);
            Controls.Add(finalizarPresupuesto);
            Controls.Add(removerPresupuesto);
            Controls.Add(presupuestosElegidos);
            Controls.Add(presupuestosBuscados);
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
            Name = "GenerarPresupuestoCruceros";
            Text = "GenerarPresupuestoCruceros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Button agregarPresupuesto;
        private Button buscarPresupuesto;
        private Label label8;
        private TextBox nombreDelServicio;
        private Label label7;
        private TextBox precioDesde;
        private Label label6;
        private TextBox precioHasta;
        private Label label5;
        private DateTimePicker fechaHasta;
        private Label label4;
        private DateTimePicker fechaDesde;
        private Label label3;
        private ComboBox tipoDeServicio;
        private Label label2;
        private TextBox pasajerosMenores;
        private Label lbl;
        private TextBox pasajerosAdultos;
        private Button btnVolverMenuGenerarPresupuestos;
        private Button finalizarPresupuesto;
        private Button removerPresupuesto;
    }
}