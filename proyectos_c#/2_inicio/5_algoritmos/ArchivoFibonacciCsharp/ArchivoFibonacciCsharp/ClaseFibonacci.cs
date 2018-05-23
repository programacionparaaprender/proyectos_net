using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArchivoFibonacciCsharp
{
    class ClaseFibonacci
    {
        public ClaseFibonacci()
        {

        }
        public void siIterativo(int n)
        {
            int anterior = 0;
            int siguiente = 0;
            for (int i = 0; i < n; i++)
            {
                int temp;
                temp = siguiente;
                siguiente += anterior;
                anterior = temp;
                if (i < 1)
                {
                    ++i;
                    ++siguiente;
                }
            }
        }

        private long fibonacci(long numero)
        {
            if (numero == 0 || numero == 1)
            {
                return numero;
            }
            else
            {
                return fibonacci(numero - 1) + fibonacci(numero - 2);
            }

        }
        public void mostrarFibonacci(int j, int n)
        {
            if (j < n)
            {
                fibonacci(j);
                mostrarFibonacci(++j, n);
            }
        }
        public double[] veces(int[] valores)
        {
            double[] mas = new double[valores.Length];
            int elementos = 0;
            foreach(int i in valores)
            {
            DateTime tiempo1 = DateTime.Now;
            mostrarFibonacci(0, i);
            DateTime tiempo2 = DateTime.Now;
            mas[elementos++] = 
                new 
                    TimeSpan(tiempo2.Ticks - tiempo1.Ticks).TotalMilliseconds;
            }
            return mas;
        }
        public double[] veces1(int[] valores)
        {
            double[] mas = new double[valores.Length];
            int elementos = 0;
            foreach(int i in valores)
            {
                DateTime tiempo1 = DateTime.Now;
                siIterativo(i);
                DateTime tiempo2 = DateTime.Now;
                mas[elementos++] =
                new
                    TimeSpan(tiempo2.Ticks - tiempo1.Ticks).TotalMilliseconds;
            }
            return mas;
        }
    }
}
