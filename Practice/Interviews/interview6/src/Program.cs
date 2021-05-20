using System;

namespace interview6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); 
            var interview = new Test();
            var res = interview.GetPos(new int [] {1,5,9,6});     
            Console.WriteLine($"result {res}");   
            var res1 = interview.GetPos(new int [] {1,2,3,5,7,8,3});     
            Console.WriteLine($"result {res1}");  
        }
    }
}
