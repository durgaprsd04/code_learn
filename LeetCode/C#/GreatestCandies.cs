using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace LeetCode
{
    class GreatestCandiesClass
    {
      public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
      {
        if(candies.Length==0)
          new List<bool>();
        if(candies.Length==1)
          return new List<bool>(){false};
        var max1 = candies[0];
        IList<bool> l1 = new List<bool>();
        for(int i=1;i<candies.Length;i++)
        {
          if(max1<candies[i])
            max1=candies[i];
        }
        for(int i=0;i<candies.Length;i++)
        {
          l1.Add((candies[i]+extraCandies >=max1));
        }
        return l1;

      }
    }
}
