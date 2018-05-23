using System;

namespace AFDCsharp
{
    public class Principal
    {
        private static int input()
        {
            return int.Parse(Console.ReadLine());
        }

        private static string raw_input(string cadena)
        {
            Console.WriteLine(cadena);
            return Console.ReadLine();
        }

        private static int menu()
        {
            int op = 0;

            Console.WriteLine("Automata finito deterministico");
            Console.WriteLine("1->Crear estados");
            Console.WriteLine("2->estado inicial y final");
            Console.WriteLine("3->Enlazar estados");
            Console.WriteLine("4->Evaluar una cadena");
            Console.WriteLine("5->Mostrar automata");
            Console.WriteLine("6->Salir");
            op = input();
            return op;
        }

        public static void Main()
        {
            Grafo Grafo1 = new Grafo();
            int opcion = 0;
            while (opcion != 6)
            {
                opcion = menu();
                if (opcion == 1)
                    Grafo1.crearVertice();

                else if (opcion == 2)
                    Grafo1.estados();

                else if (opcion == 3)
                    Grafo1.enlazarVertices();
                else if (opcion == 4)
                    Grafo1.expresionRegular(raw_input("ingrese expresion regular a leer"));
                else if (opcion == 5)
                    Grafo1.Mostrar();
            }
        }
    }
}