using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.IO;
namespace ArchivoFibonacciCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private int[] burbuja(int[] a)
        {
            int cambio, aux;
            cambio = 1;
            while (cambio == 1)
            {
                cambio = 0;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        aux = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = aux;
                        cambio = 1;
                    }
                }
            }

            return a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] ves,ves1;
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.ShowDialog(null);
                int[] valores;
                ClaseArchivo archivo = new ClaseArchivo();
                ClaseFibonacci fibo = new ClaseFibonacci();

                valores=archivo.leerArchivo(open);
                StreamReader sr = new StreamReader(open.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();    

                valores = burbuja(valores);
                    //estadistica 1 y 2
                    
                    ves = fibo.veces(valores);
                    ves1 = fibo.veces1(valores);
                    this.Lienzo1.cs = new Point[valores.Length];
                    //this.Lienzo1.poligono = new Point[valores.Length+2];
                    this.Lienzo2.cs = new Point[valores.Length];
                    //this.Lienzo2.poligono = new Point[valores.Length+2];
                    for(int i = 0; i <valores.Length;i++)
                    {
                        this.Lienzo1.cs[i] = 
                                new Point(valores[i],(int)ves[i]);
                        this.Lienzo2.cs[i] = 
                                new Point(valores[i],(int)ves1[i]);
                    }
                    this.Lienzo1.setActivador(true);
                    this.Lienzo2.setActivador(true);
                    this.Lienzo2.maximo = 8500;
                    this.Lienzo2.divisor = 250;

                    this.Lienzo1.Refresh();
                    this.Lienzo2.Refresh();
                    //this.Lienzo1.Update();
                    //this.Lienzo2.Update();
                    /*
                    this.panel1.Invalidate();
                    this.panel2.Invalidate();
                    this.panel1.Refresh();
                    this.panel2.Refresh();
                    this.panel1.Update();
                    this.panel2.Update();
                     */
                /*
                    this.panel1.Paint += 
                        new System.Windows.Forms.PaintEventHandler(
                            this.panel1_Paint);
                    this.panel2.Paint += 
                        new System.Windows.Forms.PaintEventHandler(
                            this.panel2_Paint);
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Lienzo1.setActivador(false);
            this.Lienzo2.setActivador(false);
            /*
            this.panel1.Paint += null;
            this.panel2.Paint += null;
            this.panel1.Paint +=
                new System.Windows.Forms.PaintEventHandler(
                    this.panel1_Paint);
            this.panel2.Paint +=
                new System.Windows.Forms.PaintEventHandler(
                    this.panel2_Paint);
             */
            this.Lienzo1.Refresh();
            this.Lienzo2.Refresh();
        }
    }
}
