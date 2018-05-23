using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImagenCsharp
{
    public class Bob: Rectangle
    {
        public string[] bob;
        public Bob(int x,int y,int width,int height,string[] bob):
            base(x,y,width,height)
        {
            this.bob = bob;
        }
    }
}
