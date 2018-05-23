using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;


namespace SystemDiagnosticsConditional
{
    class Condicional
    {
        [Conditional("DEBUG")]
        public static void F()
        { 
            Console.WriteLine("Ff()"); 
        }
        public static void Main(string[] args)
        {
            F();
            Console.ReadKey(true);
        }
    }
}
