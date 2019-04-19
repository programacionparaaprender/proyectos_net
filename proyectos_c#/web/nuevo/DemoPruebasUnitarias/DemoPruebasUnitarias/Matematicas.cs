using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoPruebasUnitarias
{
    public class Matematicas
    {
        public static int suma(int sumando1, int sumando2)
        {
            return sumando1 + sumando2;
        }
        public static int division(int dividendo, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("No se puede dividir entre cero");
            }
            return dividendo / divisor;
        }
    }
}