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
//<<<<<<< HEAD
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 58);
            label1.Name = "label1";
            label1.Size = new Size(269, 30);
            label1.TabIndex = 0;
            label1.Text = "Seleccione que desea hacer";
            label1.Click += label1_Click;
//=======
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(518, 190);
            button1.Name = "button1";
            button1.Size = new Size(241, 23);
            button1.TabIndex = 0;
            button1.Text = "Generar Presupuesto";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(518, 231);
            button2.Name = "button2";
            button2.Size = new Size(241, 23);
            button2.TabIndex = 1;
            button2.Text = "Generar Reserva";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(518, 357);
            button3.Name = "button3";
            button3.Size = new Size(241, 23);
            button3.TabIndex = 2;
            button3.Text = "Salir del Sistema";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(518, 315);
            button4.Name = "button4";
            button4.Size = new Size(241, 23);
            button4.TabIndex = 3;
            button4.Text = "Informar Estado de Reservas";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(518, 152);
            button5.Name = "button5";
            button5.Size = new Size(241, 23);
            button5.TabIndex = 4;
            button5.Text = "Informar Productos Disponibles";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(518, 271);
            button6.Name = "button6";
            button6.Size = new Size(241, 23);
            button6.TabIndex = 5;
            button6.Text = "Confirmar Reserva";
            button6.UseVisualStyleBackColor = true;
//>>>>>>> 0cf15ab1261db55f98947b8966023a59eed0f5c3
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
//<<<<<<< HEAD
            ClientSize = new Size(307, 446);
            Controls.Add(label1);
            Name = "MenuPrincipal";
            Text = "Menu Principal";
            ResumeLayout(false);
            PerformLayout();
//=======
            ClientSize = new Size(1251, 487);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            ResumeLayout(false);
//>>>>>>> 0cf15ab1261db55f98947b8966023a59eed0f5c3
        }

        #endregion

//<<<<<<< HEAD
        private Label label1;
//=======
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
//>>>>>>> 0cf15ab1261db55f98947b8966023a59eed0f5c3
    }
}