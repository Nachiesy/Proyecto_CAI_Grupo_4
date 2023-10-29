namespace Proyecto_CAI_Grupo_4.GenerarPresupuesto
{
    partial class BuscarPresupuesto
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
            btn_BuscarPresupuesto = new Common.Components.BotonEstilizado();
            txt_NumeroPresupuesto = new TextBox();
            label2 = new Label();
            btn_Volver = new Common.Components.BotonEstilizado();
            SuspendLayout();
            // 
            // btn_BuscarPresupuesto
            // 
            btn_BuscarPresupuesto.BackColor = Color.Transparent;
            btn_BuscarPresupuesto.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_BuscarPresupuesto.FlatStyle = FlatStyle.Flat;
            btn_BuscarPresupuesto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_BuscarPresupuesto.ForeColor = Color.Black;
            btn_BuscarPresupuesto.Location = new Point(143, 232);
            btn_BuscarPresupuesto.Name = "btn_BuscarPresupuesto";
            btn_BuscarPresupuesto.Size = new Size(223, 40);
            btn_BuscarPresupuesto.TabIndex = 4;
            btn_BuscarPresupuesto.Text = "Buscar";
            btn_BuscarPresupuesto.UseVisualStyleBackColor = false;
            btn_BuscarPresupuesto.Click += btn_BuscarPresupuesto_Click;
            // 
            // txt_NumeroPresupuesto
            // 
            txt_NumeroPresupuesto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_NumeroPresupuesto.Location = new Point(30, 168);
            txt_NumeroPresupuesto.Multiline = true;
            txt_NumeroPresupuesto.Name = "txt_NumeroPresupuesto";
            txt_NumeroPresupuesto.Size = new Size(336, 40);
            txt_NumeroPresupuesto.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15.15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 122);
            label2.Name = "label2";
            label2.Size = new Size(336, 26);
            label2.TabIndex = 7;
            label2.Text = "Ingrese número de presupuesto";
            // 
            // btn_Volver
            // 
            btn_Volver.BackColor = Color.Transparent;
            btn_Volver.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_Volver.FlatStyle = FlatStyle.Flat;
            btn_Volver.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Volver.ForeColor = Color.Black;
            btn_Volver.Location = new Point(30, 232);
            btn_Volver.Name = "btn_Volver";
            btn_Volver.Size = new Size(103, 40);
            btn_Volver.TabIndex = 8;
            btn_Volver.Text = "Volver";
            btn_Volver.UseVisualStyleBackColor = false;
            btn_Volver.Click += btn_Volver_Click;
            // 
            // BuscarPresupuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 294);
            Controls.Add(btn_Volver);
            Controls.Add(label2);
            Controls.Add(txt_NumeroPresupuesto);
            Controls.Add(btn_BuscarPresupuesto);
            Name = "BuscarPresupuesto";
            Text = "BuscarPresupuesto";
            Load += BuscarPresupuesto_Load;
            Controls.SetChildIndex(btn_BuscarPresupuesto, 0);
            Controls.SetChildIndex(txt_NumeroPresupuesto, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(btn_Volver, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Common.Components.BotonEstilizado btn_BuscarPresupuesto;
        private TextBox txt_NumeroPresupuesto;
        private Label label2;
        private Common.Components.BotonEstilizado btn_Volver;
    }
}