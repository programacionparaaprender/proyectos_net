
using System;

sealed class Muestra
{
    private int numero;

    public Muestra()
    {
 
    }
    public int input(string cadena)
    {
        Console.WriteLine(cadena);
        return int.Parse(Console.ReadLine());
    }
}

public class PrincipalMain
{
    public static void Main(string[] args)
    {
        Muestra muestra = new Muestra();
        Console.ReadKey(true);
 
    }
}