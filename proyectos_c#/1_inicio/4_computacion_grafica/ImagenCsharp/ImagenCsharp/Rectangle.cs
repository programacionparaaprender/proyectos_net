using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImagenCsharp
{
    public class Rectangle
    {
        public int x, y, width, height;
        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x; this.y = y; this.width = width; this.height = height;
        }
        public Rectangle() 
        {
        }
    }
}
