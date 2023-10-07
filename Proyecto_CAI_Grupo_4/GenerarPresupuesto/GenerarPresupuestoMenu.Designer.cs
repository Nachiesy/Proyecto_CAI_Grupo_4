namespace Proyecto_CAI_Grupo_4
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
            btnMenuHoteles = new Button();
            btnMenuCruceros = new Button();
            btnMenuAereos = new Button();
            label2 = new Label();
            btnFinalizarPresupuesto = new Button();
            btnVolverMenuPrincipal = new Button();
            presupuestosElegidos = new ListView();
            ID = new ColumnHeader();
            Nombre = new ColumnHeader();
            Precio = new ColumnHeader();
            TipoDeServicio = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(553, 23);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 6;
            // 
            // btnMenuHoteles
            // 
            btnMenuHoteles.Location = new Point(502, 115);
            btnMenuHoteles.Name = "btnMenuHoteles";
            btnMenuHoteles.Size = new Size(206, 23);
            btnMenuHoteles.TabIndex = 11;
            btnMenuHoteles.Text = "Generar Presupuesto de Hoteles";
            btnMenuHoteles.UseVisualStyleBackColor = true;
            btnMenuHoteles.Click += btnMenuHoteles_Click;
            // 
            // btnMenuCruceros
            // 
            btnMenuCruceros.Location = new Point(502, 160);
            btnMenuCruceros.Name = "btnMenuCruceros";
            btnMenuCruceros.Size = new Size(206, 23);
            btnMenuCruceros.TabIndex = 8;
            btnMenuCruceros.Text = "Generar Presupuesto de Cruceros";
            btnMenuCruceros.UseVisualStyleBackColor = true;
            btnMenuCruceros.Click += btnMenuCruceros_Click;
            // 
            // btnMenuAereos
            // 
            btnMenuAereos.Location = new Point(502, 72);
            btnMenuAereos.Name = "btnMenuAereos";
            btnMenuAereos.Size = new Size(206, 23);
            btnMenuAereos.TabIndex = 7;
            btnMenuAereos.Text = "Generar Presupuesto de Aéreos";
            btnMenuAereos.UseVisualStyleBackColor = true;
            btnMenuAereos.Click += btnMenuAereos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(502, 23);
            label2.Name = "label2";
            label2.Size = new Size(206, 30);
            label2.TabIndex = 12;
            label2.Text = "Generar Presupuesto";
            // 
            // btnFinalizarPresupuesto
            // 
            btnFinalizarPresupuesto.Location = new Point(502, 531);
            btnFinalizarPresupuesto.Name = "btnFinalizarPresupuesto";
            btnFinalizarPresupuesto.Size = new Size(206, 23);
            btnFinalizarPresupuesto.TabIndex = 14;
            btnFinalizarPresupuesto.Text = "Finalizar Presupuesto";
            btnFinalizarPresupuesto.UseVisualStyleBackColor = true;
            btnFinalizarPresupuesto.Click += btnFinalizarPresupuesto_Click;
            // 
            // btnVolverMenuPrincipal
            // 
            btnVolverMenuPrincipal.Location = new Point(502, 572);
            btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            btnVolverMenuPrincipal.Size = new Size(206, 23);
            btnVolverMenuPrincipal.TabIndex = 15;
            btnVolverMenuPrincipal.Text = "Volver al Menu Principal";
            btnVolverMenuPrincipal.UseVisualStyleBackColor = true;
            btnVolverMenuPrincipal.Click += btnVolverMenuPrincipal_Click;
            // 
            // presupuestosElegidos
            // 
            presupuestosElegidos.Columns.AddRange(new ColumnHeader[] { ID, Nombre, Precio, TipoDeServicio });
            presupuestosElegidos.FullRowSelect = true;
            presupuestosElegidos.Location = new Point(47, 225);
            presupuestosElegidos.Name = "presupuestosElegidos";
            presupuestosElegidos.Size = new Size(1159, 280);
            presupuestosElegidos.TabIndex = 32;
            presupuestosElegidos.UseCompatibleStateImageBehavior = false;
            presupuestosElegidos.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 250;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre";
            Nombre.Width = 100;
            // 
            // Precio
            // 
            Precio.Text = "Precio";
            Precio.Width = 100;
            // 
            // TipoDeServicio
            // 
            TipoDeServicio.Text = "Tipo de Servicio";
            TipoDeServicio.Width = 100;
            // 
            // GenerarPresupuestoMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 644);
            Controls.Add(presupuestosElegidos);
            Controls.Add(btnVolverMenuPrincipal);
            Controls.Add(btnFinalizarPresupuesto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMenuHoteles);
            Controls.Add(btnMenuCruceros);
            Controls.Add(btnMenuAereos);
            Name = "GenerarPresupuestoMenu";
            Text = "GenerarPresupuestoMenu";
            Load += GenerarPresupuestoMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnMenuHoteles;
        private Button btnMenuCruceros;
        private Button btnMenuAereos;
        private Label label2;
        private Button btnFinalizarPresupuesto;
        private Button btnVolverMenuPrincipal;
        private ListView presupuestosElegidos;
        private ColumnHeader ID;
        private ColumnHeader Nombre;
        private ColumnHeader Precio;
        private ColumnHeader TipoDeServicio;
    }
}