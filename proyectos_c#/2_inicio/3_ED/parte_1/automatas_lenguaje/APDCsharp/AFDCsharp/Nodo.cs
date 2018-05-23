using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFDCsharp
{

    class Nodo
    {
        private Nodo proximo;
        private Nodo antes;
        private char simbolo;

        public Nodo()
        {
            this.proximo = null;
            this.antes = null;
            this.simbolo = 'z';
        }

        public Nodo(char simbolo)
        {
            this.proximo = null;
            this.antes = null;
            this.simbolo = simbolo;
        }

        public void setProximo(Nodo proximo)
        {
            this.proximo = proximo;
        }

        public Nodo getProximo()
        {
            return this.proximo;
        }

        public void setAntes(Nodo antes)
        {
            this.antes = antes;
        }

        public Nodo getAntes()
        {
            return this.antes;
        }

        public void setSimbolo(char simbolo)
        {
            this.simbolo = simbolo;
        }

        public char getSimbolo()
        {
            return this.simbolo;
        }
    }
}
