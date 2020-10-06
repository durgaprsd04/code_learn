using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
    class AssignCookies
    {
      public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);
        int i=0,j=0, count=0;
        int len1 =g.Length, len2 = s.Length;
        while(i<len1 && j<len2)
        {
          if(g[i]>s[j])
            j++;
          else
          {
            i++;
            j++;
            count++;
          }
        }
        return count;
      }
    }
}
