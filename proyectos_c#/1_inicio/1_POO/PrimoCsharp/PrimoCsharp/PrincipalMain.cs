using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimoCsharp
{
    public class PrincipalMain
    {
        public static void Main(string[] args)
        {
            int num, c, res, nc = 0;
            Console.WriteLine("Introduce un número: "); 
            num = int.Parse(Console.ReadLine());

            for (c = 1; c <= num; c++)
            {
                res = num % c;
                if (res == 0)
                    nc++;
                if (nc > 2)
                    break;
            }
            if (nc == 2)
                Console.WriteLine("Es primo");
            else
                Console.WriteLine("No es primo");
            Console.ReadKey(true);
        }
    }
}
