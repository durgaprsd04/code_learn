using System;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
namespace CSharp.ThreadingConcepts
{

    public class TaskRunTest{
        public   async Task  CountUpto1M()
        {
            Console.WriteLine("Counting started inside method");
        await Task.Factory.StartNew( () =>{        for(int i=0;i<1000000;i++);
                });
                
            Console.WriteLine("Counting finished inside method");
        }
        public void TestTask()
        {
            Console.WriteLine("Count task started");
            Task.WaitAll( CountUpto1M());
            Console.WriteLine("count task finished");
        }
    }

}
