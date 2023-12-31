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
        private Color defaultColor = Color.Transparent; //Color.FromArgb(255, 248, 245, 242); // Color.FromArgb(1, 248, 245, 242);
        private Color hoverColor = Color.LightGray; //Color.FromArgb(255, 240, 238, 229);
        private Color textColor = Color.Black; //Color.FromArgb(255, 95, 42, 167);

        public BotonEstilizado()
        {
            InitializeComponent();

            BackColor = defaultColor;
            FlatAppearance.MouseOverBackColor = hoverColor;
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = textColor;
            Size = new Size(100, 40);
            TabIndex = 4;
            UseVisualStyleBackColor = false;
            Cursor = Cursors.Hand;
        }
    }
}



