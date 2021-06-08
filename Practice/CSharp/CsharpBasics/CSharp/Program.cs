using System;
using System.Linq;
using System.Text;
using System.Threading;
using CSharp.ThreadingConcepts;
using CSharp.GeneralTrivia;
using CSharp.OOP;
using CSharp.Basics;
namespace CSharp.Basics
{
    public class Program
    {
        static void Main(string[] args)
        {
          #region abstract class test
          AbstractClassTest ab = new SolidClass("solod");
          ab.PrintLine();
          #endregion 

          #region Enumaskey test
          var e = new EnumsTest();
          e.EnumAsKeyTest(10);
          #endregion

          #region  indextest
           var queue = new IndexedQueue<int>();
           for(int i=0;i< 10;i++)
            queue.Enqueue(i+1);
          Console.WriteLine($"queue[{3}] {queue[3]}");
           queue.Print();
           while(!queue.isEmpty())
              Console.Write(queue.Dequeue()+"->");
          #endregion


          #region  start invocation
          OrderOfInvocationParent od = new OrderOfInvocation(3);
          #endregion 
        }
    }
}

