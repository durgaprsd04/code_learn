using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
namespace CSharp.ThreadingConcepts
{
    public class AutoResetExample
    {
        private AutoResetEvent event_1 = new AutoResetEvent(false);
        private AutoResetEvent event_2 = new AutoResetEvent(false);
        public void Even()
        {
            Thread.CurrentThread.Name="EvenThread";
            for(int i=0;i<=10;i=i+2)
            {
                Console.WriteLine($"{i} printed using {Thread.CurrentThread.Name}");
                event_2.WaitOne();
            }
        }
        public void Odd()
        {
            Thread.CurrentThread.Name="OddThread";
            for(int i=1;i<10;i=i+2)
            {
                Console.WriteLine($"{i} printed using {Thread.CurrentThread.Name}");
                event_1.WaitOne();
            }
        }
        public void Main1()
        {
            var odd = new Thread(Odd);
            var even = new Thread(Even);
            even.Start();
            odd.Start();
            Thread.Sleep(250);
            for(int i=0;i<6;i++)
            {                
                //Console.WriteLine("Waiting for setone");
                //Console.ReadKey();
                event_2.Set();
                Thread.Sleep(200);
                //Console.WriteLine("Waiting for set two");
                //Console.ReadKey();
                event_1.Set();
                Thread.Sleep(200);
            }
            
            
        }
        public void ThreadProc()
        {
            
        string name = Thread.CurrentThread.Name;

        Console.WriteLine("{0} waits on AutoResetEvent #1.", name);
        event_1.WaitOne();
        Console.WriteLine("{0} is released from AutoResetEvent #1.", name);

        Console.WriteLine("{0} waits on AutoResetEvent #2.", name);
        event_2.WaitOne();
        Console.WriteLine("{0} is released from AutoResetEvent #2.", name);

        Console.WriteLine("{0} ends.", name);
        }
        public void Main()
        {
             Console.WriteLine("Press Enter to create three threads and start them.\r\n" +
                          "The threads wait on AutoResetEvent #1, which was created\r\n" +
                          "in the signaled state, so the first thread is released.\r\n" +
                          "This puts AutoResetEvent #1 into the unsignaled state.");
        Console.ReadLine();
            
        for (int i = 1; i < 4; i++)
        {
            Thread t = new Thread(ThreadProc);
            t.Name = "Thread_" + i;
            t.Start();
        }
        Thread.Sleep(250);

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Press Enter to release another thread.");
            Console.ReadLine();
            event_1.Set();
            Thread.Sleep(250);
        }

        Console.WriteLine("\r\nAll threads are now waiting on AutoResetEvent #2.");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Press Enter to release a thread.");
            Console.ReadLine();
            event_2.Set();
            Thread.Sleep(250);
        }
        }
    }
}