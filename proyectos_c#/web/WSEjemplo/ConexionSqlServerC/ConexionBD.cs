using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace ConexionSqlServerC
{
    class ConexionBD
    {
        string cadena = "Data Source=BONE\\SQLEXPRESS;Initial Catalog=TEST; Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();
        public ConexionBD()
        {
            conectarbd.ConnectionString = cadena;
        } 
        public void abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("Todo resulto bien");
                
            }catch(Exception ex)
            {
                Console.WriteLine("Error al abrir la base de datos");
            }finally
            {

            }
        }
        public void insertar()
        {
            
            string sql = @"INSERT into dbo.Products (ProductName, Price, ProductDescription)  
    VALUES (@ProductName, @Price, @ProductDescription)";
            SqlCommand cmd = new SqlCommand(sql, conectarbd);
            cmd.Parameters.AddWithValue("@ProductName", "Pollo");
            cmd.Parameters.AddWithValue("@Price", 50);
            cmd.Parameters.AddWithValue("@ProductDescription", "Comida");
            cmd.ExecuteNonQuery();
        }
        public void consultar()
        {
            string sql = "select * from dbo.Products";
            SqlCommand cmd = new SqlCommand(sql, conectarbd);
            //cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr["ProductName"] + " " + dr["Price"] + " " + dr["ProductDescription"]);
            }
        }
        public void insertar2()
        {
            SqlCommand cmd = new SqlCommand(string.Format("INSERT into dbo.Products (ProductID, ProductName, Price, ProductDescription) VALUES('{0}', '{1}', '{2}')", "Pollo", 50, "Comida"), conectarbd);
            cmd.ExecuteNonQuery();
        }
        public void cerrar()
        {
            conectarbd.Close();
        }
    }
}
