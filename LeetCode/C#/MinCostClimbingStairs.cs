using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    public class MinCostClimbingStairsClass
    {
      public int MinCostClimbingStairs(int[] cost)
      {
        var len = cost.Length;
        if(len<=1)
          return cost[0];
        if(len<=2)
          return  min(cost[0], cost[1]);

        int [] dp = new int[len+1];
        dp[0] = cost[0];
        dp [1] = cost[1];
        for(int i=2;i<len+1;i++)
        {
          dp[i] = ((i<len)? cost[i] :0)+ min(dp[i-2], dp[i-1]);
        }
        Console.WriteLine("string join "+string.Join(',', dp));
        return dp[len];
      }
      private int min(int a , int b)
      {
        return (a>b)?b:a;
      }
    }
}
