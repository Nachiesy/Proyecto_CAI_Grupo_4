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
            label1 = new Label();
            textBox1 = new TextBox();
            reservaslb = new ListBox();
            buscarclientebtn = new Button();
            generarreservabtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el DNI del Cliente: ";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // reservaslb
            // 
            reservaslb.FormattingEnabled = true;
            reservaslb.ItemHeight = 15;
            reservaslb.Location = new Point(12, 55);
            reservaslb.Name = "reservaslb";
            reservaslb.Size = new Size(440, 79);
            reservaslb.TabIndex = 2;
            // 
            // buscarclientebtn
            // 
            buscarclientebtn.Location = new Point(286, 16);
            buscarclientebtn.Name = "buscarclientebtn";
            buscarclientebtn.Size = new Size(75, 23);
            buscarclientebtn.TabIndex = 3;
            buscarclientebtn.Text = "Aceptar";
            buscarclientebtn.UseVisualStyleBackColor = true;
            // 
            // generarreservabtn
            // 
            generarreservabtn.Location = new Point(334, 140);
            generarreservabtn.Name = "generarreservabtn";
            generarreservabtn.Size = new Size(118, 23);
            generarreservabtn.TabIndex = 4;
            generarreservabtn.Text = "Generar reserva";
            generarreservabtn.UseVisualStyleBackColor = true;
            // 
            // GenerarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 189);
            Controls.Add(generarreservabtn);
            Controls.Add(buscarclientebtn);
            Controls.Add(reservaslb);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(1, 1, 1, 1);
            Name = "GenerarReserva";
            Text = "Generar Reserva";
            Load += GenerarReserva_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ListBox reservaslb;
        private Button buscarclientebtn;
        private Button generarreservabtn;
    }
}