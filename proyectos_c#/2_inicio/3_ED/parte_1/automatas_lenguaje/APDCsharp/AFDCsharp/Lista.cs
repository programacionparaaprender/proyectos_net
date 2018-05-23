using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFDCsharp
{

    class Lista
    {
        private Nodo raiz;
        private Nodo ultimo;
        private int c_elementos;

        public Lista()
        {
            this.raiz = new Nodo();
            this.ultimo = raiz;
            this.c_elementos = 0;
        }
   
        public bool listaVacia()
        {
	        if(this.raiz.getSimbolo()=='z')
                return true;
            else
                return false;
        }

        public Lista(Nodo nodo)
        {
	        this.raiz = nodo;
	        this.c_elementos = 0;
        }

        public void insertar(Nodo nodo)
        {
	        this.c_elementos++;
            this.ultimo.setProximo(nodo);
            nodo.setAntes(this.ultimo);
            this.ultimo = nodo;
        }

        public void eliminar()
        {
	        if(!this.listaVacia())
                {
                    ultimo = ultimo.getAntes();
                    ultimo.setProximo(null);
                }
            else
            {
                this.raiz = null;
                this.ultimo = null;
            }
        }

        public Nodo getUltimo()
        {
            return this.ultimo;
        }
    }

}
