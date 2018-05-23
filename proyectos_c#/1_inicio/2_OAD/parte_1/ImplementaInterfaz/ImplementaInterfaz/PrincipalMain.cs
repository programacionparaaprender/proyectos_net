using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImplementaInterfaz
{
    interface I
    {
        object Clone();
    }
    public class PrincipalMain:I
    {
        public object Clone()
        {
            Console.WriteLine("Implementación implícita");
            return new object();
        }
        object I.Clone() //no se puede poner public
        {
            Console.WriteLine("Implementación explícita");
            return new object();
        }
        public static void Main(string[] args)
        {
            try
            {
                PrincipalMain obj = new PrincipalMain();
                ((I)obj).Clone();
                obj.Clone();
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
