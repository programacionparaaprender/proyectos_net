using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomDimension
{
    class PrincipalMain
    {
        public static void Main(string[] args)
        {
            //int numero = objeto.Next(6);
            //generaría un número aleatorio entre 0 y 7 (pero no 6), 
            //es decir, seis posibles números. Pero, si desearamos 
            //algún rango más exacto, podríamos hacer algo como:
            //Random objeto = new Random();
            //int numero = objeto.Next(1, 20);
            try
            {
                Random objeto = new Random();
                
                int[] entero = { 1,2,3};
                int[,] tabla = { { 1, 2 }, { 3, 4, 5, 6 } };

                int[,] a = new int[20,20];
                for(int i = 0 ; i < 20 ; i++)
                    for(int j = 0 ; j < 20 ; j++)
                        a[i,j] = objeto.Next(1,20);
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                        Console.Write(a[i, j]+"->");
                    Console.WriteLine();
                }
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
    }
}
