
using System;

public struct Complejo
{
    public int real;
    public int imaginaria;
    public Complejo(int real, int imaginaria)
    {
        this.real = real;
        this.imaginaria = imaginaria;
    }

    // Declarar el operador de sobrecarga (+), los tipos
    // que se pueden agregar (dos objetos Complejo), y el
    // tipo de valor devuelto (Complejo):
    public static Complejo operator +(Complejo c1, Complejo c2)
    {
        return new Complejo(c1.real + c2.real, c1.imaginaria + c2.imaginaria);
    }

    // Reemplazar el método ToString para mostrar adecuadamente número complejo
    public override string ToString()
    {
        return (String.Format("{0} + {1}i", real, imaginaria));
    }
    public static void Main()
    {
        Complejo num1 = new Complejo(2, 3);
        Complejo num2 = new Complejo(3, 4);
        // Agregar dos objetos Complejo (num1 y num2) mediante el operador más sobrecargado
        Complejo sum = num1 + num2;
        // Imprimir los números y la suma usando el método reemplazado ToString:
        Console.WriteLine("Primer número complejo: {0}", num1);
        Console.WriteLine("Segundo número complejo: {0}", num2);
        Console.WriteLine("Suma de los dos números: {0}", sum);
        Console.ReadKey(true);
    }
}