using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace  HackerRank
{
class Solution {

    // Complete the almostSorted function below.
   public static void almostSorted(int[] arr) {

        var length=arr.Length;
        string operation="";
        bool isSortable=false, isDecSubArray=false;
        int outOfSeqV=0, outOfSeqC=0, outOfSeqVIndex=-1, outOfSeqCIndex=-1;
        bool OutOfSeqDetected=false;
        if(length<=2)
        {
          Console.WriteLine("yes");
          if(arr[0]>arr[1])
            Console.WriteLine("swap 1 2");
          return;
        }
        for(int i=0;i< length-1;i++)
        {
            if(isDecSubArray)
            {
              if(outOfSeqC<=arr[i+1])
              {
                  if(outOfSeqCIndex>=1&& arr[outOfSeqCIndex-1]<arr[i])
                  {
                    isSortable=true;
                    OutOfSeqDetected=false;
                    operation="reverse "+(outOfSeqCIndex+1) .ToString()+" "+(i+1).ToString();
                  }
                  {
                    isSortable=false;
                  }
              }
              else
                isSortable=false;
            }
            if(arr[i]<=arr[i+1])
            {
                isSortable=true;
                isDecSubArray=false;
            }
            else
            {
              if(outOfSeqVIndex==i)
              {
                  isDecSubArray=true;
              }
              outOfSeqVIndex=i+1;

              if(!OutOfSeqDetected&&!isDecSubArray)
              {
                OutOfSeqDetected=true;
                outOfSeqC=arr[i];
                outOfSeqV=arr[i+1];
                outOfSeqCIndex=i;
              }
              else
              {
                if(outOfSeqC>=arr[i] && outOfSeqV>=arr[i+1])
                {
                  if(outOfSeqCIndex>=1&& arr[outOfSeqCIndex-1]<arr[i+1])
                  {
                    OutOfSeqDetected=false;
                    operation = "swap "+(outOfSeqCIndex+1).ToString() +" "+(i+1+1).ToString();
                  }
                  else
                  {
                    isSortable=false;
                    operation="";
                  }
                }
                else
                {
                  isSortable=false;
                }
              }
            }
        }
        if(!OutOfSeqDetected&&isSortable)
          Console.WriteLine("yes");
        else
          Console.WriteLine("no");
        if(!string.IsNullOrEmpty(operation))
          Console.WriteLine(operation);
    }

    /*static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        almostSorted(arr);
    }*/
}
}


