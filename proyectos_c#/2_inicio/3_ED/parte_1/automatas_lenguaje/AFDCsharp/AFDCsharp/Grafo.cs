using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFDCsharp
{
    class Grafo
    {
        private Vertice primero;
        private Vertice ultimo;
        private Vertice estadoInicial;
        private Vertice estadoFinal; 

        private char raw_input(string cadena)
        {
            Console.WriteLine(cadena);
            return char.Parse(Console.ReadLine());
        }

        private int input(string cadena)
        {
            Console.WriteLine(cadena);
            return int.Parse(Console.ReadLine());
        }

        public void estados()
        {
            if(this.primero!=null)
            {
                char inicial = raw_input("ingrese letra de  vertice inicial");
                char final = raw_input("ingrese letra de vertice final");

                while(!this.existe(inicial,this.primero))
                    inicial = raw_input("ingrese letra de  vertice inicial");
            
                while(!this.existe(final,this.primero))
                    final = raw_input("ingrese letra de vertice final");
            
                Vertice aux = this.primero;
                while(aux.nombre!=inicial)
                    aux = aux.sig;

                Vertice aux2 = this.primero;
                while(aux2.nombre!=final)
                    aux2 = aux2.sig;
                
                this.estadoInicial = aux;
                this.estadoFinal = aux2;
            }
            else
                Console.WriteLine("aun no existe ni un solo estado");
        }
  
        public void expresionRegular(string cadena)
        {
            if(this.estadoInicial != null && this.estadoFinal != null)
                busquedaRecursiva(this.estadoInicial,cadena,0,cadena.Length);
            else
                Console.WriteLine("no existen aun");
	    }

        private void busquedaRecursiva(Vertice primero,string cadena,int contador,int tamanio)
        {
	        if(contador<tamanio)
            {
                if(cadena[contador] == '1')
                {
		            primero = primero.derecha.ver;
                    busquedaRecursiva(primero,cadena,contador+1,tamanio);
                }
                else if(cadena[contador] == '0')
                {
		            primero = primero.izquierda.ver;
		            busquedaRecursiva(primero,cadena,contador+1,tamanio);
                }
            }
            else
            {
                if(primero==this.estadoFinal)
		            Console.WriteLine("cadena correcta ",primero.nombre);
                else
		            Console.WriteLine("error en cadena ",primero.nombre );
            }
        }
              
        private bool existe(char nod,Vertice pri)
        {
            Vertice aux = pri;
	        while(aux != null )
            {
                if (aux.nombre == nod)
		            return true;
                aux = aux.sig;
            }
	        return false;
        }

        public void crearVertice()
        {
	        Vertice nue = new Vertice();
	        nue.nombre = raw_input("Digite la letra del estado: ");

	        if (this.primero == null)
            {
                this.primero = nue;
                this.ultimo = this.primero;
            }
            else
            {
	
                while(existe(nue.nombre,this.primero))
		            nue.nombre = raw_input("Digite nuevamente la letra del estado: ");
		
                this.ultimo.sig = nue;
                nue.ant = this.ultimo;
                this.ultimo = nue;
            }       
	        raw_input("estado registrado correctamente.");
        }

        private Vertice optenerDireccion(char auxNod)
        {
            Vertice aux = this.primero;
            while(aux.nombre != auxNod)
                aux = aux.sig;
            return aux;
        }

        private Vertice nuevoArco(Vertice aux2)
        {
            Vertice nueArc = new Vertice();
            nueArc.ver = aux2;
            nueArc.clave = input("\nDigite el valor del enlace:(1/0) ");
            return nueArc;
        }

        public void enlazarVertices()
        {
	        char auxNod ='a';
            char auxNod2 = 'b';

	        if (this.primero != null)
            {
                Vertice auxw = this.primero;
                while(auxw != null)
                {
		            Console.WriteLine(auxw.nombre);
                    auxw = auxw.sig;
                }
                auxNod = raw_input("\nDigite la letra del estado al cual desea enlazar: ");

                while(!this.existe(auxNod,this.primero))
                    auxNod = raw_input("\nDigite la letra del estado al cual desea enlazar: ");
                    
                auxNod2 = raw_input("\nDigite la letra del estado a donde se dirige: ");

                while(!this.existe(auxNod2,this.primero))
                    auxNod2 = raw_input("\nDigite la letra del estado a donde se dirige: ");
  
                Vertice aux = optenerDireccion(auxNod);

                Vertice aux2 = optenerDireccion(auxNod2);

                //arco auxiliar 1 apunta al vertice
                Vertice nueArc = nuevoArco(aux2);
        
                while(nueArc.clave < 0)
                    nueArc.clave = input("\nDigite el valor del enlace:(1/0) ");

                if(nueArc.clave==0)
                {
                    if(aux.izquierda == null)
                    {
                        aux.izquierda = nueArc;
                        Console.WriteLine("\nEnlace creado correctamente.");
                    }
                    else
                        Console.WriteLine("arco ya utilizado");
                }
                else if(nueArc.clave==1)
                {
		
                    if(aux.derecha == null)
                    {
                        aux.derecha = nueArc;
                        Console.WriteLine("\nEnlace creado correctamente.");
                    }
                    else
                        Console.WriteLine("arco ya utilizado");
                }
            }
        }

        public void Mostrar()
        {
	        if(this.primero!=null && this.primero.izquierda!=null && this.primero.derecha!=null
            && this.estadoInicial != null && this.estadoFinal != null)
            {
                Console.WriteLine("alfabeto A = {0,1}");
                Console.WriteLine("S(->"+this.estadoInicial.nombre,")");
                Console.WriteLine("F=("+this.estadoFinal.nombre,")");
                Vertice aux = this.primero;
                while(aux!=null)
                {
		            Console.WriteLine("S(",aux.nombre,",0)=",aux.izquierda.ver.nombre);
		            Console.WriteLine("S(",aux.nombre,",1)=",aux.derecha.ver.nombre);
                    aux = aux.sig;
                }
            }
        else
            Console.WriteLine("automata aun no se ha creado");
        }

        public Grafo()
        {
            this.primero = null;
            this.estadoInicial = null; 
            this.estadoFinal = null;
            this.ultimo = null;
        }
    }

}
