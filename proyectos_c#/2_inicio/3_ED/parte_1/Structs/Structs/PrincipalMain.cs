using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structs
{
    public struct fecha
    {
        public int dia,mes,year;
        
	}

    public struct afiliado
    {
		public string nom,ape,edad,ced;
		public fecha fec;
        

	}

    public class PrincipalMain
    {
        private static int input()
        {
            return int.Parse(Console.ReadLine());
        }
        private static int input(string cadena)
        {
            Console.WriteLine(cadena);
            return int.Parse(Console.ReadLine());
        }
        private static string raw_input()
        {
            return Console.ReadLine();
        }
        private static string raw_input(string cadena)
        {
            Console.WriteLine(cadena);
            return Console.ReadLine();
        }
        private static void print(string cadena)
        {
            Console.WriteLine(cadena);
        }
        private static void Ingresar(afiliado[] afi,int n)
        {
            for( int i=0; i < n ; i++)
            {
        
	            afi[i].nom = raw_input("Ingrese nombre");
                afi[i].ape = raw_input("Ingrese apellido");
                afi[i].edad = raw_input("Ingrese edad");
                afi[i].ced = raw_input("Ingrese cedula");
	            print("Ingrese Fecha de Ingreso a la linea");
                afi[i].fec.dia = input("Dia");
                afi[i].fec.mes = input("Mes");

	            Console.WriteLine("Año");
	            afi[i].fec.year = int.Parse(Console.ReadLine());
	        }
        }

        private static void Eliminar(afiliado[] afi,int n)
        {
            int enc = 1;
            string cedu;
            Console.WriteLine("Ingrese el Cedula del afiliado a eliminar");
            cedu = Console.ReadLine();
            for( int i=0; i<n ; i++ )
	        {
		        if(cedu==afi[i].ced)
			    {
				    afi[i].ced = afi[i+1].ced;
				    afi[i].nom = afi[i+1].nom;
				    afi[i].ape = afi[i+1].ape;
				    afi[i].edad = afi[i+1].edad;
				    Console.WriteLine("Afiliado "+
                        afi[i].nom+" "+afi[i].ape+" eliminado\n");
				    enc=1;
			    }
		        else 
                    enc=0;
                break;
		    }
            if(enc==0) 
                Console.WriteLine(
                    "Persona ingresada no se encuentra registrado");
        }
        private static void bus_ced(afiliado[] afi,int n)
        {
            int enc = 1;
            string cedula;
            Console.WriteLine("Ingrese CI a buscar:");
            cedula = Console.ReadLine();
            for( int i=0 ; i<n ; i++ )
	        {
	            if(cedula == afi[i].ced)
		        {
			        Console.WriteLine(
                        "Nombre:"+afi[i].nom+"\nApellido:"+afi[i].ape+
                        "\nEdad:"+afi[i].edad+"\nCedula:"+afi[i].ced+
                        "\nFecha de Ingreso:"+afi[i].fec.dia+"/"+
                        afi[i].fec.mes+"/"+afi[i].fec.year+"\n");
			        enc=1;
		        }
		        else 
                    enc=0;
                break;
		    }
	        if(enc==0)
                Console.WriteLine("Cedula no registrada");
	    }
        private static void Bus_nom(afiliado[] afi,int n)
        {
            int enc = 1;
            string nombre;
            Console.WriteLine("Ingrese nombre a buscar:");
            nombre = Console.ReadLine();
            for( int i = 0 ; i<n ; i++ )
	        {
	            if(nombre==afi[i].nom)
		        {
			        Console.WriteLine(
                        "Nombre:"+afi[i].nom+"\nApellido:"+afi[i].ape+"\nEdad:"+afi[i].edad+
                        "\nCedula:"+afi[i].ced+"\nFecha de Ingreso:"+afi[i].fec.dia+
                        "/"+afi[i].fec.mes+"/"+afi[i].fec.year+"\n");
			        enc=1;

		        }

				else 
                    enc=0;
                break;
		    }
	        if(enc==0)
                Console.WriteLine("Nombre no registrado");
        }

        private static void Bus_ape(afiliado[] afi,int n)
        {
	        int enc = 1;
            string apel;
            Console.WriteLine("Ingrese apellido a buscar:");
            apel = Console.ReadLine();
            for( int i = 0 ; i<n ; i++ )
	        {
	            if( apel == afi[i].ape )
		        {
			        Console.WriteLine(
                        "Nombre:"+afi[i].nom+"\nApellido:"+afi[i].ape+"\nEdad:"+afi[i].edad+
                        "\nCedula:"+afi[i].ced+"Fecha de Ingreso:"+afi[i].fec.dia+
                        "/"+afi[i].fec.mes+"/"+afi[i].fec.year+"\n");
			        enc=1;

		        }

			    else 
                    enc=0;
                break;
		    }
	        if(enc==0)
                Console.WriteLine("Apellido no registrado");
        }
        private static void Bus_edad(afiliado[] afi,int n)
        {
	        int enc = 1;
            string Edad;
            Console.WriteLine("Ingrese Edad a buscar:");
            Edad = Console.ReadLine();
            for( int i=0 ; i<n ; i++ )
	        {
	            if(Edad==afi[i].edad)
		        {
			        Console.WriteLine(
                        "Nombre:"+afi[i].nom+"\nApellido:"+afi[i].ape+"\nEdad:"+afi[i].edad+
                        "\nFecha de Ingreso:"+afi[i].fec.dia+"/"+afi[i].fec.mes+
                        "/"+afi[i].fec.year+"\n");
			        enc=1;

		        }
                else 
                    enc=0;
                break;
		    }
	        if(enc==0)
                Console.WriteLine("Edad no registrada");
        }

        public static void Main(string[] args)
        {
            const int maxa = 20;

            afiliado[] afi = new afiliado[maxa];
            for (int i = 0; i < maxa; i++)
            {
                afi[i] = new afiliado();
            }
            int n = 1,opc,opc2;
            string nombre,pre,teso,secre;

            Console.WriteLine(
                "                               Nucleo Anzoategui");
            Console.WriteLine(
                "                   Escuela de Ingenieria y Ciencias Aplicadas");
            Console.WriteLine(
                "                   Departamento de Computacion y Sistemas\n\n\n\n");
            Console.WriteLine(
                "                   TALLER DE PROGRAMACION ORIENTADA A OBJETOS\n\n\n\n");
            Console.WriteLine(
                "Profesor:                                                       Bachiller:\n");
            Console.WriteLine(
                "Pedro Dorta                                                     Osman Villegas");
            Console.WriteLine(
                "                                                                C.I. 20361695\n\n\n\n\n");
            Console.WriteLine(
                "                         Barcelona, 06 de Abril de 2011\n\n");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("Ingrese Nombre de la Linea:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el presidente de la linea");
            pre = Console.ReadLine();
            Console.WriteLine("Ingrese Secretario");
            secre = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del tesorero");
            teso = Console.ReadLine();
            Console.ReadKey(true);
            Console.Clear();
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1.-Ingresar Afiliados");
                Console.WriteLine("2.-Eliminar Afiliados");
                Console.WriteLine("3.-Buscar datos de Afiliados");
                Console.WriteLine("4.-Salir");
                Console.WriteLine("Ingrese una Opcion");
                opc = int.Parse(Console.ReadLine());
                Console.ReadKey(true);
                Console.Clear();
	            if(opc == 1)	
                {
					do
                    {
						Console.WriteLine("Ingrese Nro de Afiliados a ingresar");
						n = int.Parse(Console.ReadLine());
				    }while(n<1||n>maxa);
					Ingresar(afi,n);
					Console.ReadKey(true); 
                    Console.Clear();
				}
	            else if(opc==2)
                {
				    Eliminar(afi,n);
				    Console.ReadKey(true);
                    Console.Clear();
                }
	            else if(opc==3) 
                    do
                    {
                        Console.WriteLine(
                            "1.-Buscar por cedula");
                        Console.WriteLine(
                            "2.-Buscar por Nombre");
                        Console.WriteLine(
                            "3.-Buscar por Apellido");
                        Console.WriteLine(
                            "4.-Buscar por Edad");
                        Console.WriteLine(
                            "5.-Regresar al menu");
					    opc2 = int.Parse(Console.ReadLine());
					    Console.Clear();
					    if(opc2==1)
                        {
                            bus_ced(afi,n);
                            Console.ReadKey(true);
                            Console.Clear();
                        }   
						else if(opc2==2)
                        {
                            Bus_nom(afi,n);
						    Console.ReadKey(true);
							Console.Clear();
                        }
						else if(opc2==3)
                        {
                            Bus_ape(afi,n);
						    Console.ReadKey(true);
							Console.Clear();
                        }
						else if(opc2==4)
                        {
                            Bus_edad(afi,n);
							Console.ReadKey(true);
							Console.Clear();
                        }
                    }while(opc2!=5);
            }while(opc!=5);
        }
    }
}
