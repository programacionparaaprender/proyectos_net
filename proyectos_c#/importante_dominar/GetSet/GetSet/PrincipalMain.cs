using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetSet
{
    public class B
    {
        private int month;  //"backing store"

        public B()
        {
 
        }

        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                month = value;
            }
        }
    }

    public class PrincipalMain
    {
        public static void Main(string[] args)
        {
            B B1 = new B();
            //increible
            B1.Month = 20;

            Console.WriteLine(B1.Month);
            Console.ReadKey(true);
        }
    }
}
