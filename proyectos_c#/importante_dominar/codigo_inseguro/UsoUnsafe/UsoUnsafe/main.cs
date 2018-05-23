
// cs_unsafe_keyword.cs
// compile with: /unsafe
using System;

public class UnsafeTest
{
    /*
     * para que funcione unsafe es muy facil solo hacer
     * En caso de que la compilación se vaya a realizar a través de 
     * Visual Studio.NET, la forma de indicar que se desea compilar 
     * código inseguro es activando la casilla 
     * View 
     * 􀃆Property Pages 􀃆 
     * Configuration Properties 􀃆 
     * Build 􀃆 
     * Allow unsafe code blocks
     * 
     * propiedades de explorador de soluciones
     * generar
     * Permitir codigo no seguro
     */
    // Unsafe method: takes pointer to int:
    unsafe static void SquarePtrParam(int* p)
    {
        *p *= *p;
    }

    unsafe static void Main(string[] args)
    {
        int* apuntadorNada;
        int i = 5;
        apuntadorNada = &i;
        Console.WriteLine(*apuntadorNada);
        // Unsafe method: uses address-of operator (&):
        SquarePtrParam(&i);
        Console.WriteLine(i);
        Console.ReadKey(true);
    }
}