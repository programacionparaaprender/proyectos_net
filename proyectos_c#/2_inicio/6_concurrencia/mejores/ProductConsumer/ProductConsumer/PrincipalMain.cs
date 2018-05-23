using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductConsumer
{
    using System;
    using System.Threading;
    using System.Collections;
    using System.Collections.Generic;

    public class SyncEvents
    {
        public SyncEvents()
        {

            _newItemEvent = new AutoResetEvent(false);
            _exitThreadEvent = new ManualResetEvent(false);
            _eventArray = new WaitHandle[2];
            _eventArray[0] = _newItemEvent;
            _eventArray[1] = _exitThreadEvent;
        }

        public EventWaitHandle ExitThreadEvent
        {
            get { return _exitThreadEvent; }
        }
        public EventWaitHandle NewItemEvent
        {
            get { return _newItemEvent; }
        }
        public WaitHandle[] EventArray
        {
            get { return _eventArray; }
        }

        private EventWaitHandle _newItemEvent;
        private EventWaitHandle _exitThreadEvent;
        private WaitHandle[] _eventArray;
    }
    public class Producer
    {
        public Producer(Queue<int> q, SyncEvents e)
        {
            _queue = q;
            _syncEvents = e;
        }
        // Producer.ThreadRun
        public void ThreadRun()
        {
            int count = 0;
            Random r = new Random();
            while (!_syncEvents.ExitThreadEvent.WaitOne(0, false))
            {
                lock (((ICollection)_queue).SyncRoot)
                {
                    while (_queue.Count < 20)
                    {
                        _queue.Enqueue(r.Next(0, 100));
                        _syncEvents.NewItemEvent.Set();
                        count++;
                    }
                }
            }
            Console.WriteLine("Producer thread: produced {0} items", count);
        }
        private Queue<int> _queue;
        private SyncEvents _syncEvents;
    }

    public class Consumer
    {
        public Consumer(Queue<int> q, SyncEvents e)
        {
            _queue = q;
            _syncEvents = e;
        }
        // Consumer.ThreadRun
        public void ThreadRun()
        {
            int count = 0;
            while (WaitHandle.WaitAny(_syncEvents.EventArray) != 1)
            {
                lock (((ICollection)_queue).SyncRoot)
                {
                    int item = _queue.Dequeue();
                }
                count++;
            }
            Console.WriteLine("Consumer Thread: consumed {0} items", count);
        }
        private Queue<int> _queue;
        private SyncEvents _syncEvents;
    }

    public class PrincipalMain
    {
        private static void ShowQueueContents(Queue<int> q)
        {
            lock (((ICollection)q).SyncRoot)
            {
                foreach (int item in q)
                {
                    Console.Write("{0} ", item);
                }
            }
            Console.WriteLine();
        }

        public static void Main()
        {
            Queue<int> queue = new Queue<int>();
            SyncEvents syncEvents = new SyncEvents();

            Console.WriteLine("Configurando los hilos...");
            Producer producer = new Producer(queue, syncEvents);
            Consumer consumer = new Consumer(queue, syncEvents);
            Thread producerThread = new Thread(producer.ThreadRun);
            Thread consumerThread = new Thread(consumer.ThreadRun);

            Console.WriteLine("Inician productor consumidor");
            producerThread.Start();
            consumerThread.Start();

            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(2500);
                ShowQueueContents(queue);
            }
            Console.WriteLine("señal de final de hilo...");
            syncEvents.ExitThreadEvent.Set();
            producerThread.Join();
            consumerThread.Join();
            Console.ReadKey(true);
        }

    }
}
