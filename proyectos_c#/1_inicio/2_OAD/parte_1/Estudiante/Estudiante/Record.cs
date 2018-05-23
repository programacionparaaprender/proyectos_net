using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estudiante
{
    class Record
    {

        private string matematica1 = "", fisica1 = "", quimica1 = "";

        private string introCompu = "", compuBasica = "", logicMatematica = "";

        private string carrera, nombre = "", apellido = "", cedula = "", periodo = "";

        private int creditos;

        private double promedio;

        private int numeroRec;

        public Record()
        {

            this.carrera = "computacion";

            this.nombre = "luis";

            this.apellido = "correa";

            this.cedula = "19763776";

            this.periodo = "6 Semestre";

            this.creditos = 18;

            this.promedio = 10;

        }

        public Record(string carrera, string nombre, string apellido, string cedula, 
            string periodo, int creditos, double promedio)
        {

            this.carrera = carrera;

            this.nombre = nombre;

            this.apellido = apellido;

            this.cedula = cedula;

            this.periodo = periodo;

            this.creditos = creditos;

            this.promedio = promedio;

        }

        public void Record1(string carrera, string nombre, string apellido, string cedula, 
            string periodo, int creditos, double promedio)
        {
		
			System.Console.WriteLine(carrera);
		
			System.Console.WriteLine(nombre);
			
			System.Console.WriteLine(apellido);
			
			System.Console.WriteLine(cedula);
			
			System.Console.WriteLine(periodo);
	
			System.Console.WriteLine(creditos);

            System.Console.WriteLine(promedio);
		
		}

        public void Record1()
        {
		
			System.Console.WriteLine("computacion");
		
			System.Console.WriteLine("luis");
			
			System.Console.WriteLine("correa");
			
			System.Console.WriteLine("20776567");
			
			System.Console.WriteLine("6 semestre");
	
			System.Console.WriteLine("18");

            System.Console.WriteLine("10");
		
			}

        public string mostrarRecord()
        {
		    int z = 1, i = 0;
		
		    bool sw = false;
		
		    String s = "", m;
		
		    do
            {
			    try
                {	
				    sw = false;
				
				    System.Console.WriteLine("ingrese cuantas nuevas materias a pasado");
				
				    numeroRec = int.Parse(System.Console.ReadLine());
				
				    for(i = 0 ; i < numeroRec ; i++ )
                    {
			
					    System.Console.WriteLine("ingresa la materia nro "+z);
			
					    m = System.Console.ReadLine();
				
					    z++;
				
					    s = s+"\n"+m;
		
					}
			
				}
			
			    catch(Exception e)
                {

                    System.Console.WriteLine("ERROR"+e);
			
				    sw = true;
			
				}
			
			}while(sw);

		return s;
			
		}
        public string toString(string x)
        {

            string s = "record de estudiante de carrera" + carrera + "\nsu nombre es" + 
                nombre + apellido + cedula + periodo + creditos + promedio;

            string g;

            this.matematica1 = "matematica1";

            this.fisica1 = "fisica1";

            this.quimica1 = "quimica1";

            this.introCompu = "introduccion a la ingenieria en computacion";

            this.compuBasica = "computacion basica";

            this.logicMatematica = "logica matematica";

            g = matematica1 + "\n" + fisica1 + "\n" + quimica1 + "\n" + introCompu + 
                "\n" + compuBasica + "\n" + logicMatematica;

            return s + "\na aprobado" + g + "\n y estas otras tambien\n" + x;

        }
        public string toString()
        {

            string s = "record de estudiante de carrera" + carrera + "\nsu nombre es" + 
                nombre + apellido + cedula + periodo + creditos + promedio;

            string g;

            this.matematica1 = "matematica1";

            this.fisica1 = "fisica1";

            this.quimica1 = "quimica1";

            this.introCompu = "introduccion a la ingenieria en computacion";

            this.compuBasica = "computacion basica";

            this.logicMatematica = "logica matematica";

            g = matematica1 + "\n" + fisica1 + "\n" + quimica1 + "\n" + introCompu + 
                "\n" + compuBasica + "\n" + logicMatematica;

            return s + "\na aprobado" + g + "\n";

        }

    }
}
