using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class HouseRobber
    {
      public int Rob(int[] nums)
      {
        var len = nums.Length;
        int [] dp = new int [len];
        if(len==0)
          return 0;
        if(len==1)
          return nums[0];
        if(len==2)
          return Max(nums[0],nums[1]);
        dp[0]= nums[0];
        dp[1]= Max(nums[0], nums[1]);
        for(int i=2;i<len;i++)
        {
          dp[i] = Max(nums[i]+dp[i-2], dp[i-1]);
        }
        var max1 =dp[0];
        for(int j =1;j<len;j++)
        {
          if(max1<dp[j])
            max1=dp[j];
        }
        return max1;
      }
      public int Max(int a, int b)
      {
        return (a>b)?a:b;
      }
    }
}
