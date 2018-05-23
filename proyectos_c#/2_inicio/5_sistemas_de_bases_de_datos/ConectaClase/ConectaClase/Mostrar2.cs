using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ConectaClase
{
    public partial class Mostrar2 : Form
    {
        public Mostrar2()
        {
            InitializeComponent();
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.StringConexion);
            try
            {
                conexion.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("erro al abrir el archivo");
                conexion.Close();
                return;
            }
            DataSet ds=new DataSet();
            try
            {
                SqlCommand cond = new SqlCommand("spObtenerEmpleados",conexion);
                cond.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da=new SqlDataAdapter(cond);
                da.Fill(ds, "Empleado");
            }
            catch(Exception)
            {
                MessageBox.Show("Error al intentar leer los datos de empleado");
                conexion.Close();
                return;
            }
            cbxEmpleados.DataSource = ds.Tables["Empleado"];
            cbxEmpleados.DisplayMember = "Nombre";
            cbxEmpleados.ValueMember = "idEmpleado";
            conexion.Close();
            
        }

        private void cbxEmpleados_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.StringConexion);
            try
            {
                conexion.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("erro al abrir el archivo");
                conexion.Close();
                return;
            }
            DataSet ds=new DataSet();
            try
            {
                //ES UN NUEVO spObtenerEmpleado
                SqlCommand cmd = new SqlCommand("spObtenerEmpleado", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idEmpleado",SqlDbType.Int).Value=Int32.Parse(cbxEmpleados.SelectedValue.ToString());
                SqlDataAdapter da=new SqlDataAdapter(cmd);
                //da.Fill(ds, "DatoEmpleado");
                da.Fill(ds, "Empleado");
            }
            catch(Exception)
            {
                MessageBox.Show("error");
                conexion.Close();
                return;
            }
            DataRow r = ds.Tables["Empleado"].Rows[0];
            DataTable t = ds.Tables[0];
            /*
             * foreach(DataRow in t.Rows){
             * 
             * }
             * foreach(DataRows r in  ds.Tables[0].Rows){
             * 
             * }
             */
            if(t.Rows.Count>0)
            {
                this.textBox1.Text = r[0].ToString();
                this.textBox2.Text = r["Nombre"].ToString();
                this.textBox3.Text = r["Apellido"].ToString();
                //this.textBox4.Text = r["Cedula"].ToString();
                //this.textBox5.Text = r["FechaNac"].ToString();
                this.textBox6.Text = r["Salario"].ToString();

            }
            conexion.Close();
        }
    }
}
