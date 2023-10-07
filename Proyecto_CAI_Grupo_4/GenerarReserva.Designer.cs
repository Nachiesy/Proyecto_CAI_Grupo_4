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
            dniClientetxb = new TextBox();
            buscarclientebtn = new Button();
            generarreservabtn = new Button();
            reservasListView = new ListView();
            Codigo = new ColumnHeader();
            Estado = new ColumnHeader();
            Nrodocumento = new ColumnHeader();
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
            // dniClientetxb
            // 
            dniClientetxb.Location = new Point(163, 16);
            dniClientetxb.Name = "dniClientetxb";
            dniClientetxb.Size = new Size(100, 23);
            dniClientetxb.TabIndex = 1;
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
            generarreservabtn.Location = new Point(470, 204);
            generarreservabtn.Name = "generarreservabtn";
            generarreservabtn.Size = new Size(118, 23);
            generarreservabtn.TabIndex = 4;
            generarreservabtn.Text = "Generar reserva";
            generarreservabtn.UseVisualStyleBackColor = true;
            // 
            // reservasListView
            // 
            reservasListView.Columns.AddRange(new ColumnHeader[] { Codigo, Estado, Nrodocumento });
            reservasListView.Location = new Point(12, 45);
            reservasListView.Name = "reservasListView";
            reservasListView.Size = new Size(576, 153);
            reservasListView.TabIndex = 5;
            reservasListView.UseCompatibleStateImageBehavior = false;
            // 
            // GenerarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 265);
            Controls.Add(reservasListView);
            Controls.Add(generarreservabtn);
            Controls.Add(buscarclientebtn);
            Controls.Add(dniClientetxb);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(1);
            Name = "GenerarReserva";
            Text = "Generar Reserva";
            Load += GenerarReserva_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox dniClientetxb;
        private Button buscarclientebtn;
        private Button generarreservabtn;
        private ListView reservasListView;
        private ColumnHeader Codigo;
        private ColumnHeader Estado;
        private ColumnHeader Nrodocumento;
    }
}