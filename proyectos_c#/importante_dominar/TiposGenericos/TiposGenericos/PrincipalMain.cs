using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiposGenericos
{
    class ClaseGenerica<T>
    {
        // CS0693
        void metodoGenerico<T>(T variable) { }
    }

    class ClaseGenerica2<T>
    {
        //No warning
        void SampleMethod<U>() { }
    }

    public class PrincipalMain
    {
        public static void Main(string[] args)
        {
            ClaseGenerica<int> clase = new ClaseGenerica<int>();

            Console.ReadKey(true);
        }
    }
}
