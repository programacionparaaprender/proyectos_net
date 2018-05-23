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
namespace CsharpSQL
{
    public partial class frmMostrar : Form
    {
        public frmMostrar()
        {
            InitializeComponent();
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {

        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=LUISALBERTO-PC\SQLEXPRESS;Initial Catalog=ClaseTaller;User ID=LuisCorrea;Password=yose1342");
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
                SqlCommand cmd = new SqlCommand("spMostrarProfesor", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Profesor");
                this.dgvMostrar.DataSource = ds.Tables["Profesor"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al intentar ingresar datos" + ex.Message);
            }
            conexion.Close();
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=LUISALBERTO-PC\SQLEXPRESS;Initial Catalog=ClaseTaller;User ID=LuisCorrea;Password=yose1342");
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
                SqlCommand cmd = new SqlCommand("spMostrarEstudiante", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Estudiante");
                this.dgvMostrar.DataSource = ds.Tables["Estudiante"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al intentar ingresar datos" + ex.Message);
            }
            conexion.Close();
        }
    }
}
