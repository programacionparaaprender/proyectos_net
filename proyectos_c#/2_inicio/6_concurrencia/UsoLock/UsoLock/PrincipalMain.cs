using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsoLock
{
    using System.Threading;

    public class PrincipalMain
    {
        //public static void RunMe()
        public void RunMe()
        {
            while(true)
                Console.WriteLine("RunMe called");
        }

        public static void Main(string[] args)
        {
            //RunMe();
            ///*
            PrincipalMain b = new PrincipalMain();
            Thread t = new Thread(b.RunMe);
            t.Start();
            //*/
            Console.ReadKey(true);
        }
    }
}
