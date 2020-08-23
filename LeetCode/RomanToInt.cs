using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace LeetCode
{
    class RomanToIntClass
    {
        public int RomanToInt(string s) {
        var dict = new Dictionary<char, int> {{'I',1}, {'V',5},{'X',10}, {'L',50}, {'C',100}, {'D',500}, {'M',1000 }};
        var sArray = s.ToCharArray();
        var len = sArray.Length;
        int val =0;
        int i=len-2;
        int val1 = dict[sArray[len-1]];
        val=val1;
        for(;i>0;i--)
        {
          var val2 =  dict[sArray[i-1]];
          Console.WriteLine($"val {val} val1 {val1} val2 {val2}");
          if(val1>val2)
          {
              val =  (val-val2);
          }
          else
          {
            val = val + val2;
          }
          val1=val2;
        }
        //if(i==0)
          //val = val +dict[sArray[0]];
        return val;
    }
    }
}

