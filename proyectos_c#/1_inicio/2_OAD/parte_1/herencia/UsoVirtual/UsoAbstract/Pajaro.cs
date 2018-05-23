using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsoAbstract
{
    class Pajaro: Animal
    {
        public Pajaro(int nroPatas, string nombre)
            : base(nroPatas,nombre)
        {
        }
        public override void mover()
        {
            Console.WriteLine("vuela");
        }
        public override void alimentos()
        {
            Console.WriteLine("pescado");
        }
    }
}
