using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsoStackalloc
{
    class PrincipalMain
    {
        public PrincipalMain()
        { 
        }
        public unsafe static void Main(string[] args)
        {
            
            int* pt = stackalloc int[100];

            for (int i = 0; i < 100; i++)
                pt[i] = i;

            for (int i = 0; i < 100; i++)
                System.Console.WriteLine(pt[i]);
            
            Console.ReadKey(true);
        }
    }
}
