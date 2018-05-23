using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SueldoEmpleados
{
    public class PrincipalMain
    {
        public static int input(string cadena)
        {
            Console.WriteLine(cadena);
            return int.Parse(Console.ReadLine());
        }

        public static int input()
        {
            return int.Parse(Console.ReadLine());
        }

        public static string raw_input()
        {
            return Console.ReadLine();
        }

        public static string raw_input(string cadena)
        {
            Console.WriteLine(cadena);
            return Console.ReadLine();
        }

	    public static void Main(string[] args) 
        {
    	    try
            {
    		    // GERENTE
    			Gerente obj1 = new Gerente(
                    input("ingrese seguro social que debe pagar al anio"),
                    input("ingrese ley de politica habitacional por anio"),
                    input("ingrese paro forzoso por anio"),
                    input("ingrese SHCM"),
                    input("bono segunda quincena"));
	    	    obj1.calculo();
	    	
	    	    //SUPERVISOR
	    	    Supervisor obj2 = new Supervisor(
                    raw_input("ingrese nombre"),
                    raw_input("ingrese id"),
                    input("ingrese salario por dia"),
                    input("ingrese horas extras"),
                    input("ingrese seguro social por anio de obrero"),
                    input("ingrese ley de politica habitacional por anio"),
                    input("ingrese paro forzoso por anio"),
                    input("ingrese bono de utilidades"));
	    	    obj2.calculo();
	    	    
	    	    //OBRERO
                Obrero obj3 = new Obrero(
                    raw_input("ingrese nombre"),
                    raw_input("ingrese id"),
                    input("ingrese salario por dia"),
                    input("ingrese horas extras"),
                    input("ingrese seguro social por anio de obrero"),
                    input("ingrese ley de politica habitacional por anio"),
                    input("ingrese paro forzoso por anio"));
	    	    obj3.calculo();
            }
		    catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.ReadKey(true);
            }  
        }
    }
}
