using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegadosCsharp
{
    public delegate void D();

    public class ComprobaciónDelegados
    {
        public static void Main(string[] args)
        {
            try
            {
                Type t = typeof(ComprobaciónDelegados);
                MethodInfo m = t.GetMethod("Metodo1");
                D obj = (D)Delegate.CreateDelegate(typeof(D), m);
                obj();
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
        public static void Metodo1()
        { 
            Console.WriteLine("Ejecutado Metodo1"); 
        }
        public static void Metodo2(string s)
        { 
            Console.WriteLine("Ejecutado Metodo2"); 
        }
    }
 
}
