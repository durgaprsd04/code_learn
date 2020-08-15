using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace  HackerRank
{
class CaesarCipherClass
  {
      public static string CaesarCipher(string s, int k)
      {
      var caps="abcdefghijklmnopqrstuvwxyz";
      var smalls ="ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      var smallDict = new Dictionary<int,char>();
      var largeDict = new Dictionary<int,char>();
      var smallDictC = new Dictionary<char,int>();
      var largeDictC = new Dictionary<char,int>();
      int i=0, j=0;
      foreach(char c in caps)
      {
        smallDict[i]=c;
        smallDictC[c]=i;
        i++;
      }
      foreach(char c in smalls)
      {
        largeDict[j]=c;
        largeDictC[c]=j;
        j++;
      }
      StringBuilder sb = new StringBuilder();
      foreach(char c in s)
        {
            if(largeDictC.ContainsKey(c))
            {
             //Console.WriteLine(largeDict[(largeDictC[c]+k)%26]);
              sb.Append(largeDict[(largeDictC[c]+k)%26]);
            }
            else if(smallDictC.ContainsKey(c))
            {
              sb.Append(smallDict[(smallDictC[c]+k)%26]);
            }
            else
            {
              sb.Append(c);
            }
        }
      return sb.ToString();
      }
  }
}
