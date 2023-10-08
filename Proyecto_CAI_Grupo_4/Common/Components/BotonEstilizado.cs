using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_CAI_Grupo_4.Common.Components
{
    public partial class BotonEstilizado : Button
    {
        private Color defaultColor = Color.Transparent;
        private Color hoverColor = Color.LightGray;
        private Color textColor = Color.Black;

        public BotonEstilizado()
        {
            InitializeComponent();

            this.BackColor = defaultColor;
            this.FlatAppearance.MouseOverBackColor = hoverColor;
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            this.ForeColor = textColor;
            this.Size = new Size(100, 40);
            this.TabIndex = 4;
            this.UseVisualStyleBackColor = false;
        }
    }
}



