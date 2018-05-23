using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SueldoEmpleados
{
    public class Obrero : Empleado
    {
        private double SegSocialAnio1;
	    private double LPHAnio1;
        private double PFAnio1;
   
	    public Obrero(
            string nombre,string id,double salario,double horaExtra,
            double SegSocialAnio1,double LPHAnio1,double PFAnio1):
            base(nombre,id,salario,horaExtra)
        {
	        this.SegSocialAnio1 = SegSocialAnio1;
		    this.LPHAnio1 = LPHAnio1;
            this.PFAnio1 = PFAnio1;	      
		}
	        	                         
	    public Obrero():base("luis","23",100,2)
        {
	        this.SegSocialAnio1 = 2520;
            this.LPHAnio1 = 4255;
            this.PFAnio1 = 2650;
	   }
	    
	    public override void calculo()
        {
            Console.WriteLine(toString()+" sueldo "+(base.salario * 30 + base.horaExtra * 20));
    	}
    	
        public string toString()
        {
	        return SegSocialAnio1+LPHAnio1+PFAnio1+base.ToString();
	    }
    }
}
