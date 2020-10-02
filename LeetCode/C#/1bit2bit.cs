using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
   public class OneBit2Bit
    {
      public bool IsOneBitCharacter(int[] bits)
      {
        int i=0;
        var res =false;
        var len = bits.Length;
        while(i<len)
        {
          if(bits[i]==0)
          {
            i++;
            res=true;
          }
          else if(bits[i]==1)
          {
            if((i+1)<len)
            {
              if(bits[i+1]==1 || bits[i+1]==0)
                i=i+2;
              res=false;
            }
          }
        }
        return res;
      }
    }
}
