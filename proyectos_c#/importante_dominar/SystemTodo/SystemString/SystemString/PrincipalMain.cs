using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemString
{
    class PrincipalMain
    {
        public static void Main(string[] args)
        {
            try
            {
                /*
                int IndexOf(string subcadena): Indica cuál es el índice de la primera aparición de la
                subcadena indicada dentro de la cadena sobre la que se aplica. La búsqueda de dicha
                subcadena se realiza desde el principio de la cadena, pero es posible indicar en un
                segundo parámetro opcional de tipo int cuál es el índice de la misma a partir del que
                se desea empezar a buscar. Del mismo modo, la búsqueda acaba al llegar al final de
                 int LastIndexOf(string subcadena): Funciona de forma similar a IndexOf() sólo que
                devuelve la posición de la última aparición de la subcadena buscada en lugar de
                devolver la de la primera.
                 * 
                • string Insert(int posición, string subcadena): Devuelve la cadena resultante de
                insertar la subcadena indicada en la posición especificada de la cadena sobre la que
                se aplica.
                 * 
                • string Remove(int posición, int número): Devuelve la cadena resultante de eliminar
                el número de caracteres indicado que hubiese en la cadena sobre al que se aplica a
                partir de la posición especificada.
                 * 
                • string Replace(string aSustituir, string sustitua): Devuelve la cadena resultante de
                sustituir en la cadena sobre la que se aplica toda aparación de la cadena aSustituir
                indicada por la cadena sustituta especificada como segundo parámetro.
                 * 
                • string Substring(int posición, int número): Devuelve la subcadena de la cadena sobre
                la que se aplica que comienza en la posición indicada y tiene el número de caracteres
                especificados. Si no se indica dicho número se devuelve la subcadena que va desde
                la posición indicada hasta el final de la cadena.
                 * 
                • string ToUpper() y string ToLower(): Devuelven, respectivamente, la cadena que
                resulte de convertir a mayúsculas o minúsculas la cadena sobre la que se aplican.
                */
                string cadena1 = "holaMundo@gmail.com";
                Console.WriteLine("letra "+cadena1[cadena1.IndexOf("@")]+
                    " posicion " + cadena1.IndexOf("@"));

                Console.WriteLine(cadena1.Insert(cadena1.IndexOf("@"),"fc"));

                Console.WriteLine(cadena1.Remove(cadena1.IndexOf("@"),3));

                Console.WriteLine(cadena1.Replace("hola",cadena1));

                Console.WriteLine(cadena1.Substring(cadena1.IndexOf("@"), 3));

                Console.WriteLine(cadena1.ToUpper());
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
