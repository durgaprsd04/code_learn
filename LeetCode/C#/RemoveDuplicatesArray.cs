using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class RemoveDuplicatesArray
    {
      public int RemoveDuplicates(int[] nums)
      {
        var len = nums.Length;
        int j=0;
        for(int i=1;i<len;i++)
        {
          if(nums[i]!=nums[j])
            j++;
          nums[j]=nums[i];
        }
      return j+1;
    }
  }
}
