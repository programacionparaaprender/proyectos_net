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
    public partial class Form1 : Form
    {
        public List<Empleado> lista=new List<Empleado>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeerD_Click(object sender, EventArgs e)
        {
            FrmLeerD f = new FrmLeerD();
            f.ShowDialog(this);
            lista.Add(f.retorno);
        } 
        private void button2_Click(object sender, EventArgs e)
        {
            FrmVerDatosEmp mostrar = new FrmVerDatosEmp(); 
            mostrar.Visible = true;
            mostrar.cbxLista.DataSource = lista;
            mostrar.empleados = lista;
            mostrar.cbxLista.DisplayMember = "Cedula";
            /*
            foreach (var a in lista)
            {
                mostrar.cbxLista.DataSource=
                mostrar.cbxLista.Text = a.toString();
                MessageBox.Show(a.toString());
            }
                */
            //mostrar.ShowDialog(this);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo ese=new Nuevo(lista);
            ese.ShowDialog(this);
            //ese.setLista(lista);
        }
    }
}
