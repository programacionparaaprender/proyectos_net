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
    public partial class FrmVerDatosEmp : Form
    {
        public List<Empleado> empleados; 
        public FrmVerDatosEmp()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void cbxLista_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbxLista_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string cedulaSel = ((Empleado) this.cbxLista.SelectedItem).Cedula;
            //
            Empleado empSel = empleados.Find(delegate(Empleado _emp)
                                                 {
                                                     if (_emp.Cedula==cedulaSel)
                                                     {

                                                         return true;
                                                     }
                                                     return false;
                                                 });
            this.lNombre.Text = empSel.Nombre;
            this.lbSeleccionados.Items.Add(empSel.toString());
        }
    }
}
