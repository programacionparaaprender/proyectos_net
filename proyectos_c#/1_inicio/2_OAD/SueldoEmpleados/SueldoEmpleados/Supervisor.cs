using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SueldoEmpleados
{
    public class Supervisor : Empleado
    {
        private double SegSocialAnio1;
        private double LPHAnio1;
        private double PFAnio1;
        private double BonoCH1;

	    public Supervisor(string nombre,string id,double salario,double horaExtra,
            int SegSocialAnio2,int LPHAnio2,int PFAnio2,double BonoCH1):
            base(nombre,id,salario,horaExtra)
        {
	        this.SegSocialAnio1 = SegSocialAnio2;

		    this.LPHAnio1 = LPHAnio2;
	
		    this.PFAnio1 = PFAnio2;

            this.BonoCH1 = BonoCH1;
        }
	        	                         
	    public Supervisor():base()
        {
		    SegSocialAnio1 = 2520;

		    LPHAnio1 = 4255;
	
		    PFAnio1 = 2650;
		
		    BonoCH1 = 500;	
	    }
	    
	    public override void calculo()
        {
            Console.WriteLine(SegSocialAnio1+
                LPHAnio1+PFAnio1+BonoCH1+toString());
    	}
    	
        public string toString()
        {
            return base.toString();
        }
	
        }

}
