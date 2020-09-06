using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class LengthOfLastWordClass
    {
         public int LengthOfLastWord(string s)
         {
            string last=string.Empty, a=string.Empty;
            foreach(char c in s)
            {
              if(c==' ')
              {
                 last=string.Empty;
              }
              else
                last = last +c.ToString();
              if(last.Length>0)
                a=last;
              //Console.WriteLine(a);
            }
            return string.IsNullOrEmpty(last)? a.Length: last.Length;
         }
    }
}
