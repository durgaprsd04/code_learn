using System;
using System.IO;
using System.Collections.Generic;
namespace LeetCode
{
    public class Duplicates2InArray
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var hs = new HashSet<int>();
            Dictionary<int, int> posDict = new Dictionary<int, int>();
            var flag = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!hs.Contains(nums[i]))
                {
                    hs.Add(nums[i]);
                    posDict.Add(nums[i], i);
                }
                else
                {
                    if (i-posDict[nums[i]] <= k)
                    {
                        flag = true;
                        break;
                    }
                    else
                        posDict[nums[i]] = i;
                }
            }
            return flag;
        }
    }
}