using System;
using System.IO;
namespace HackerRank
{
  public class IntroTutorial
  {
      public int introTutorial(int v, int [] a)
      {
          var len = a.Length;
          int min=0, max=a.Length;
          int index=0;
          while(min<max)
          {
            //Console.WriteLine("c");
          if(a[(max+min)/2]>v)
            max=(max+min)/2;
          else if(a[(max+min)/2]<v)
            min =(max+min)/2;
          else
          {
            index=(max+min)/2;
            break;
          }
          }
          return index;

      }
  }
}
