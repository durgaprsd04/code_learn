using System;
using System.IO;
namespace LeetCode
{
public class ContainerWater
    {
       public int MaxArea(int[] height) {
       int area =0;
       var len  = height.Length;
       for(int i=0;i<len-1;i++)
       {
          for(int j=i+1;j<len;j++)
          {
          if(Math.Min(height[i], height[j])*(j-i)>area)
            area= (Math.Min(height[i], height[j])*(j-i));
          }
       }
       return area;
    }
  }
}

