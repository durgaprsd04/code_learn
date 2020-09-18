using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace Leetcode
{
    class NonOverLappingSubArray
    {
        public int MinSumOfLengths(int[] arr, int target)
        {
          var len = arr.Length;
          int [] dp = new int[len];
          dp[0] = arr[0];
          int j=0;
          List<System.Tuple<int,int>> listOfIndex = new List<System.Tuple<int,int>>();
          if(dp[0]==target)
            {
              listOfIndex.Add(new System.Tuple<int,int>(0,0));
            }
          for(int i=1;i<len;i++)
          {
            dp[i] = arr[i] +dp[i-1];
            Console.WriteLine(dp[i]);
            if(dp[i]>target)
            {
                while(dp[i]>target)
                {
                  Console.WriteLine($"j at this point {j}");
                  dp[i]-=dp[j];
                  j++;
                }

            }
            Console.WriteLine("post decrement "+dp[i]);
            if(dp[i]==target)
            {
              listOfIndex.Add(new System.Tuple<int,int>(j,i));
              dp[i]= arr[i];
              j=i;
            }
          }
          foreach(var v in listOfIndex)
            Console.Write(v.Item1 +" : "+ v.Item2);
          Console.WriteLine();
          return 0;
        }
    }
}
