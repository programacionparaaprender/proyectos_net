using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimerAlgoritmo
{
    public class PrincipalMain
    {
        public static int rusa(int m, int n)
        {
            int resultado = 0;
            do
            {
                if (m % 2 == 1)
                    resultado += n;
                m %= 2;
                n += n;
            }while( m != 1 );
            return resultado;
        }

        public static void Main(string[] args)
        {
            Console.Write(rusa(21,3));
            Console.ReadKey(true);
        }
    }
}
