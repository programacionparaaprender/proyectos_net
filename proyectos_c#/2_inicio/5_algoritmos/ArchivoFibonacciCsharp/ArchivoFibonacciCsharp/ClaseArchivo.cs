using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Windows;
using System.Windows.Forms;

namespace ArchivoFibonacciCsharp
{
    class ClaseArchivo
    {
        public ClaseArchivo()
        {
            
        }
        public int[] leerArchivo(OpenFileDialog open)
        {
            int[] valores = 
                new int[100];//cantidad de nros que lee
            int elementos = 0;
            try
            {
                StreamReader obj =
                    new StreamReader(open.FileName);
                String datos = obj.ReadToEnd();
                int contador = 0;
                for (int i = 0; datos[i] != '\0'; i++)
                {
                    //if (datos[i] == '\n')
                    if(datos[i]==' ')
                    {
                        valores[elementos++] =
                            int.Parse(
                            datos.Substring(contador,i-1)
                            );
                        contador = i + 1;
                    } 
                }
                    /*
                    int s = 0;
                    do
                    //while (s!=null)
                    {
                        s = obj.Read();
                        valores[elementos++] = s;

                    } while (!obj.EndOfStream);
                
                     */
                    obj.Close();

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
           
            if(elementos>1)
            {
                int[] mas = new int[elementos];
                for(int i = 0 ; i < elementos;i++)
                {
                    mas[i] = valores[i]; 
                }
                return mas;
            }
        
            return valores;
        }
    }
}
