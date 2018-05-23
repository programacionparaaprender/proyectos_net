using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace UsoIEnumerable
{
    /*
    interface IEnumerator
    {
        object Current { get; }
        bool MoveNext();
        void Reset();
    }
    */
    class Patron
    {
        private int actual = -1;
        
        public Patron GetEnumerator()
        {
            return this;
        }
        public int Current
        {
            get 
            {
                return actual;
            }
        }
        public bool MoveNext()
        {
            bool resultado = true;
            actual++;
            if (actual==10)
                resultado = false;
            return resultado;
        }
    }

    class Interfaz:IEnumerable,IEnumerator
    {
        private int actual = -1;
        public object Current
        {
            get {return actual;}
        }
        public bool MoveNext()
        {
            bool resultado = true;
            actual++;
            if (actual == 10)
                resultado = false;
            return resultado;
        }
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        public void Reset()
        {
            actual = -1;
        }
    }
    public class PrincipalMain
    {
        public static void Main(string[] args)
        {
            try
            {
                Patron obj = new Patron();
                Interfaz obj2 = new Interfaz();
                foreach (int elem in obj)
                    Console.WriteLine(elem);
                foreach (int elem in obj2)
                    Console.WriteLine(elem);
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
