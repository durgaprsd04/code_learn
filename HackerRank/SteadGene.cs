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
class SteadyGeneClass
  {
    public static int steadyGene(string gene)
      {
        var charMap = new Dictionary<char,int>();
        var length = gene.Length/4;
        char [] geneList = {'A','C','T','G'};
        foreach(char c in gene)
        {
          if(charMap.ContainsKey(c))
            charMap[c]++;
          else
            charMap.Add(c,1);
        }
        var missingDict = new Dictionary<char, int>();
        foreach(var val in charMap.Keys)
        {
          if(charMap[val]!=length)
            missingDict.Add(val, (charMap[val]-length));
        }
        var diffMax=0;
        var regex="^";
        //^[c]{4,5}[t]{0,2}
        var diffKey= new List<char>();
        foreach(var key in  missingDict.Keys)
        {
          Console.WriteLine($"{key}:miss {missingDict[key]} :char {charMap[key]} ");
          if(missingDict[key]>0)
          {
            diffMax=diffMax+ missingDict[key];
            diffKey.Add(key);
            regex = regex+"["+key+"]{0,"+missingDict[key].ToString()+"]";
          }
        }
        Console.WriteLine("diff key"+diffKey);
        Console.WriteLine("diff Max"+diffMax);
        string sub=string.Empty;
        int limit=diffMax, beginIndex=0;
        foreach(var key in missingDict.Keys)
        {
          if(!diffKey.Contains(key))
            continue;
            for(int i=limit;i>=1;i--)
            {
              //Console.Write("limit "+ i);
              var str = new string(key,i);
              //Console.Write("limit strt "+ str);
              var result=string.Empty;
              Match m = Regex.Match(str, @""+regex);
              if(m.Success)
              {
                var diffChars = limit-i;
                beginIndex= gene.IndexOf(str);
                sub = gene.Substring(beginIndex, limit);
                break;
              }
            }
        }
        int k=0;
        while((sub.Count(x=> x==diffKey)<limit))
            {
                sub = gene.Substring(beginIndex, limit+k);
                k++;
            }
        Console.WriteLine("substring "+ sub);
        return sub.Length;
    }
  }
}
