using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsoAbstract
{
    class Perro: Animal
    {
        public Perro(int nroPatas, string nombre)
            : base(nroPatas,nombre)
        {

        }
        public override void mover()
        {
            Console.WriteLine("Corre");
        }
        public override void alimentos()
        {
            Console.WriteLine("Carne");
        }
    }
}
