using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estudiante
{
    class Semestre
    {

        private string matematica1 = "", fisica1 = "", quimica1 = "";

        private string introCompu = "", compuBasica = "", logicMatematica = "";

        private int numeroMat;

        public Semestre()
        {

            this.matematica1 = "matematica1";

            this.fisica1 = "fisica1";

            this.quimica1 = "quimica1";

            this.introCompu = "introduccion a la ingenieria en computacion";

            this.compuBasica = "computacion basica";

            this.logicMatematica = "logica matematica";

        }

        public Semestre(string matematica1, string fisica1, string quimica1,
            string introCompu, string compuBasica, string logicMatematica)
        {

            this.matematica1 = matematica1;

            this.fisica1 = fisica1;

            this.quimica1 = quimica1;

            this.introCompu = introCompu;

            this.compuBasica = compuBasica;

            this.logicMatematica = logicMatematica;

        }

        public void Semestre1(string matematica1, string fisica1, string quimica1, 
            string introCompu, string compuBasica, string logicMatematica)
        {
		
		    System.Console.WriteLine("aprobo:");
		
		    System.Console.WriteLine(matematica1);
		
		    System.Console.WriteLine(fisica1);
		
		    System.Console.WriteLine(quimica1);
		
		    System.Console.WriteLine(introCompu);
		
		    System.Console.WriteLine(compuBasica);

            System.Console.WriteLine(logicMatematica);
		
		}

        public void Semestre2(
            /*String matematica1, String fisica1, String quimica1, String introCompu*/)
        {
		
		    System.Console.WriteLine("aprobo:");
		
		    System.Console.WriteLine();
		
		    System.Console.WriteLine();

            System.Console.WriteLine();
		
		}

        public String mostrarSemestre()
        {
	
		    int z = 1, i = 0;
		
		    bool sw = false;
		
		    string s = "", m;
		
		    do
            {
		
			    try
                {
				
				    sw = false;
				
				    System.Console.WriteLine("cuantas materias va a ingresar");
				
				    numeroMat = int.Parse(System.Console.ReadLine());
				
				    for(i = 0 ; i < numeroMat ; i++ )
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

		    return "su carga academica es\n"+s;
			
		}

        public void Semestre1()
        {
		
		    System.Console.WriteLine("debe aprobar:");
		
		    System.Console.WriteLine("matematica1");
		
		    System.Console.WriteLine("fisica1");
		
		    System.Console.WriteLine("quimica1");

            System.Console.WriteLine("introduccion a la ingenieria en computacion");
		
		}

        public String RetornarMaterias()
        {

            String s = "s";

            return s;

        }

    }
}
