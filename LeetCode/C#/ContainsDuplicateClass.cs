using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class ContainsDuplicateClass
    {
      public bool ContainsDuplicate(int[] nums) {
        int n = nums.Length;
        for(int i=0;i<n;i++)
        {
            for(int j = i+1;j<n;j++)
            {
            if(nums[j]<=nums[i])
              {
                var temp = nums[i];
                nums[i] = nums[j];
                nums[j]=temp;
              }
            }
        }
        Console.WriteLine($" sorted array {string.Join(',', nums)}");
        var result=false;
        for(int i=1;i<n;i++)
        {
          if(nums[i-1]==nums[i])
          {
            result=true;
            break;
          }
        }
      return result;
    }
    }
}
