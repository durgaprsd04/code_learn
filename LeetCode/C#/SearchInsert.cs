using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class SearchInsertClass
    {
      public int SearchInsert(int[] nums, int target)
      {
        int hi = nums.Length;
        int lo = 0;
        int mid = (lo+hi)/2;
        if(hi==0)
          return 0;
        if(hi==1)
          if(target>nums[0])
            return 1;
          else
            return 0;
        while(lo<mid)
        {
          Console.WriteLine($"hi {hi} mid {mid} lo {lo}");
          if(hi-lo==2)
          {
            mid = (hi+lo)/2;
            if(nums[mid]>target)
            {
                if(nums[mid-1]>target)
                  mid=mid-1;
            }
            else
              mid=mid+1;
            break;
          }

          if(target>nums[mid])
          {
            lo = mid;
            mid = (mid+hi)/2;
          }
          else if(target<nums[mid])
          {
            hi = mid;
            mid = (lo+mid)/2;
          }
          else
          {
            break;
          }
          if(hi-lo<2)
          {
            mid = (hi+lo)/2;
            if(nums[mid]>target)
            {
                if(nums[mid-1]>target)
                  mid=mid-1;
            }
            else
              mid=mid+1;
            break;
          }

        }
        return mid;
      }
    }
}
