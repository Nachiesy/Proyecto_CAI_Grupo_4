namespace Proyecto_CAI_Grupo_4
{
    partial class IngresarPasajero
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
            label2 = new Label();
            label3 = new Label();
            label8 = new Label();
            nombrepasajerotxt = new TextBox();
            apellidopasajerotxt = new TextBox();
            dnipasajerotxt = new TextBox();
            label10 = new Label();
            dtnacmiento = new DateTimePicker();
            grp_DatosPersonales = new GroupBox();
            btn_Confirmar = new Common.Components.BotonEstilizado();
            btn_Cancelar = new Common.Components.BotonEstilizado();
            grp_DatosContato = new GroupBox();
            lv_ListadoProductos = new ListView();
            idproductoseleccionado = new ColumnHeader();
            descripcionproducto = new ColumnHeader();
            grp_DatosPersonales.SuspendLayout();
            grp_DatosContato.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(70, 19);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15.15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(423, 26);
            label2.TabIndex = 1;
            label2.Text = "Por favor ingrese los datos del pasajeros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 71);
            label3.Name = "label3";
            label3.Size = new Size(70, 19);
            label3.TabIndex = 2;
            label3.Text = "Apellido:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 110);
            label8.Name = "label8";
            label8.Size = new Size(39, 19);
            label8.TabIndex = 7;
            label8.Text = "DNI:";
            // 
            // nombrepasajerotxt
            // 
            nombrepasajerotxt.Location = new Point(85, 30);
            nombrepasajerotxt.MaxLength = 50;
            nombrepasajerotxt.Name = "nombrepasajerotxt";
            nombrepasajerotxt.Size = new Size(180, 23);
            nombrepasajerotxt.TabIndex = 9;
            // 
            // apellidopasajerotxt
            // 
            apellidopasajerotxt.Location = new Point(82, 71);
            apellidopasajerotxt.MaxLength = 50;
            apellidopasajerotxt.Name = "apellidopasajerotxt";
            apellidopasajerotxt.Size = new Size(183, 23);
            apellidopasajerotxt.TabIndex = 10;
            // 
            // dnipasajerotxt
            // 
            dnipasajerotxt.Location = new Point(51, 110);
            dnipasajerotxt.Name = "dnipasajerotxt";
            dnipasajerotxt.Size = new Size(214, 23);
            dnipasajerotxt.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(9, 149);
            label10.Name = "label10";
            label10.Size = new Size(158, 19);
            label10.TabIndex = 22;
            label10.Text = "Fecha de Nacimiento:";
            // 
            // dtnacmiento
            // 
            dtnacmiento.Location = new Point(9, 181);
            dtnacmiento.Name = "dtnacmiento";
            dtnacmiento.Size = new Size(238, 23);
            dtnacmiento.TabIndex = 23;
            // 
            // grp_DatosPersonales
            // 
            grp_DatosPersonales.Controls.Add(label10);
            grp_DatosPersonales.Controls.Add(label1);
            grp_DatosPersonales.Controls.Add(label3);
            grp_DatosPersonales.Controls.Add(nombrepasajerotxt);
            grp_DatosPersonales.Controls.Add(dtnacmiento);
            grp_DatosPersonales.Controls.Add(apellidopasajerotxt);
            grp_DatosPersonales.Controls.Add(dnipasajerotxt);
            grp_DatosPersonales.Controls.Add(label8);
            grp_DatosPersonales.Location = new Point(12, 151);
            grp_DatosPersonales.Name = "grp_DatosPersonales";
            grp_DatosPersonales.Size = new Size(284, 231);
            grp_DatosPersonales.TabIndex = 26;
            grp_DatosPersonales.TabStop = false;
            grp_DatosPersonales.Text = "Datos Personales";
            // 
            // btn_Confirmar
            // 
            btn_Confirmar.BackColor = Color.Transparent;
            btn_Confirmar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_Confirmar.FlatStyle = FlatStyle.Flat;
            btn_Confirmar.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Confirmar.ForeColor = Color.Black;
            btn_Confirmar.Location = new Point(311, 388);
            btn_Confirmar.Name = "btn_Confirmar";
            btn_Confirmar.Size = new Size(391, 40);
            btn_Confirmar.TabIndex = 4;
            btn_Confirmar.Text = "Confirmar";
            btn_Confirmar.UseVisualStyleBackColor = false;
            btn_Confirmar.Click += confirmpasajerobtn_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.Transparent;
            btn_Cancelar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Cancelar.ForeColor = Color.Black;
            btn_Cancelar.Location = new Point(12, 388);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(284, 40);
            btn_Cancelar.TabIndex = 28;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += cancelpasajbtn_Click;
            // 
            // grp_DatosContato
            // 
            grp_DatosContato.Controls.Add(lv_ListadoProductos);
            grp_DatosContato.Location = new Point(311, 151);
            grp_DatosContato.Name = "grp_DatosContato";
            grp_DatosContato.Size = new Size(391, 231);
            grp_DatosContato.TabIndex = 27;
            grp_DatosContato.TabStop = false;
            grp_DatosContato.Text = "Asignar a...";
            // 
            // lv_ListadoProductos
            // 
            lv_ListadoProductos.Columns.AddRange(new ColumnHeader[] { idproductoseleccionado, descripcionproducto });
            lv_ListadoProductos.FullRowSelect = true;
            lv_ListadoProductos.Location = new Point(5, 21);
            lv_ListadoProductos.Margin = new Padding(2, 1, 2, 1);
            lv_ListadoProductos.Name = "lv_ListadoProductos";
            lv_ListadoProductos.Size = new Size(381, 206);
            lv_ListadoProductos.TabIndex = 4;
            lv_ListadoProductos.UseCompatibleStateImageBehavior = false;
            lv_ListadoProductos.View = View.Details;
            // 
            // idproductoseleccionado
            // 
            idproductoseleccionado.Text = "Id";
            idproductoseleccionado.Width = 180;
            // 
            // descripcionproducto
            // 
            descripcionproducto.Text = "Descripcion del Producto";
            descripcionproducto.Width = 200;
            // 
            // IngresarPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(710, 439);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Confirmar);
            Controls.Add(grp_DatosContato);
            Controls.Add(grp_DatosPersonales);
            Controls.Add(label2);
            Margin = new Padding(6);
            Name = "IngresarPasajero";
            Text = "IngresarPasajero";
            Load += IngresarPasajero_Load;
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(grp_DatosPersonales, 0);
            Controls.SetChildIndex(grp_DatosContato, 0);
            Controls.SetChildIndex(btn_Confirmar, 0);
            Controls.SetChildIndex(btn_Cancelar, 0);
            grp_DatosPersonales.ResumeLayout(false);
            grp_DatosPersonales.PerformLayout();
            grp_DatosContato.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label8;
        private TextBox nombrepasajerotxt;
        private TextBox apellidopasajerotxt;
        private TextBox dnipasajerotxt;
        private Label label10;
        private DateTimePicker dtnacmiento;
        private GroupBox grp_DatosPersonales;
        private Common.Components.BotonEstilizado btn_Confirmar;
        private Common.Components.BotonEstilizado btn_Cancelar;
        private GroupBox grp_DatosContato;
        private ListView lv_ListadoProductos;
        private ColumnHeader idproductoseleccionado;
        private ColumnHeader descripcionproducto;
    }
}