/*
Secuencia de escape
Nombre del carácter
Codificación Unicode
 
\'
Comilla simple
0x0027
  
\"
Comilla doble
0x0022

\\
Barra invertida
0x005C
 
\0
Null
0x0000
 
\a
Alerta
0x0007

\b
Retroceso
0x0008
 
\f
Avance de página
0x000C
 
\n
Nueva línea
0x000A
 
\r
Retorno de carro
0x000D
 
\t
Tabulación horizontal
0x0009
 
\v
Tabulación vertical
0x000B

*/
using System;

public class PrincipalMain
{
    public static void Main(string[] args)
    {
        Console.WriteLine('\0');
        Console.ReadKey(true);
    }
}