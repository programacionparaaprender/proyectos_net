
using System;
using System.IO;
using System.Net;
//Código común a las distintas operaciones

public class PrincipalMain
{
    const string server = "ftp://localhost/host";
    FtpStatusCode://local
    static NetworkCredential credentials = new NetworkCredential("ftpuser", "ftppw");

    const string document = "Documento.pdf";
    static string uploads = 
        Environment.CurrentDirectory + @"\Subidas\";
    static string downloads = 
        Environment.CurrentDirectory + @"\Descargas\";

    public static void Main(string[] args)
    {
        UploadFile();
        ListDirectory();
        DownloadFile();
        DeleteFile();
    }
    //subida de archivo
    public static void UploadFile()
    {
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(server + document);
        request.Credentials = credentials;
        request.Method = WebRequestMethods.Ftp.UploadFile;

        byte[] content = File.ReadAllBytes(uploads + document);

        request.ContentLength = content.Length;

        Stream stream = request.GetRequestStream();
        stream.Write(content, 0, content.Length);
        stream.Close();
    }
    //listado de contenido de directorio
    public static void ListDirectory()
    {
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(server);
        request.Credentials = credentials;
        request.Method = WebRequestMethods.Ftp.ListDirectory;

        using (StreamReader reader = new StreamReader(((FtpWebResponse)request.GetResponse()).GetResponseStream()))
        {
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
        }

        Console.Read();
    }
    //descarga de archivo
    public static void DownloadFile()
    {
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(server + document);
        request.Credentials = credentials;
        request.Method = WebRequestMethods.Ftp.DownloadFile;

        using (MemoryStream stream = new MemoryStream())
        {
            ((FtpWebResponse)request.GetResponse()).GetResponseStream().CopyTo(stream);
            File.WriteAllBytes(downloads + document, stream.ToArray());
        }
    }
    //borrado de archivo
    public static void DeleteFile()
    {
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(server + document);
        request.Credentials = credentials;
        request.Method = WebRequestMethods.Ftp.DeleteFile;

        request.GetResponse();
    }

}