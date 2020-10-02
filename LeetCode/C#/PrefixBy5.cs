using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace LeetCode
{
    class BinaryPrefix5
    {
      public IList<bool> PrefixesDivBy5(int[] A)
      {
        var len = A.Length;
        var sum = 0;
        IList<bool> l1 = new List<bool>();
        for(int i=0;i<len;i++)
        {
            sum= (2*sum + A[i]);
            Console.Write(sum +" ");
            if(sum%5==0)
            {
              l1.Add(true);
              sum=0;
            }
            else
            {
              l1.Add(false);
            }
            if(sum>10)
            {
              var v = sum - sum%10;
              sum = sum -v;
            }
        }
        return l1;
      }
    }
}
