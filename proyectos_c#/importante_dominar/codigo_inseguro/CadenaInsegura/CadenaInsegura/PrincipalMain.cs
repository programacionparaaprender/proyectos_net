using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CadenaInsegura
{
    class CadenaInsegura
    {
        public unsafe static void Main(string[] args)
        {
            string s="Hola";
            Console.WriteLine("Cadena inicial: {0}", s);
            fixed ( char* ps = s )
            {
                for ( int i=0 ; i<s.Length ; i++ )
                    ps[i] = 'A';
            }
            Console.WriteLine("Cadena final: {0}", s);
            Console.ReadKey(true);
        }
    }
}
