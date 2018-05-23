using System;

namespace CalculadoraCsharp
{
    public class PrincipalMain
    {
        private static int input(string cadena)
        {
            Console.WriteLine(cadena);
            return int.Parse(Console.ReadLine());
        }
        private static int input()
        {
            return int.Parse(Console.ReadLine());
        }
        private static string raw_input(string cadena)
        {
            Console.WriteLine(cadena);
            return Console.ReadLine();
        }
        private static void print(string cadena)
        {
            Console.WriteLine(cadena);
        }
        private static int menu()
        {
            print("Calculadora C#");
            print("1->escriba cadena a calcular");
            print("2->ver la cadena");
            print("3->mostrar resultado");
            print("4->salir");
            return input();
        }
        public static void Main(string[] args)
        {
            string cadena="";
            int opcion;
            int s = '+';
            int r = '-';
            int m = '*';
            int d = '/';
            Console.WriteLine(s);
            Console.WriteLine(r);
            Console.WriteLine(m);
            Console.WriteLine(d);
            do
            {
                opcion = menu();
                if (opcion == 1)
                    cadena = raw_input("ingrese cadena a calcular");
                else if (opcion == 2)
                    print(cadena);
                else if (opcion == 3)
                    mostrar(cadena);

            }while(opcion!=4);
        }
        private static void mostrar(string cadena)
        {
            if (cadena.Length > 0)
            {
                Lista Lista1 = new Lista();

            }
            else
                print("no existe ninguna cadena");
 
        }
    }
}