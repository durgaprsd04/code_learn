using System;
using LeetCode2.LinkedList;
namespace LeetCode2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var n =2147483648;
            //Console.WriteLine($"Hello World! {(n&(n-1))}");
            var v1 = new DoubleListNodeOpertions();
            var result =v1.Init(10);
            v1.Print(result);
            v1.InsertInPosition(result, 0, 20);
            v1.Print(result);
            v1.Reverse(result);
            v1.Print(result);
        }
    }
}
