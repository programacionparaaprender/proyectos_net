using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    // cref=”Espacio”
namespace UsoCref
{
    // cref=”Espacio.Clase”
    class Clase
    {
        // cref=”Espacio.Clase.Campo”
        int Campo;
        // cref=”Espacio.Clase.Propiedad”
        int Propiedad
        { 
            set 
            {
            } 
        }
        // cref=”Espacio.Clase.EstructuraInterna”
        struct EstructuraInterna 
        {
        }

        // cref=”Espacio.Clase.DelegadoInterno”
        public delegate int DelegadoInterno(string s, float f);
    
        // cref =”Espacio.Clase.Evento”
        public event DelegadoInterno Evento;

        // cref=”Espacio.Clase.Metodo(System.Int32, System.Int32@,
        // System.Int32*, System.Int32@,
        // System.Int32[][], System.Int32[0:, 0:, 0:])”
        int Metodo(int a, out int b, int * c, ref d, int[][] e, int[,,] f)
        {
            return 1;
        }

        // cref=”Espacio.Clase.Item(System.String)”
        int this[string s]
        { 
            set 
            {
            } 
        }

        // cref=”Espacio.Clase.#ctor”
        Clase(int a)
        {
        }

        // cref=”Espacio.Clase.#cctor”
        static Clase(int a)
        {
        }

        // cref=”Espacio.Clase.Finalize”
        //sustituido por
        //~X()
        ~Clase()
        {
        }

        // cref=”Espacio.Clase.op_Addition(Espacio.Clase, Espacio.Clase)”
        public static int operator +(Clase operando1, Clase operando2)
        { 
            return 1; 
        }

        // cref=”Espacio.Clase.op_Explicit (Espacio.Clase)~System.Int32”
        public static explicit operator int(Clase fuente)
        { 
            return 1; 
        }
    }
    class PrincipalMain
    { 
        public static void Main(string[] args)
        {
        }
    }
}
