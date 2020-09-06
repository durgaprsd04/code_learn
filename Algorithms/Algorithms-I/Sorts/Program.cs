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
            List<char> array = new List<char>();//{'A','J','X','Y','W','V','R','S'} ;
            //Console.WriteLine(string.Join(",",array.ToArray()));
            //var N = array.Count;
            var rand = new Random();
            for(int i=0;i<N;i++)
            {
                array.Add( (char)(rand.Next(65,90)));
            }
            ///Console.WriteLine("Enter string ");
            //string input=Console.ReadLine();
            
            //Shell_Sort s = new Shell_Sort(array.ToArray());
            //Merge_Sort m = new Merge_Sort();
            //QuickSort q = new QuickSort();
            //Merge_Sort_bottomUP msb = new Merge_Sort_bottomUP();
            Heap hp = new Heap(array.ToArray(), array.Count );

            hp.Sort();
            //Console.WriteLine(string.Join(",",array.ToArray()));
            ///msb.Print();
        }
    }
}
