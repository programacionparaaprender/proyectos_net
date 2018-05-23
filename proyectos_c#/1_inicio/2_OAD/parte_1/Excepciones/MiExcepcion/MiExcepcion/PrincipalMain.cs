using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiExcepcion
{
    class MiException:Exception {}
    public class PrincipalMain
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("En el try de Main()");
                Método();
                Console.WriteLine("Al final del try de Main()");
            }
            catch (MiException)
            {
                Console.WriteLine("En el catch de Main()");
            }
            finally
            {
                Console.WriteLine("finally de Main()");
            }
        }
        public static void Método()
        {
            try
            {
                Console.WriteLine("En el try de Método()");
                Método2();
                Console.WriteLine("Al final del try de Método()");
            }
            //catch (OverflowException)
            catch (MiException)
            {
                Console.WriteLine("En el catch de Método()");
            }
            finally
            {
                Console.WriteLine("finally de Método()");
            }
        }
        public static void Método2()
        {
            try
            {
                Console.WriteLine("En el try de Método2()");
                throw new MiException();
                Console.WriteLine("Al final del try de Método2()");
            }
            catch (DivideByZeroException)
            { 
                Console.WriteLine("En el catch de Método2()"); 
            }
            finally
            { 
                Console.WriteLine("finally de Método2()");
                Console.ReadKey(true);
            }
        }
    }
}
