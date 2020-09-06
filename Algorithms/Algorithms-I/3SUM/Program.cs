using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace _3SUM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num");
            var num = Convert.ToInt32(Console.ReadLine());
            //RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator(num);
            int [] array = new  int[num]; 

             List<int> l = new List<int>{};
            using(StreamReader sr = new StreamReader(@"numberlist.txt"))
            {
                var i=0;
                while(sr.Peek()>0)
                {
                    
                    array[i]=Convert.ToInt32(sr.ReadLine());
                    l.Add(array[i]);
                    i++; 
                }
                sr.Close();
            }
            l.Sort();
            array=l.ToArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int count=0;
            for(int i=0;i<num;i++)
                for(int j=i+1;j<num;j++)
                    {

                    /*
                    for(int k=j+1;k<num;k++)
                        if(array[i]+ array[j]+array[k]==0)
                        {
                            //Console.WriteLine("Pair ({0},{1},{2}) ", array[i], array[j], array[k]);
                            count++;
                        }
                            
                      */
                    if(l.BinarySearch(-1*(array[i]+array[j]))>j)
                    {
                        ///Console.WriteLine("Pair ({0},{1},{2}) ", array[i], array[j], -(array[i]+array[j]));
                        //Console.WriteLine(l.Where(x=> x==-1*(array[i]+array[j])).Count());
                        count+=l.Where(x=> x==-1*(array[i]+array[j])).Count();
                    }
                    
                    
                    }
                    
            sw.Stop();
            
            Console.WriteLine("Number of zero sums {0}", count);
            Console.WriteLine("Elapsed time  {0}", sw.Elapsed);
            
            //Console.WriteLine("Array {0}", string.Join(", ",array));
        }
    }
}
