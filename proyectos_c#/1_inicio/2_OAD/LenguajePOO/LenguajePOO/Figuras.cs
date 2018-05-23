using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LenguajePOO
{
    public abstract class Figuras 
    {
        private double mbase,maltura;
        public Figuras()
        {
            this.mbase = 0;
            this.maltura = 0;
        }
        public Figuras(double base1,double altura)
        {
            this.mbase = base1;
            this.maltura = altura;
        }
        public double getBase(){ return this.mbase; }
        public double getAltura(){ return this.maltura; }
        public virtual double area(){ return 0; } 
    }
}
