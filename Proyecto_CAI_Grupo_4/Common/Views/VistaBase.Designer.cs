namespace Proyecto_CAI_Grupo_4.Common.Views
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
            logo = new PictureBox();
            btn_VolverAlMenu = new PictureBox();
            btn_Salir = new PictureBox();
            lbl_TituloModulo = new Label();
            pnl_BarraFijaSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_VolverAlMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Salir).BeginInit();
            SuspendLayout();
            // 
            // pnl_BarraFijaSuperior
            // 
            pnl_BarraFijaSuperior.BackColor = Color.FromArgb(95, 42, 167);
            pnl_BarraFijaSuperior.Controls.Add(logo);
            pnl_BarraFijaSuperior.Controls.Add(btn_VolverAlMenu);
            pnl_BarraFijaSuperior.Controls.Add(btn_Salir);
            pnl_BarraFijaSuperior.Controls.Add(lbl_TituloModulo);
            pnl_BarraFijaSuperior.Cursor = Cursors.SizeAll;
            pnl_BarraFijaSuperior.Dock = DockStyle.Top;
            pnl_BarraFijaSuperior.Location = new Point(0, 0);
            pnl_BarraFijaSuperior.Name = "pnl_BarraFijaSuperior";
            pnl_BarraFijaSuperior.Size = new Size(800, 100);
            pnl_BarraFijaSuperior.TabIndex = 1;
            pnl_BarraFijaSuperior.MouseDown += pnl_BarraFijaSuperior_MouseDown;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(12, -10);
            logo.Name = "logo";
            logo.Size = new Size(120, 120);
            logo.TabIndex = 4;
            logo.TabStop = false;
            // 
            // btn_VolverAlMenu
            // 
            btn_VolverAlMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btn_VolverAlMenu.Cursor = Cursors.Hand;
            btn_VolverAlMenu.Image = (Image)resources.GetObject("btn_VolverAlMenu.Image");
            btn_VolverAlMenu.Location = new Point(654, 13);
            btn_VolverAlMenu.Name = "btn_VolverAlMenu";
            btn_VolverAlMenu.Size = new Size(64, 64);
            btn_VolverAlMenu.TabIndex = 3;
            btn_VolverAlMenu.TabStop = false;
            btn_VolverAlMenu.Click += btn_Volver_Menu;
            // 
            // btn_Salir
            // 
            btn_Salir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Salir.Cursor = Cursors.Hand;
            btn_Salir.Image = (Image)resources.GetObject("btn_Salir.Image");
            btn_Salir.Location = new Point(724, 13);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(64, 64);
            btn_Salir.TabIndex = 2;
            btn_Salir.TabStop = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // lbl_TituloModulo
            // 
            lbl_TituloModulo.AutoSize = true;
            lbl_TituloModulo.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TituloModulo.ForeColor = Color.SeaShell;
            lbl_TituloModulo.Location = new Point(133, 41);
            lbl_TituloModulo.Name = "lbl_TituloModulo";
            lbl_TituloModulo.Size = new Size(0, 35);
            lbl_TituloModulo.TabIndex = 0;
            // 
            // VistaBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnl_BarraFijaSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VistaBase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VistaBase";
            pnl_BarraFijaSuperior.ResumeLayout(false);
            pnl_BarraFijaSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_VolverAlMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Salir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_BarraFijaSuperior;
        private Label lbl_TituloModulo;
        private PictureBox btn_Salir;
        private PictureBox btn_VolverAlMenu;
        private PictureBox logo;
    }
}