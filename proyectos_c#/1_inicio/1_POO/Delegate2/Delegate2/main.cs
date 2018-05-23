
using System;

public class Program
{
    delegate void PunteroMetodoSumar(int A, int B);

    public static void MetodoSumar(int A, int B)
    {
        Console.WriteLine(A + B);
    }

    public static void Main(string[] args)
    {

        PunteroMetodoSumar Suma
             = new PunteroMetodoSumar(MetodoSumar);
       
        Suma(5, 4);
        Console.ReadLine();
    }
}