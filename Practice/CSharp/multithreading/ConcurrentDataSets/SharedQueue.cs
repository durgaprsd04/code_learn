using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using  System.Threading.Tasks;
namespace ConcurrentDataSets
{
    public class SharedQueue
    {
        ConcurrentQueue<Client> concurrent = new ConcurrentQueue<Client>();
        private Queue<Client> [] queueList = new Queue<Client>[10];

        public SharedQueue()
        {
            for(int i=0;i<10;i++)
                queueList[i] = new Queue<Client>();
        }
       public async Task ParellelPush(int element)
       {
                     // Console.WriteLine("here 0");
          await Task.Run(()=> Parallel.ForEach(Enumerable.Range(0, 9), i =>
           {
                for(int j=0;j< 10;j++)
                    concurrent.Enqueue(new Client(i, j));
                Client result =null;
                if(concurrent.TryDequeue(out result))
                {
                    if(result.order==element)
                        queueList[result.order].Enqueue(result);
                    else
                        concurrent.Enqueue(result);
                }
                //Console.WriteLine(string.Join(",",queueList[i]));
           }));
       }
       public void Print()
       {
           while(concurrent.Count()>0)
           {
               Client result =null;
                if(concurrent.TryDequeue(out result))
                {
                    queueList[result.order].Enqueue(result);
                }
           }
           foreach(var queue in queueList)
           {
               Console.WriteLine(string.Join(", ",queue));
           }
       }
       public void SharedQueueMainCall(int element)
       {
           Console.WriteLine("Pushing starts");
           Task.WaitAll(ParellelPush(element));
           Console.WriteLine("Pushign ends");
           Print();
       }
    }
    public class Client
    {
        public int order;
        public int digits;
        public Client(int order, int digits)
        {
            this.order = order;
            this.digits = digits;
        }
        public override string ToString()
        {
            return $"({order}:{digits})";
        }
    }
}