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
            btn_GenerarPresupuesto = new Common.Components.BotonEstilizado();
            btn_GenerarReserva = new Common.Components.BotonEstilizado();
            btn_ConfirmarReserva = new Common.Components.BotonEstilizado();
            btn_EstadoDeReservas = new Common.Components.BotonEstilizado();
            btn_BuscarPresupuesto = new Common.Components.BotonEstilizado();
            SuspendLayout();
            // 
            // btn_GenerarPresupuesto
            // 
            btn_GenerarPresupuesto.BackColor = Color.Transparent;
            btn_GenerarPresupuesto.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_GenerarPresupuesto.FlatStyle = FlatStyle.Flat;
            btn_GenerarPresupuesto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_GenerarPresupuesto.ForeColor = Color.Black;
            btn_GenerarPresupuesto.Location = new Point(320, 130);
            btn_GenerarPresupuesto.Name = "btn_GenerarPresupuesto";
            btn_GenerarPresupuesto.Size = new Size(226, 67);
            btn_GenerarPresupuesto.TabIndex = 4;
            btn_GenerarPresupuesto.Text = "Generar Presupuesto";
            btn_GenerarPresupuesto.UseVisualStyleBackColor = false;
            btn_GenerarPresupuesto.Click += btnMenuGenerarPresupuesto_Click;
            // 
            // btn_GenerarReserva
            // 
            btn_GenerarReserva.BackColor = Color.Transparent;
            btn_GenerarReserva.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_GenerarReserva.FlatStyle = FlatStyle.Flat;
            btn_GenerarReserva.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_GenerarReserva.ForeColor = Color.Black;
            btn_GenerarReserva.Location = new Point(320, 212);
            btn_GenerarReserva.Name = "btn_GenerarReserva";
            btn_GenerarReserva.Size = new Size(224, 67);
            btn_GenerarReserva.TabIndex = 4;
            btn_GenerarReserva.Text = "Generar Reserva";
            btn_GenerarReserva.UseVisualStyleBackColor = false;
            btn_GenerarReserva.Click += btn_GenerarReserva_Click;
            // 
            // btn_ConfirmarReserva
            // 
            btn_ConfirmarReserva.BackColor = Color.Transparent;
            btn_ConfirmarReserva.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_ConfirmarReserva.FlatStyle = FlatStyle.Flat;
            btn_ConfirmarReserva.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ConfirmarReserva.ForeColor = Color.Black;
            btn_ConfirmarReserva.Location = new Point(320, 295);
            btn_ConfirmarReserva.Name = "btn_ConfirmarReserva";
            btn_ConfirmarReserva.Size = new Size(226, 67);
            btn_ConfirmarReserva.TabIndex = 4;
            btn_ConfirmarReserva.Text = "Confirmar Reserva";
            btn_ConfirmarReserva.UseVisualStyleBackColor = false;
            btn_ConfirmarReserva.Click += btn_ConfirmarReserva_Click;
            // 
            // btn_EstadoDeReservas
            // 
            btn_EstadoDeReservas.BackColor = Color.Transparent;
            btn_EstadoDeReservas.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_EstadoDeReservas.FlatStyle = FlatStyle.Flat;
            btn_EstadoDeReservas.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_EstadoDeReservas.ForeColor = Color.Black;
            btn_EstadoDeReservas.Location = new Point(27, 295);
            btn_EstadoDeReservas.Name = "btn_EstadoDeReservas";
            btn_EstadoDeReservas.Size = new Size(227, 67);
            btn_EstadoDeReservas.TabIndex = 8;
            btn_EstadoDeReservas.Text = "Consultar Reservas";
            btn_EstadoDeReservas.UseVisualStyleBackColor = false;
            btn_EstadoDeReservas.Click += btnConsultarReservas_Click;
            // 
            // btn_BuscarPresupuesto
            // 
            btn_BuscarPresupuesto.BackColor = Color.Transparent;
            btn_BuscarPresupuesto.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_BuscarPresupuesto.FlatStyle = FlatStyle.Flat;
            btn_BuscarPresupuesto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_BuscarPresupuesto.ForeColor = Color.Black;
            btn_BuscarPresupuesto.Location = new Point(27, 130);
            btn_BuscarPresupuesto.Name = "btn_BuscarPresupuesto";
            btn_BuscarPresupuesto.Size = new Size(226, 67);
            btn_BuscarPresupuesto.TabIndex = 9;
            btn_BuscarPresupuesto.Text = "Buscar Presupuesto";
            btn_BuscarPresupuesto.UseVisualStyleBackColor = false;
            btn_BuscarPresupuesto.Click += btn_BuscarPresupuesto_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(557, 378);
            Controls.Add(btn_BuscarPresupuesto);
            Controls.Add(btn_EstadoDeReservas);
            Controls.Add(btn_ConfirmarReserva);
            Controls.Add(btn_GenerarReserva);
            Controls.Add(btn_GenerarPresupuesto);
            Margin = new Padding(6);
            Name = "MenuPrincipal";
            Text = "Menu Principal";
            Load += MenuPrincipal_Load;
            Controls.SetChildIndex(btn_GenerarPresupuesto, 0);
            Controls.SetChildIndex(btn_GenerarReserva, 0);
            Controls.SetChildIndex(btn_ConfirmarReserva, 0);
            Controls.SetChildIndex(btn_EstadoDeReservas, 0);
            Controls.SetChildIndex(btn_BuscarPresupuesto, 0);
            ResumeLayout(false);
        }

        #endregion
        private Common.Components.BotonEstilizado btn_GenerarPresupuesto;
        private Common.Components.BotonEstilizado btn_GenerarReserva;
        private Common.Components.BotonEstilizado btn_ConfirmarReserva;
        private Common.Components.BotonEstilizado btn_EstadoDeReservas;
        private Common.Components.BotonEstilizado btn_BuscarPresupuesto;
        //>>>>>>> 0cf15ab1261db55f98947b8966023a59eed0f5c3
    }
}