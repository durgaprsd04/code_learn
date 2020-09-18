using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class KConcatenation
    {
      public int KConcatenationMaxSum(int[] arr, int k)
      {
        var len = arr.Length;
        int [] dp = new int[len];
        dp[0]  = Max(0, arr[0]);
        for(int i=1;i<len;i++)
        {
            dp[i] = arr[i]+dp[i-1];
        }
        var res =  IsContinous(dp, arr);
        if(res.inc)
        {
          //Console.WriteLine("string in dp "+string.Join(',', dp));
          return k*dp[len-1];
        }
        else
        {
          //Console.WriteLine("Sum in dp "+string.Join(',',dp));
          //Console.WriteLine("Sum position " + res.pos);
          var res1=0;
          for(int i=0;i<res.pos;i++)
            res1+=dp[i];
          var max = GetMaximalSubArray(arr, res.pos);
          return res1+max;
        }
      }
      private int Max(int a, int b)
      {
        return a>b?a:b;
      }
      private (int pos, bool inc) IsContinous(int [] dp, int  [] nums)
      {
        var len = nums.Length;
        var inc =true;
        int i=0;
        for(i=1;i<len;i++)
          if(dp[i]<=dp[i-1] &&nums[i]!=0 )
          {
            inc =false;
            break;
          }
        return (i, inc);
      }
      private int  GetMaximalSubArray(int [] nums, int i)
      {
          var len = nums.Length;
          var max =0;
          int pos =len-1;
          for(int j=len-1;j>=i;j--)
          {
            //Console.WriteLine($"inside max {(max+nums[j])} len {max}");
              if((max+nums[j])> max)
              {
                  max = max + nums[j];
                  pos=i;
              }
          }
          return max;
      }
    }
}
