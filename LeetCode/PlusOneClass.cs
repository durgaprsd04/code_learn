using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class PlusOneClass
    {
      public int[] PlusOne(int[] digits)
      {
          var len = digits.Length;
          int rem=0;
          for(int i=len-1;i>=0;i--)
          {
            if(i==len-1)
              digits[i] = digits[i]+1+rem;
            else
              digits[i] +=rem;
            rem = (digits[i]< 10)?0:digits[i]/10;
            digits[i] = (digits[i]<10)?digits[i]:digits[i]%10;
          }
          //Console.WriteLine("here"+rem);
          if(rem>=1)
          {
           // Console.WriteLine("here");
            int [] v1 = new int [len+1];
           // Console.WriteLine(v1.Length);
            v1[0]=rem;
            for(int i=1;i<len;i++)
              v1[i]=digits[i];
          return v1;
          }
        return digits;
      }
    }
}

