using System;
using System.Collections;
using System.Collections.Generic;
namespace CSharp
{
   public class ListIndexer
    {
      public void TestList()
      {
        IList<int> t = new List<int>();
        for( int i=1;i<=10;i++)
            t.Add(i);
        for(int i=0;i<t.Count;i++)
          Console.Write($"{t[i]}");
      }
    }
}

