using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JuegoSnake
{
    public class Comida: Objeto
    {
        public Comida(int tamano): base(tamano){
            this.colocar();
        }
        public void colocar(){
            this.x = this.generarx();
            this.y = this.generary();
        }

        public void dibujar(Graphics g)
        {
            Pen bluePen = new Pen(Color.Blue, 3);
            g.DrawRectangle(bluePen, this.x, this.y, this.tamano, this.tamano);
        }
        public int generarx() {
            //entre 0 y 500
            //Size(369, 262)
            int tam = 369 / 10;
            Random random = new Random();
            int num = random.Next(0, tam) * 10;// Math.floor(Math.random() * tamx) * 10;
            return num;
        }
        public int generary(){
            //entre 0 y 500
            int tam = 262 / 10;
            Random random = new Random();
            int num = random.Next(0, tam) * 10;// Math.floor(Math.random() * tamx) * 10;
            return num;
        }
    }
}
