using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PintarPantalla
{
    public partial class Pantalla : Form
    {
        public Pantalla()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /*
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphicsObj;

            graphicsObj = this.CreateGraphics();

            Pen myPen = new Pen(System.Drawing.Color.Red, 5);

            graphicsObj.DrawLine(myPen, 20, 20, 200, 210);
        }
         */
       private void Form1_Paint(object sender, PaintEventArgs e)
       {
           Graphics g = this.CreateGraphics();

           Pen myPen = new Pen(System.Drawing.Color.Red, 15);// grueso del color

           Rectangle myRectangle = new Rectangle(20, 20, 250, 200);

           //Point s = new Point(0,0);

           g.DrawRectangle(myPen, myRectangle);
           g.DrawEllipse(myPen, myRectangle);
       }
    }
}
