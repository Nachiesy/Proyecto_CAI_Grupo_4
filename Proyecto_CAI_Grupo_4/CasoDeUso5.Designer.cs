namespace Proyecto_CAI_Grupo_4
{
    partial class CasoDeUso5
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            reservasListView = new ListView();
            Codigo = new ColumnHeader();
            Estado = new ColumnHeader();
            NroDocumento = new ColumnHeader();
            Precio = new ColumnHeader();
            Fecha = new ColumnHeader();
            Desde = new ColumnHeader();
            Hasta = new ColumnHeader();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // reservasListView
            // 
            reservasListView.Columns.AddRange(new ColumnHeader[] { Codigo, Estado, NroDocumento, Precio, Fecha, Desde, Hasta });
            reservasListView.Location = new Point(128, 204);
            reservasListView.Name = "reservasListView";
            reservasListView.Size = new Size(1049, 228);
            reservasListView.TabIndex = 0;
            reservasListView.UseCompatibleStateImageBehavior = false;
            reservasListView.View = View.Details;
            // 
            // Codigo
            // 
            Codigo.Text = "Codigo";
            Codigo.Width = 100;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 150;
            // 
            // NroDocumento
            // 
            NroDocumento.Text = "Nro. Documento";
            NroDocumento.Width = 150;
            // 
            // Precio
            // 
            Precio.Text = "Precio";
            Precio.Width = 100;
            // 
            // Fecha
            // 
            Fecha.Text = "Fecha";
            Fecha.Width = 100;
            // 
            // Desde
            // 
            Desde.Text = "Desde";
            Desde.Width = 100;
            // 
            // Hasta
            // 
            Hasta.Text = "Hasta";
            Hasta.Width = 100;
            // 
            // button1
            // 
            button1.Location = new Point(128, 159);
            button1.Name = "button1";
            button1.Size = new Size(119, 30);
            button1.TabIndex = 1;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(128, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(119, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 88);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(478, 88);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 5;
            label2.Text = "Nro. Documento";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(478, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(137, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 88);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 7;
            label3.Text = "Estado";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pendiente de Pago", "Pagada", "Confirmada" });
            comboBox1.Location = new Point(294, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // CasoDeUso5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 509);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(reservasListView);
            Name = "CasoDeUso5";
            Text = "Form1";
            Load += CasoDeUso5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView reservasListView;
        private ColumnHeader Codigo;
        private ColumnHeader Estado;
        private ColumnHeader NroDocumento;
        private ColumnHeader Precio;
        private ColumnHeader Fecha;
        private ColumnHeader Desde;
        private ColumnHeader Hasta;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private ComboBox comboBox1;
    }
}