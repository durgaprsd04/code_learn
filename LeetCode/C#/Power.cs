using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
    class Power
    {
      public double MyPow(double x, int n)
      {
        double res=1.0, prevRes=0.0;
        bool flag =false, flag2=false;
        if(n==0)
          return 1;
        else
        {
          res = pow1(x,n);
        }
        if(n<0)
          return (res!=0)?1.0/res:0;
        else
          return res;
      }
      private double pow1(double x, int n)
      {
        if(n==0)
          return 1.0;
        else
        {
          var y = pow1(x, n/2);
          if(n%2==0)
            return y*y;
          else
            return x*y*y;
        }
      }
    }
}
