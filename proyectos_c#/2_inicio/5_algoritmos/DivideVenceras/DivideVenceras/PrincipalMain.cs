using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DivideVenceras
{
    public class PrincipalMain
    { 
        public static void Main()
        {
            string a = "981";
            string b = "1234";
            Console.WriteLine((int)('1'));
            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.reslizarCalculo(a, b));
            Console.WriteLine(calculadora.reslizarCalculo("26", "26"));
            Console.WriteLine(calculadora.reslizarCalculo("326", "326"));
            Console.ReadKey(true);
        }
    }
}
