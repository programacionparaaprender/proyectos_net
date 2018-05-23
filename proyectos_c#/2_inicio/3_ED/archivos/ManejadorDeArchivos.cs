using System;
using System.IO;

namespace CSharp.Utilidades
{
    public class ManejadorDeArchivos
    {

        private static ManejadorDeArchivos _instance;
        public static ManejadorDeArchivos Instance
        {
            get
            {
                return _instance ?? (_instance = new ManejadorDeArchivos());
            }
        }

        public bool GuardarArchivo(String ubicacion, String cadena)
        {
            return GuardarArchivo(new FileStream(ubicacion, FileMode.Create), cadena);
        }

        public bool GuardarArchivo(FileStream file,String cadena){
            var info = new System.Text.UTF8Encoding(true).GetBytes(cadena);
            try{
                file.Write(info, 0, info.Length);
                file.Close();
                return true;
            }catch(Exception e){
                Console.WriteLine(e.Data);
            }
            return false;
        }

        public String CargarArchivo(String ubicacion)
        {
            return CargarArchivo(new StreamReader(ubicacion));
        }

        public String CargarArchivo(FileStream file)
        {
            return CargarArchivo(new StreamReader(file));
        }

        public String CargarArchivo(StreamReader file){
            try
            {
                return file.ReadToEnd();
            } catch (IOException ex) {
                Console.WriteLine(ex.Data);
                return null;
            } 
        } 

    }
}
