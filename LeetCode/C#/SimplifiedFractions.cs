using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
namespace LeetCode
{
    class SimplifiedFraction
    {
      public IList<string> SimplifiedFractions(int n)
      {
        IList<string> l = new List<string>();
        for(int i=1;i<=n-1;i++)
          for(int j=i+1;j<=n;j++)
          {
            if(j%i==0 && i!=1)
              continue;
            if(hasCommonFactors(i,j))
              continue;
            l.Add(i.ToString()+"/"+j.ToString());
          }
        return l;
      }
      public bool hasCommonFactors(int m, int n)
      {
        var min = m>n?n:m;
        var flag=false;
        for(int i=2;i<min;i++)
        {
            if(m%i==0 &&n%i==0)
            {
              flag=true;
              break;
            }
        }
        return flag;
      }
    }
}
