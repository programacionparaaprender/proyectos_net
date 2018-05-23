using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TallerBaseDatos{
    public partial class Ventana : Form{
        public Ventana(){
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DateTime hoy=DateTime.Now;
            DateTime fechaN = DateTime.Parse(this.tFecha.Text);
            int edad = hoy.Year - fechaN.Year;
            if (hoy < fechaN.AddYears(edad))
            {
                edad--;
            }
            MessageBox.Show("Nombre: "+this.tNombre.Text+"\nApellido: "
                +this.tApellido.Text+"\nCedula: "+this.tCedula.Text
                +"\nFecha de nacimiento: "+this.tFecha.Text
                +"\nEdad: "+edad);
        }
    }
}
