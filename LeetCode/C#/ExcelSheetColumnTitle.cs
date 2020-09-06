using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace LeetCode
{
    class ExcelSheetColumn
    {
      public string ConvertToTitle(int n) 
      {
        var charDict = new Dictionary<int,char>();
       var  i=1;
       foreach(var v2 in "ABCDEFGHIJKLMNOPQRSTUVWXYZ")
       {
         charDict.Add(i++,v2);
       }
       int r=0;
       var queue = new Stack<int>();

      while(n>0)
      {
       r = n%26;
       n = n/26;
       Console.WriteLine($" n {n} r {r}");
       queue.Push(r==0?26:r);
      if(n==27&& r==0)
      {
        queue.Push(26);
        break;
      }
      }
       var s="";
       while(queue.Count()>0)
       {
          s= s+charDict[queue.Pop()];
       }
       return s;
    }
    }
}

