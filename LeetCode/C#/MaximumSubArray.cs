using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class MaximumSubArrayClass
    {
          public int MaxSubArray(int[] nums)
          {
            var len = nums.Length;
            int maxSum=0, sum=Int32.MinValue;
            for(int i=0;i<len;i++)
            {

              maxSum = maxSum +nums[i];
              if(maxSum > sum)
                sum=maxSum;
              if(maxSum<0)
                maxSum=0;
              /*
                int j =0;
                while(j<=i)
                {
                  var sum =0;
                  for(int k=j;k<len-(i-j);k++)
                  {
                    sum = sum + nums[k];
                  }
                  if(sum>maxSum)
                    maxSum=sum;
                  j++;
                }
                */
            }
            return sum;
          }
    }
}
