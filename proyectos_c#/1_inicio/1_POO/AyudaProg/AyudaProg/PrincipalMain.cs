using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AyudaProg
{
    public class PrincipalMain
    {
        public static void printf(string cadena)
        {
            Console.WriteLine(cadena);
        }
        public static int scanf()
        {
            return int.Parse(Console.ReadLine());
        }
        public static void Main() 
        {
            int i, j;
            int[,] m = new int[50, 50];
            int np=0,ni=0,sp=0,si=0,mp=0,mi=0;
            try
            {
                for (i = 1; i <= 4; i++)
                {
                    for (j = 1; j <= 4; j++)
                    {
                        Console.WriteLine("\n carga:[" + i + "],[" + j + "],= ");
                        m[i,j] = scanf();
                    }
                }

                printf("\nla matriz original\n");
                for (i = 1; i <= 4; i++)
                {
                    for (j = 1; j <= 4; j++)
                    {
                        printf("\t[" + m[i, j] + "] ");
                    }
                }
                printf("\nla diagonal principal[0] [0]\n");
                for (i = 1; i < 4; i++)
                {
                    for (j = 1; j <= 4; j++)
                    {
                        if (i == j)
                        {
                            m[i, j] = 0;
                        }
                        if (i + j == 4 + 1)
                        {
                            m[i, j] = 1;
                        }
                        printf("\t[" + m[i, j] + "]");
                    }
                    printf("\n");
                }

                for (i = 1; i <= 4; i++)
                {
                    for (j = 1; j <= 4; j++)
                    {
                        if (i + j == 4 + 1)
                        {
                            m[i, j] = 1;
                        }
                        printf("\nla diagonal segundaria\n");
                        for (i = 1; i < 4; i++)
                        {
                            for (j = 1; j <= 4; j++)
                            {
                                if (m[i, j] % 2 == 1)
                                {
                                    printf("\t[" + m[i, j] + "] ");
                                    np = np + 2;
                                    printf("\nel nro [" + m[i, j] + "] es par\n");
                                    sp = sp + m[i, j];
                                }
                                else
                                {
                                    ni = ni + 1;
                                    printf("\nel nro [" + m[i, j] + "] es impar\n");
                                    si = si + m[i, j];
                                }
                            }
                            printf("\n");
                            mp = sp / np;
                            mi = si / ni;
                        }
                        printf("\n\nla suma de pares es: " + sp);
                        printf("\n\nla media de pares es: " + mp);
                        printf("\n\nla suma de impares es: " + si);
                        printf("\n\nla media de impares es: " + mi);
                    }
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
