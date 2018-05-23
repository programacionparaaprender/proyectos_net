using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FibonacciIteRec
{
    class PrincipalMain
    {
        private static long fibonacci(long i)
        {
            long j=1,k=1,l;
            long resultado = 0;
            if(i<=1L)
                return 1L;
            for(l=1L;l<i;l++)
            {
                resultado=j+k;
                j=k;
                k=resultado;
            }
            return resultado;
        }
        /* fin función fibonacci ITERATIVO */
        public static void Main()
        {
            try
            {
                long i;
                for (i = 0L; i < 1000L; i++)
                    fibonacci(20L);
                Console.WriteLine("nro " + fibonacci(20L));
                Console.WriteLine("nro " + fibonacci(4));
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
            finally
            {
                Console.ReadKey(true);
            }
        }/* fin de testeador de la función fibonacci ITERATIVO*/
    }
}
