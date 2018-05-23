using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sincronizacion
{
    public class ThreadingExample
    {
        private static AutoResetEvent autoEvent;

        private static void DoWork()
        {
            Console.WriteLine("   worker thread started, now waiting on event...");
            autoEvent.WaitOne();
            Console.WriteLine("continuo pedazo de codigo");
            Console.WriteLine("   worker thread reactivated, now exiting...");
        }
        public static void Main(string[] args)
        {
            try
            {
                autoEvent = new AutoResetEvent(false);

                Console.WriteLine("main thread starting worker thread...");

                Thread t = new Thread(DoWork);
                t.Start();

                Console.WriteLine("main thrad sleeping for 1 second...");

                Thread.Sleep(1000);

                Console.WriteLine("main thread signaling worker thread...");

                autoEvent.Set();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
            finally
            {
                Console.ReadKey(true);
            }
        }
    }
}
