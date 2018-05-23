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
        private Vertice estadoInicio;
        private Vertice estadoFinal;
        private Pila Pila1;

        public Grafo()
        {
            this.primero = null;
            this.ultimo = null;
            this.estadoInicio = null;
            this.estadoFinal = null;
            this.Pila1 = new Pila();
        }

        public bool existe(Vertice aux,char nombre)
        {
            while(aux!=null)
            {
                if(aux.getNombre()==nombre)
                    return true;
                aux = aux.getProximo();
            }
            return false;
        }
        
        public void crearEstado()
        {
            if(this.primero==null)
            {
                Console.WriteLine("ingrese letra de primer estado");
                this.primero = new Vertice(char.Parse(Console.ReadLine()));
                this.ultimo = this.primero;
            }
            else
            {
                Console.WriteLine("ingrese letra del estado");
                Vertice nuevo = new Vertice(char.Parse(Console.ReadLine()));
            
                while(this.existe(this.primero,nuevo.getNombre()))
                { 
                    Console.WriteLine("ingrese letra de estado");
                    nuevo.setNombre(char.Parse(Console.ReadLine()));
                }
                this.ultimo.setProximo(nuevo);
                this.ultimo = nuevo;
            }
            Console.ReadKey(true);
        }
    
        public Vertice busqueda(Vertice aux,char nombre)
        {
            while(aux!=null)
            {
                if(aux.getNombre()==nombre)
                    return aux;
                aux = aux.getProximo();
            }
            return null;
        }
    
        public void establecerIF()
        {
            if(this.primero!=null)
            {
                Console.WriteLine("ingrese letra de estado inicio");
                char inicio = char.Parse(Console.ReadLine());

                while(!this.existe(this.primero,inicio))
                { 
                    Console.WriteLine("ingrese letra de estado inicio");
                    inicio = char.Parse(Console.ReadLine());
                }   
                Console.WriteLine("ingrese letra de estado final");
                char final = char.Parse(Console.ReadLine());
            
                while(!this.existe(this.primero,final))
                {
                    Console.WriteLine("ingrese letra de estado final");
                    final = char.Parse(Console.ReadLine());
                }
                this.estadoInicio = busqueda(this.primero,inicio);
                this.estadoFinal = busqueda(this.primero,final);
            }
            else
            {
                Console.WriteLine("no existe ni un solo estado");
                Console.ReadKey(true);
            }
        } 
  
        public void enlazarEstados()
        {
            if(this.primero!=null)
            {
                Console.WriteLine("ingrese letra de primer estado");
                char inicio = char.Parse(Console.ReadLine());
            
                while(!this.existe(this.primero,inicio))
                {
                    Console.WriteLine("ingrese letra de primer estado");
                    inicio = char.Parse(Console.ReadLine());
                }
                Console.WriteLine("ingrese letra de primer estado");
                char final = char.Parse(Console.ReadLine());
            
                while(!this.existe(this.primero,final))
                {
                    Console.WriteLine("ingrese letra de primer estado");
                    final = char.Parse(Console.ReadLine());
                }
                Console.WriteLine("digite el numero del enlace (1/0):");
                int enlace = Console.Read();
            
                while(enlace!=1 && enlace!=0)
                {
                    Console.WriteLine("digite el numero del enlace (1/0):");
                    enlace = Console.Read();
                }

                Console.WriteLine("apilar o desapilar (1/0)");
                int accion = Console.Read();
            
                while(accion!=1 && accion!=0)
                {
                    Console.WriteLine("apilar o desapilar (1/0)");
                    accion = Console.Read();
                }
                Console.WriteLine("que simbolo estara en la sima(z,a o b)");
                char simbolo = char.Parse(Console.ReadLine());
            
                while(simbolo!='z' && simbolo!='a' && simbolo!='b')
                {
                    Console.WriteLine("que simbolo estara en la sima(z,a o b)");
                    simbolo = char.Parse(Console.ReadLine());
                }
                Vertice aux1 = busqueda(this.primero,inicio);
                Vertice aux2 = busqueda(this.primero,final);
        
                //antes abajo estaba aux sin el 1
                if( !enlaceExiste(accion,simbolo,aux1))
                {
                    if((accion == 0) && (simbolo == 'a'))
                        aux1.setArco(new Vertice(aux2,enlace,accion,simbolo),0);

                    else if ((accion == 0) && (simbolo == 'b'))
                        aux1.setArco(new Vertice(aux2,enlace,accion,simbolo),1);

                    else if ((accion == 1) && (simbolo == 'a'))
                        aux1.setArco(new Vertice(aux2,enlace,accion,simbolo),2);

                    else if ((accion == 1) && (simbolo == 'b'))
                        aux1.setArco(new Vertice(aux2,enlace,accion,simbolo),3);
                    //para 'z'    

                    else if ((accion == 0) && (simbolo == 'z'))
                        aux1.setArco(new Vertice(aux2,enlace,accion,simbolo),4);

                    else if ((accion == 1) && (simbolo == 'z'))
                        aux1.setArco(new Vertice(aux2,enlace,accion,simbolo),5);
                    
                    Console.WriteLine("enlace creado correctamente");
                    Console.ReadKey(true);
                }
                else
                    Console.WriteLine("ya existe ese arco");  
            }
         
            
            else
                Console.WriteLine("no existe ni un solo estado");
        } 

        public bool enlaceExiste(int accion,char simbolo,Vertice aux)
        {
            while(aux!=null)
            {
                int l = 0;
                while(l<6)
                    if (aux.getArco(l).getAccion() == accion && aux.getArco(l).getSimbolo() == simbolo)
                        return true;
                l++;
                aux = aux.getProximo();
            }
            return false;
        }

        public void retorna(int numero)
        {
            if(numero == 0)
                Console.WriteLine("desapilar");
            else if(numero == 1)
                Console.WriteLine("apilar");

        }
        /*
        public void mostrarEstados()
        {
            if (this.primero != null && estadoInicio != null && estadoFinal != null)
            {
                Vertice aux = this.primero;
                Console.WriteLine("alfabeto (0,1)");
                Console.WriteLine("simbolos de pila a y b");
                Console.WriteLine("estado inicial " + estadoInicio.getNombre());
                Console.WriteLine("estado final " + estadoFinal.getNombre());
                Console.WriteLine("estados de automata de pila");
                while (aux != null)
                {
                    int l = 0;
                    while (l < 6)
                    {
                        Console.WriteLine("S(" + aux.getNombre + "," + aux.getArco().simbolo +
                        "," + aux.getArco().numero + ")=(" + aux.getArco().Ver.getNombre() +
                        ",", aux);
                        l++;
                    }
                    aux = aux.getProximo();
                }
                Console.WriteLine("pulse una tecla para continuar");
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("le falta ingresar datos");
                Console.ReadKey(true);
            }
        }
         */
    }
}

