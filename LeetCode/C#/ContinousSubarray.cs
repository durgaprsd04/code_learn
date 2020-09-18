using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class ContinousSubArray
    {
       public bool CheckSubarraySum(int[] nums, int k)
       {
         var len = nums.Length;
         if(len<=1)
           return false;
         int [] dp = new int[len];
         dp[0] = nums[0];
         var isk =false;
         for(int i=1;i<len;i++)
         {
              dp[i]= nums[i] + dp[i-1];
              if(k!=0)
              {
                if(dp[i]%k==0) isk=true;
              }
              else
              {
                if(dp[i]==0) isk=true;
              }
         }
         if(isk)
           return true;
         Console.WriteLine("sum "+string.Join(',',dp));
         for(int i=len-1;i>0;i--)
         {
            for(int j=0;j<i-1;j++)
            {
              if(k!=0)
              {
                if((dp[i]- dp[j])%k==0)
                {
                  Console.WriteLine($" dp[i] {dp[i]} dp[j]{dp[j]}");
                  isk=true;
                  break;
                }
              }
              else
              {
                if((dp[i]- dp[j])==0)
                {
                  Console.WriteLine($" dp[i] {dp[i]} dp[j]{dp[j]}");
                  isk=true;
                  break;
                }
              }

            }
         }
         if(isk)
           return true;
         else
           return false;
       }
    }
}
