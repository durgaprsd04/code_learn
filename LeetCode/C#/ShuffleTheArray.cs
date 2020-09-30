using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class ShuffleTheArray
    {
        public int[] Shuffle(int[] nums, int n)
        {
          var len = nums.Length;
           var v = new int [2*n];
          if (len!=2*n)
            return v;
          for(int i=0;i<n;i++)
          {
            v[2*i] = nums[i];
            v[2*i+1] = nums[n+i];
          }
          return v;
        }
    }
}
