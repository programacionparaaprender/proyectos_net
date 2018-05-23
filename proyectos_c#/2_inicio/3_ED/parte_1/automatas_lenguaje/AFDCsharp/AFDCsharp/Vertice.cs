using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFDCsharp
{
    class Vertice
    {
        //parte de vertice
        public char nombre;
        public Vertice sig;
        public Vertice ant;
        public Vertice izquierda;
        public Vertice derecha;
        
        //parte del arco
        public Vertice ver;
	    public int clave;

        public Vertice()
        {
        
            //parte de vertice
            this.nombre = 'l';
            this.sig = null;
            this.ant = null;
            this.izquierda = null;
            this.derecha = null;
        
            //parte del arco
            this.ver = null;
	        this.clave = 0;
        }
    }
}
