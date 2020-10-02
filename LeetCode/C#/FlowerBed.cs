using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class FlowerBed
    {
      public bool CanPlaceFlowers(int[] flowerbed, int n)
      {
        int prev =0, curr=1;
        var len = flowerbed.Length;
        var f =0;
        if(len<=1)
          return flowerbed[0]==0 || n<1;
        while(curr<len)
        {
          Console.WriteLine($"curr {curr } prev {prev}");
          if(flowerbed[prev] ==0 && flowerbed[curr]==0)
          {
            if(prev-1>=0 && flowerbed[prev-1]==0)
            {
              f++;
              prev+=2;
              curr+=2;
            }
            prev++;
            curr++;
          }
          else
          {
            prev++;
            curr++;
          }

        }
        if(n<=f)
          return true;
        else
          return false;
      }
    }
}

