using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImagenCsharp
{
    public class Fondo:Rectangle
    {
        public System.Drawing.Image imagen;
        public Fondo(int x,int y, int width,int height,string fondo):
            base(x,y,width,height)
        {
            try
            {
                this.imagen = new System.Drawing.Image(fondo);
            }
            catch (Exception) 
            {
            }
        }
    }
}
