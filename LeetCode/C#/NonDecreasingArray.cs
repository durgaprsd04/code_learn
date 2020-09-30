using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class NonDecreasingSubArray
    {
      public bool CheckPossibility(int[] nums)
      {
        if(nums.Length<=1)
          return true;
        var len  = nums.Length;
        int falseCount=0, max = Int32.MinValue, min=Int32.MaxValue;
        if(nums[0] > nums[1])
        {
          min = nums[1];
          max =  nums[0];
          falseCount++;
        }
        else
        {
          min = nums[0];
          max = nums[1];
        }
        for(int i=2;i<len;i++)
        {
          if(falseCount==1 && i==2)
          {
              if(nums[i]<min)
                falseCount++;
          }
          else{
            if(nums[i]<max)
            {
              falseCount++;
              if(min<nums[i])
              max = nums[i];
            }
          }
          if(falseCount>1)
            break;
        }
        return (falseCount<=1);
      }
    }
}
