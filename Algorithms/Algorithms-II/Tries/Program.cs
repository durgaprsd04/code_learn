using System;
using System.Collections.Generic;
namespace Tries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var str = "A quick brown fox jumped over a lazy fox";
            var dict = new Dictionary<string, int>();
            int i=0;
            RWayTries r = new RWayTries();
            foreach(var st in str.Split(' '))
            {
              if(!dict.ContainsKey(st))
                dict.Add(st.ToLower(), i);
              else
                dict[st.ToLower()]=i;
              i++;
            }
            r.Add("brownstone",23);
            r.Add("lazier", 22);
            r.Add("quciker", 12);
            r.Add("quicker",20);
            foreach(var d in dict)
            {
              r.Add(d.Key, d.Value);
            }
            Console.WriteLine("The Trie ");
            r.Print();
            Console.WriteLine();
            var res = r.Get("quick");
            Console.WriteLine("Result for fetch of quick: " + res);
            res = r.Get("brownstone");
            Console.WriteLine("Result for fetch of brownstone: " + res);
            res = r.Get("brownstones");
            Console.WriteLine("Result for fetch of brownstones: " + res);
            r.Delete("brownstone");
            r.Delete("lazy");
            r.Print();
        }
    }
}
