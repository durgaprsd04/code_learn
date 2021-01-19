using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class CountTeams
    {
      public int NumTeams(int[] rating)
      {
        var len = rating.Length;
        var dp = new int [len];
        var dp1 = new int [len];
        dp[0]=0;
        dp[1] = rating[len-1] >rating[len-2] ?0:1;
        dp1[0]=0;
       // dp1[1] = rating[0]<rating[1]?1:0;
        var max = rating[len-1];
       
        var count =0;
        //decreasing array
        for(int i=len-3;i>=0;i--)
        {
          if(max < Math.Max( rating[i],max))
          {
            dp[len-(i+1)]=dp[len-(i+1)-1]+dp[len-(i+1)-2];
            max = rating[i];
          }
          else
            dp[len-(i+1)]=dp[len-(i+1)-1];         
        }
        var max1 = rating.Max();
        dp1[1] = (rating[0]<rating[1])?((rating[1]!=max1)?1:0):0;
        var lmax = rating[0];
        for(int i=2;i<len;i++)
        {
         if(lmax <Math.Max(rating[i], lmax) &&(i!=len-1 && rating[i]!=max1))
          {
            lmax = rating[i];
            dp1[i] = dp1[i-1]+dp[i-2];
          }
          else
            dp1[i] = dp1[i-1];
        }
        count = dp[len-1] +dp1[len-1];
        Console.WriteLine($"rating {string.Join(',',rating)}");
        Console.WriteLine($"dp {string.Join(',',dp)}");
        Console.WriteLine($"dp1 {string.Join(',',dp1)}");
        return count;
      }
    }
}
