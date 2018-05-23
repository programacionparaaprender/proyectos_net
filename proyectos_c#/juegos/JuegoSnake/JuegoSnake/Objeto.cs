using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoSnake
{
    public class Objeto
    {
        public int x, y;
        public int tamano;
        public Objeto(int tamano, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.tamano = tamano;
        }
        public Objeto(int tamano)
        {
            this.x = 0;
            this.y = 0;
            this.tamano = tamano;
        }
        public Boolean interseccion(Objeto obj)
        {
            var difx = Math.Abs(this.x - obj.x);
            var dify = Math.Abs(this.y - obj.y);
            if (difx >= 0 && difx < tamano && dify >= 0 && dify < tamano)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
