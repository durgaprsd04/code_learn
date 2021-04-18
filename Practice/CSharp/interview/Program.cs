using System;

namespace interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n!");
            interview1 i = new interview1();
            var n = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine($"factorial { i.WaitForFact(n)} ");
        }
    }
}
