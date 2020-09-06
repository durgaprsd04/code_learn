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

namespace  Practise
{
class Solution {

    // Complete the almostSorted function below.
   public static void almostSorted(int[] arr) {

        var length=arr.Length;
        var isSortable=false;
        for(int i=0;i< length-1;i++)
        {
            if(arr[i]<=arr[i+1])
                isSortable=true;
        }
        if(isSortable)
          Console.WriteLine("yes");
        else
          Console.WriteLine("no");

    }

    /*static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        almostSorted(arr);
    }*/
}
}

