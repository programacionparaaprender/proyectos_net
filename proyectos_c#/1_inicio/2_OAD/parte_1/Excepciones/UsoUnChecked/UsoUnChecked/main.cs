// statements_unchecked.cs
using System;

/*
 Este ejemplo muestra cómo utilizar la instrucción unchecked, 
 * utilizando unchecked con expresiones constantes.
 */

public class TestClass
{
    const int x = 2147483647;   // Max int 
    const int y = 2;

    public static void Main(string[] args)
    {
        int z;
        unchecked
        {
            z = x * y;
        }
        Console.WriteLine("Unchecked output value: {0}", z);
        Console.ReadKey(true);
    }
}