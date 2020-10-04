using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace LeetCode
{
    class MinAnagramDist
    {
       public int MinSteps(string s, string t)
       {
          var sDict = getCharDict(s);
          var tDict = getCharDict(t);
          Dictionary<char,int> diffDict = new Dictionary<char, int>();
          foreach(char c in tDict.Keys)
          {
            if(sDict.ContainsKey(c))
            {
              if(sDict[c]!=tDict[c])
                diffDict.Add(c, tDict[c]-sDict[c]);
            }
            else
            {
             diffDict.Add(c,tDict[c]);
            }
          }
          foreach(var d in diffDict)
            Console.Write($" {d.Key} :{d.Value} ");
         int sumP = 0;
         int sumN = 0;
         foreach(var key in diffDict.Keys)
         {
            if(diffDict[key]>0)
              sumP+=diffDict[key];
            else
              sumN+=diffDict[key]*-1;
         }
         var res = (sumP>=sumN)?sumP:(sumN-sumP);
          return res;
       }
       public Dictionary<char,int> getCharDict(string s )
       {
         Dictionary<char,int> dict = new Dictionary<char, int>();
         foreach(char c in s)
         {
            if(!dict.ContainsKey(c))
              dict.Add(c,0);
            dict[c]++;
         }
        return dict;
       }
    }
}
