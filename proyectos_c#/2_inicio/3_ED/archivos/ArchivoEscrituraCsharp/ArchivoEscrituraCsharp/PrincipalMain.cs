using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace ArchivoEscrituraCsharp
{
    public class PrincipalMain
    {
        public static void Main()
        {
            try
            {
                //Open the File
                StreamWriter sw = new StreamWriter("C:\\Test1.txt", true, Encoding.ASCII);

                //Writeout the numbers 1 to 10 on the same line.
                for (int x = 0; x < 10; x++)
                {
                    sw.Write(x);
                }

                //close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
                Console.ReadKey(true);
            }
        }
    }
}
