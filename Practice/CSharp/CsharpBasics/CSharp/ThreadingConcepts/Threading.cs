using System;
using System.Threading;
using System.Diagnostics;

namespace CSharp.ThreadingConcepts
{
    public class ThreadingSetup
    {

        public void MainMethod()
        {
            /*
            var th = new Thread(ThreadMethod1);
            th.IsBackground = true;
            th.Start();
            Thread.Sleep(1500);
            Console.WriteLine("Main thread ({0}) exiting...", 
                                Thread.CurrentThread.ManagedThreadId); 
            Console.WriteLine($"The thread state is { th.ThreadState}");
            ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadMethod));
            ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadMethod2));
            Console.WriteLine("main thread does some work and then sleeps");
            Thread.Sleep(1000);
            */
            var th = new Thread(PrintY);
            th.Start();
            for(int i=0;i<10;i++)
            {
                //if(i==200)
                //Thread.Sleep(100);
                Console.Write('x');
            }
            
        }
        public void PrintY()
        {
             for(int i=0;i<10;i++)
                Console.Write('y');
        }
        public void ThreadMethod(object state)
        {
            Thread.Sleep(750);
            Console.WriteLine("Wonderbar  1 thread here");
             Console.WriteLine("Thread {0}: {1}, Priority {2}", 
                                Thread.CurrentThread.ManagedThreadId,
                                Thread.CurrentThread.ThreadState,
                                Thread.CurrentThread.Priority);
        }

public void ThreadMethod2(object state)
        {
            Thread.Sleep(750);
            Console.WriteLine("Wonderbar 2 thread here");
             Console.WriteLine("Thread {0}: {1}, Priority {2}", 
                                Thread.CurrentThread.ManagedThreadId,
                                Thread.CurrentThread.ThreadState,
                                Thread.CurrentThread.Priority);
        }


        public void ThreadMethod1()
        {
            DateTime start = DateTime.Now;
            var sw = Stopwatch.StartNew();
            Console.WriteLine("Thread {0}: {1}, Priority {2}", 
                                Thread.CurrentThread.ManagedThreadId,
                                Thread.CurrentThread.ThreadState,
                                Thread.CurrentThread.Priority);
            do { 
                Console.WriteLine("Thread {0}: Elapsed {1:N2} seconds", 
                                Thread.CurrentThread.ManagedThreadId,
                                sw.ElapsedMilliseconds / 1000.0);
                Thread.Sleep(500);
            } while (sw.ElapsedMilliseconds <= 5000);
            sw.Stop(); 
        }
        
    }
}