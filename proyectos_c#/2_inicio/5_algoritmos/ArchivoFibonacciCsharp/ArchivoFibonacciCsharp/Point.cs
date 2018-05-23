using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArchivoFibonacciCsharp
{
    public class Point
    {
        public int x, y;
        public Point()
        {
            this.x = 0; this.y = 0;
        }
        public Point(double x, double y)
        {
            this.x = x; this.y = y;
        }
    }
}
