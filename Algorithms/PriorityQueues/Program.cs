using System;
using System.Collections.Generic;

namespace PriorityQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var v ="aquickkkkkkbrownfx";
            var v1 = "jumped";
            List<char> l = new List<char>();
            foreach(char c in v)
                l.Add(c);

            MinHeap<char> m = new MinHeap<char>(l.ToArray(), l.Count);
            m.Add(v1.ToCharArray(), v1.Length);
            m.Sort();
            m.Delete('x');
            m.Delete('j');
            m.Delete('k');
            while(m.HasElement())
            {
                Console.WriteLine(m.Pop());
            }
        }
    }
}
