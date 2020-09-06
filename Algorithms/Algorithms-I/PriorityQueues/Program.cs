using System;
using System.Collections.Generic;

namespace PriorityQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var seed ="abc".ToCharArray();
            var indexPQ = new IndexedPriorityQueue<char>(5);
            for(int i=0;i<seed.Length;i++)
              indexPQ.Add((int)seed[i], seed[i]);
            indexPQ.Print();
            Console.WriteLine("Min on first pop : " +indexPQ.DeleteMin());
            Console.WriteLine("Min on first pop : " +indexPQ.DeleteMin());
            Console.WriteLine("Min on first pop : " + indexPQ.DeleteMin());
            Console.WriteLine("after all Delete min "+ indexPQ.IsEmpty());
            indexPQ.Print();
            /*
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
            */
        }
    }
}
