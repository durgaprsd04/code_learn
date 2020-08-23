using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class ReverseInt
    {
         public int Reverse(int x) {
            bool neg=false, overflow=false;
            int v=0;
           if(x<0)
           {
             x=x*-1;
             neg=true;
           }
           while(x>0)
           {
             Console.WriteLine($"v {v}");
             if((((long)v)*10)>(long)Int32.MaxValue)
             {
               overflow=true;
               break;
             }
             v =v*10+ x%10;
             x=x/10;
           }
           if(overflow)
             v=0;
           if(neg)
             v=v*-1;
           return v;

      }
    }
}
