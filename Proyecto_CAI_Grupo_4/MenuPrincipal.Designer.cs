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
            label1 = new Label();
            btnMenuGenerarPresupuesto = new Button();
            btnGenerarReserva = new Button();
            btnClose = new Button();
            btnEstadoDeReservas = new Button();
            button5 = new Button();
            button6 = new Button();
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
            // 
            // btnMenuGenerarPresupuesto
            // 
            btnMenuGenerarPresupuesto.Location = new Point(518, 190);
            btnMenuGenerarPresupuesto.Name = "btnMenuGenerarPresupuesto";
            btnMenuGenerarPresupuesto.Size = new Size(241, 23);
            btnMenuGenerarPresupuesto.TabIndex = 0;
            btnMenuGenerarPresupuesto.Text = "Generar Presupuesto";
            btnMenuGenerarPresupuesto.UseVisualStyleBackColor = true;
            btnMenuGenerarPresupuesto.Click += btnMenuGenerarPresupuesto_Click;
            // 
            // btnGenerarReserva
            // 
            btnGenerarReserva.Location = new Point(518, 231);
            btnGenerarReserva.Name = "btnGenerarReserva";
            btnGenerarReserva.Size = new Size(241, 23);
            btnGenerarReserva.TabIndex = 1;
            btnGenerarReserva.Text = "Generar Reserva";
            btnGenerarReserva.UseVisualStyleBackColor = true;
            btnGenerarReserva.Click += btnGenerarReserva_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(518, 357);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(241, 23);
            btnClose.TabIndex = 2;
            btnClose.Text = "Salir del Sistema";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnEstadoDeReservas
            // 
            btnEstadoDeReservas.Location = new Point(518, 315);
            btnEstadoDeReservas.Name = "btnEstadoDeReservas";
            btnEstadoDeReservas.Size = new Size(241, 23);
            btnEstadoDeReservas.TabIndex = 3;
            btnEstadoDeReservas.Text = "Informar Estado de Reservas";
            btnEstadoDeReservas.UseVisualStyleBackColor = true;
            btnEstadoDeReservas.Click += btnEstadoDeReservas_Click;
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
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 487);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(btnEstadoDeReservas);
            Controls.Add(btnClose);
            Controls.Add(btnGenerarReserva);
            Controls.Add(btnMenuGenerarPresupuesto);
            Name = "MenuPrincipal";
            Text = "Menu Principal";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        //<<<<<<< HEAD
        private Label label1;
        //=======
        private Button btnMenuGenerarPresupuesto;
        private Button btnGenerarReserva;
        private Button btnClose;
        private Button btnEstadoDeReservas;
        private Button button5;
        private Button button6;
        //>>>>>>> 0cf15ab1261db55f98947b8966023a59eed0f5c3
    }
}