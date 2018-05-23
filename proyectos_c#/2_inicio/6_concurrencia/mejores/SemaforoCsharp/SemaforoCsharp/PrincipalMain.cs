using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SemaforoCsharp
{
    public class PrincipalMain
    {
        private static Semaphore _pool;
        private static int _padding;

        public static void Main()
        {
            System.Threading.Monitor a;
            _pool = new Semaphore(0, 3);

            // Create and start five numbered threads. 
            //
            for (int i = 1; i <= 5; i++)
            {
                Thread t = new Thread(new ParameterizedThreadStart(Worker));

                // Start the thread, passing the number.
                //
                t.Start(i);
            }
            Thread.Sleep(500);

            Console.WriteLine("Main thread calls Release(3).");
            _pool.Release(3);

            Console.WriteLine("Main thread exits.");
            Console.ReadKey(true);
        }

        private static void Worker(object num)
        {
            // Each worker thread begins by requesting the
            // semaphore.
            Console.WriteLine("Thread {0} begins " +
                "and waits for the semaphore.", num);
            _pool.WaitOne();

            // A padding interval to make the output more orderly.
            int padding = Interlocked.Add(ref _padding, 100);

            Console.WriteLine("Thread {0} enters the semaphore.", num);

            Thread.Sleep(1000 + padding);

            Console.WriteLine("Thread {0} releases the semaphore.", num);
            Console.WriteLine("Thread {0} previous semaphore count: {1}",
                num, _pool.Release());
        }
    }
}
