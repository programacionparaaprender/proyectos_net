
#define PRUEBA
#define TRAZA

using System;

enum Muestra
{
    Manta,Mueble
}

class A
{
    public static void Main(string[] args)
    {
        Muestra hogar = Muestra.Manta;
        //por que prueba si existe arriba
        #if PRUEBA
            Console.WriteLine("Esto es una prueba");
            //por que traza si existe arriba
            //tambien podriamos haber dicho true
            #if TRAZA
                Console.WriteLine(" con traza");
            #elif !TRAZA
                Console.Write(" sin traza");
            #endif
        #endif

        #if hogar == Manta
            Console.WriteLine("son iguales");

        #endif
        Console.ReadKey(true);
    }
}