using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
    class PartitionArray
    {
      public bool CanThreePartsEqualSum(int[] A)
      {
        int n = A.Length;
        int [] dp1 =new int [A.Length];
        int [] dp2 = new int [A.Length];
        var dict = new Dictionary<int,int>();
        var flag=false;
        dp1[0] = A[0];
        dp2[0] = A[n-1];
        for(int i=1;i<n;i++)
        {
          dp1[i] = dp1[i-1] + A[i];
          dp2[i] = dp2[i-1] + A[n-i-1];
        }
        Console.WriteLine($"dp1 {string.Join(",", dp1)}");
        Console.WriteLine($"dp2 {string.Join(",", dp2)}");


        for(int i=0;i<A.Length;i++)
          for(int j=0;j<n-i-1;j++)
          {             
            if(dp1[i]==dp2[j])
            {
              var v =dp1[n-2-j]-dp1[i];
              Console.WriteLine($"i {i} j {n-j-1} v {v}  ");
             // Console.Write("subarray ");
             // Console.WriteLine();
              if (v==dp1[i] && (i+1 <=(n-2-j)))
                flag=true;
            }
          }

        return flag;

      }
    }
}
