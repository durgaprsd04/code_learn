using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class ThirdMaximumClass
    {
      public int ThirdMax(int[] nums)
      {
        /*
        int firstMax=Int32.MinValue , secondMax=Int32.MinValue, thirdMax=Int32.MinValue;
        bool secondMaxSet =false, thirdmaxSet=false;
        for(int i=0;i<nums.Length;i++)
        {
          if(nums[i]==firstMax || nums[i]==secondMax)
            continue;
          if(nums[i]>firstMax)
          {
            thirdMax = secondMax;
            secondMax = firstMax;
            firstMax = nums[i];
          }
          else if(nums[i]>secondMax)
          {
            thirdMax = secondMax;
            secondMax = nums[i];
          }
          else if(nums[i]>=thirdMax)
          {
            thirdmaxSet=true;
            thirdMax = nums[i];
          }
        }
        Console.WriteLine($" tm {thirdmaxSet} sm {secondMaxSet}");
        Console.WriteLine( $"min  {Int32.MinValue} first max {firstMax} second {secondMax} thrid {thirdMax}");
        if(!thirdmaxSet)
          return firstMax;
        return thirdMax;*/
        return 0;
      }
    }
}
