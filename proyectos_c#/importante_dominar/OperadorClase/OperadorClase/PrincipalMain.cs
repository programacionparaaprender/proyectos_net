using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperadorClase
{

    class Complejo
    {
        private float ParteReal;
        private float ParteImaginaria;

        public float Real
        {
            set
            {
                this.ParteReal = value;
            }
            get 
            {
                return this.ParteReal;
            }
        }

        public float Imaginaria 
        {
            set 
            {
                this.ParteImaginaria = value;
            }
            get
            {
                return this.ParteImaginaria;
            }
        }

        public Complejo()
        {
            this.ParteReal = 0;
            this.ParteImaginaria = 12;
        }

        public Complejo (float parteReal, float parteImaginaria)
        {
            this.ParteReal = parteReal;
            this.ParteImaginaria = parteImaginaria;
        }
        public static Complejo operator +(Complejo op1, Complejo op2)
        {
            Complejo resultado = new Complejo();
            resultado.ParteReal = op1.ParteReal + op2.ParteReal;
            resultado.ParteImaginaria = op1.ParteImaginaria + op2.ParteImaginaria;

            return resultado;
        }
    }

    public class PrincipalMain
    {
        public static void Main(string[] args)
        {
            Complejo p1 = new Complejo(20,1);
            Complejo p2 = new Complejo(2, 13);
            Complejo p3 = p1 + p2;

            Console.WriteLine("parte real "+p3.Real+" parte imaginaria "+p3.Imaginaria);
            Console.ReadKey(true);
        }
    }
}
