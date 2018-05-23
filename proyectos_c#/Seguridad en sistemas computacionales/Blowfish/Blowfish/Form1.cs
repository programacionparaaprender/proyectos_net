using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blowfish
{
    public partial class Form1 : Form
    {
        private ClaseBlowfish b12=null;
        private string cipherText;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b12= new ClaseBlowfish("04B915BA43FEB5B6");
            string mensajebox = this.textBox1.Text;
            cipherText = b12.Encrypt_CBC(mensajebox);
            this.textBox3.Text = cipherText;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (b12 != null)
            {
                string textobox = b12.Decrypt_CBC(cipherText);
                this.textBox2.Text = textobox;
            }
            else {
                MessageBox.Show("Ingrese una nueva palabra");
            }
            b12 = null;
        }
    }
}
