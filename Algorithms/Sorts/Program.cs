using System;
using System.Collections.Generic;

namespace Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N");
             
            var N =  Convert.ToInt32( Console.ReadLine());
            List<int> array = new List<int>();//{3,2,0,3,4} ;
            var rand = new Random();
            for(int i=0;i<N;i++)
            {
                array.Add( rand.Next(0,N*10));
            }
            
            
            //Shell_Sort s = new Shell_Sort(array.ToArray());
            Merge_Sort m = new Merge_Sort();
            m.Sort(array.ToArray());
            //Console.WriteLine(string.Join(",",array.ToArray()));
            m.Print();
        }
    }
}
