
class @class
{
    static void Main(string[] args)
    {
        try
        {
            bool @bool = true;

            if (@bool)
                System.Console.WriteLine("cierto");
            else
                System.Console.WriteLine("falso");
        }
        catch (System.Exception exc)
        {
            System.Console.WriteLine(exc);
        }
        finally
        {
            System.Console.ReadKey(true);
        }
    }
}