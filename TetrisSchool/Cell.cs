using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Cell : UserControl
    {
        public int reihe { get; set; }
        public int spalte { get; set; }

        public Cell(int reihe, int spalte)
        {
            InitializeComponent();
            this.Name = reihe.ToString() + ", " + spalte.ToString();
            this.reihe = reihe;
            this.spalte = spalte;
        }
        
        public int cellColor
        {
            set
            {
                this.BackColor = Color.FromArgb(value);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, 1, ButtonBorderStyle.Inset
                , Color.Black, 1, ButtonBorderStyle.Inset
                , Color.Black, 1, ButtonBorderStyle.Inset
                ,Color.Black, 1, ButtonBorderStyle.Inset);
        }
    }
}
