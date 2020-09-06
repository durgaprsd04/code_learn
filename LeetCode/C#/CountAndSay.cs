using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace LeetCode
{
    class CountAndSayClass
    {
      public string CountAndSay(int n)
        {
        Dictionary<string,int> dict=new Dictionary<string, int>() ;
        int len=0;
        string key, prev;

        var seed ="1";
        for(int j=0;j<n;j++)
        {
          var seedArray = seed.ToCharArray();
          prev=seedArray[0].ToString() ;
          key = prev +"_0";
          len = seedArray.Length;
          dict = new Dictionary<string, int>();
          dict.Add(key,1);
          for(int i=1;i<len; i++)
          {
            if(prev!=seedArray[i].ToString())
            {
              prev=seedArray[i].ToString();
              key = prev +"_"+i.ToString();
              dict.Add(key,0);
            }
            //Console.WriteLine("prev" +prev);
            dict[key]++;
          }
          seed=string.Empty;
          foreach(var key1 in dict.Keys)
            seed = seed+ dict[key1].ToString()+ key1.Split('_')[0];
          //Console.WriteLine(dict.Keys.Count);
          if(j==2)
          {
           foreach(var v in dict.Keys)
           {
              Console.Write($"[{v}:{dict[v]}] ");
           }
          }
        }
                return seed;
      }
    }
}
