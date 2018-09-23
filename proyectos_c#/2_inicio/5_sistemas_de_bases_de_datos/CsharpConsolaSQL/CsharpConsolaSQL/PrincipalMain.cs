using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
//using System.Xml.Serialization.IXmlSerializable;
using System.Collections;
using System.Diagnostics;
using System.Configuration;
/*Error	1	El tipo 'System.Xml.Serialization.IXmlSerializable' 
está definido en un ensamblado al que no se hace referencia. 
 * Debe agregar una referencia al ensamblado 'System.Xml, Version=4.0.0.0, 
 * Culture=neutral, PublicKeyToken=b77a5c561934e089'.	
 * c:\users\luis alberto\documents\visual studio 2010\Projects\CsharpConsolaSQL\CsharpConsolaSQL\PrincipalMain.cs	15	24	CsharpConsolaSQL
*/
namespace CsharpConsolaSQL
{
    public class PrincipalMain
    {
        static String cadena1 = @"Data Source=LUISALBERTO-PC\SQLEXPRESS;Initial Catalog=ClaseTaller;Integrated Security=True";
        static String cadena2 = @"Data Source=LUISALBERTO-PC\SQLEXPRESS;Initial Catalog=ClaseTaller;User ID=LuisCorrea; Password=yose1342";
        static String cadena = @"Data Source=BONE\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True";
        /*static String cadenaConexion = ConfigurationManager.ConnectionStrings("CadenaConexion").ConnectionString();*/
        public static void eliminar()
        {
            try
            {
                String nombre = "Electronica";
                String telefono = "02812344561";
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                SqlCommand consulta = new SqlCommand(@"DELETE Departamento WHERE Nombre=@Nombre AND Telefono=@Telefono", conexion);
                consulta.Parameters.AddWithValue("@Nombre",nombre);
                consulta.Parameters.AddWithValue("@Telefono", telefono);
                consulta.ExecuteNonQuery();
                conexion.Close();
            }
            catch (ArgumentNullException)
            {
            }
        }
        public static void MostrarEstructura2()
        {
            String cadenaConexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                SqlDataReader myReader = null;
                String strCadSQL = @"SELECT * FROM Departamento";
                SqlCommand myCommand = new SqlCommand(strCadSQL, conexion);
                myReader = myCommand.ExecuteReader();
                Console.WriteLine("Datos de tabla");
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
        public static void MostrarEstructura()
        {
            //String cad = @"Data Source=BONE\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True";
            String cadenaConexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;

            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                SqlDataReader myReader = null;
                String strCadSQL = @"SELECT * FROM dbo.usuarios";
                SqlCommand myCommand = new SqlCommand(strCadSQL, conexion);
                myReader = myCommand.ExecuteReader();
                Console.WriteLine("Datos de tabla");
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
        public static void MostrarEstructura3()
        { 
             try
             {
                SqlConnection conexion = new SqlConnection(cadena);
                 //string consultaselect = @"SELECT * FROM Estudiante WHERE idEstudiante = 5";
                 //abrir la conexion
                conexion.Open();
                //Formar la sentencia SQL, un SELECT en este caso
                SqlDataReader myReader = null;
                //String strCadSQL = "SELECT * FROM animales";
                //String strCadSQL = "USE Escuela";
                String strCadSQL = @"SELECT * FROM Departamento";
                 SqlCommand myCommand = new SqlCommand(strCadSQL, conexion);
                //Ejecutar el comando SQL

                myReader = myCommand.ExecuteReader();
                //Imprimir un encabezado para mostrar una tabla de resultados

                Console.WriteLine("Datos de tabla");

                //Mostrar los datos de la tabla
                
                while (myReader.Read())
                {
                    Console.WriteLine(myReader.GetString(1)+" "+myReader.GetString(2));
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
        public static void Main()
        {
            //insertar();
            MostrarEstructura();
            //eliminar();
            //MostrarEstructura();
            Console.ReadKey(true);
        }

    }
}
