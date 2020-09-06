using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
    class TwoSumClass
    {
        public int[] TwoSum(int[] nums, int target) {
          var len = nums.Length;
          int i=0, j=0, indexI=0, indexJ=0;
          bool numFound =false;
          //Console.WriteLine("target"+target);
          List<int> l = new List<int>();
          for(i=0;i<len;i++)
          {
            for(j=1;j<len;j++)
            {
              if(i==j)
                continue;
              //Console.WriteLine($" sum  {nums[i]+nums[j]}");
              if((nums[i]+nums[j])==target)
              {
                  indexI=i;
                  indexJ=j;
                  numFound=true;
              }
            }
            if(numFound)
              break;
          }
          l.Add(indexI);
          l.Add(indexJ);
          return l.ToArray();
    }
    }
}
