using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Services.Client;
using System.Data;
using System.Data.Services;
using System.Data.SqlClient;
namespace VacioBiblioteca
{
    class PrincipalMain
    {
        private string cadenaConexion = "Data Source=LUISALBERTO-PC\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True";
        public static void Main(string[] args) {
            try{
                SqlConnection conexion=new SqlConnection(cadenaConexion);
                conexion.Open();
                conexion.Close();
            }
            catch(Exception){}
        }
    }
}
