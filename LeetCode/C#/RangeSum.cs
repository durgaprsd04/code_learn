using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class NumArray
    {
      private int [] num;
      private int [] sum;
      public NumArray(int[] nums)
      {
          var len = nums.Length;
          num = new int[len+1];
          sum = new int[len+1];
          num[0] = nums[0];
          sum[0] = nums[0];
          for(int i=1;i<len;i++)
          {
              sum[i] = sum[i-1]+nums[i];
              num[i] = nums[i];
          }
          //Console.WriteLine($" sum of nusm "+ string.Join(',', sum));
      }

    public int SumRange(int i, int j)
    {
      if(num.Length==0)
        return 0;
      if(num.Length==1)
        return num[0];
      if(j>num.Length)
        return 0;
      int val=0;
      if(i==0)
      {
        val = sum[j];
      }
      else
      {
       val= sum[j] - ((i-1>=0)?sum[i-1]:0);
      }
      return val;
    }
    }
}
