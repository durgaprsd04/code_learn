using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
namespace Leetcode
{
    class CountPrimesClass
    {
      public int CountPrimes(int n)
      {
        Stopwatch sw = new Stopwatch();
        //Console.WriteLine("n is "+n);
        List<int> l1 = new List<int>();
        var flag =false;
        sw.Start();
        for(int i=2;i<n;i++)
        {
          foreach(var v in l1)
          {
            if(v<=i/2)
            {
              if(i%v==0)
              {
                flag = true;
                break;
              }
            }
          }
         if(!flag)
          {
            //Console.WriteLine($"adding {i}");
            l1.Add(i);
          }
          flag=false;
        }
        sw.Stop();
        Console.WriteLine("teim elaspsed "+sw.Elapsed);
        //Console.WriteLine(string.Join(',', l1.ToArray()));
        return l1.Count;
      }
      private bool IsPrime(int i)
      {
        bool flag=false;
        for(int j=2;j<=Math.Sqrt(i);j++)
        {
        //Console.WriteLine("test "+i);
        if(i%j==0)
        {
        flag=true;
        break;
        }
        }
        return !flag;
      }
    }
}
