using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsoUsing
{
    using System;

    class C : IDisposable
    {
        public void UseLimitedResource()
        {
            Console.WriteLine("metodo de c");
        }

        void IDisposable.Dispose()
        {
            Console.WriteLine("dispose de c");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            using (C c = new C())
            {
                c.UseLimitedResource();
            }
            
            Console.WriteLine("teclado");
            Console.ReadLine();
        }
    }
}
