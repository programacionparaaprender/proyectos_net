
using System;

public class ConstructorPrivate
{
    private ConstructorPrivate() 
    {

    }
    public ConstructorPrivate(int x)
    {

    }
    // Cuerpo vacío y miembros estáticos
    public static int contador;

    public static int IncrementarContador ()
    {
        return ++contador;
    }
}

public class Pruebas
{
    public static void Main()
    {
        // La llamada siguiente a ConstructorPrivate(comentada) genería un error
        // por que no es accesible
        // 
        ConstructorPrivate cs = new ConstructorPrivate(3); 
        // Error
        ConstructorPrivate.contador = 100;
        ConstructorPrivate.IncrementarContador ();
        Console.WriteLine("Valor: {0}", ConstructorPrivate.contador);
        Console.ReadKey(true);
    }
}

/*
--------------------
Salida en ejecución:
--------------------
Valor: 101
*/