using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class CountTeams
    {
      public int NumTeams(int[] rating)
      {
        //less than
        var len = rating.Length;
        if(len<=2)
          return 0;
        var dp = new int [len];
        dp[0]=0;
        dp[1] = rating[0]<rating[1]?1:0;
        var min =rating[0]<rating[1]?rating[0]:rating[1];
        for(int i=2;i<len;i++)
        {
          if(min<rating[i])
          {
            dp[i] = dp[i-1]+1;
            //max = rating[i];
          }
          else
          {
              dp[i] = dp[i-1];
          }
        }
        Console.WriteLine($"rating {string.Join(',',dp)}");
        return 0;
      }
    }
}
