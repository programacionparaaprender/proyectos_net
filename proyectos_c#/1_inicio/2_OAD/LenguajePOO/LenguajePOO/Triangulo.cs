using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LenguajePOO
{
    public class Triangulo : Figuras
    {
        public Triangulo(): base()
        {
        }
        public Triangulo(double base1,double altura):base(base1,altura)
        {
        } 
        public override double area() 
        {
            return base.getBase()*base.getAltura()/2;
        }
    }
}
