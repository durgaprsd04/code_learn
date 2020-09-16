using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace LeetCode
{
    public class DivisorGameClass
    {
      public bool DivisorGame(int N)
      {
        //var backup=N;
        var aliceWins = false;
        List<int> l = new List<int>();
        while(N>=1)
        {
          l.Add(N);
          N = N -findLargestDivisor(N);
          aliceWins= !aliceWins;
        }
        Console.WriteLine("l lines "+string.Join(',', l.ToArray()));
        return aliceWins;
      }
      public int findLargestDivisor(int n)
      {
        int maxRem=1;
            for(int i=2;i<=(n/2);i++)
            {
              var rem = n%i;
              if(rem==0&&i>maxRem)
                maxRem=i;
            }
            if(maxRem==n)
              return 1;
            else
              return maxRem;
      }
    }
}
