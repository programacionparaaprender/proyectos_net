using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcepcionZero
{
    public class PrincipalMain
    {
        public static void G()
        {
            int c;
            int d;
            try
            {
                c = 0;
                d = 2 / c;
            }
            catch (DivideByZeroException exc)
            {
                Console.WriteLine(exc);
                d = 0;
            }
            finally
            {
                Console.ReadKey(true);
            }
        }
        public static void Main(string[] args)
        {
            G();
        }
    }
}
