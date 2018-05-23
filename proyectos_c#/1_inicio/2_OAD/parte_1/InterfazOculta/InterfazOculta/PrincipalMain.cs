using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfazOculta
{
    interface IA
    {
        void F();
    }
    class C1 : IA
    {
        public void F()// aquí no aculta
        {
            Console.WriteLine("El F() de C1");
        }
    }
    class PrincipalMain : C1, IA
    {
        void IA.F() // Sin implementación explícita no redefiniría, sino ocultaría
        {
            Console.WriteLine("El F() de PrincipalMain");
        }
        public static void Main(string[] args)
        {
            try
            {
                IA obj = new C1();
                IA obj2 = new PrincipalMain();
                obj.F();
                obj2.F();
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