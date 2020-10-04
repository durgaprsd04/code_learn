using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace LeetCode
{
    class GoodWaySplit
    {
       public int NumSplits(string s)
       {
          var len = s.Length;
          var  hs1 = new HashSet<char>();
          var hs2 = new HashSet<char>();
          int [] dp1 = new int[len];
          int [] dp2 = new int[len];
          var count=0;
          dp1[0]=1;
          dp2[0]=1;
          hs1.Add(s[0]);
          hs2.Add(s[len-1]);
          for(int i=1;i<len;i++)
          {
              if(!hs1.Contains(s[i]))
              {
                dp1[i]= dp1[i-1]+1;
                hs1.Add(s[i]);
              }
              else
              {
                dp1[i]=dp1[i-1];
              }
              if(!hs2.Contains(s[len-i-1]))
              {
                dp2[i]= dp2[i-1]+1;
                hs2.Add(s[len-i-1]);
              }
              else
              {
                dp2[i]=dp2[i-1];
              }
          }
          for(int i=0;i<len-1;i++)
            if(dp1[i]== dp2[len -i-2])
                count++;
          Console.WriteLine($" dp1 {string.Join(',', dp1)}");
          Console.WriteLine($" dp2 {string.Join(',', dp2)}");
          return count;
       }
    }
}
