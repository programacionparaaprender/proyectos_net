
// statements_goto_switch.cs
using System;
public class SwitchTest
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Coffee sizes: 1=Small 2=Medium 3=Large");
            Console.Write("Please enter your selection: ");
            string s = Console.ReadLine();
            int n = int.Parse(s);
            //int n = 1;
            int cost = 0;
            switch (n)
            {
                case 1:
                    cost += 25;
                    break;
                case 2:
                    cost += 25;
                    goto case 1;
                case 3:
                    cost += 50;
                    goto case 1;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
            if (cost != 0)
            {
                Console.WriteLine("Please insert {0} cents.", cost);
            }
            Console.WriteLine("Thank you for your business.");
        }
        catch (Exception exc)
        {
            Console.WriteLine("error\n"+exc);
        }
        finally
        {

            Console.ReadKey(true);
        }
    }
}