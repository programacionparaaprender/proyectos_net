using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsoWhile
{
    public class PrincipalMain
    {
        public static void mostrar(string[] args)
        {
            int actual = 0;
            if (args.Length > 0)
                while (actual < args.Length)
                    Console.WriteLine("¡Hola {0}!", args[actual++]);
            else
                Console.WriteLine("¡Hola mundo!");
        }
        public static void Main(string[] args)
        {
            string[] cadena = {"Jose","Paco"};
            mostrar(cadena);
            Console.ReadKey(true);
        }
    }
}