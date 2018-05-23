
using System;

public class EjemploCadena
{
    public static void Main(string[] args)
    {
        string s1 = "Una cadena";
        string s2 = s1;
        Console.WriteLine("Cadena 1: {0}", s1); //Imprime "Una cadena"
        Console.WriteLine("Cadena 2: {0}", s2); //Imprime "Una cadena"
        s1 = "Otra cadena";
        Console.WriteLine("Cadena 1: {0}", s1); //Imprime "Otra cadena"
        Console.WriteLine("Cadena 2: {0}", s2); //Imprime "Una cadena"
        Console.ReadKey(true);
    }
}