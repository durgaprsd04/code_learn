using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
    class SquareRoot
    {
      public int MySqrt(int x)
      {
        if(x==1)
          return 1;
      var prevV=0;
        var v = x/2;
        prevV=v;
        while(v>=2)
        {
          Console.Write(v +"  ");
        if(x/v>=v)
          break;
        else
        {
          prevV=v;
          v= v%2==0? v/2:(v+1)/2;
        }
        }
        int hi = prevV;
        int lo = v;
        int mid = (prevV+v)/2;
        while(lo<mid)
        {
          Console.WriteLine($"hi {hi} lo {lo} mid {mid} mid*mid {(long)mid*mid} ");
          if((long)mid*mid>(long)x)
          {
          hi = mid;
          mid = (lo+mid)/2;
          }
          else if((long)mid*mid<(long)x)
          {
          lo=mid;
          mid = (mid+hi)/2;
          }
          else
          {
           break;
          }
       }
        return mid;
    }
  }
}
