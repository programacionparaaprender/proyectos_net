using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoSnake
{
    public class Pantalla
    {
        private int x, y, height, width, tamano;
        public Pantalla()
        {
            ////Size(369, 262)
            this.x = 0;
            this.y = 0;
            this.height = 262;
            this.width = 369;
            this.tamano = 10;
        }
        public void mantenerx(Cola snake)
            {
                if (snake.verX() < 0)
                {
                    snake.x = this.width - tamano;
                }
                else if (snake.verX() > this.width - tamano)
                {
                    snake.x = 0;
                }
            }

        public void mantenery(Cola snake)
            {
                if (snake.verY() < 0)
                {
                    snake.y = this.height - tamano;
                }
                else if (snake.verY() > this.height - tamano)
                {
                    snake.y = 0;
                }
            }
    }
}
