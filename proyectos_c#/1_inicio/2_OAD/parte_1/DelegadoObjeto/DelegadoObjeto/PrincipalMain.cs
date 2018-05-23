using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegadoObjeto
{
    delegate void D(int valor);
        
    class PrincipalMain
    {
        public static void Main()
        {
            try
            {
                D objDelegado = new D(F);
                objDelegado(3);
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
        public static void F(int x)
        {
            Console.WriteLine( "Pasado valor {0} a F()");
        }
     
    }
}
