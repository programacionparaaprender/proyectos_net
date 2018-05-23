using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsoFixed
{
    class CopiaInsegura
    {
        public unsafe static void Main(string[] args)
        {
            int[] tOrigen = new int[100];
            int[] tDestino = new int[100];

            for (int i = 0; i < 100; i++)
                tDestino[i] = i;

            fixed (int* pOrigen = tOrigen, pDestino = tDestino)
            {
                for (int i = 0; i < 100; i++)
                    pOrigen[i] = pDestino[i];

                for (int i = 0; i < 100; i++)
                    Console.WriteLine(pOrigen[i]);
            }
            Console.ReadKey(true);
        }
    }
}
