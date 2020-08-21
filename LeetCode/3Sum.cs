using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace LeetCode
{
    class Threesum
    {
        public IList<IList<int>> ThreeSum(int[] a) 
        {
          IList<IList<int>> listofArrays = new List<IList<int>>();
          var len =a.Length;
          List<int> l1 = new List<int>();
          Console.WriteLine(string.Join(',', a));
          len = a.Length;
          for(int i=0;i<len;i++)
          {
            for(int j=i+1;j<len;j++)
            {
              for(int k=j+1;k<len;k++)
              {
                if(a[i]+a[j]+a[k]==0 &&(i!=j&&j!=k&&k!=i))
                /*if(introTutorial(-(a[i]+a[j]), l1.ToArray())!=-1)*/
                {
                  IList<int> l = new List<int>();
                  l.Add(a[i]);
                  l.Add(a[j]);
                  l.Add(-(a[i]+a[j]));
                  listofArrays.Add(l);
                  //Console.WriteLine(string.Join(',',l));
                }
              }
            }
        }
        return listofArrays;
    }
      public int introTutorial(int v, int [] a)
      {
          //Console.WriteLine(string.Join(',',a));
          var len = a.Length;
          int min=0, max=a.Length, mid= (max)/2;
          int index=-1;
          while(min<mid && mid<max)
          {
            //Console.WriteLine($"max {max} min {min} mid {mid} a[mid] ${a[mid]} v ${v}");
            //Console.ReadLine();
          if(a[mid]>v)
          {
            max=(max+min)/2;
          }
          else if(a[mid]<v)
          {
             min =(max+min)/2;
          }
          else if(a[mid]==v)
          {
            index=(max+min)/2;
            break;
          }
          }
          return index;
      }

     }
}
