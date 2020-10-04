using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class CheckifItCanBreak
    {
      public bool CheckIfCanBreak(string s1, string s2)
      {
        var flag=false;
        var s1sorted = s1.ToCharArray();
        var s2sorted = s2.ToCharArray();
        Array.Sort(s1sorted);
        Array.Sort(s2sorted);
        for(int i=0;i<s1.Length;i++)
        { 
          if(s2sorted[i]>s1sorted[i])
              {
                continue;
              }
              else
              {
                flag=true;
              }
        }
        return flag;
      }
    }
}
