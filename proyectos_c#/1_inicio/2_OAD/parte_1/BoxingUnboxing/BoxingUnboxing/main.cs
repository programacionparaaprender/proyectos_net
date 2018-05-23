
using System;

public class PrincipalMain
{
    public static void Main(String[] args)
    {
        int y = 20;
        object x = y; //Proceso de boxing: y se convierte a 
        //referencia para permitir la asignación
        int z = (int)x; //Proceso de Unboxing: x se convierte 
        //a entero para
        Console.ReadKey(true);
    }
}