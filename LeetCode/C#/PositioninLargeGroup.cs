using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;
namespace LeetCode
{
    class PositioninLargeGroup
    {
      public IList<IList<int>> LargeGroupPositions(string s)
      {

        IList<IList<int>>  l = new List<IList<int>>();
        if(s.Length<1)
          return  l;
        int start=0, end =0;
        StringBuilder sb = new StringBuilder();
        sb.Append(s[0]);
        for(int i=1;i<s.Length;i++)
        {
          if(s[i-1]==s[i])
            sb.Append(s[i]);
          else
          {
            if(sb.ToString().Length>=3)
            {
                l.Add(new List<int>{start,i-1});
                sb.Clear();
                sb.Append(s[i]);
                start =i;
            }
            else
            {
              sb.Clear();
              sb.Append(s[i]);
              start=i;
            }
          }
        }
        Console.WriteLine($"sb last {sb.ToString()}");
        if(sb.ToString().Length>=3)
          l.Add(new List<int>(){start,s.Length-1});



        return l;
      }
    }
}
