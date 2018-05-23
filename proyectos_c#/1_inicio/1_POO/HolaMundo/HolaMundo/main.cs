using System;


namespace ProgramaLuis
{
    enum Enumerado //es una clase
    {
        Rojo,Azul,Verde
    };

    struct agenda//puede ser public, internal o private
    {
        String nombre;
        String apellido;
        String cedula;
    };

    interface ISampleInterface
    {
        void SampleMethod();
    }

    class ImplementationClass : ISampleInterface
    {
        // Explicit interface member implementation: 
        void ISampleInterface.SampleMethod()
        {
            // Method implementation.
        }

    };

    class Otra
    {
        private int numero;

        protected String nombre;

        internal int uxiliar;

        protected internal double real;

        private String apellido;

        public Otra(int numero)
        {
            this.numero = numero;
        }
    };

    class HolaMundoCS
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Hola desde C#");
            //tambien se puedo hacer así sin importar la 
            //libreria
            //System.Console.WriteLine("Hola Mundo");
            Console.ReadKey(true);
        }
    }
}
//te quedaste en otros modificadores