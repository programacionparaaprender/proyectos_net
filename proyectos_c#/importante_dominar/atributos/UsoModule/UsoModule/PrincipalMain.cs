using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Reflection;
using System.ComponentModel;

namespace UsoModule
{
    public class PrincipalMain
    {
        // default: applies to method
        [SomeAttr]
        static int Method1() { return 0; }

        // applies to method
        [method: SomeAttr]
        static int Method2() { return 0; }

        // applies to return value
        [return: SomeAttr]
        static int Method3() { return 0; }

        public static void Main(string[] args)
        {
            Console.ReadKey(true);
        }
    }
}
