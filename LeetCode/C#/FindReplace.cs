using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace LeetCode
{
    class FindReplace
    {
      public IList<string> FindAndReplacePattern(string[] words, string pattern)
      {
         IList<string> l = new List<string>();
         foreach(var str in words)
           if(isPattern(str,pattern))
             l.Add(str);
         return l;
      }
      public bool isPattern(string a, string b)
      {
        StringBuilder sb = new StringBuilder();
        Dictionary<char,char> dict = new Dictionary<char, char>();
        var len = a.Length;
        for(int i=0;i<len;i++)
        {
          if(!dict.ContainsKey(b[i]))
          {
            if(!dict.ContainsValue(a[i]))
              dict.Add(b[i],a[i]);
          }
          sb.Append( (dict.ContainsKey(b[i])?dict[b[i]]:';'));
        }
        return sb.ToString()==a;
      }
    }
}
