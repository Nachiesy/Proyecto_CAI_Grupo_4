﻿namespace Proyecto_CAI_Grupo_4
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
            cantpasajeros = new ColumnHeader();
            Fecha = new ColumnHeader();
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
            reservasListView.Columns.AddRange(new ColumnHeader[] { Codigo, Estado, NroDocumento, Precio, cantpasajeros, Fecha });
            reservasListView.Location = new Point(27, 245);
            reservasListView.Name = "reservasListView";
            reservasListView.Size = new Size(806, 228);
            reservasListView.TabIndex = 0;
            reservasListView.UseCompatibleStateImageBehavior = false;
            reservasListView.View = View.Details;
            // 
            // Codigo
            // 
            Codigo.Text = "ID";
            Codigo.Width = 150;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 150;
            // 
            // NroDocumento
            // 
            NroDocumento.Text = "Nro. Documento";
            NroDocumento.Width = 200;
            // 
            // Precio
            // 
            Precio.Text = "Precio";
            Precio.Width = 150;
            // 
            // cantpasajeros
            // 
            cantpasajeros.Text = "Cant. Pasajeros";
            cantpasajeros.Width = 200;
            // 
            // Fecha
            // 
            Fecha.Text = "Fecha";
            Fecha.Width = 200;
            // 
            // filtroCodigo
            // 
            filtroCodigo.Location = new Point(112, 22);
            filtroCodigo.Name = "filtroCodigo";
            filtroCodigo.Size = new Size(137, 23);
            filtroCodigo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 22);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 55);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 5;
            label2.Text = "DNI";
            // 
            // filtroNroDeDoc
            // 
            filtroNroDeDoc.Location = new Point(112, 55);
            filtroNroDeDoc.Name = "filtroNroDeDoc";
            filtroNroDeDoc.Size = new Size(137, 23);
            filtroNroDeDoc.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 86);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 7;
            label3.Text = "Estado";
            // 
            // filtroEstado
            // 
            filtroEstado.FormattingEnabled = true;
            filtroEstado.Items.AddRange(new object[] { "Pendiente de Confirmación", "Confirmada" });
            filtroEstado.Location = new Point(112, 86);
            filtroEstado.Name = "filtroEstado";
            filtroEstado.Size = new Size(137, 23);
            filtroEstado.TabIndex = 9;
            // 
            // btn_BuscarReserva
            // 
            btn_BuscarReserva.BackColor = Color.Transparent;
            btn_BuscarReserva.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_BuscarReserva.FlatStyle = FlatStyle.Flat;
            btn_BuscarReserva.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_BuscarReserva.ForeColor = Color.Black;
            btn_BuscarReserva.Location = new Point(627, 114);
            btn_BuscarReserva.Name = "btn_BuscarReserva";
            btn_BuscarReserva.Size = new Size(204, 40);
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
            grp_Filtros.Location = new Point(27, 106);
            grp_Filtros.Name = "grp_Filtros";
            grp_Filtros.Size = new Size(297, 115);
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
            btn_Limpiar.Location = new Point(628, 175);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(203, 40);
            btn_Limpiar.TabIndex = 4;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = false;
            btn_Limpiar.Click += limpiarConsulta_Click;
            // 
            // ConsultarReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(843, 487);
            Controls.Add(btn_Limpiar);
            Controls.Add(grp_Filtros);
            Controls.Add(btn_BuscarReserva);
            Controls.Add(reservasListView);
            Margin = new Padding(6, 6, 6, 6);
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
        private TextBox filtroCodigo;
        private Label label1;
        private Label label2;
        private TextBox filtroNroDeDoc;
        private Label label3;
        private ComboBox filtroEstado;
        private Common.Components.BotonEstilizado btn_BuscarReserva;
        private GroupBox grp_Filtros;
        private Common.Components.BotonEstilizado btn_Limpiar;
        private ColumnHeader cantpasajeros;
    }
}