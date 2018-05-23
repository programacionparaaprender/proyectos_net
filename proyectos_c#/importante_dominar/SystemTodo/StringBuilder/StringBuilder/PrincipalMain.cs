using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StringBuilder
{
    public class PrincipalMain
    {
        public static void Main(string[] args)
        {
            try
            {
                StringBuilder cadena = new StringBuilder("Pelas");
                String cadenaInmutable;
                cadena[0] = 'V';
                Console.WriteLine(cadena); // Muestra Velas 
                cadenaInmutable = cadena.ToString();
                Console.WriteLine(cadenaInmutable); // Muestra Velas
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
            finally
            {
                Console.ReadKey(true);
            }
        }
    }
}
