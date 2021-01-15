using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace LeetCode
{
    public class ProductArrayExpectSelf
    {
         public int[] ProductExceptSelf(int[] nums)
         {
             var len =nums.Length;
            var res = new int [len];
            var res2 = new int [len];
             var res3 = new int [len];
           
            res[0]=1;
            res2[0]=1;
            for(int i =1;i<len;i++)
            {
                res[i] = nums[i-1]*res[i-1];
            }
           
            for(int i=1;i<len;i++)
            {
                res2[i]=nums[len-i-1]*res2[i-1];
            }
            
            Console.WriteLine("res 2 "+string.Join(",", res2));
            Console.WriteLine("res 1 "+string.Join(",", res));
            for(int i=1;i<len-1;i++)
            {
                res3[i]=res[i-1]*res2[len-i-1];
            }
            return res;
        
         }
    }
}