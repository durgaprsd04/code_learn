using System;
using System.Linq;
using System.Threading;
using  System.Threading.Tasks;
namespace ConcurrentDataSets
{
    public class ThreadingTest
    {
        public void ThreadingMethod1()
        {
            Console.WriteLine("Summing start "+DateTime.Now.ToLongTimeString());
            long sum=0;
            for(int i=0;i<100000000;i++)
                sum+=i;
            Console.WriteLine($"Summing done with sum {sum} "+DateTime.Now.ToLongTimeString() );
        }
         public async Task ThreadingMethod2()
        {
            Console.WriteLine("Summing start for task "+DateTime.Now.ToLongTimeString());
            long sum=0;
            await Task.Run(() =>{
                for(int i=0;i<100000000;i++)
                sum+=i;
            });
            Console.WriteLine($"Summing done for task wth sum{sum} "+DateTime.Now.ToLongTimeString() );
        }
        public void ThreadTestCalling()
        {
            var t = new Thread(ThreadingMethod1);
            t.Start();
            t.Join();
            //Task.WaitAll(Task.Run(()=>  ThreadingMethod1()));
        
        }
        public void ThreadTaskCalling()
        {
            //var t = new Thread(ThreadingMethod1);
            //t.Start();
            //t.Join();
            Task.WaitAll( Task.Run(()=>  ThreadingMethod2()));
        
        }

    }
}