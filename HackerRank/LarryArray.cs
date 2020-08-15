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
class LarryArray {

    // Complete the almostSorted function below.
   public static string  larrysArray( int [] a) {

     bool invalidSeq=false;
     int invalidSeqCount=0, invalidIndex=-1;;
     var length = a.Length;
     for(int i=0;i<length-2;i++)
     {
       //CBA,ACB and BAC
        if((a[i]>a[i+1] && a[i+1] > a[i+2])||(a[i]<a[i+2] &&a[i+2]<a[i+1])||(a[i]>a[i+1] && a[i]<a[i+2]))
        {
          ///Console.WriteLine(" invalid seq "+(invalidSeqCount+1));
          //Console.WriteLine(a[i]+", "+a[i+1]+", "+a[i+2]);
          var max=(a[i]>a[i+1])?((a[i]>a[i+2])?a[i]:a[i+2]):((a[i+1]>a[i+2])?a[i+1]:a[i+2]);
          invalidSeqCount++;
          if(invalidSeq)
          {
            //Console.WriteLine($"{i} index ${invalidSeqCount}");
            if(i<=invalidIndex)
            {
              //Console.WriteLine( "test");
              invalidIndex=i+2;
              //Console.WriteLine(invalidSeqCount);
              if(invalidSeqCount>2)
              {
                invalidSeqCount=0;
                invalidSeq=false;
              }
            }
          }
          else
          {
            invalidSeq=true;
            invalidIndex=i+2;
          }
           if(i>0)
          {
            if(a[i-1]>max)
            {
              Console.WriteLine("Thatone edge case");
              invalidSeq=false;
            }
          }
        }
     }
     if(invalidSeq)
       return "no";
     else
       return "yes";
   }
}
}

