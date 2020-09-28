using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
    class IsoMorphicClass
    {
      public bool IsIsomorphic(string s, string t)
      {
        if(string.IsNullOrWhiteSpace(s) && string.IsNullOrWhiteSpace(t))
            return true;
        if(string.IsNullOrWhiteSpace(s) || string.IsNullOrWhiteSpace(t))
          return false;
        if(s.Length != t.Length)
          return false;
        var dict = new Dictionary<char,char>();
        StringBuilder sb = new StringBuilder();
        for(int i =0;i<s.Length;i++)
        {
            if(!dict.ContainsKey(s[i]))
              if(!dict.Values.Contains(t[i]))
                dict.Add(s[i],t[i]);
              else
                break;
            sb.Append(dict[s[i]]);
        }
        return sb.ToString()==t;
      }
    }
}
