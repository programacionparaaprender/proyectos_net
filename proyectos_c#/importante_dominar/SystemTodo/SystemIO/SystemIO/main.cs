
using System;
using System.IO;
using System.Text;

public class Test
{

    public static void Main(string[] args)
    {
        string path = "luis.txt";

        // elimina el archivo si existe 
        if (File.Exists(path))
            File.Delete(path);
        

        //crea el archivo  

        using (FileStream fs = File.Create(path))
        {
            AddText(fs, "Hola a todos\n");
            AddText(fs, "son parte de la demostracion\n");
            AddText(fs, "de un programa de archivos en c#\n");
            AddText(fs, "hecho por luis correa");

            //for (int i = 1; i < 120; i++)
            //    AddText(fs, Convert.ToChar(i).ToString());

        }

        //Open the stream and read it back. 
        using (FileStream fs = File.OpenRead(path))
        {
            byte[] b = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding(true);
            while (fs.Read(b, 0, b.Length) > 0)
            {
                Console.WriteLine(temp.GetString(b));
            }
        }
        Console.ReadKey(true);
    }

    private static void AddText(FileStream fs, string value)
    {
        byte[] info = new UTF8Encoding(true).GetBytes(value);
        fs.Write(info, 0, info.Length);
    }
}