using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
namespace Dynamic_Greedy_backtracking
{
    public class DynamicProgramming2
    {
        /*
         given n and m find squences of length n were max value is lessser than m. 2nd element is twice or more than the first element.
        */    
      
       public int GetTotalNumberOfSequences(int m, int n, HashSet<int> hs)
       {
            if(m==0)
                return 0;
            
            if(m<n)
                return 0;
            
            if(!hs.Contains(m))
                hs.Add(m);
            else
                return 0;

            if(m==1)
            {
                if(n==1)
                    return 1;
                else
                    return 0;
            }

           return 1+GetTotalNumberOfSequences(m/2, n-1, hs)+GetTotalNumberOfSequences((m-1)/2, n-1, hs);
       }
  
    //LIS only
     public int MaximumProductOfLongestIncreasingSubSeq(int [] arr)
       {
           //10, 22, 9, 33, 21, 50, 41, 60
            int n = arr.Length;
            var dp  = new int[n+1];
            for(int i=0;i<n;i++)
                dp[i]=0;
            HashSet<int> l = new HashSet<int>();
            dp[0]=1;
            for(int i=1;i<n;i++)
            {
                for(int j=0;j<i;j++)
                {
                    if( arr[i]>arr[j])
                    {
                        dp[i]=Math.Max(dp[i], dp[j]+1);
                    }
                }
            }
            Console.WriteLine(string.Join(",", dp));
            Console.WriteLine(string.Join(",",l));
            return dp[n-1];
       }
       public int ProductLessThanK(int [] arr, int k)
       {
            var n = arr.Length;
            var dp = new int [k+1][];
            for(int i=0;i<k+1;i++)
                dp[i]= new int[n+1];
            
            for(int i=0;i<n+1;i++)
                dp[i][0]=0;

            for(int i=1;i<k;i++)
            {
                for(int j=1;i<j+1;i++)
                {
                    dp[i][j] = dp[i][j-1];
                    if(arr[j-1]<i  && Convert.ToInt32(arr[i])!=0)
                    {
                        dp[i][j] = Math.Max(dp[i-1][j], dp[i/(arr[j-1])][j-1]+1);
                    }
                }
            }
            return dp[n][n];

       }
       //Max sub sequence sum no 3 are consecutive.
       public int MaxSubSequenceSum(int [] arr)
       {
           var len  = arr.Length;
           var dp = new int[len];
            if(len<3)
                return arr.Sum();
            if(len ==3)
                {
                    var l = arr.OrderByDescending(x => x ).ToList();
                    return l[0]+l[1];
                }
            dp[0] = arr[0];
            dp[1] = arr[1]+dp[0];
            //var adj=false;
            //var firstIndex=0;
            dp[2] = arr[2]+dp[1] - Math.Min(arr[0],Math.Min(arr[1], arr[2]));
            for(int i=3;i<len;i++)
            {
               dp[i] = Math.Max( Math.Max(dp[i-1], dp[i-2] +arr[i]), dp[i-3]+arr[i-1]+arr[i]);
            }
            return dp[len-1];
       }
       //Longest Sub sequence such taht diff between adj is 1
       public int GetLongestSubSequenceWithDifference1(int []arr)
       {
           var len = arr.Length;
           var dp = new int[len];
           dp[0]=1;
           for(int i=1;i<len;i++)
           {
               for(int j=0;j<i;j++)
               {
                    if(Math.Abs(arr[i]-arr[j])==1)
                        dp[i] = Math.Max(dp[i],dp[j]+1);
               }
           }
           return dp.Max();
       }
    //longest  sequence of pair that can be formed given pairs (a,b) , (c,d) a < b always can be a chain only if b<c
       public int GetLongestPairLength(int [][] pairs)
       {
           var len = pairs.Length;
           var dp =new int[len];
           dp[0] =1;
           for(int i=1;i<len;i++)
           {
               for(int j=0;j<i;j++)
               {
                   if(pairs[i][0]> pairs[j][1])
                        dp[i]= Math.Max(dp[i], dp[j]+1);
               }
           }
           Console.WriteLine(string.Join("," , dp));
           return dp.Max();
       }
        // longest pair length

        public List<int[]> GetLongestPair(int [][] pairs)
        {
            var len = pairs.Length;
            List<List<int[]>> result= new List<List<int[]>>();
            for(int i=0;i<len;i++)
                result.Add(new List<int[]>());
            var dp = new int[len];
            dp[0]=1;
            for(int i=1;i<len;i++)
            {
                for(int j=0;j<i;j++)
                {
                    if(pairs[i][0]>pairs[j][1])
                    {
                        dp[i] = Math.Max(dp[i], dp[j]+1);
                        result[i].Add(pairs[j]);
                    }
                }
            }
            Console.WriteLine(string.Join(",", dp));
            var maxI=0;
            var len1=0;
            for(int i=0;i<result.Count;i++)
            {
                if(result[i].Count>len1)
                {
                    len1=result[i].Count;
                    maxI=i;
                }    
            }
            return result[maxI];
        }
    }
}