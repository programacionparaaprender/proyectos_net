using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;
using System.Configuration;
using System.Data.SqlClient;

namespace WebWCF1.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1 : IService1
    {
        public String DoWork()
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
                    return myReader.GetString(1) + " " + myReader.GetString(2);
                }
                Console.WriteLine("  ...OK. Operacion exitosa!");
                conexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return "Hello REST WCF Service :)";
        }
        public int DoSquare(int value)
        {
            return value * value;
        }
        public int DoAddValues(AddValues addValues)
        {
            return addValues.value1 + addValues.value2;
        }
    }

    [DataContract]
    public class AddValues
    {
        [DataMember]
        public int value1 { get; set; }
        [DataMember]
        public int value2 { get; set; }
        public AddValues()
        {
            value1 = 0;
            value2 = 0;
        }
    }
}
