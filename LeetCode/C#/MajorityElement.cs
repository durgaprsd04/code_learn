using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace LeetCode
{
    class MajorityElementClass
    {
      public int MajorityElement(int[] nums)
      {
          var len = nums.Length;
          Dictionary<int,int> countDict = new Dictionary<int, int>();
          foreach(var v in nums)
          {
            if(!countDict.Keys.Contains(v))
              countDict.Add(v,0);
            countDict[v]++;
          }
          return countDict.Where(x => x.Value>len/2).First().Key;
      }
    }
}
