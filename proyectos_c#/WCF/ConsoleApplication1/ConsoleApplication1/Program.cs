using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = @"Data Source=BONE\SQLEXPRESS;Initial Catalog=TEST;User ID=sa;Password=123";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                //MessageBox.Show("Connection Open ! ");
                Mostrar();
                Console.ReadKey();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
        public static void eliminar()
        {
            try
            {
                string cadena = @"Data Source=BONE\SQLEXPRESS;Initial Catalog=TEST;User ID=sa;Password=123";
                String nombre = "Electronica";
                String telefono = "02812344561";
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                SqlCommand consulta = new SqlCommand(@"DELETE Departamento WHERE Nombre=@Nombre AND Telefono=@Telefono", conexion);
                consulta.Parameters.AddWithValue("@Nombre", nombre);
                consulta.Parameters.AddWithValue("@Telefono", telefono);
                consulta.ExecuteNonQuery();
                conexion.Close();
            }
            catch (ArgumentNullException)
            {
            }
        }
        public static void Mostrar()
        {
            try
            {
                string cadena = @"Data Source=BONE\SQLEXPRESS;Initial Catalog=TEST;User ID=sa;Password=123";

                SqlConnection conexion = new SqlConnection(cadena);
                //string consultaselect = @"SELECT * FROM Estudiante WHERE idEstudiante = 5";
                //abrir la conexion
                conexion.Open();
                //Formar la sentencia SQL, un SELECT en este caso
                SqlDataReader myReader = null;
                //String strCadSQL = "SELECT * FROM animales";
                //String strCadSQL = "USE Escuela";
                String strCadSQL = @"SELECT * FROM usuarios";
                SqlCommand myCommand = new SqlCommand(strCadSQL, conexion);
                //Ejecutar el comando SQL

                myReader = myCommand.ExecuteReader();
                //Imprimir un encabezado para mostrar una tabla de resultados

                Console.WriteLine("Datos de tabla");

                //Mostrar los datos de la tabla

                while (myReader.Read())
                {
                    Console.WriteLine(myReader.GetString(1) + " " + myReader.GetString(2));
                }
                Console.WriteLine("  ...OK. Operacion exitosa!");
                conexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private static void insertar()
        {
            string cadena = @"Data Source=BONE\SQLEXPRESS;Initial Catalog=TEST;User ID=sa;Password=123";
            String nombre = "Electronica";
            String telefono = "02812344561";
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                string consulta = @"INSERT INTO Departamento (Nombre,Telefono) Values(@Nombre,@Telefono)";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Telefono", telefono);
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
