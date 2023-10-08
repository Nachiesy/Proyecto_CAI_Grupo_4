namespace Proyecto_CAI_Grupo_4
{
    partial class ConsultarReservas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            reservasListView = new ListView();
            Codigo = new ColumnHeader();
            Estado = new ColumnHeader();
            NroDocumento = new ColumnHeader();
            Precio = new ColumnHeader();
            Fecha = new ColumnHeader();
            Desde = new ColumnHeader();
            Hasta = new ColumnHeader();
            filtroCodigo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            filtroNroDeDoc = new TextBox();
            label3 = new Label();
            filtroEstado = new ComboBox();
            btn_BuscarReserva = new Common.Components.BotonEstilizado();
            grp_Filtros = new GroupBox();
            btn_Limpiar = new Common.Components.BotonEstilizado();
            grp_Filtros.SuspendLayout();
            SuspendLayout();
            // 
            // reservasListView
            // 
            reservasListView.BackColor = SystemColors.ControlLight;
            reservasListView.Columns.AddRange(new ColumnHeader[] { Codigo, Estado, NroDocumento, Precio, Fecha, Desde, Hasta });
            reservasListView.Location = new Point(50, 523);
            reservasListView.Margin = new Padding(6, 6, 6, 6);
            reservasListView.Name = "reservasListView";
            reservasListView.Size = new Size(1493, 482);
            reservasListView.TabIndex = 0;
            reservasListView.UseCompatibleStateImageBehavior = false;
            reservasListView.View = View.Details;
            reservasListView.SelectedIndexChanged += reservasListView_SelectedIndexChanged;
            // 
            // Codigo
            // 
            Codigo.Text = "Codigo";
            Codigo.Width = 100;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 150;
            // 
            // NroDocumento
            // 
            NroDocumento.Text = "Nro. Documento";
            NroDocumento.Width = 150;
            // 
            // Precio
            // 
            Precio.Text = "Precio";
            Precio.Width = 100;
            // 
            // Fecha
            // 
            Fecha.Text = "Fecha";
            Fecha.Width = 100;
            // 
            // Desde
            // 
            Desde.Text = "Desde";
            Desde.Width = 100;
            // 
            // Hasta
            // 
            Hasta.Text = "Hasta";
            Hasta.Width = 100;
            // 
            // filtroCodigo
            // 
            filtroCodigo.Location = new Point(208, 47);
            filtroCodigo.Margin = new Padding(6, 6, 6, 6);
            filtroCodigo.Name = "filtroCodigo";
            filtroCodigo.Size = new Size(251, 39);
            filtroCodigo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 47);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 32);
            label1.TabIndex = 3;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 117);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 32);
            label2.TabIndex = 5;
            label2.Text = "DNI";
            // 
            // filtroNroDeDoc
            // 
            filtroNroDeDoc.Location = new Point(208, 117);
            filtroNroDeDoc.Margin = new Padding(6, 6, 6, 6);
            filtroNroDeDoc.Name = "filtroNroDeDoc";
            filtroNroDeDoc.Size = new Size(251, 39);
            filtroNroDeDoc.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 183);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 32);
            label3.TabIndex = 7;
            label3.Text = "Estado";
            // 
            // filtroEstado
            // 
            filtroEstado.FormattingEnabled = true;
            filtroEstado.Items.AddRange(new object[] { "Pendiente de Pago", "Pagada", "Confirmada" });
            filtroEstado.Location = new Point(208, 183);
            filtroEstado.Margin = new Padding(6, 6, 6, 6);
            filtroEstado.Name = "filtroEstado";
            filtroEstado.Size = new Size(251, 40);
            filtroEstado.TabIndex = 9;
            // 
            // btn_BuscarReserva
            // 
            btn_BuscarReserva.BackColor = Color.Transparent;
            btn_BuscarReserva.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_BuscarReserva.FlatStyle = FlatStyle.Flat;
            btn_BuscarReserva.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_BuscarReserva.ForeColor = Color.Black;
            btn_BuscarReserva.Location = new Point(1164, 243);
            btn_BuscarReserva.Margin = new Padding(6, 6, 6, 6);
            btn_BuscarReserva.Name = "btn_BuscarReserva";
            btn_BuscarReserva.Size = new Size(379, 85);
            btn_BuscarReserva.TabIndex = 4;
            btn_BuscarReserva.Text = "Buscar";
            btn_BuscarReserva.UseVisualStyleBackColor = false;
            btn_BuscarReserva.Click += buscarReserva_Click;
            // 
            // grp_Filtros
            // 
            grp_Filtros.Controls.Add(filtroCodigo);
            grp_Filtros.Controls.Add(label1);
            grp_Filtros.Controls.Add(filtroNroDeDoc);
            grp_Filtros.Controls.Add(label2);
            grp_Filtros.Controls.Add(label3);
            grp_Filtros.Controls.Add(filtroEstado);
            grp_Filtros.Location = new Point(50, 226);
            grp_Filtros.Margin = new Padding(6, 6, 6, 6);
            grp_Filtros.Name = "grp_Filtros";
            grp_Filtros.Padding = new Padding(6, 6, 6, 6);
            grp_Filtros.Size = new Size(552, 245);
            grp_Filtros.TabIndex = 10;
            grp_Filtros.TabStop = false;
            grp_Filtros.Text = "Filtros";
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor = Color.Transparent;
            btn_Limpiar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_Limpiar.FlatStyle = FlatStyle.Flat;
            btn_Limpiar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Limpiar.ForeColor = Color.Black;
            btn_Limpiar.Location = new Point(1166, 373);
            btn_Limpiar.Margin = new Padding(6, 6, 6, 6);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(377, 85);
            btn_Limpiar.TabIndex = 4;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = false;
            btn_Limpiar.Click += limpiarConsulta_Click;
            // 
            // ConsultarReservas
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1566, 1039);
            Controls.Add(btn_Limpiar);
            Controls.Add(grp_Filtros);
            Controls.Add(btn_BuscarReserva);
            Controls.Add(reservasListView);
            Margin = new Padding(11, 13, 11, 13);
            Name = "ConsultarReservas";
            Text = "Form1";
            Load += ConsultarReservas_Load;
            Controls.SetChildIndex(reservasListView, 0);
            Controls.SetChildIndex(btn_BuscarReserva, 0);
            Controls.SetChildIndex(grp_Filtros, 0);
            Controls.SetChildIndex(btn_Limpiar, 0);
            grp_Filtros.ResumeLayout(false);
            grp_Filtros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView reservasListView;
        private ColumnHeader Codigo;
        private ColumnHeader Estado;
        private ColumnHeader NroDocumento;
        private ColumnHeader Precio;
        private ColumnHeader Fecha;
        private ColumnHeader Desde;
        private ColumnHeader Hasta;
        private TextBox filtroCodigo;
        private Label label1;
        private Label label2;
        private TextBox filtroNroDeDoc;
        private Label label3;
        private ComboBox filtroEstado;
        private Common.Components.BotonEstilizado btn_BuscarReserva;
        private GroupBox grp_Filtros;
        private Common.Components.BotonEstilizado btn_Limpiar;
    }
}