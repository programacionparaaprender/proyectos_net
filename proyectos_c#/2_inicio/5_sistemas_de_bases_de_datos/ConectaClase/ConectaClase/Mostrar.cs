using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace ConectaClase
{
    public partial class Mostrar : Form
    {
        public Mostrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                SqlConnection conexion = new SqlConnection("Data Source=SNAV-21;Initial Catalog=ClaseTaller;Integrated Security=True");
                try
                {
                    conexion.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error al intentar establecer la conexion" + ex.Message);
                    conexion.Close();
                    return;
                }
                try
                {
                    SqlCommand cmd = new SqlCommand("spObtenerEmpleados",conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds=new DataSet();
                    da.Fill(ds, "Empleado");
                    this.dgvEmpleado.DataSource = ds.Tables["Empleado"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error al intentar ingresar datos" + ex.Message);
                }
                conexion.Close();
            }

        }
    }
}
