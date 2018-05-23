using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraCsharp
{
    class Nodo
    {
        private int clave;
        private Nodo antes, siguiente;
        public Nodo(int clave)
        {
            this.clave = clave;
            this.antes = null;
            this.siguiente = null;
        }
        public void setAntes(Nodo antes)
        {
            this.antes = antes;
        }
        public Nodo getAntes()
        {
            return this.antes;
        }
        public void setSiguiente(Nodo siguiente)
        {
            this.siguiente = siguiente;
        }
        public Nodo getSiguiente()
        {
            return this.siguiente;
        }
        public void setClave(int clave)
        {
            this.clave = clave;
        }
        public int getClave()
        {
            return this.clave;
        }
    }
}
