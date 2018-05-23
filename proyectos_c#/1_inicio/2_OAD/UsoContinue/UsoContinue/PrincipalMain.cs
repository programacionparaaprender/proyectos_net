using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsoContinue
{
    public class PrincipalMain
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i < 9)
                    continue;
                
                Console.WriteLine(i);
            }
            Console.ReadKey(true);
        }
    }
}
