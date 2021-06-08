using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
namespace CSharp.ThreadingConcepts
{
    public class ThreadingTest3
    {
        public void PrintNumbersBy2(int seed, int limit)
        {
            var count =seed;
            while(count<limit)
            {
                Console.Write(count +" ");
                count+=2;
            }
        }
        
    }
    public class Worker
    {
        public void WorkerThread(int limit)
        {
            ThreadingTest3 th = new ThreadingTest3();
            var cworker1 = new Thread(() => th.PrintNumbersBy2(0, limit));
            var cworker2 = new Thread(() => th.PrintNumbersBy2(1, limit));
            cworker1.Start();
            cworker2.Start();
            cworker1.Join();
            cworker2.Join();
            //th.PrintNumbersBy2(3,100);
        }
        public void WorkerTask(int limit)
        {
            ThreadingTest3 th = new ThreadingTest3();
            var t1= Task.Run( () => th.PrintNumbersBy2(0,limit));
            var t2 = Task.Run( () => th.PrintNumbersBy2(1, limit));
           t2.Wait();
           t1.Wait();
        
        }
    }
}