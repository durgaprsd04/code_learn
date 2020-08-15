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
class SherlockString {

    // Complete the almostSorted function below.
   public static string  isValid(string s) {
        Dictionary<char,int> charMap = new Dictionary<char, int>();
        var result="";
        foreach(char c in s)
        {
        if(charMap.ContainsKey(c))
            charMap[c]++;
          else
            charMap.Add(c,1);
        }
        var arr = charMap.Values.ToArray();
        var countDict = new Dictionary<int,int>();
        for(int i=0;i<arr.Length;i++)
        {
          if(countDict.ContainsKey(arr[i]))
            countDict[arr[i]]++;
          else
            countDict.Add(arr[i],1);
        }
        if(countDict.Count>2)
        {
          result="NO";
        }
        else if(countDict.Count==2)
        {
          /*:q!
          foreach(var key1 in charMap.Keys)
            Console.Write($"{key1}:{charMap[key1]}  ");
          foreach(var key1 in countDict.Keys)
            Console.Write($"{key1}:{countDict[key1]}  ");
          */
            var keys = countDict.Keys.ToArray();
          var values = countDict.Values.ToArray();
          if((values[0]==1 || values[1]==1))
            if((Math.Abs(keys[0]-keys[1])==1))
              result="YES";
            else if((keys[0]==1 && values[0]==1) || (keys[1]==1&&values[1]==1))
              result="YES";
            else
              result="NO";
          else
            result="NO";
        }
        else
        {
          result="YES";
        }
      return result;
   }
  }
}
