using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IgualCadena
{
    public class PrincipalMain
    {
        public static void Main(string[] args)
        {
            try
            {
                string cadena1 = "Josee Antonio";
                string cadena2 = "Josee Antonio";
                Console.WriteLine(Object.ReferenceEquals(cadena1, cadena2));
                Console.WriteLine( ((object) cadena1) == ((object) cadena2));
                Console.WriteLine(cadena1==cadena2);
            }
            catch(Exception exc)
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
