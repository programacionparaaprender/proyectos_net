using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * // 
 * this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(46, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(453, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 400);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
 *          
 *          this.Controls.Add(this.blimpiar);
            this.Controls.Add(this.bcalcular);
 */

namespace ArchivoFibonacciCsharp
{
    public class AreaDibujo
        : System.Windows.Forms.Panel
    {
        private int escala = 20;
        private bool activador = false;
        public System.Drawing.Point[] cs = new System.Drawing.Point[2];
        private System.Drawing.Point[] poligono;
        private int lpoligono;
        public void setActivador(bool sw)
        {
            this.activador = sw;
        }
        public AreaDibujo()
        {
            //Color color = new Color(rojo, verde, azul);
            System.Drawing.Color color = System.Drawing.Color.White;
            //this.setBackground(color);
           //falta ponerle color
            //this.setSize(900, 300);
        }
    
        private int met = 0;
        private int multiplicador = 10;
        private int multiplicadorx = 10;
        public long divisor = 5000000;
        public long maximo = 170000000;
        public void metodoRecursivo(System.Drawing.Graphics g)
        {
            if(this.met<this.cs.Length)
            {
                g.FillEllipse(
                        new System.Drawing.SolidBrush(System.Drawing.Color.Red),
                        new System.Drawing.Rectangle(this.escala+cs[this.met].X * this.multiplicadorx,
                        (int)((380 - cs[this.met].Y * this.multiplicador)/divisor),
                        5, 5));
                this.poligono[this.lpoligono++] = new System.Drawing.Point(
                    //poligono[this.lpoligono++] = new System.Drawing.Point(
                            this.escala + cs[this.met].X * this.multiplicadorx,
                            (int)((380 - cs[this.met++].Y*this.multiplicador)/divisor));

                metodoRecursivo(g);
            }
        }
        public void paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            this.lejeX = 0;
            this.lejeY = 0;
            this.met = 0;
            this.lpoligono = 0;
            this.poligono = new System.Drawing.Point[this.cs.Length+2];
            //comienza cambio
   
            e.Graphics.DrawLine(
                    new System.Drawing.Pen(System.Drawing.Color.Black, 1),
                    new System.Drawing.Point(20, 20),
                    new System.Drawing.Point(20, 380));
            e.Graphics.DrawLine(
                new System.Drawing.Pen(System.Drawing.Color.Black, 1),
                new System.Drawing.Point(20, 380),
                new System.Drawing.Point(380, 380));

            if (activador)
            {
                this.poligono[this.lpoligono++]= new System.Drawing.Point(20, 380);
                metodoRecursivo(e.Graphics);

                this.poligono[this.lpoligono++]=new System.Drawing.Point(this.escala +
                        cs[this.met - 1].X*this.multiplicadorx,
                        380);
                e.Graphics.FillPolygon(
                    new System.Drawing.Pen(System.Drawing.Color.Yellow).Brush,
                    this.poligono
                    );
                e.Graphics.DrawPolygon(
                    new System.Drawing.Pen(System.Drawing.Color.Black),
                    this.poligono
                    );
            }
            ejeX(e.Graphics, 20 + this.escala, 380, 370, 0);
            ejeY(e.Graphics, 20 + this.escala, 20, 30, maximo);
        }
    
    
        private int lejeX = 0;
        private void ejeX(System.Drawing.Graphics g,int x,
            int paraY1,int  paraY2,
            int i) 
        {
        
            if(lejeX<19)
            {
                //cambio
                //comenzamos con las medidas eje x
                g.DrawLine(
                    new System.Drawing.Pen(System.Drawing.Color.Black, 1),
                    new System.Drawing.Point(x, paraY1),
                    new System.Drawing.Point(x, 20));
                g.DrawLine(
                    new System.Drawing.Pen(System.Drawing.Color.Black, 1),
                    new System.Drawing.Point(x, paraY1),
                    new System.Drawing.Point(x, paraY2));
                g.DrawString(""+(i += 2),
                    new System.Drawing.Font("Arial", 5),
                     new System.Drawing.SolidBrush(System.Drawing.Color.Black),
                     x, paraY1 + 10
                    //,drawFormat
                     );
                x+=this.escala;
                lejeX++;
                ejeX(g,x,paraY1,paraY2,i);
            }
        }
    
        private int lejeY = 0;
        private void ejeY(System.Drawing.Graphics g, int y, int paraX1,
            int paraX2,long i)
        {
        
            if(lejeY<18)
            {
                //comienzo
                g.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black, 1),
                new System.Drawing.Point(paraX1, y),
                new System.Drawing.Point(300, y));
                //comenzamos con las medidas eje y
                g.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black, 1),
                new System.Drawing.Point(paraX1, y),
                new System.Drawing.Point(paraX2, y));
                //g.drawString(""+i, 0, y);

                //StringFormat drawFormat = new StringFormat();
                //drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;

                g.DrawString("" + i,
                    new System.Drawing.Font("Arial", 5),
                     new System.Drawing.SolidBrush(System.Drawing.Color.Black),
                     0, y
                    //,drawFormat
                     );

                y += this.escala;
                lejeY++;
                ejeY(g, y, paraX1, paraX2, i - maximo / 17);
            }
        } 
    }
}
