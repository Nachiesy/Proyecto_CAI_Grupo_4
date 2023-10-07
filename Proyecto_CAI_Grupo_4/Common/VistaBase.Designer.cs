namespace Proyecto_CAI_Grupo_4.Common
{
    partial class VistaBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaBase));
            pnl_BarraFijaSuperior = new Panel();
            btn_Salir = new PictureBox();
            label1 = new Label();
            pnl_BarraFijaSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_Salir).BeginInit();
            SuspendLayout();
            // 
            // pnl_BarraFijaSuperior
            // 
            pnl_BarraFijaSuperior.BackColor = Color.FromArgb(95, 42, 167);
            pnl_BarraFijaSuperior.Controls.Add(btn_Salir);
            pnl_BarraFijaSuperior.Controls.Add(label1);
            pnl_BarraFijaSuperior.Dock = DockStyle.Top;
            pnl_BarraFijaSuperior.Location = new Point(0, 0);
            pnl_BarraFijaSuperior.Name = "pnl_BarraFijaSuperior";
            pnl_BarraFijaSuperior.Size = new Size(800, 100);
            pnl_BarraFijaSuperior.TabIndex = 7;
            pnl_BarraFijaSuperior.MouseDown += pnl_BarraFijaSuperior_MouseDown;
            // 
            // btn_Salir
            // 
            btn_Salir.Cursor = Cursors.Hand;
            btn_Salir.Image = (Image)resources.GetObject("btn_Salir.Image");
            btn_Salir.Location = new Point(763, 12);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(25, 25);
            btn_Salir.TabIndex = 2;
            btn_Salir.TabStop = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(27, 37);
            label1.Name = "label1";
            label1.Size = new Size(91, 35);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // VistaBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnl_BarraFijaSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VistaBase";
            Text = "VistaBase";
            pnl_BarraFijaSuperior.ResumeLayout(false);
            pnl_BarraFijaSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_Salir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_BarraFijaSuperior;
        private Label label1;
        private PictureBox btn_Salir;
    }
}