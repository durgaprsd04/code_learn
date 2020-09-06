using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
    class PascalTriangle
    {
      public IList<IList<int>> Generate(int numRows)
      {
        IList<int> seed = new List<int>(){1};
        IList<int> temp = new List<int>();
        IList<IList<int>> final = new List<IList<int>>();
        int i=1;
        int [] a = new int [1] {1};
        while(i<numRows+1)
        {
          var b = new int [a.Length+1];
          b[0]=1;
          b[b.Length-1]=1;
          for(int j=1;j<a.Length;j++)
          {
            b[j] = a[j-1]+a[j];
          }
          foreach(int a1 in a)
            temp.Add(a1);
          a=b;
          if(temp.Count>0)
            final.Add(temp);
          else
            final.Add(seed);
          temp = new List<int>();
          i++;
        }
        return final;
      }
    }
}
