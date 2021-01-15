using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
    public class MinDifferenceClass
    {
        public int MinDifference(int[] nums) 
        {
            Array.Sort(nums);
            var len = nums.Length;
            if(len<=4)
            {
            return 0;
            }
            else
            {
                if(len>=7)
                {
                    if(Math.Abs(nums[len-7]- nums[len-4])>Math.Abs(nums[len-4]-nums[len-1]))
                    {
                        return Math.Abs(nums[len-4]- nums[len-1]);
                    }
                    else
                    {
                        return Math.Abs(nums[len-7]- nums[len-4]);
                    }
                }
                else
                {
                    if(Math.Abs(nums[len-4]-nums[len-1])>Math.Abs(nums[len-4]-nums[0]))
                    {
                        return Math.Abs(nums[len-4]-nums[0]);
                    }
                    else
                    {
                        return Math.Abs(nums[len-4]-nums[len-1]);
                    }
                }
            }
    }
    }
}
