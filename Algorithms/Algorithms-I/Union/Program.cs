using System;
using System.IO;
using System.Diagnostics;

namespace Union
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RandomInputGenerator r = new RandomInputGenerator();
            Console.WriteLine("Enter N");
            var n = Convert.ToInt32(Console.ReadLine());
            r.RandomGenerator(n);
            //Reading the generated file
            
            UnionFindWQPC uf = new UnionFindWQPC(n);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            using (StreamReader sr = new StreamReader("numberlist.txt")) 
            {
                while (sr.Peek() >= 0) 
                {
                    var t= sr.ReadLine();
                    var a = Convert.ToInt32(t.Split(" ")[0]);
                    var b = Convert.ToInt32(t.Split(" ")[1]);
                    uf.Connect(a,b);
                    Console.WriteLine("After Union with ({0}, {1})",a,b);
                    uf.PrintArray();
                }
            }
            sw.Stop();
            Console.WriteLine("Stop watch span connect {0} ",sw.Elapsed);
            sw.Start();
            using (StreamReader sr = new StreamReader("numberlist.txt")) 
            {
                while (sr.Peek() >= 0) 
                {
                    var t= sr.ReadLine();
                    var a = Convert.ToInt32(t.Split(" ")[0]);
                    var b = Convert.ToInt32(t.Split(" ")[1]);
                    Console.WriteLine(" connect b/w ({0}, {1}) : {2}",a,b,uf.isConnected(a,b));
                }
            }
            sw.Stop();
            Console.WriteLine("Stop watch span isconnect {0} ",sw.Elapsed);
        }
    }
}
