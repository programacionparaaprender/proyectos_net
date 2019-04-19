using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookList.Models;
using System.Text;
using System.Data.SqlClient;
//using System.Windows.Forms;
using System.Data;
//using System.Xml.Serialization.IXmlSerializable;
using System.Collections;
using System.Configuration;

//using System.Web.Mvc.ViewDataDictionary;

namespace BookList.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Conexion conexion = new Conexion();
            
            System.Data.Datatable dt = new System.Data.Datatable();
            //dt = conexion.MostrarEstructuraAdapter();
            String cadena = @"Data Source=BONE\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True";
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                
                string strCadSQL = "SELECT * FROM dbo.usuarios";
                SqlDataAdapter dataadapter = new SqlDataAdapter(strCadSQL, conexion);
                dataadapter.Fill(dt);
                conexion.Close();
            }
            catch (Exception e)
            {
                throw e;//Console.WriteLine(e.ToString());
            }
            
            viewData["Tabla"] = dt;
            return View();
        }
        /* 
        public IActionResult About(){
            viewData["Message"] = "Your application description";
            return view();
        }
        */
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
