using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFDCsharp
{

    class Vertice
    {
        //parte del vertice
        Vertice[] Arco; 
        char nombre;
        Vertice proximo;
        int c_elementos;

        //parte del arco
        Vertice Ver;
        int numero;
        int accion;
        char simbolo;

        public Vertice()
        {
            //parte del vertice
            this.Arco = new Vertice[6];
            this.nombre = 'a';
            this.proximo = null;
            this.c_elementos = 0;

            //parte del arco
            this.Ver = null;
            this.numero = 0;
        } 
  
        //para vertice
        public Vertice(char nombre)
        {
            this.Arco = new Vertice[6];
            this.nombre = nombre;
            this.proximo = null;
        }   

        public void setArco(Vertice Arco,int numero)
        {
            if(c_elementos<6)
            {
                this.Arco[numero] = Arco;
                c_elementos++;
            }
            else
                Console.WriteLine("ya estan usandose todos los arcos");
        }   
    
        public Vertice getArco(int numero)
        {
            return this.Arco[numero];
        }
    
        public char getNombre()
        {
            return this.nombre;
        }

        public void setNombre(char nombre)
        {
            this.nombre = nombre;
        }

        public Vertice getProximo()
        {
            return this.proximo;
        }

        public void setProximo(Vertice proximo)
        {
            this.proximo = proximo;
        }

        //para el arco
        public Vertice(Vertice Ver,int numero,int accion,char simbolo)
        {
            this.Ver = Ver;
            this.numero = numero;
            this.accion = accion;
            this.simbolo = simbolo;
        }

        public char getSimbolo()
        {
            return this.simbolo;
        }

        public int getAccion()
        {
            return this.accion;
        }
    }

}
