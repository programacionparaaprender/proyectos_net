using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estudiante
{
    class Estudiante
    {

        private string carrera, nombre = "", apellido = "", cedula = "", periodo = "";

        private Semestre Semestre1;

        private Record Record1;

        private int creditos;

        private double promedio;

        private string cargaAcademica, recordAcademico;

        private string nuevorecordAcademico;

        public Estudiante()
        {
		
		    this.carrera = "computacion";
			
		    this.nombre = "luis";
		
		    this.apellido = "correa";
		
		    this.cedula = "19763776";
			
		    this.periodo = "6 Semestre";
		
		    this.Semestre1 = new Semestre();
	
		    this.Record1 = new Record();
	
		    this.creditos = 18;
	
		    this.promedio = 10;
		
		    this.cargaAcademica = Semestre1.mostrarSemestre();
		
		    this.nuevorecordAcademico = Record1.mostrarRecord();
		
		    this.recordAcademico = Record1.toString(nuevorecordAcademico);
		
		    System.Console.WriteLine(cargaAcademica);

            System.Console.WriteLine(recordAcademico);
	
		}

        public Estudiante(string carrera, string nombre, string apellido, string cedula, 
            string periodo, Record Record1, int creditos, double promedio)
        {
		
			this.carrera = carrera;
		
			this.nombre = nombre;
			
			this.apellido = apellido;
			
			this.cedula = cedula;
			
			this.periodo = periodo;
	
			this.Record1 = Record1;
	
			this.creditos = creditos;
			
			this.promedio = promedio;
			
			this.Semestre1 = new Semestre();
			
			this.Semestre1.Semestre1();
			
			this.Record1 = new Record();
			
			this.cargaAcademica = Semestre1.mostrarSemestre();
		
			this.recordAcademico = Record1.toString();
		
			System.Console.WriteLine(cargaAcademica);

            System.Console.WriteLine(recordAcademico);
			
		}

        public void Estudiante1()
        {

            this.carrera = "ingenieria en computacion";

            this.nombre = "Luis";

            this.apellido = "Correa";

            this.cedula = "9.545.655";

            this.periodo = "1 semestre";

            this.Record1 = new Record(); ;

            //this.creditos = creditos;

            //this.promedio = promedio;

            this.Semestre1 = new Semestre();

            this.Semestre1.Semestre1();

        }

    }
}
