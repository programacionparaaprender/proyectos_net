using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LenguajePOO
{
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Rectangulo mirec = new Rectangulo(double.Parse(this.tbaserec.Text), double.Parse(this.talturarec.Text));

                Triangulo tri = new Triangulo(double.Parse(this.tbasetri.Text), double.Parse(this.talturatri.Text));

                this.larearec.Text = "" + mirec.area();
             
                this.lareatri.Text = "" + tri.area();
            }
            catch (Exception)
            {
                MessageBox.Show("error", " ",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
