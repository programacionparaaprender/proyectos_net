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
    public partial class Nuevo : Form
    {
        private List<Empleado> lista; 
        private List<Empleado> sel=new List<Empleado>(); 
        public Nuevo(List<Empleado> lista)
        {
            InitializeComponent();
            this.lista = lista;
            this.lbEstudiantes.DataSource = null;
            this.lbEstudiantes.DataSource = lista;
            this.lbEstudiantes.DisplayMember = "Nombre";
        }
        public void setLista(List<Empleado> lista)
        {
            this.lista = lista;
            this.lbEstudiantes.DataSource=null;
            this.lbEstudiantes.DataSource = lista;
            this.lbEstudiantes.DisplayMember = "Nombre";
        }

        private void btnAgregsr_Click(object sender, EventArgs e)
        {
            
            if(this.lbEstudiantes.SelectedIndex==-1)
            {
                return;
            }
             
            //this.lbSeleccionados.Items.Add(((Empleado)lbEstudiantes.SelectedItem).Nombre);
            Empleado emp = (Empleado) this.lbEstudiantes.SelectedItem;
            //this.lbSeleccionados.Items.Add(emp.Nombre);
            this.lista.Remove(emp);
            this.lbEstudiantes.DataSource = null;
            this.lbEstudiantes.DataSource = lista;
            this.lbEstudiantes.DisplayMember = "Nombre";

            this.sel.Add(emp);
            this.lbSeleccionados.DataSource = null;
            this.lbSeleccionados.DataSource = sel;
            this.lbSeleccionados.DisplayMember = "Nombre";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (this.lbSeleccionados.SelectedIndex == -1)
            {
                return;
            }
            
            Empleado emp = (Empleado)this.lbSeleccionados.SelectedItem;
            //this.lbSeleccionados.Items.Add(emp.Nombre);
            this.sel.Remove(emp);
            this.lbSeleccionados.DataSource = null;
            this.lbSeleccionados.DataSource = sel;
            this.lbSeleccionados.DisplayMember = "Nombre";

            this.lista.Add(emp);
            this.lbEstudiantes.DataSource = null;
            this.lbEstudiantes.DataSource = lista;
            this.lbEstudiantes.DisplayMember = "Nombre";
        }

        private void lbEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
