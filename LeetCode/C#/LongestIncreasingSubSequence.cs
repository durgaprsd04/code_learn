using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class LongestIncreasingSubSequence
    {
      public int FindLengthOfLCIS(int[] nums)
      {
        if(nums.Length<1)
          return 0;
        int count =0, nextCount=0;
        int len = nums.Length;
        for(int i=0;i<len-1;i++)
        {
          if(nums[i]< nums[i+1] )
          {
            //Console.WriteLine($"nums[{i}]{nums[i]} nums[{i+1}]{ nums[i+1]}");
            count++;
            //Console.WriteLine($"count {count}");
          }
          else
          {
            if(count>=nextCount)
              nextCount =count+1;
            //Console.WriteLine($"nextcount {nextCount}");
            count=0;
          }
        }
        if(count>=nextCount)
          nextCount  = count+1;
        return nextCount==0? 1:nextCount;
      }
    }
}
