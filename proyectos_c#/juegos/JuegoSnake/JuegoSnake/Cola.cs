using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JuegoSnake
{
    public class Cola : Objeto
    {
        private Cola siguiente;
        public Cola(int tamano, int x, int y):base(tamano, x, y)
        {
            this.siguiente = null;
        }

        public void setxy(int x, int y)
        {
            if (this.siguiente != null)
            {
                this.siguiente.setxy(this.x, this.y);
            }
            this.x = x;
            this.y = y;
        }
        public int verX()
        {
            return this.x;
        }
        public int verY()
        {
            return this.y;
        }
        public void meter()
        {
            if (this.siguiente == null)
            {
                this.siguiente = new Cola(this.tamano, this.x, this.y);
            }
            else
            {
                this.siguiente.meter();
            }
        }

        public Boolean colisiona(Objeto obj)
        {
            if (this.interseccion(obj))
            {
                return true;
            }
            else if (this.siguiente != null)
            {
                return this.siguiente.colisiona(obj);
            }
            else
            {
                return false;
            }
        }

        public Boolean revision()
        {
            if (this.siguiente != null)
            {
                return this.siguiente.colisiona(this);
            }
            else
            {
                return false;
            }
        }
        public void dibujar(Graphics g)
        {
            if (this.siguiente != null)
            {
                this.siguiente.dibujar(g);
            }
            g.FillRectangle(new SolidBrush(Color.Blue), this.x, this.y, this.tamano, this.tamano);
        }
    }
}
