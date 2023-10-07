namespace Proyecto_CAI_Grupo_4
{
    partial class MenuPrincipal
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
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(27, 177);
            button1.Name = "button1";
            button1.Size = new Size(241, 23);
            button1.TabIndex = 0;
            button1.Text = "Generar Presupuesto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(27, 218);
            button2.Name = "button2";
            button2.Size = new Size(241, 23);
            button2.TabIndex = 1;
            button2.Text = "Generar Reserva";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(27, 302);
            button4.Name = "button4";
            button4.Size = new Size(241, 23);
            button4.TabIndex = 3;
            button4.Text = "Informar Estado de Reservas";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(27, 128);
            button5.Name = "button5";
            button5.Size = new Size(241, 43);
            button5.TabIndex = 4;
            button5.Text = "Informar Productos Disponibles";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.Location = new Point(27, 258);
            button6.Name = "button6";
            button6.Size = new Size(241, 23);
            button6.TabIndex = 5;
            button6.Text = "Confirmar Reserva";
            button6.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(997, 604);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuPrincipal";
            Text = "Menu Principal";
            ResumeLayout(false);
        }

        #endregion
        //=======
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        //>>>>>>> 0cf15ab1261db55f98947b8966023a59eed0f5c3
    }
}