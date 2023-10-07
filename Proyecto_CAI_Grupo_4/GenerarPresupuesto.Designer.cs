namespace Proyecto_CAI_Grupo_4
{
    partial class GenerarPresupuesto
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
            presupuestosElegidos = new ListView();
            presupuestosBuscados = new ListView();
            TipoDeServicio = new ColumnHeader();
            NombreDelServicio = new ColumnHeader();
            Adultos = new ColumnHeader();
            Menores = new ColumnHeader();
            PrecioDesde = new ColumnHeader();
            PrecioHasta = new ColumnHeader();
            FechaDesde = new ColumnHeader();
            FechaHasta = new ColumnHeader();
            SuspendLayout();
            // 
            // presupuestosElegidos
            // 
            presupuestosElegidos.Location = new Point(31, 257);
            presupuestosElegidos.Name = "presupuestosElegidos";
            presupuestosElegidos.Size = new Size(1179, 186);
            presupuestosElegidos.TabIndex = 1;
            presupuestosElegidos.UseCompatibleStateImageBehavior = false;
            // 
            // presupuestosBuscados
            // 
            presupuestosBuscados.Columns.AddRange(new ColumnHeader[] { TipoDeServicio, NombreDelServicio, Adultos, Menores, PrecioDesde, PrecioHasta, FechaDesde, FechaHasta });
            presupuestosBuscados.Location = new Point(31, 23);
            presupuestosBuscados.Name = "presupuestosBuscados";
            presupuestosBuscados.Size = new Size(1179, 168);
            presupuestosBuscados.TabIndex = 2;
            presupuestosBuscados.UseCompatibleStateImageBehavior = false;
            presupuestosBuscados.View = View.Details;
            // 
            // TipoDeServicio
            // 
            TipoDeServicio.Text = "Tipo de Servicio";
            TipoDeServicio.Width = 100;
            // 
            // NombreDelServicio
            // 
            NombreDelServicio.Text = "Nombre del Servicio";
            NombreDelServicio.Width = 150;
            // 
            // Adultos
            // 
            Adultos.Text = "Adultos";
            Adultos.Width = 100;
            // 
            // Menores
            // 
            Menores.Text = "Menores";
            Menores.Width = 100;
            // 
            // PrecioDesde
            // 
            PrecioDesde.Text = "Precio Desde";
            PrecioDesde.Width = 100;
            // 
            // PrecioHasta
            // 
            PrecioHasta.Text = "Precio Hasta";
            PrecioHasta.Width = 100;
            // 
            // FechaDesde
            // 
            FechaDesde.Text = "Fecha Desde";
            FechaDesde.Width = 150;
            // 
            // FechaHasta
            // 
            FechaHasta.Text = "Fecha Hasta";
            FechaHasta.Width = 150;
            // 
            // GenerarPresupuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 500);
            Controls.Add(presupuestosBuscados);
            Controls.Add(presupuestosElegidos);
            Name = "GenerarPresupuesto";
            Text = "GenerarPresupuesto";
            Load += GenerarPresupuesto_Load;
            ResumeLayout(false);
        }

        #endregion
        private ListView presupuestosElegidos;
        private ListView presupuestosBuscados;
        private ColumnHeader TipoDeServicio;
        private ColumnHeader NombreDelServicio;
        private ColumnHeader Adultos;
        private ColumnHeader Menores;
        private ColumnHeader PrecioDesde;
        private ColumnHeader PrecioHasta;
        private ColumnHeader FechaDesde;
        private ColumnHeader FechaHasta;
    }
}