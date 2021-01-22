using System;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;
namespace CSharp
{

    public class Taskcheck
    {
        public void TaskRunTest(int n)
        {
            var actionFunc=new Func<int>(Tester);
              var actionFunc1=new Func<int,int>(Tester1);
            var res = actionFunc();
            Task t = Task.Run(actionFunc);
            Task t1 = Task.Run(() => Tester1(n));
            //Task t2 = Task.Run(actionFunc1);
            Console.WriteLine(DateTime.Now);
            Thread.Sleep(3000);
            Console.WriteLine(DateTime.Now);
            t.Wait();
            Task t4 = Task.Factory.StartNew(() => {Console.WriteLine("wonder where");});
            t4.Wait();
        }
        public static int Tester()
        {
            var n=10;
            var sum=0;
                for(int i=0;i<n;i++){
                Console.WriteLine("hello world");
                sum+=i;
            }
            return sum;
        }
        public static int Tester1(int n)
        {            
            var sum=0;
                for(int i=0;i<n;i++){
                Console.WriteLine("hello world");
                sum+=i;
            }
            return sum;
        }
    }
}