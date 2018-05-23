using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PintarPoligono
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int lpoligono = 0;
            Point[] cs = new Point[3];
            int escala = 20;
            int multiplicadorx = 2;
            e.Graphics.DrawLine(
                new Pen(System.Drawing.Color.Black, 1),
                new Point(20, 20),
                new Point(20, 280));
            e.Graphics.DrawLine(
                new Pen(System.Drawing.Color.Black, 1),
                new Point(20, 280),
                new Point(380, 280));

            cs[lpoligono++] = new Point(20, 280);
            
            cs[lpoligono] =
                    new Point(
                        escala +
                        cs[lpoligono-1].X * multiplicadorx,
                        280);
            cs[++lpoligono] =
                    new Point(
                        escala +
                        cs[lpoligono - 1].X * multiplicadorx,
                        80);
            e.Graphics.FillPolygon(
                    new Pen(Color.Yellow).Brush,
                    cs
                    );

            e.Graphics.DrawPolygon(
                    new Pen(Color.Black),
                    cs
                    );
            
        }
    }
}
