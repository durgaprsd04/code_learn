using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class FindUnsortedSubarrayClass
    {
       public int FindUnsortedSubarray(int[] nums)
       {
          var len = nums.Length;
          int maxValue=Int32.MinValue;
          int minIndex = Int32.MinValue, maxIndex = Int32.MinValue;
          int res =0;
          for(int i=0;i<len-1;i++)
          {
            if(nums[i]>nums[i+1])
            {
              if(minIndex==Int32.MinValue)
              {
                minIndex=i;
                maxValue = nums[i];
              }
              else
              {
                maxIndex = i+1;
              }
            }
            else
            {
              if(maxIndex!=Int32.MinValue)
              {
                if(nums[i+1] > maxValue)
                  maxIndex = i;
                else
                  maxIndex =i+1;
              }
              if(minIndex!=Int32.MinValue)
              {
                if(nums[i+1]<maxValue)
                  maxIndex = i+1;
              }
            }
          }
          if((minIndex == Int32.MinValue) && (maxIndex == Int32.MinValue))
            res =0;
          else if (maxIndex == Int32.MinValue)
            res = 2;
          else
            res = (maxIndex - minIndex)+1 ;
          return res;
       }
    }
}
