using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

/*
 * El siguiente ejemplo muestra cómo escribir en un archivo de forma 
 * asíncrona.
*/
namespace ArchivoAsincrono
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
