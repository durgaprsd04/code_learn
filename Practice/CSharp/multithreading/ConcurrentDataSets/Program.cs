using System;

namespace ConcurrentDataSets
{
    class Program
    {
        static void Main(string[] args)
        {
           SharedQueueTest();
        }
        public static void ThreadingTestMethod1()
        {
             Console.WriteLine("Hello World!");
            var a = new ThreadingTest();
            a.ThreadTestCalling();
             a.ThreadTaskCalling();
             Console.WriteLine("Hello World!");
        }
        public  static void SharedQueueTest()
        {
            SharedQueue sh  = new SharedQueue();
            sh.SharedQueueMainCall(5);
        }
    }
}
