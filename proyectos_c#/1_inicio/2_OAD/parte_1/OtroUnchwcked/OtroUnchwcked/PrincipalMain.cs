using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OtroUnchwcked
{
    class PrincipalMain
    {
        static short x = 32767; // Valor maximo del tipo short
        public static void Main(string[] args)
        {
            /*
            unchecked
            {
                Console.WriteLine((short)(x + 1)); // (1)
                Console.WriteLine((short)32768); // (2)
            }
            */
            Console.WriteLine((short)(x + 1)); // (1)
            //Console.WriteLine((short)32768); // (2)

            Console.ReadKey(true);
        }
    }
}
