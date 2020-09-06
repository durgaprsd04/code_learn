using System;
using System.IO;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
             //SeparateChainingSample();  
             LinearProbingSample();

        }
        public static void SeparateChainingSample()
        {
            //var key ="hasexample";
           StreamReader sr = new StreamReader("mini_file.txt");
           SeparateChaining<string> sp = new SeparateChaining<string>(10);
            while(sr.Peek()!=-1)
            {
                string line = sr.ReadLine();
                var linearray = line.Split(" ");
                foreach(var str in linearray)
                {
                    sp.Add(str);
                }
            }
        sp.Print();       
        }
        public static void LinearProbingSample()
        {
            var key ="hasexample";
           StreamReader sr = new StreamReader("mini_file.txt");
           LinearProbing<char> lp = new LinearProbing<char>(20);
           foreach(char c in key)
           {
               lp.Add(c);
           }
           lp.Print();
        }
    }
}
