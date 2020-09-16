using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    public class SubSequence
    {
        public bool IsSubsequence(string s, string t)
        {
          if(string.IsNullOrWhiteSpace(s))
            return true;
         if(string.IsNullOrWhiteSpace(s)&& string.IsNullOrWhiteSpace(t))
           return true;

          var len = t.Length;
          var len2 = s.Length;
          int j =0;
          bool isSub=false;
          for(int i=0;i<len;i++)
          {
            if(t[i]==s[j])
            {
              Console.WriteLine($"t[i] {t[i]} s[i] {s[j]}");
              if(++j==(len2))
              {
                isSub=true;
                break;
              }
            }
          }
          return isSub;
        }
    }
}
