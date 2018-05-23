using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TallerClass2
{
    public partial class FrmLeerD : Form
    {
        public Empleado e;
        public FrmLeerD()
        {
            InitializeComponent();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.e=new Empleado(this.tNombre.Text,this.tApellido.Text,
                this.tCedula.Text,this.tFecha.Text);
            //this.Visible=false;
            this.Dispose(true);
            //this.Close();
        }
        public Empleado retorno
        {
            set { this.e = value; }
            get { return this.e; }
        }
    }
}
