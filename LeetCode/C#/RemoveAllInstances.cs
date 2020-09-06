using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class RemoveAllInstances
    {
          public int RemoveElement(int[] nums, int val) 
          {
            int j =0;
            int len = nums.Length;
            for(int i=0;i<len;i++)
            {
                  if(nums[i]!=val)
                    nums[j++]=nums[i];
            }
            return j;
         }
    }
}
