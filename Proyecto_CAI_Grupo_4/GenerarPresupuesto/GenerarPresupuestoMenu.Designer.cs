﻿namespace Proyecto_CAI_Grupo_4
{
    partial class GenerarPresupuestoMenu
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
            presupuestoTotal = new Label();
            productosElegidos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            TipoDeServicio = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnMenuAereos = new Common.Components.BotonEstilizado();
            btnMenuPaquetes = new Common.Components.BotonEstilizado();
            btnMenuHoteles = new Common.Components.BotonEstilizado();
            btnMenuCruceros = new Common.Components.BotonEstilizado();
            btnFinalizarPresupuesto = new Common.Components.BotonEstilizado();
            grp_Estimacion = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)productosElegidos).BeginInit();
            groupBox1.SuspendLayout();
            grp_Estimacion.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 233);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 6;
            // 
            // presupuestoTotal
            // 
            presupuestoTotal.AutoSize = true;
            presupuestoTotal.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            presupuestoTotal.Location = new Point(15, 30);
            presupuestoTotal.Name = "presupuestoTotal";
            presupuestoTotal.Size = new Size(108, 31);
            presupuestoTotal.TabIndex = 34;
            presupuestoTotal.Text = "Total: $-";
            // 
            // productosElegidos
            // 
            productosElegidos.AllowUserToAddRows = false;
            productosElegidos.AllowUserToDeleteRows = false;
            productosElegidos.AllowUserToOrderColumns = true;
            productosElegidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productosElegidos.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, TipoDeServicio, PrecioUnitario, Cantidad, SubTotal });
            productosElegidos.Location = new Point(303, 126);
            productosElegidos.Name = "productosElegidos";
            productosElegidos.RowTemplate.Height = 25;
            productosElegidos.Size = new Size(893, 344);
            productosElegidos.TabIndex = 36;
            productosElegidos.CellValueChanged += productosElegidos_CellValueChanged;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 250;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 200;
            // 
            // TipoDeServicio
            // 
            TipoDeServicio.HeaderText = "Tipo de Servicio";
            TipoDeServicio.Name = "TipoDeServicio";
            TipoDeServicio.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.HeaderText = "Precio Unitario";
            PrecioUnitario.Name = "PrecioUnitario";
            PrecioUnitario.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMenuAereos);
            groupBox1.Controls.Add(btnMenuPaquetes);
            groupBox1.Controls.Add(btnMenuHoteles);
            groupBox1.Controls.Add(btnMenuCruceros);
            groupBox1.Location = new Point(12, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 228);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar productos";
            // 
            // btnMenuAereos
            // 
            btnMenuAereos.BackColor = Color.Transparent;
            btnMenuAereos.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnMenuAereos.FlatStyle = FlatStyle.Flat;
            btnMenuAereos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuAereos.ForeColor = Color.Black;
            btnMenuAereos.Location = new Point(68, 31);
            btnMenuAereos.Name = "btnMenuAereos";
            btnMenuAereos.Size = new Size(172, 40);
            btnMenuAereos.TabIndex = 4;
            btnMenuAereos.Text = "Aéreos";
            btnMenuAereos.UseVisualStyleBackColor = false;
            btnMenuAereos.Click += btnMenuAereos_Click;
            // 
            // btnMenuPaquetes
            // 
            btnMenuPaquetes.BackColor = Color.Transparent;
            btnMenuPaquetes.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnMenuPaquetes.FlatStyle = FlatStyle.Flat;
            btnMenuPaquetes.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuPaquetes.ForeColor = Color.Black;
            btnMenuPaquetes.Location = new Point(68, 169);
            btnMenuPaquetes.Name = "btnMenuPaquetes";
            btnMenuPaquetes.Size = new Size(172, 40);
            btnMenuPaquetes.TabIndex = 4;
            btnMenuPaquetes.Text = "Paquetes";
            btnMenuPaquetes.UseVisualStyleBackColor = false;
            // 
            // btnMenuHoteles
            // 
            btnMenuHoteles.BackColor = Color.Transparent;
            btnMenuHoteles.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnMenuHoteles.FlatStyle = FlatStyle.Flat;
            btnMenuHoteles.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuHoteles.ForeColor = Color.Black;
            btnMenuHoteles.Location = new Point(68, 77);
            btnMenuHoteles.Name = "btnMenuHoteles";
            btnMenuHoteles.Size = new Size(172, 40);
            btnMenuHoteles.TabIndex = 4;
            btnMenuHoteles.Text = "Hoteles";
            btnMenuHoteles.UseVisualStyleBackColor = false;
            btnMenuHoteles.Click += btnMenuHoteles_Click;
            // 
            // btnMenuCruceros
            // 
            btnMenuCruceros.BackColor = Color.Transparent;
            btnMenuCruceros.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnMenuCruceros.FlatStyle = FlatStyle.Flat;
            btnMenuCruceros.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuCruceros.ForeColor = Color.Black;
            btnMenuCruceros.Location = new Point(68, 123);
            btnMenuCruceros.Name = "btnMenuCruceros";
            btnMenuCruceros.Size = new Size(172, 40);
            btnMenuCruceros.TabIndex = 4;
            btnMenuCruceros.Text = "Cruceros";
            btnMenuCruceros.UseVisualStyleBackColor = false;
            btnMenuCruceros.Click += btnMenuCruceros_Click;
            // 
            // btnFinalizarPresupuesto
            // 
            btnFinalizarPresupuesto.BackColor = Color.Transparent;
            btnFinalizarPresupuesto.Enabled = false;
            btnFinalizarPresupuesto.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnFinalizarPresupuesto.FlatStyle = FlatStyle.Flat;
            btnFinalizarPresupuesto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinalizarPresupuesto.ForeColor = Color.Black;
            btnFinalizarPresupuesto.Location = new Point(12, 430);
            btnFinalizarPresupuesto.Name = "btnFinalizarPresupuesto";
            btnFinalizarPresupuesto.Size = new Size(246, 40);
            btnFinalizarPresupuesto.TabIndex = 4;
            btnFinalizarPresupuesto.Text = "Guardar";
            btnFinalizarPresupuesto.UseVisualStyleBackColor = false;
            btnFinalizarPresupuesto.Click += btnFinalizarPresupuesto_Click;
            // 
            // grp_Estimacion
            // 
            grp_Estimacion.Controls.Add(presupuestoTotal);
            grp_Estimacion.Location = new Point(12, 349);
            grp_Estimacion.Name = "grp_Estimacion";
            grp_Estimacion.Size = new Size(246, 75);
            grp_Estimacion.TabIndex = 38;
            grp_Estimacion.TabStop = false;
            grp_Estimacion.Text = "Estimacion";
            // 
            // GenerarPresupuestoMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 483);
            Controls.Add(grp_Estimacion);
            Controls.Add(btnFinalizarPresupuesto);
            Controls.Add(groupBox1);
            Controls.Add(productosElegidos);
            Controls.Add(label1);
            Name = "GenerarPresupuestoMenu";
            Text = "Generar Presupuesto";
            Load += GenerarPresupuestoMenu_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(productosElegidos, 0);
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(btnFinalizarPresupuesto, 0);
            Controls.SetChildIndex(grp_Estimacion, 0);
            ((System.ComponentModel.ISupportInitialize)productosElegidos).EndInit();
            groupBox1.ResumeLayout(false);
            grp_Estimacion.ResumeLayout(false);
            grp_Estimacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label presupuestoTotal;
        private DataGridView productosElegidos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn TipoDeServicio;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private GroupBox groupBox1;
        private Common.Components.BotonEstilizado btnMenuAereos;
        private Common.Components.BotonEstilizado btnMenuHoteles;
        private Common.Components.BotonEstilizado btnMenuCruceros;
        private Common.Components.BotonEstilizado btnMenuPaquetes;
        private Common.Components.BotonEstilizado btnFinalizarPresupuesto;
        private GroupBox grp_Estimacion;
    }
}