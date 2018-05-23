using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoSnake
{
    public partial class Form1 : Form
    {
        private Cola cabeza;
        private Comida comida;
        private Pantalla pantalla;
        private Graphics g;
        private int tamano;
        public Form1()
        {
            InitializeComponent();
            this.tamano = 10;
            cabeza = new Cola(10, 10, 10);
            comida = new Comida(this.tamano);
            pantalla = new Pantalla();
            g = canvas.CreateGraphics();
        }
        Boolean ejex = true;
        Boolean ejey = true;
        int xdir = 0;
        int ydir = 0;

        public void movimiento()
        {
            var nx = cabeza.verX() + xdir;
            var ny = cabeza.verY() + ydir;
            cabeza.setxy(nx, ny);
            
            if (cabeza.colisiona(comida))
            {
                comida.colocar();
                cabeza.meter();
            }

            if (cabeza.revision())
            {
                //console.log("toco");
            }
            if (xdir != 0)
            {
                pantalla.mantenerx(cabeza);
            }
            if (ydir != 0)
            {
                pantalla.mantenery(cabeza);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bucle_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            this.movimiento();
            cabeza.dibujar(g);
            comida.dibujar(g);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys cod = e.KeyCode;
	        if(ejex){
                switch (cod)
                {
                    case Keys.Left:
                        xdir = -tamano;
                        ydir = 0;
                        ejex = false;
                        ejey = true;
                        break;
                    case Keys.Right:
                        xdir = tamano;
                        ydir = 0;
                        ejex = false;
                        ejey = true;
                        break;
                    default:
                        break;
                }
            }
	        if(ejey){
                    switch (cod)
                    {
                        case Keys.Up:
                            ydir = -tamano;
                            xdir = 0;
                            ejey = false;
                            ejex = true;
                            break;
                        case Keys.Down:
                            ydir = tamano;
                            xdir = 0;
                            ejey = false;
                            ejex = true;
                            break;
                        default:
                            break;
                    }
                }
        }
    }
}
