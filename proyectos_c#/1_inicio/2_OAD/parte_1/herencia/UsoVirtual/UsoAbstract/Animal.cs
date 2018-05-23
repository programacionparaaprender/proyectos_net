using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsoAbstract
{
    abstract class Animal
    {
        private int nroPatas;
        private string nombre;
        public Animal(int nroPatas, string nombre)
        {
            this.nroPatas = nroPatas;
            this.nombre = nombre;
        }
        public virtual void mover()
        {
        }
        public virtual void alimentos()
        {
        }
    }
}
