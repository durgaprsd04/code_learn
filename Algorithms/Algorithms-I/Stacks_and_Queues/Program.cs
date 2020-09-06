using System;

namespace Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedListStackofStrings linkedListStackofStrings = new LinkedListStackofStrings();
            /* 
            StackWithArray stackWithArray = new StackWithArray();
            var list = Console.ReadLine().Split(" ");
            foreach(string j in list)
                if(j.Equals("_"))
                {
                    var test = stackWithArray.Pop();
                    Console.WriteLine("Popped :"+test);
                }
                else
                {
                    stackWithArray.Push(j);
                    Console.WriteLine("pushed :"+j);
                }
            Console.WriteLine("current Element:"+ stackWithArray.Current());
            */
            //Queues queues = new Queues();
            QueuesWithArray queues = new QueuesWithArray();
            var list = Console.ReadLine().Split(" ");
            foreach(string j in list)
                {
                    queues.Enqueue(j);
                    Console.WriteLine("queued :"+j);
                }
            foreach(string j in list)
            {
                var q = queues.Dequeue();
                Console.WriteLine("Dequed :"+q);
            }
            //Console.WpushedriteLine("current Element:"+ stackWithArray.Current());
        }
    }
}
