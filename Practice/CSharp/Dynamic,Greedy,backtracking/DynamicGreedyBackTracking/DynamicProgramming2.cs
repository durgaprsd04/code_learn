using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
namespace Dynamic_Greedy_backtracking
{
    public class DynamicProgramming2
    {
        
        //given n and m find squences of length n were max value is lessser than m. 2nd element is twice or more than the first element.
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
        // longest pair  taht has the above property.
        public List<int[]> GetLongestPair(int [][] pairs)
        {
            var len = pairs.Length;
            List<List<int[]>> result= new List<List<int[]>>();
            for(int i=0;i<len;i++)
                result.Add(new List<int[]>());
            var dp = new int[len];
            dp[0]=1;
            result[0].Add(pairs[0]);
            for(int i=1;i<len;i++)
            {
                for(int j=0;j<i;j++)
                {
                    if(pairs[i][0]>pairs[j][1] && result[j].Count > result[i].Count)
                    {
                        dp[i] = Math.Max(dp[i], dp[j]+1);
                        result[i]  = new List<int[]>(result[j]){};
                    }
                }
                result[i].Add(pairs[i]);
            }
            Console.WriteLine(string.Join(",", dp));
            var maxIndex=0;
            var len1=0;
            for(int i=0;i<result.Count;i++)
            {
                if(result[i].Count>len1)
                {
                    len1=result[i].Count;
                    maxIndex=i;
                }    
            }
            return result[maxIndex];
        }
        //Maximum average value in a matrix of size N
        public double MaximumAverageValue(int [][] arr, int N)
        {
            // maxmise from Arr[N-1][N-1] to arr[0][0]
           
            double sum = arr[N-1][N-1];
            var dp = new int[N][];
 
            for(int i=0;i<N;i++)
                dp[i] = new int[N];
            dp[0][0]=arr[0][0];
            for(int i=1;i<N;i++)
                dp[0][i] = dp[0][i-1]+arr[0][i];
            for(int i=1;i<N;i++)
                dp[i][0]= dp[i-1][0]+arr[i][0];
            
            for(int i=1;i<N;i++)
            {
                for(int j=1;j<N;j++)
                {
                    dp[i][j] = Math.Max(dp[i][j-1], dp[i-1][j])+arr[i][j];
                }
            }
            return (double)(dp[N-1][N-1]*1.0/(2*N-1));
        }
        //Subarray with maximum sum(Kadanes)
        public (int start, int end) SubArrayWithMaxSum(int [] arr)
        {
            var len =arr.Length;
            var start =0;
            var end = 0;
            var sum=0;
            var maxSum=0;
            var s=0;
            for(int i =0;i<len;i++)
            {
                sum+=arr[i];
                if(sum>maxSum)
                {
                    maxSum=sum; 
                    start =s;
                    end =i;
                }
                if(sum<0)
                {
                    sum=0;
                    s=i+1;    
                }    

            }
            return (start,end);

        }
        // Path Sum in a triangle
        public int MinimumPathSumTriangle(int [][] triangle)
        {
            var width = triangle[triangle.Length-1].Length;
            var dp = new int[triangle.Length][] ;
            for(int i=0;i<width;i++)
                dp[i] = new int[width];
            for(int i=0;i<width;i++)
                dp[triangle.Length-1][i] = triangle[triangle.Length-1][i];

            var len = triangle.Length;
            for(int i=len-2;i>=0;i--)
            {
                for(int j=0;j<triangle[i].Length;j++)
                {
                    dp[i][j]= Math.Max(dp[i+1][j] , dp[i+1][j+1])+triangle[i][j];
                }
                Console.WriteLine(string.Join(", ",dp[i]));
            }
            return dp[0].Max();
        }
        //Max sum with specific difference
        public int MaximumSumofArrayWithSpecificDifference(int [] arr, int k)
        {
            Array.Sort(arr);
            //int i=0;
            /*List<int> pairs = new List<int>();
            while(i<arr.Length-1)
            {
                if(arr[i]+k> arr[i+1])
                    {
                        pairs.Add(arr[i]);
                        pairs.Add(arr[i+1]);
                        i+=2;
                    }
                    else{
                        i=i+1;
                    }
            }
            Console.WriteLine(string.Join(", ", pairs));
            return pairs.Sum();
            */
            int []dp = new int[arr.Length];
            dp[0]=arr[0];
            for(int i=1;i<arr.Length;i++)
            {
                dp[i] =dp[i-1];
                if(arr[i]-arr[i-1]<k)
                {
                    if(i>2)
                    {
                        dp[i] = Math.Max(dp[i], arr[i] +arr[i-1]+dp[i-2]);
                    }
                    else
                    {
                        dp[i] = Math.Max (dp[i], arr[i]+arr[i-1]);
                    }
                }   
            }
            //Console.WriteLine(string.Join(",", dp));
            return dp[arr.Length-1];

        }
        //Size of a maximum matrix with all 1s
        public int SizeOfMaxMatrix(int [][] A)
        {
            var m = A.Length;
            var n = A.FirstOrDefault().Length;
            var S = new int[m][];
            for(int i=0;i<m;i++)
                S[i] = new int[n];
            for(int i=0;i<n;i++)
                S[0][i] = A[0][i];
            for(int j=0;j<m;j++)
                S[j][0] = A[j][0];
            for(int i=1;i<m;i++)
            {
                for(int j=1;j<n;j++)
                {
                    if(A[i][j]==1)
                        S[i][j] = Math.Min(S[i][j-1], Math.Min(S[i-1][j], S[i-1][j-1]))+1;
                    else
                        S[i][j]=0;
                }
            }
            for(int i=0;i<m;i++)
            {
                for(int j=0;j<n;j++)
                    Console.Write(S[i][j] +" ");
                Console.WriteLine();
            }
            var max=0;
            for(int i=0;i<m;i++)
            {
                var m1 = S[i].Max();
                if(m1>max)
                    max=m1;
            }
            return max;
        }
        //Maximum Sum in a 2d Grid
        public int MaxSumIn2dGrid(int [][] grid)
        {
            var odd = Math.Max(grid[0][0], grid[1][0]);
            var even =0;
            var excl =0;
            var len = grid.FirstOrDefault().Count();
            for(int i=1;i<len;i++)
            {
                excl = odd>even? odd:even;
                odd = even+Math.Max(grid[i][0], grid[i][1]);
                even =excl;
            }
            return Math.Max(even, odd); 
        }
        // Max Sum in 1d array incorrect logic in gfg.
        public int MaxSumIn1dGrid(int [] grid)
        {
            var odd = grid[0];
            var even =0;
            var excl =0;
            var len = grid.Count();
            for(int i=1;i<len;i++)
            {
                Console.WriteLine($"excl {excl} even {even} odd {odd}");
               if(i%2==1)
                    even+=grid[i];
                else
                    odd+=grid[i];
                
            }
             Console.WriteLine($"excl {excl} even {even} odd {odd}");
            return Math.Max(even, odd); 
        }
        //Max jump position at each position in an array. - unfinished
        public int [] MaxJumpPositions(int []arr)
        {
            //arr = new int[]{2,3,1,4,6,5};
            int[] dp = new int[arr.Length];
            dp[0]=arr[0];
            for(int i=1;i<arr.Length;i++)
            {
                //dp[i]=arr[i];
                for(int j=1;j<=Math.Sqrt(i+1);j++)
                {
                    if((i+1)%j==0)
                    {
                        dp[i] = Math.Max(dp[j-1]+arr[i], dp[i]);
                    }
                }
            }
            Console.WriteLine(string.Join(",",dp));
            return dp;
        }
    }
}