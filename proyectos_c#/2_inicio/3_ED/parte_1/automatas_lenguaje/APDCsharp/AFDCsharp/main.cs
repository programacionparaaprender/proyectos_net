using System;

namespace AFDCsharp
{
    public class Principal
    {

        private static int menu()
        {
            int opcion = 0;

            try
            {
                Console.WriteLine(
                    "programa automata de pila deterministico");
                Console.WriteLine(
                    "1->ingresar un estado del automata");
                Console.WriteLine(
                    "2->establecer estado inicial y final");
                Console.WriteLine(
                    "3->establecer enlaces entre los estados");
                Console.WriteLine(
                    "4->mostrar automata de pila determinista");
                Console.WriteLine(
                    "5->salir");
                opcion = int.Parse(Console.ReadLine());
            }

            //La cláusula catch se puede utilizar sin argumentos, en cuyo caso captura cualquier tipo de excepción y se conoce como cláusula catch general. También puede aceptar un argumento de objeto derivado de System.Exception, en cuyo caso trata una excepción específica. Por ejemplo:
            //buscar la excepcion
            catch (InvalidCastException es) 
            {
                Console.WriteLine("error "+es);
                return menu();
            }
            return opcion;
        }

        public static void Main(string[] args)
        {
            int opcion = 0;
            Grafo Grafo1 = new Grafo();
            do
            {
                opcion = menu();
                if (opcion == 1)
                    Grafo1.crearEstado();
                else if (opcion == 2)
                    Grafo1.establecerIF();
                else if (opcion == 3)
                    Grafo1.enlazarEstados();
                //else if (opcion == 4)
                //    Grafo1.mostrarEstados();
                Console.ReadKey(true);
            } while (opcion != 5);
        }
    }
}