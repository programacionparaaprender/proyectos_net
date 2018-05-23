using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unidimensional
{
    public class PrincipalMain
    {
        public static void Main(string[] args)
        {
            try
            {
                int[,] a = new int[20, 20];
                for (int i = 0; i < 20; i++)
                    for (int j = 0; j < 20; j++)
                        a[i, j] = j;

                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                        Console.Write(a[i, j] + "->");
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
