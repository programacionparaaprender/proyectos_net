// statements_checked.cs
using System;

public class OverFlowTest
{
    static short x = 32767;   // Max short value
    static short y = 32767;

    // Using a checked expression 
    public static int CheckedMethod()
    {
        int z = 0;
        try
        {
            z = checked((short)(x + y));
        }
        catch (System.OverflowException e)
        {
            Console.WriteLine(e.ToString());
        }
        return z;
    }

    public static void Main()
    {
        Console.WriteLine("Checked output value is: {0}",
                     CheckedMethod());
        Console.ReadKey(true);
    }
}