using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace Leetcode
{
    class NonOverLappingSubArray
    {
        public int MinSumOfLengths(int[] arr, int target)
        {
          var len = arr.Length;
          if(len==0)
            return -1;
          int [] dp = new int[len];
          dp[0] = arr[0];
          int j=0;
          int mini=0; int minj=0;
          int min = Int32.MaxValue;
          List<System.Tuple<int,int>> listOfIndex = new List<System.Tuple<int,int>>();
          if(dp[0]==target)
            {
              listOfIndex.Add(new System.Tuple<int,int>(0,0));
            }
          for(int i=1;i<len;i++)
          {
            dp[i] = arr[i] +dp[i-1];
            Console.WriteLine(dp[i]);
            if(dp[i]>target)
            {
                int k=j;
                int prev=0;
                for(;k<i;k++)
                {
                  Console.WriteLine($"k at this point {k}");
                  Console.WriteLine($"Subtracting  {dp[k]}  from {dp[i]}");
                  if(dp[i]>target)
                  {
                    dp[i]-=(dp[k]-prev);
                    prev=dp[k];
                  }
                  else
                    break;
                  //dp[j+1] -=dp[j];
                }
                j=k;
            }
            Console.WriteLine("post decrement "+dp[i]);
            if(dp[i]==target)
            {
              if((Math.Abs(i-j)+1)<min)
              {
                min=Math.Abs(i-j)+1;
                mini=i;
                minj=j;
              }
              listOfIndex.Add(new System.Tuple<int,int>(j,i));
              dp[i]= arr[i];
              j=i;
            }
          }
          var nextMin = GetMinLenFromTuple(listOfIndex, mini, minj);
          foreach(var v in listOfIndex)
            Console.Write(v.Item1 +" : "+ v.Item2);
         Console.WriteLine();
        return ((nextMin==null)?-1:(nextMin.Item1+min));
        }
        public System.Tuple<int,int,int> GetMinLenFromTuple(List<System.Tuple<int,int>> list, int i , int j)
        {
             int min = Int32.MaxValue, mini=0, minj=0;
          System.Tuple<int,int,int> st =null;
            foreach(var tp in list)
            {
                if((Math.Abs(tp.Item1 - tp.Item2)+1)< min || st==null)
                {
                  min = Math.Abs(tp.Item1 - tp.Item2)+1;
                  mini=tp.Item1;
                  minj=tp.Item2;
                  Console.WriteLine($"mini{mini} minj {minj} i {i} j{j} ");
                  if( (j!=minj && i!=mini)&&((i> mini)&&(j>mini ) || (i<minj) &&(j< minj) ))
                      {
                      st = new System.Tuple<int,int,int>(min, mini, minj);
                      }
                }
            }
            return st;

        }
    }
}
