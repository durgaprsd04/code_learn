using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class MaxProductof3
    {
       public int MaximumProduct(int[] nums)
       {
        Array.Sort(nums);
        var pdt =1;
        var choice=false;
        var v = nums.Length;
        if(nums.Length>0)
        {
          if(nums[0]<0)
          {
              if(nums[0]*nums[1] > nums[v-2]*nums[v-3])
              {
                pdt = nums[0]*nums[1];
                Console.WriteLine($"{nums[1]} {nums[0]}");
                choice =true;
              }
              else
              {
                  pdt = nums[v-2]*nums[v-3];
                Console.WriteLine($"{nums[v-1]} {nums[v-2]}");
              }
              if(v>=3)
              {
                Console.WriteLine("should");
                //if(choice)
                  pdt = pdt*nums[v-1];
                //else
                  //pdt = pdt*nums[v-3];
              }
          }
          else
          {
            pdt = pdt* nums[v-1];
            pdt = pdt*nums[v-2];
            pdt = pdt*nums[v-3];
          }
        }
        return pdt;
      }

    }
}
