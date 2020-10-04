using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace LeetCode
{
    class AddArrayForm 
    {
        public IList<int> AddToArrayForm(int[] A, int K)
        {
          IList<int> l= new List<int>();
          int rem = 0;
          var len = A.Length;
          for(int i=len-1;i>=0 || K>0;i--)
          {
            var d= (i>=0)?A[i]:0;
            var c =d + K%10 +rem ;
            rem = c/10;
            K = K/10;
            l.Add(c%10);
          }
          if(rem>0)
            l.Add(rem);
          IList<int> l1 = new List<int>();
          foreach(var n in l.Reverse())
            l1.Add(n);
          return l1;

        }
    }
}
