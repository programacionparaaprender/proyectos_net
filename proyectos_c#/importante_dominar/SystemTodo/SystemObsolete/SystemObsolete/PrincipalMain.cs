using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemObsolete
{
    class PrincipalMain
    {
        [Obsolete("No usar f(), que está obsoleto.", true)]
        public static void f()
        {
        }
        public static void Main(string[] args)
        {
            try
            {
                f();
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
