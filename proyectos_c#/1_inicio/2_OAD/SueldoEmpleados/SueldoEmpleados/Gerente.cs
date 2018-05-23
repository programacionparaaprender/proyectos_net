using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SueldoEmpleados
{
    public class Gerente
    {
        private double SegSocialAnio3;
        private double LPHAnio3;
        private double PFAnio3;
        private double Bono2Da;
        private double S_HCMAnio3;

        public Gerente(
            double SegSocialAnio3,double LPHAnio3,double PFAnio3,
            double S_HCMAnio3,double Bono2Da)
        {
            this.SegSocialAnio3 = SegSocialAnio3;
            this.LPHAnio3 = LPHAnio3;
            this.PFAnio3 = PFAnio3;
            this.S_HCMAnio3 = S_HCMAnio3;
            this.Bono2Da = Bono2Da;

        }

        public Gerente()
        {
            SegSocialAnio3 = 2520;
            LPHAnio3 = 4255;
            PFAnio3 = 2650;
            S_HCMAnio3 = 2000;
            Bono2Da = 5000;
        }

        public void calculo()
        {
            Console.WriteLine("su salario total al mes es");
    	}

        public string toString()
        {
		    return ""+SegSocialAnio3+LPHAnio3
                +PFAnio3+Bono2Da+S_HCMAnio3;
    	}
    }
}
