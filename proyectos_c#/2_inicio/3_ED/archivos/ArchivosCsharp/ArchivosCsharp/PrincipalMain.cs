using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Windows;

namespace ArchivosCsharp
{
    public class PrincipalMain
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                ArrayList s1 = new ArrayList();
                open.ShowDialog(null);
                StreamReader obj = 
                new StreamReader(
                    open.FileName
                );
               
                string sLine = "";
                //sLine = obj.ReadToEnd();
                string s = "";
                
                int elemento = 0;
       
                do
                {
                    s = ""+obj.Read();
                    s1.Add(s);
                } while (s!=null);
                obj.Close();

                int[] valores = new int[100];
                foreach (Object obj1 in s1)
                {
                    valores[elemento++] = int.Parse(obj1);
                }
                
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}

