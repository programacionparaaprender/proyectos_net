
using System;

class A
{
    // Constructor estático
    static A()
    {
        Console.WriteLine("Llamado el constructor estático");
    }
    public static void F()
    {
        Console.WriteLine("Llamado F().");
    }
}

class MainClass
{
    static void Main()
    {
        A.F();
        Console.ReadKey(true);
    }
}