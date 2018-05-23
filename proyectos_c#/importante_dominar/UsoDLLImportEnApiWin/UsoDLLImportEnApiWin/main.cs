
using System;

public class PrincipalMain
{
    //[DllImport("version.dll")]
    public static extern bool GetFileVersionInfo(string sFileName,
    int handle, int size, byte[] infoBuffer);

    public static void Main(string[] args)
    {

        Console.ReadKey(true);
    }
}