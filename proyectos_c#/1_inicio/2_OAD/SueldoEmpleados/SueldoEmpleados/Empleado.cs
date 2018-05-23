using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SueldoEmpleados
{
    public abstract class Empleado : Persona
    {
        protected double salario;

        protected double horaExtra; 

	    public Empleado(
            string nombre,string id,double salario,double horaExtra)
            :base(nombre,id)
        {
            this.salario = salario;
		    this.horaExtra = horaExtra;
	          		      
        }
	        	                         
	    public Empleado():base()
        {
		    salario = 100;
            horaExtra = 30;
	    }
        public double Salario
        {
            set
            {
                this.salario = value;
            }
            get
            {
                return this.salario;
            }
        }
        public double HoraExtra
        {
            set
            {
                this.horaExtra = value;
            }
            get
            {
                return this.horaExtra;
            }
        }
        public virtual void calculo()
        { 
        }

        public string toString()
        {
            return "salario: "+this.salario+" hora extra "+
                this.horaExtra+base.ToString();
        }
	
	}  
}
