using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ConectaClase
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=SNAV-21;Initial Catalog=ClaseTaller;Integrated Security=True");
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al intentar establecer la conexion"+ex.Message);
                conexion.Close();
                return;
            }
            try
            {
                SqlCommand cmd=new SqlCommand();
                cmd.CommandText = "INSERT INTO Empleado VALUES("
                +this.tbidEmpleado.Text+",'" 
                +this.tbNombre.Text+"','"
                +this.tbApellido.Text+"','"
                +this.tbDireccion.Text+"',"
                +this.tbSalario.Text+")";
                cmd.Connection = conexion;
                int r = cmd.ExecuteNonQuery();
                if(r>0)
                {
                    MessageBox.Show("Empleado agregado satisfactoriamente DATOS "+r);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al intentar ingresar datos"+ex.Message);
            }
            conexion.Close();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {

        }
    }
}
