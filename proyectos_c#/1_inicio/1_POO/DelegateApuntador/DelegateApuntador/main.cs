
using System;

namespace Devjoker.Ejemplos
{
    delegate int myDelegate(int arg);

    class MainClass
    {
        public static void Main(string[] args)
        {
            MainClass instancia = new MainClass();
            int numero = 5;
            myDelegate variableDelegado;
            variableDelegado =
            new myDelegate(instancia.delegateFunction1);
            int a = variableDelegado(numero);

            Console.WriteLine("El resultado obtenido es ... {0}", a);
            Console.WriteLine("El resultado obtenido es ... {0}", numero);
            
            Console.ReadKey(true);
        }

        private int delegateFunction1(int a)
        {
            Console.WriteLine("Ejecutando ... delegateFuntion1");
            return ++a;
        }

        private int delegateFunction2(int a)
        {
            Console.WriteLine("Ejecutando ... delegateFuntion2");
            return a;
        }

    }

}