using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsoSwitch
{
    public class PrincipalMain
    {
        public static void mostrar(string[] args)
        {
            try
            {
                if (args.Length > 0)
                    switch (args[0])
                    {
                        case "Jose":
                            Console.WriteLine("Hola José. Buenos días");
                            break;
                        case "Paco":
                            Console.WriteLine("Hola Paco. Me alegro de verte");
                            break;
                        default:
                            Console.WriteLine("Hola {0}", args[0]);
                            break;
                    }
                else
                    Console.WriteLine("Hola Mundo");
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
            finally
            {
                Console.ReadKey(true);
            }
        }

        public static void Main(string[] args)
        {
            string[] cadena = {"Jose","Paco"};
            mostrar(cadena);
        }
    }
}
