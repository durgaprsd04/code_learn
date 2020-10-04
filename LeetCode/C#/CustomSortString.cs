using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace LeetCode
{
    class CustomSortStringClass
    {
        public string CustomSortString(string S, string T)
        {
          StringBuilder sb = new StringBuilder();
          foreach(char c in S)
            if(T.Contains(c))
              sb.Append(c);
          var sArray = sb.ToString().ToCharArray();
          var dict = new Dictionary<char,int>();
          int i=0;
          foreach(char c in sArray)
          {
            dict.Add(c, i++);
          }
          var vArray = new int[sArray.Length ];
          for(int j=0;j<vArray.Length;j++)
            vArray[j]=0;
          foreach(char c in T)
          {
            if(!sArray.Contains(c))
              sb.Append(c);
            else
            {
              vArray[dict[c]]++;
              Console.WriteLine($"varray[dict[{c}]] {vArray[dict[c]]}");
              if(vArray[dict[c]]>=2)
              {
               var  x1 =  new String(c, vArray[dict[c]]-1);
               var  x2 = new String(c, vArray[dict[c]]);
               Console.WriteLine($"x1 {x1} x2 {x2}");
                sb.Replace(x1,x2);
              }
            }
          }
          return sb.ToString();
        }
    }
}
