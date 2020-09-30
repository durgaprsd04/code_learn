using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace LeetCode
{
    public class ThirdMaxNumberClass
    {
        int firstMax = Int32.MinValue, secondMax = Int32.MinValue, thirdMax = Int32.MinValue; 
        public int ThirdMax(int[] nums) 
        {
            int firstMax=Int32.MinValue , secondMax=Int32.MinValue, thirdMax=Int32.MinValue;
            bool  distintElements=false;
            List<int> l1 = new List<int>();
            for(int i=0;i<nums.Length;i++)
            {
               if(!l1.Contains(nums[i]))
               l1.Add(nums[i]);
               if(l1.Count>=3)
               {
                   distintElements=true;
                break;
               }
            }

            for(int i=0;i<nums.Length;i++)
            {
                if(nums[i]==firstMax || nums[i]==secondMax)
                continue;
                if(nums[i]>=thirdMax)
                {
                    if(nums[i]>firstMax)
                    {
                        thirdMax = secondMax;
                        secondMax = firstMax;
                        firstMax = nums[i];
                    }
                    else if(nums[i]>secondMax)
                    {
                        thirdMax = secondMax;
                        secondMax = nums[i];
                    }
                    else
                    {                      
                        thirdMax = nums[i];
                    }
                }         
                
            }
            Console.WriteLine( $"min  {Int32.MinValue} first max {firstMax} second {secondMax} thrid {thirdMax}");
            if(distintElements)
                return thirdMax;
            else
                return firstMax;
        }
    }
}