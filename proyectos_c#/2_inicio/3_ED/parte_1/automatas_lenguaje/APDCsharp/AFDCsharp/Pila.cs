using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFDCsharp
{
    class Pila
    {
        private int l;
        private const int MAX = 10;
        private Lista Lista1;
        private int cancelar;

        public Pila()
        {
            this.l = 0;
            this.Lista1 = new Lista();
            this.cancelar = 0;
        } 
  
        public bool vacio()
        {
            if(this.l<=0)
                return true;
            else
                return false;
        }

        public void insertar(char simbolo)
        {
            this.Lista1.insertar(new Nodo(simbolo));
            this.l++;
        }
        public char extraer()
        {
            if (this.cancelar == 0)
            {
                if (this.vacio())
                {
                    this.Lista1.eliminar();
                    this.cancelar = 1;
                    return 'z';
                }
                else
                {
                    this.l--;
                    Nodo nodo = this.Lista1.getUltimo();
                    this.Lista1.eliminar();
                    return nodo.getSimbolo();
                }
            }
            else
                return 'f';
        }

        public int getCancelar()
        {
            return this.cancelar;
        }

        
    }
}
