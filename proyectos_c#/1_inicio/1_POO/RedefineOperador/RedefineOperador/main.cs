
using System;

public class ComplexNumber
{
    private int real;
    private int imaginary;

    public ComplexNumber()
        : this(0, 0)  // constructor
    {
    }

    public ComplexNumber(int r, int i)  // constructor
    {
        real = r;
        imaginary = i;
    }

    // Override ToString() to display a complex number in the traditional format:
    public override string ToString()
    {
        return (System.String.Format("{0} + {1}i", real, imaginary));
    }

    // Overloading '+' operator:
    public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
    {
        return new ComplexNumber(a.real + b.real, a.imaginary + b.imaginary);
    }

    // Overloading '-' operator:
    public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
    {
        return new ComplexNumber(a.real - b.real, a.imaginary - b.imaginary);
    }
}

public class TestComplexNumber
{
    public static void Main(string[] args)
    {
        ComplexNumber a = new ComplexNumber(10, 12);
        ComplexNumber b = new ComplexNumber(8, 9);

        Console.WriteLine("Complex Number a = {0}", a);

        Console.WriteLine("Complex Number b = {0}", b);

        ComplexNumber sum = a + b;
        Console.WriteLine("Complex Number sum = {0}", sum);

        ComplexNumber difference = a - b;
        Console.WriteLine("Complex Number difference = {0}", difference);

        Console.ReadKey(true);
    }
}