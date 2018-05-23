using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LenguajePOO
{
    public class Rectangulo : Figuras
    {
        public Rectangulo():base()
        {
        }
        public Rectangulo(double base1,double altura):base(base1,altura)
        {
        }
        public override double area()
        {
            return base.getBase() * base.getAltura();
        }   
    }
}
