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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            nombrepasajerotxt = new TextBox();
            apellidopasajerotxt = new TextBox();
            dnipasajerotxt = new TextBox();
            emailpasajerotxt = new TextBox();
            telpasajerotxt = new TextBox();
            paiscbx = new ComboBox();
            exppasajerodgv = new DateTimePicker();
            nacpasajerocbx = new ComboBox();
            label10 = new Label();
            dtnacmiento = new DateTimePicker();
            label11 = new Label();
            cbxTipodoc = new ComboBox();
            grp_DatosPersonales = new GroupBox();
            grp_DatosContato = new GroupBox();
            btn_Confirmar = new Common.Components.BotonEstilizado();
            btn_Cancelar = new Common.Components.BotonEstilizado();
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
            label2.Size = new Size(452, 26);
            label2.TabIndex = 1;
            label2.Text = "Por favor ingrese los datos de los pasajeros";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 66);
            label4.Name = "label4";
            label4.Size = new Size(157, 19);
            label4.TabIndex = 3;
            label4.Text = "Teléfono de contacto:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(9, 28);
            label5.Name = "label5";
            label5.Size = new Size(56, 19);
            label5.TabIndex = 4;
            label5.Text = "E-Mail:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(280, 169);
            label6.Name = "label6";
            label6.Size = new Size(92, 19);
            label6.TabIndex = 5;
            label6.Text = "País Emisor:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(280, 110);
            label7.Name = "label7";
            label7.Size = new Size(149, 19);
            label7.TabIndex = 6;
            label7.Text = "Fecha de Expiración:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 169);
            label8.Name = "label8";
            label8.Size = new Size(198, 19);
            label8.TabIndex = 7;
            label8.Text = "DNI/Numero de Pasaporte:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(281, 80);
            label9.Name = "label9";
            label9.Size = new Size(105, 19);
            label9.TabIndex = 8;
            label9.Text = "Nacionalidad:";
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
            dnipasajerotxt.Location = new Point(6, 191);
            dnipasajerotxt.Name = "dnipasajerotxt";
            dnipasajerotxt.Size = new Size(259, 23);
            dnipasajerotxt.TabIndex = 12;
            // 
            // emailpasajerotxt
            // 
            emailpasajerotxt.Location = new Point(71, 28);
            emailpasajerotxt.Name = "emailpasajerotxt";
            emailpasajerotxt.Size = new Size(268, 23);
            emailpasajerotxt.TabIndex = 15;
            // 
            // telpasajerotxt
            // 
            telpasajerotxt.Location = new Point(172, 66);
            telpasajerotxt.Name = "telpasajerotxt";
            telpasajerotxt.Size = new Size(167, 23);
            telpasajerotxt.TabIndex = 16;
            // 
            // paiscbx
            // 
            paiscbx.DropDownStyle = ComboBoxStyle.DropDownList;
            paiscbx.FormattingEnabled = true;
            paiscbx.Items.AddRange(new object[] { "Argentina", "Bolivia", "Brasil", "Chile", "Colombia", "Paraguay", "Venezuela", "Uruguay" });
            paiscbx.Location = new Point(281, 191);
            paiscbx.Name = "paiscbx";
            paiscbx.Size = new Size(237, 23);
            paiscbx.TabIndex = 17;
            // 
            // exppasajerodgv
            // 
            exppasajerodgv.Location = new Point(280, 132);
            exppasajerodgv.Name = "exppasajerodgv";
            exppasajerodgv.Size = new Size(238, 23);
            exppasajerodgv.TabIndex = 18;
            // 
            // nacpasajerocbx
            // 
            nacpasajerocbx.DropDownStyle = ComboBoxStyle.DropDownList;
            nacpasajerocbx.FormattingEnabled = true;
            nacpasajerocbx.Items.AddRange(new object[] { "Argentina", "Bolivia", "Brasil", "Chile", "Colombia", "Paraguay", "Venezuela", "Uruguay" });
            nacpasajerocbx.Location = new Point(390, 78);
            nacpasajerocbx.Name = "nacpasajerocbx";
            nacpasajerocbx.Size = new Size(128, 23);
            nacpasajerocbx.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(281, 19);
            label10.Name = "label10";
            label10.Size = new Size(158, 19);
            label10.TabIndex = 22;
            label10.Text = "Fecha de Nacimiento:";
            label10.Click += label10_Click;
            // 
            // dtnacmiento
            // 
            dtnacmiento.Location = new Point(281, 45);
            dtnacmiento.Name = "dtnacmiento";
            dtnacmiento.Size = new Size(238, 23);
            dtnacmiento.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(6, 106);
            label11.Name = "label11";
            label11.Size = new Size(149, 19);
            label11.TabIndex = 24;
            label11.Text = "Tipo de Documento:";
            // 
            // cbxTipodoc
            // 
            cbxTipodoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipodoc.FormattingEnabled = true;
            cbxTipodoc.Items.AddRange(new object[] { "DNI" });
            cbxTipodoc.Location = new Point(6, 128);
            cbxTipodoc.Name = "cbxTipodoc";
            cbxTipodoc.Size = new Size(259, 23);
            cbxTipodoc.TabIndex = 25;
            cbxTipodoc.SelectedIndexChanged += cbxTipodoc_SelectedIndexChanged;
            // 
            // grp_DatosPersonales
            // 
            grp_DatosPersonales.Controls.Add(label10);
            grp_DatosPersonales.Controls.Add(label1);
            grp_DatosPersonales.Controls.Add(cbxTipodoc);
            grp_DatosPersonales.Controls.Add(label3);
            grp_DatosPersonales.Controls.Add(paiscbx);
            grp_DatosPersonales.Controls.Add(exppasajerodgv);
            grp_DatosPersonales.Controls.Add(label11);
            grp_DatosPersonales.Controls.Add(nombrepasajerotxt);
            grp_DatosPersonales.Controls.Add(label6);
            grp_DatosPersonales.Controls.Add(dtnacmiento);
            grp_DatosPersonales.Controls.Add(apellidopasajerotxt);
            grp_DatosPersonales.Controls.Add(label7);
            grp_DatosPersonales.Controls.Add(dnipasajerotxt);
            grp_DatosPersonales.Controls.Add(nacpasajerocbx);
            grp_DatosPersonales.Controls.Add(label8);
            grp_DatosPersonales.Controls.Add(label9);
            grp_DatosPersonales.Location = new Point(12, 151);
            grp_DatosPersonales.Name = "grp_DatosPersonales";
            grp_DatosPersonales.Size = new Size(525, 231);
            grp_DatosPersonales.TabIndex = 26;
            grp_DatosPersonales.TabStop = false;
            grp_DatosPersonales.Text = "Datos Personales";
            // 
            // grp_DatosContato
            // 
            grp_DatosContato.Controls.Add(label5);
            grp_DatosContato.Controls.Add(emailpasajerotxt);
            grp_DatosContato.Controls.Add(label4);
            grp_DatosContato.Controls.Add(telpasajerotxt);
            grp_DatosContato.Location = new Point(12, 404);
            grp_DatosContato.Name = "grp_DatosContato";
            grp_DatosContato.Size = new Size(361, 100);
            grp_DatosContato.TabIndex = 27;
            grp_DatosContato.TabStop = false;
            grp_DatosContato.Text = "Datos de Contacto";
            // 
            // btn_Confirmar
            // 
            btn_Confirmar.BackColor = Color.Transparent;
            btn_Confirmar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btn_Confirmar.FlatStyle = FlatStyle.Flat;
            btn_Confirmar.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Confirmar.ForeColor = Color.Black;
            btn_Confirmar.Location = new Point(379, 411);
            btn_Confirmar.Name = "btn_Confirmar";
            btn_Confirmar.Size = new Size(158, 40);
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
            btn_Cancelar.Location = new Point(379, 464);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(158, 40);
            btn_Cancelar.TabIndex = 28;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += cancelpasajbtn_Click;
            // 
            // IngresarPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(549, 516);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Confirmar);
            Controls.Add(grp_DatosContato);
            Controls.Add(grp_DatosPersonales);
            Controls.Add(label2);
            Margin = new Padding(6);
            Name = "IngresarPasajero";
            Text = "IngresarPasajero";
            Load += IngresarPasajero_Load_1;
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(grp_DatosPersonales, 0);
            Controls.SetChildIndex(grp_DatosContato, 0);
            Controls.SetChildIndex(btn_Confirmar, 0);
            Controls.SetChildIndex(btn_Cancelar, 0);
            grp_DatosPersonales.ResumeLayout(false);
            grp_DatosPersonales.PerformLayout();
            grp_DatosContato.ResumeLayout(false);
            grp_DatosContato.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox nombrepasajerotxt;
        private TextBox apellidopasajerotxt;
        private TextBox dnipasajerotxt;
        private TextBox emailpasajerotxt;
        private TextBox telpasajerotxt;
        private ComboBox paiscbx;
        private DateTimePicker exppasajerodgv;
        private ComboBox nacpasajerocbx;
        private Label label10;
        private DateTimePicker dtnacmiento;
        private Label label11;
        private ComboBox cbxTipodoc;
        private GroupBox grp_DatosPersonales;
        private GroupBox grp_DatosContato;
        private Common.Components.BotonEstilizado btn_Confirmar;
        private Common.Components.BotonEstilizado btn_Cancelar;
    }
}