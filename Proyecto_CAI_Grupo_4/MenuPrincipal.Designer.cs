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
            btnConsultarProductos = new Common.Components.BotonEstilizado();
            btn_GenerarPresupuesto = new Common.Components.BotonEstilizado();
            btn_GenerarReserva = new Common.Components.BotonEstilizado();
            btn_ConfirmarReserva = new Common.Components.BotonEstilizado();
            btn_EstadoDeReservas = new Common.Components.BotonEstilizado();
            SuspendLayout();
            // 
            // btnConsultarProductos
            // 
            btnConsultarProductos.BackColor = Color.Transparent;
            btnConsultarProductos.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnConsultarProductos.FlatStyle = FlatStyle.Flat;
            btnConsultarProductos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultarProductos.ForeColor = Color.Black;
            btnConsultarProductos.Location = new Point(50, 277);
            btnConsultarProductos.Margin = new Padding(6, 6, 6, 6);
            btnConsultarProductos.Name = "btnConsultarProductos";
            btnConsultarProductos.Size = new Size(422, 143);
            btnConsultarProductos.TabIndex = 4;
            btnConsultarProductos.Text = "Consultar Productos";
            btnConsultarProductos.UseVisualStyleBackColor = false;
            btnConsultarProductos.Click += btnConsultarProductos_Click;
            // 
            // btn_GenerarPresupuesto
            // 
            btn_GenerarPresupuesto.BackColor = Color.Transparent;
            btn_GenerarPresupuesto.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_GenerarPresupuesto.FlatStyle = FlatStyle.Flat;
            btn_GenerarPresupuesto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_GenerarPresupuesto.ForeColor = Color.Black;
            btn_GenerarPresupuesto.Location = new Point(594, 277);
            btn_GenerarPresupuesto.Margin = new Padding(6, 6, 6, 6);
            btn_GenerarPresupuesto.Name = "btn_GenerarPresupuesto";
            btn_GenerarPresupuesto.Size = new Size(420, 143);
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
            btn_GenerarReserva.Location = new Point(594, 452);
            btn_GenerarReserva.Margin = new Padding(6, 6, 6, 6);
            btn_GenerarReserva.Name = "btn_GenerarReserva";
            btn_GenerarReserva.Size = new Size(416, 143);
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
            btn_ConfirmarReserva.Location = new Point(594, 629);
            btn_ConfirmarReserva.Margin = new Padding(6, 6, 6, 6);
            btn_ConfirmarReserva.Name = "btn_ConfirmarReserva";
            btn_ConfirmarReserva.Size = new Size(420, 143);
            btn_ConfirmarReserva.TabIndex = 4;
            btn_ConfirmarReserva.Text = "Confirmar Reserva";
            btn_ConfirmarReserva.UseVisualStyleBackColor = false;
            // 
            // btn_EstadoDeReservas
            // 
            btn_EstadoDeReservas.BackColor = Color.Transparent;
            btn_EstadoDeReservas.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_EstadoDeReservas.FlatStyle = FlatStyle.Flat;
            btn_EstadoDeReservas.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_EstadoDeReservas.ForeColor = Color.Black;
            btn_EstadoDeReservas.Location = new Point(50, 452);
            btn_EstadoDeReservas.Margin = new Padding(6, 6, 6, 6);
            btn_EstadoDeReservas.Name = "btn_EstadoDeReservas";
            btn_EstadoDeReservas.Size = new Size(422, 143);
            btn_EstadoDeReservas.TabIndex = 8;
            btn_EstadoDeReservas.Text = "Consultar Reservas";
            btn_EstadoDeReservas.UseVisualStyleBackColor = false;
            btn_EstadoDeReservas.Click += btnConsultarReservas_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1040, 836);
            Controls.Add(btn_EstadoDeReservas);
            Controls.Add(btn_ConfirmarReserva);
            Controls.Add(btn_GenerarReserva);
            Controls.Add(btn_GenerarPresupuesto);
            Controls.Add(btnConsultarProductos);
            Margin = new Padding(11, 13, 11, 13);
            Name = "MenuPrincipal";
            Text = "Menu Principal";
            Load += MenuPrincipal_Load;
            Controls.SetChildIndex(btnConsultarProductos, 0);
            Controls.SetChildIndex(btn_GenerarPresupuesto, 0);
            Controls.SetChildIndex(btn_GenerarReserva, 0);
            Controls.SetChildIndex(btn_ConfirmarReserva, 0);
            Controls.SetChildIndex(btn_EstadoDeReservas, 0);
            ResumeLayout(false);
        }

        #endregion
        //=======
        private Common.Components.BotonEstilizado btnConsultarProductos;
        private Common.Components.BotonEstilizado btn_GenerarPresupuesto;
        private Common.Components.BotonEstilizado btn_GenerarReserva;
        private Common.Components.BotonEstilizado btn_ConfirmarReserva;
        private Common.Components.BotonEstilizado btn_EstadoDeReservas;
        //>>>>>>> 0cf15ab1261db55f98947b8966023a59eed0f5c3
    }
}