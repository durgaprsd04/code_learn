using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class TwoSumInputArray
    {
      public int[] TwoSum(int[] numbers, int target)
      {
        Console.WriteLine($" nums {string.Join(',', numbers)} target {target}");
        var len = numbers.Length;
        int [] res = null;
        for(int i=0;i<len;i++)
        {
          var v =  numbers[i];
          for(int j = i+1;j<len;j++)
          {
              if(v+numbers[j]==target)
              {
                res = new int [] {i+1,j+1};
                break;
              }
          }
        }
        return res;
      }
    }
}
