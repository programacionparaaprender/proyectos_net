using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumCsharp
{
    public class PrincipalMain
    {
        enum Tamanio
        {
            Pequeño,
            Mediano,
            Grande
        }

        enum Nuevo
        {
            Pequeño = 1,
            Mediano = 2,
            Grande = Pequeño + Mediano
        }

        enum Nuevo2
        {
            Pequeño,
            Mediano = Pequeño,
            Grande = Pequeño + Mediano
        }

        enum Tamaño
        {
            Pequeño,
            Mediano = Pequeño,
            Grande = Pequeño + Mediano
        }
        public static void Main(string[] args)
        {
            try
            {
                Tamanio obj = Tamanio.Grande;
                Console.WriteLine(obj);
                Nuevo obj1 = Nuevo.Grande;
                Console.WriteLine(obj1);
                //obj.MuestraTexto(Tamanio.Mediano); // (2)
                //obj.MuestreaTexto(2); // (1)

                //object[] tabla = Enum.GetValues(typeof(Tamaño));
                object[] tabla = new Tamaño[3];

                Console.WriteLine(tabla[0]); // Muestra 0, pues Pequeño = 0
                Console.WriteLine(tabla[1]); // Muestra 1, pues Mediano = 1
                Console.WriteLine(tabla[2]); // Muestra 1, pues Grande = Pequeño+Mediano
                
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
            finally
            {
                Console.ReadKey(true);
            }
        }
    }
}
