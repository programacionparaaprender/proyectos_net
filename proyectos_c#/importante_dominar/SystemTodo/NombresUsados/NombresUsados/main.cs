/*
Dado la amplitud de la BCL, ha sido necesario organizar las clases en 
ella incluida en espacios de nombres que agrupen clases con funcionalidades 
similares. Por ejemplo, los espacios de nombres más usados son:
 * 
Espacio de nombres Utilidad de los tipos de datos que contiene
 * 
System Tipos muy frecuentemente usados, como los los tipos
básicos, tablas, excepciones, fechas, números aleatorios,
recolector de basura, entrada/salida en consola, etc.
 * 
System.Collections Colecciones de datos de uso común como pilas, colas,
listas, diccionarios, etc.
 * 
System.Data Manipulación de bases de datos. Forman la denominada
arquitectura ADO.NET.
 * 
System.IO Manipulación de ficheros y otros flujos de datos.
 * 
System.Net Realización de comunicaciones en red.
 * 
System.Reflection Acceso a los metadatos que acompañan a los módulos de
código.
 * 
System.Runtime.Remoting Acceso a objetos remotos.
 * 
System.Security Acceso a la política de seguridad en que se basa el CLR.
 * 
System.Threading Manipulación de hilos.
 * 
System.Web.UI.WebControls Creación de interfaces de usuario basadas en ventanas
para aplicaciones Web.
 * 
System.Winforms Creación de interfaces de usuario basadas en ventanas
para aplicaciones estándar.
 * 
System.XML Acceso a datos en formato XML.
Tabla 3: Espacios de nombres de la BCL más usados
*/

using System;

public class PrincipalMain
{
    public static void Main(string[] args)
    {
        try
        {
            int a = Console.Read();
        }
        catch (Exception exc)
        {
            Console.WriteLine("error");
            
        }
        finally
        {
            Console.ReadKey(true);
        }
 
    }
}