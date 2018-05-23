using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Office=Microsoft.Office.Core;
using Word=Microsoft.Office.Interop.Word;
namespace ConectaClase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar forma=new Agregar();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Mostrar forma =new Mostrar();
            //forma.ShowDialog();
            Mostrar2 forma1=new Mostrar2();
            forma1.ShowDialog();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            object cMissing = System.Reflection.Missing.Value;
            object nombreArchivo = @"C:\Documents and Settings\Estudiante\Escritorio\ParaTaller\ConectaClase\Reporte Empleados.docx";
            Word.Application app = new Word.Application();
            Word.Document doc = new Word.Document();
            app.Visible = true;
            try
            {
                doc = app.Documents.Open(ref nombreArchivo, ref cMissing,ref cMissing
                    , ref cMissing, ref cMissing, ref cMissing, ref cMissing, ref cMissing
                    , ref cMissing, ref cMissing, ref cMissing, ref cMissing, ref cMissing
                    , ref cMissing, ref cMissing, ref cMissing);
            }
            catch(Exception)
            {
                MessageBox.Show("error");
                return;
            }
            object marcadorReporte = "marcadorEmpleados";
            Word.Range sRange = doc.Bookmarks.get_Item(ref marcadorReporte).Range;
            Word.Table tEmpleado;
            object db = Word.WdDefaultTableBehavior.wdWord9TableBehavior;
            object df = Word.WdAutoFitBehavior.wdAutoFitContent;

            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.StringConexion);
            DataSet ds=new DataSet();
            try
            {
                conexion.Open();
                SqlCommand cmd=new SqlCommand("SELECT idEmpleado,Nombre,Apellido,Salario FROM Empleado",conexion);
                SqlDataAdapter da=new SqlDataAdapter(cmd);
                da.Fill(ds,"Empleado");
            }
            catch (Exception)
            {
                MessageBox.Show("error");
                conexion.Close();
                return;
            }
            tEmpleado = doc.Tables.Add(sRange, ds.Tables[0].Rows.Count + 1, 4, ref db, ref df);
            tEmpleado.Cell(1, 1).Range.Text = "idEmpleado";
            tEmpleado.Cell(1, 2).Range.Text = "Nombre";
            tEmpleado.Cell(1, 3).Range.Text = "Apellido";
            tEmpleado.Cell(1, 4).Range.Text = "Salario";
            int i = 2;
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                tEmpleado.Cell(i, 1).Range.Text = r[0].ToString();
                tEmpleado.Cell(i, 2).Range.Text = r[1].ToString();
                tEmpleado.Cell(i, 3).Range.Text = r[2].ToString();
                tEmpleado.Cell(i, 4).Range.Text = r[3].ToString();
                i++;
            }
            conexion.Close();
        }
    }
}
