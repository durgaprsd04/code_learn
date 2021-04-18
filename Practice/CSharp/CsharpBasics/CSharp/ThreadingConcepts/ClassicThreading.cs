using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
namespace CSharp.ThreadingConcepts
{
    public class ClassicThreading
    {
        public void ThreadMethod1()
        {
            for(int i=0;i<200;i++)
            {
                Thread.Sleep(1);
            }
            Console.WriteLine("Sub thread finishes");
        }
        public void ThreadCall()
        {
            var th = new Thread(ThreadMethod1);
            th.Start();
            Console.WriteLine("Main Thread finishes");
            //th.Join();

        }
        public void ExceptionTest()
        {
           
        }
    }
}