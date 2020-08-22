using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    public class NextPermutation2
    {
        public void NextPermutation(int[] nums) {
          var len = nums.Length;
          int i=1;
          int index=0;
          while(i<=len-1)
          {
            //Console.WriteLine($"x {nums[len-1]} x {nums[len-i-1]}");
            if(nums[len-i]>nums[len-i-1])
            {
              //Console.WriteLine($"swapping len-1 {len-1} len-i-1 {len-i-1}");
              var isDesc = IsdescendingFromN(nums, len-i-1);
              //if(isDesc|| len-i-1==0)
                SwapNextHighest(nums, len-i-1);
              //else
                //swap(nums, len-i, len-i-1);

              index=len-i;
              break;
            }
            else
            {
              i++;
            }
          }
          Sort(nums, index,len-1);
    }
        public bool IsdescendingFromN(int [] nums, int n)
        {
          bool isDesc = true;
          for(int i=n;i<nums.Length-1;i++)
          {
            if(nums[i]<nums[i+1])
              {
                isDesc=false;
                break;
              }
          }
          return isDesc;
        }
        public void SwapNextHighest(int [] nums, int min)
        {
           //Console.WriteLine($" min {min}");
           var val = nums[min+1];
           var nextMax=val;
           var minIndex=min+1;
           for(int i=min+1;i<nums.Length;i++)
           {
              //Console.WriteLine($"x {i} nxtMAx {nextMax}  ");
              if(nextMax>nums[i])
               {
                  nextMax=nums[i];
                  minIndex=i;
              }
           }
           //Console.WriteLine($"min index {minIndex}");
          swap(nums, min, minIndex);

        }
        public void swap(int [] nums, int i, int j)
        {
          var temp = nums[i];
          nums[i]=nums[j];
          nums[j]=temp;
        }
        public void Sort(int [] nums, int min, int max)
        {
          //Console.WriteLine($"swapping for min {min} max {max}");
          for(int i=min;i<=max;i++)
              {
                for(int j=i+1;j<=max;j++)
                {
                  if(nums[i]>=nums[j])
                    swap(nums,i, j);
                }
                //Console.WriteLine(string.Join(',', nums));
              }
        }
    }
}

