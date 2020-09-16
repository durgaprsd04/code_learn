using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    public class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
          int [] dp = new int [n+1];
          if(n<=0)
            return 0;
          dp[0]=0;
          dp[1]=1;
          if(n>=2)
          dp[2]=2;
          if(n<=2)
            return dp[n];
          for(int i=3;i<(n+1);i++)
          {
            dp[i] = dp[i-1] +dp[i-2];
          }
          return dp[n];
        }
    }
}
