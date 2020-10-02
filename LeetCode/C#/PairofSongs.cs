using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class PairofSongs
    {
        public int NumPairsDivisibleBy60(int[] time)
        {
          int count=0;
          var hash = new int[60];
          for(int i =0;i<time.Length;i++)
          {
            var e = time[i]%60;
            if(e!=0)
            {
              //Console.WriteLine($"hash[{e}] is {hash[e]} hash[{60-e}] is{hash[60-e]} ");
              if(hash[60-e]>0)
              {
                //Console.WriteLine($"here {count}");
                count = count + hash[60-e];
              }
               hash[e]++;

            }
            else
            {
              hash[0]++;
            }
         }
          count = count + (hash[0]*(hash[0]-1))/2;
          return count;
        }
    }
}
