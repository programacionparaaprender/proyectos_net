using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraCsharp
{
    class Comprueba
    {
        public Comprueba()
        { 
        }
        public static bool verifica(string cadena)
        {
            return true;
        }
        public static int suma(int numero1,int operador,int numero2)
        {
            if (operador == 43)
                return (numero1 + numero2);
            else if (operador == 45)
                return (numero1 - numero2);
            else if (operador == 42)
                return numero1 * numero2;
            else if (operador == 47)
                return numero1 / numero2;

            return 0;
        }
        public static Nodo asigna(Nodo raiz)
        {
            Nodo nodo = raiz;
            return null;
        }
    }

}
