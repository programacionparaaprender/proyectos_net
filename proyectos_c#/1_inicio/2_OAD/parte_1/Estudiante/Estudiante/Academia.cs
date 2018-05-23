using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estudiante
{
    class Academia
    {

        private Estudiante[] obj1;

        private int cantidad;

        private string nombre1 = "";

        private int numero;

        private string a = "ingrese carrera del estudiante";

        private string b = "ingrese nombre del estudiante";

        private string c = "ingrese apellido";

        private string d = "ingrese cedula";

        private string e = "ingrese periodo(semestre)";

        private string f = "ingrese creditos";

        private string g = "ingrese promedio";

        private string h = "ingrese numero de estudiantes de la academia";

        private string j = "cual estudiante desea eliminar";

        private string carrera, nombre = "", apellido = "", cedula = "", periodo = "";

        private Semestre Semestre1;

        private Record Record1 = new Record();

        private int creditos, n = 1, i;

        private double promedio;

        private bool demos;

        public Academia(String nombre1, int numero)
        {

            this.obj1 = new Estudiante[numero];

            cantidad = 0;

            this.numero = numero;

            this.nombre1 = nombre1;

        }

        public Academia()
        {

            obj1 = new Estudiante[16];

            cantidad = 0;

            nombre1 = "Universidad De Oriente";

            numero = 16;

        }

        public bool Preguntar()
        {
		
		    bool sw = false;
		
		    bool w = false;
		
		    int s;
		
		    do
            {
			    sw = false;
			
			    try
                {
				
			        System.Console.WriteLine(
                        "desea ingresar estudiantes pulse\n1 para ingresar\n0 para no ");
			
			        s = int.Parse(System.Console.ReadLine());
			
			        if(s == 1)
				        w = true;
			        else
				        w = false;
				
			    }
		
			    catch(Exception e)
                {

                    System.Console.WriteLine("ERROR"+e);
		    
		    	    sw = true;
		    
			    }
			
			}while(sw);
		
		    return w;
		
		}

        public void Ingresar()
        {

            //LEYENDO EL NUMERO DE ESTUDIANTES

            demos = Preguntar();

            if (demos)
            {

                numero = int.Parse(LeerString(h));

                //CREANDO EL OBJETO
                /*
                    Estudiante[] obj1 = new Estudiante[numero]; 
    		
                    for(i = 0; i < numero ; i++ ){
    		
                        obj1[i] = new Estudiante();
    		
                        } */

                for (i = 0; i < numero; i++)
                {

                    carrera = LeerString(a, n);

                    nombre = LeerString(b, n);

                    apellido = LeerString(c, n);

                    cedula = LeerString(d, n);

                    periodo = LeerString(e, n);

                    creditos = int.Parse(LeerString(f, n));

                    promedio = double.Parse(LeerString(g, n));

                    obj1[i] = new Estudiante(carrera, nombre, apellido, cedula, periodo, 
                        Record1, creditos, promedio);

                    n++;

                }


                Eliminar(obj1);

            }
        }

        public void Eliminar(Estudiante[] obj1)
        {
    	
    	    int i, s;
    	
    	    bool d;
    	
    	    try
            {
    		
    		    System.Console.WriteLine(
                    "pulse 1 para eliminar estudiante y 0 para no eliminar un estudiante");
    		
    		    d = bool.Parse(System.Console.ReadLine());
    		
    		    if(d)
                {
    	
    			    System.Console.WriteLine(j);
    	
    			    s = int.Parse(System.Console.ReadLine());
    	
    			    for(i = s; i < numero-1; i++)
    				    obj1[s-1] = obj1[s++];
    		
    			    numero = numero - 1;
    		
    			    System.Console.WriteLine("Estudiante eliminado con exito");
    			
    			}
    		}
    	
    	    catch(Exception e)
            {

                System.Console.WriteLine("ERROR"+e);
    		
    		}
	
		}

        public string LeerString(string a)
        {
    	
    	    bool sw = false;
    	
    	    string x = "";
    	
    	    do
            {
    		
    		    sw = false;
    		
    		    try
                {
    			
    			    System.Console.WriteLine(a);
    			
    			    x = System.Console.ReadLine();
    			
    			}
    			
    		    catch(Exception e)
                {
    			
    			    sw = true;
                    System.Console.WriteLine(e);
    			
    			}
    		
    		}while(sw);
    		
    	    return x;
    	
    	}

        public string LeerString(String a, int n)
        {
    	
    	    bool sw = false;
    	
    	    string x = "";
    	
    	    do
            {
    		
    		    sw = false;
    		
    		    try
                {

                    System.Console.WriteLine(a + n);
    			
    			    x = System.Console.ReadLine();
    			
    			}
    			
    		    catch(Exception e)
                {
    			
    			    sw = true;
                    System.Console.WriteLine(e);
    			
    			}
    		
    		}while(sw);
    		
    	return x;
    	
    	}

    }
}
