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

class CommonChildClass {

    // Complete the highestValuePalindrome function below.
    public static int CommonChild(string s1,string s2){
      char [] c1 = new char[s1.Length];
      char [] c2 = new char[s2.Length];
      int i =0, j=0;
      StringBuilder sb1 = new StringBuilder();
      StringBuilder sb2 = new StringBuilder();

      foreach(char c in s1)
      {
        if(s2.Contains(c))
            {
              c1[i]=c;
              i++;
            }
      }
      for(j=0;j<i;j++)
      {
        sb1.Append(c1[j]);
      }
      i=0;
      foreach(char c in s2)
      {
        if(s1.Contains(c))
            {
              c2[i]=c;
              i++;
            }
      }
      for(j=0;j<i;j++)
      {
        sb2.Append(c2[j]);
      }
      var sampleString1 = sb1.ToString();
      var sampleString2 = sb2.ToString();
      Console.WriteLine("first    "+ sampleString1);
      Console.WriteLine("second   "+sampleString2);
      var maxString=string.Empty;
      j=0;
      while(j<sampleString1.Length)
      {
          i=1;
          while(i<=sampleString2.Length)
          {
            if((j+i)<=sampleString1.Length)
            {
              var subStr = sampleString1.Substring(j,i);
              Console.WriteLine("fist substr"+subStr);
              if(sampleString2.Contains(subStr))
              {
                if(maxString.Length<subStr.Length)
                  maxString=subStr;
              }
              else
              {
              break;
              }
            }
            i++;
          }
          j++;
      }
      Console.WriteLine(maxString);
      return maxString.Length;
  }
}
