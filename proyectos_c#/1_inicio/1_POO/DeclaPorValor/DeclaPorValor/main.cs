
using System;

public class Class1 
{ 
    public static void Main(string[] args) 
    { 
        Console.Write("{0:C} \n", 2,5); 
        Console.Write("{0:D5} \n", 25); 
        Console.Write("{0:E} \n", 250000);
        Console.Write("{0:F2} \n", 25); 
        Console.Write("{0:F0} \n", 25); 
        Console.Write("{0:G} \n", 2,5); 
        Console.Write("{0:N} \n", 2500000); 
        Console.Write("{0:X} \n", 250); 
        Console.Write("{0:X} \n", 0xffff); 
        Console.ReadKey(true); 
    } 
}


/*
La salida por pantalla es:
2,00 ?
00025
2,500000E+005
25,00
25
2
2.500.000,00
FA
*/