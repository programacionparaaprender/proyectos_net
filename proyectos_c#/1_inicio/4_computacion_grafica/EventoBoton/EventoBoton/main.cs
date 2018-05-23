using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EventoBoton
{
    class PrincipalMain
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        public static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Pantalla1());

            Console.WriteLine("hola mundo");
            Console.ReadKey(true);
        }
    };
}